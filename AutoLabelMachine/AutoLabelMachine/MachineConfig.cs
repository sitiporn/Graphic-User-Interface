using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//using System.Transactions;
using System.Windows.Forms;
using System.Collections;
using System.Text.RegularExpressions;
using NationalInstruments.Vision;
using NationalInstruments.Vision.Acquisition.Imaqdx;
using NationalInstruments.VBAI;
using NationalInstruments.VBAI.Structures;
using KEYENCE_NU_EP1_Lib;

namespace AutoLabelMachine
{
    public partial class MachineConfig : Form
    {
        ushort g_uRet = 0;
        int ErrorLimit_count = 0;
        ushort g_uESCCardNo = 0, g_uESCSlotID = 0, g_uESCNodeID = 0, g_nESCExistCards = 0;
        int ngetPos, strReadOutput;
        int AutoFeedClicked=0, absMoveHead_flag = 0;

        ushort mDone;//, Mdone = 2;
        int btnMoveCalib = 0;
        double dTdec = 10;
        EtherCAT EtherCAT = new EtherCAT();
        TCP_IP Keyence_NUEP1 = new TCP_IP();
        string Path = System.IO.Path.GetFullPath(@".\\");
        iniFiles ini = new iniFiles(System.IO.Path.GetFullPath(@".\\") + "Machine_Config.ini");
        String sKeyence1_IP = "", sKeyence2_IP = "";


        Modbus Mod_Conveyor = new Modbus();
        vfdCommand fdd = new vfdCommand();
        VBAIEngine engine;
        bool newImageAvailable, inspectionStatus;
        //-----------------Machine config -------------
        ushort ON = 1, OFF = 0;
        int nDir_N = -1, nDir_P = 1;
        public enum NodeID : int
        {
            SERVO_X = 36,
            SERVO_Y = 37,
            SERVO_Z = 38,
            SERVO_R = 39,
            SERVO_V = 40,
            SERVO_C1 = 41,
            SERVO_C2 = 42,
            SERVO_C3 = 43,
            SERVO_C4 = 44,
        }
        private void btnServoRobotON_Click(object sender, EventArgs e)
        {
            EtherCAT.setOnservo(0, (ushort)NodeID.SERVO_X, ON);
            EtherCAT.setOnservo(0, (ushort)NodeID.SERVO_Y, ON);
            EtherCAT.setOnservo(0, (ushort)NodeID.SERVO_Z, ON);
            EtherCAT.setOnservo(0, (ushort)NodeID.SERVO_V, ON);
            EtherCAT.setOnservo(0, (ushort)NodeID.SERVO_R, ON);
            cbServo_X.Checked = true;
            cbServo_Y.Checked = true;
            cbServo_Z.Checked = true;
            cbServo_R.Checked = true;
            cbServo_V.Checked = true;
            btnServoRobotON.Enabled = false;
            btnServoRobotOFF.Enabled = true;


        }

        private void btnResetAll_Click(object sender, EventArgs e)
        {
            for (ushort i = (ushort)NodeID.SERVO_X; i <= (ushort)NodeID.SERVO_C4; i++)
            {
                g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Ralm(0, i, 0);
                ErrorLimit_count = 0;

                if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                {
                    AddErrMsg("_ECAT_Slave_Motion_Ralm, ErrorCode = " + g_uRet.ToString(), true);
                }
            }
            btnResetALL.Enabled = false;
        }

        private void btnServoRobotOFF_Click(object sender, EventArgs e)
        {
            EtherCAT.setOnservo(0, (ushort)NodeID.SERVO_X, OFF);
            EtherCAT.setOnservo(0, (ushort)NodeID.SERVO_Y, OFF);
            EtherCAT.setOnservo(0, (ushort)NodeID.SERVO_Z, OFF);
            EtherCAT.setOnservo(0, (ushort)NodeID.SERVO_V, OFF);
            EtherCAT.setOnservo(0, (ushort)NodeID.SERVO_R, OFF);
            cbServo_X.Checked = false;
            cbServo_Y.Checked = false;
            cbServo_Z.Checked = false;
            cbServo_R.Checked = false;
            cbServo_V.Checked = false;
            btnServoRobotOFF.Enabled = false;
            btnServoRobotON.Enabled = true;
            //gbMot.Enabled = false;
        }

      


        private void btnEtherCATInt_Click(object sender, EventArgs e)
        {
            if (EtherCAT_Initial() == "TRUE")
            {

                btnEtherCATInt.Enabled = false;
                btnServoRobotOFF.Enabled = false;
                TimCheckStatus.Enabled = true;
            }

        }
        private String EtherCAT_Initial()
        {
            //EtherCAT objEtherCAT = new EtherCAT();
            if (EtherCAT.openCard() == CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                if (EtherCAT.initialCard() == "INITIAL")
                {
                    EtherCAT.findSlave();
                    g_nESCExistCards = 1;
                    return "TRUE";
                }
                else
                {
                    MessageBox.Show("Cann't Initial EtherCAT card");
                    g_nESCExistCards = 0;
                    return "FAIL";
                }
            }
            else
            {
                MessageBox.Show("Cann't Open EtherCAT card");
                g_nESCExistCards = 0;
                return "FAIL";
            }

        }

        private void TimCheckStatus_Tick(object sender, EventArgs e)
        {
            ushort g_nitialDone = 0, uRet = 0, Count_Check_Initial = 0;
            ushort g_MCDone = 0, g_uStstus = 0;
            CheckBox[] cbVacummControl = new CheckBox[]
            { cbVacummControl01, cbVacummControl02, cbVacummControl03,
              cbVacummControl04, cbVacummControl05, cbVacummControl06,
              cbVacummControl07, cbVacummControl08, cbVacummControl09};
            Label[] lbVacummValue = new Label[]
            {
                lbVacuumValue01 , lbVacuumValue02, lbVacuumValue03,
                lbVacuumValue04, lbVacuumValue05, lbVacuumValue06,
                lbVacuumValue07, lbVacuumValue08, lbVacuumValue09,
            };
            CheckBox[] cbServoOn = new CheckBox[]
            {
                cbServo_X,cbServo_Y,cbServo_Z,cbServo_R,cbServo_V,
                cbServo_C1,cbServo_C2,cbServo_C3,cbServo_C4

            };
            TextBox[] txtAxisPos = new TextBox[]
            {
                txtAxis_X,txtAxis_Y,txtAxis_Z,txtAxis_R,txtAxis_V,
                txtAxis_C1,txtAxis_C2,txtAxis_C3,txtAxis_C4
            };

            int g_nCmd = 0, nPos = 0;
            if (tcMotionControl.SelectedIndex >= 1)
            {
                btnHomeR.Visible = false;
                btnHomeV.Visible = false;
                btnJOG_Z_N.Visible = false;
                btnJOG_Z_P.Visible = false;

                lbAxisName_X.Text = "C1";
                lbAxisName_Y.Text = "C2";
                lbAxisName_Z.Text = "";
                lbAxisName_R.Text = "C3";
                lbAxisName_V.Text = "C4";

            }
            else
            {
                btnHomeR.Visible = true;
                btnHomeV.Visible = true;
                btnJOG_Z_N.Visible = true;
                btnJOG_Z_P.Visible = true;

                lbAxisName_X.Text = "X";
                lbAxisName_Y.Text = "Y";
                lbAxisName_Z.Text = "Z";
                lbAxisName_R.Text = "R";
                lbAxisName_V.Text = "V";
            }

            if (g_nESCExistCards > 0)
            {
                for (ushort i = (ushort)NodeID.SERVO_X; i <= (ushort)NodeID.SERVO_C4; i++)
                {
                    uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Get_Position(0, i, 0, ref nPos);
                    if (uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                    {
                        return;
                    }
                    else
                    {
                        ushort StatusWord = 0;
                        uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Get_StatusWord(0, i, 0, ref StatusWord);
                        byte[] byteStatusWord = BitConverter.GetBytes(StatusWord);
                        System.Collections.BitArray bitStatusWord = new BitArray(new byte[] { byteStatusWord[0] });


                        gbMotionControl.Enabled = true;
                        //   gbFeederControl.Enabled = true;
                        txtAxisPos[i - (int)NodeID.SERVO_X].Text = ((double)nPos / 100).ToString("0.00");

                        if (bitStatusWord.Get(7) == true)
                        {
                            cbServoOn[i - (int)NodeID.SERVO_X].BackColor = Color.Red;
                            btnResetALL.Enabled = true;
                        }
                        else
                        {
                            cbServoOn[i - (int)NodeID.SERVO_X].BackColor = Color.Transparent;
                        }

                        Count_Check_Initial++;

                        if (chbRealTimeSensorLB.Checked == true)
                        {
                            ReadLabelSensor();
                        }
                        

                        for (int k = 0; k <= 8; k++)
                        {
                            if (cbVacummControl[k].Checked == true)
                            {
                                bool bValue = false;

                                uRet = EtherCAT.getDI((ushort)IO_EtherCAT.INPUT_DI_VACUUM_NODE[k], (ushort)IO_EtherCAT.INPUT_DI_VACUUM_BIT[k], out bValue);

                                if (uRet == CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                                {
                                    double dValue = 0;
                                    uRet = EtherCAT.getAI((ushort)IO_EtherCAT.INPUT_AI_VACUUM_NODE[k], (ushort)IO_EtherCAT.INPUT_AI_VACUUM_CH[k], ref dValue);
                                    lbVacummValue[k].Text = (dValue / 10000).ToString("0.000");
                                    if (bValue == true)
                                    {
                                        cbVacummControl[k].BackColor = Color.LightGreen;
                                    }
                                    else
                                    {
                                        cbVacummControl[k].BackColor = Color.LightPink;
                                    }

                                }
                            }
                            else
                            {
                                lbVacummValue[k].Text = "0.000";
                            }
                        }



                    }

                }
                

                if (Count_Check_Initial == 9)
                    gbMotionControl.Enabled = true;

              
            }

         



        }

        public MachineConfig()
        {
            InitializeComponent();

        }

        private void MachineConfig_Load(object sender, EventArgs e)
        {
            sKeyence1_IP = ini.IniReadValue("Keyence_NUEP1", "IP");
            sKeyence2_IP = ini.IniReadValue("Keyence_NUEP2", "IP");

          

            btnAutoFeeder.Enabled = false;
            btnFeederJOG.Enabled = false;
            btnFeedStop.Enabled = false;

            txtC1_spd.Text = ((Convert.ToDouble(ini.IniReadValue("CONVERYOR_Spd", "C1"))) / 100).ToString();
            txtC2_spd.Text = ((Convert.ToDouble(ini.IniReadValue("CONVERYOR_Spd", "C2"))) / 100).ToString();
            txtC3_spd.Text = ((Convert.ToDouble(ini.IniReadValue("CONVERYOR_Spd", "C3"))) / 100).ToString();
            txtC4_spd.Text = ((Convert.ToDouble(ini.IniReadValue("CONVERYOR_Spd", "C4"))) / 100).ToString();


            lvHeadOffset_Geo.View = View.Details;
            lvHeadOffset_Geo.GridLines = true;
            lvHeadOffset_Geo.Columns.Add("No.", 30);
            lvHeadOffset_Geo.Columns.Add("X", 60, HorizontalAlignment.Center);
            lvHeadOffset_Geo.Columns.Add("Y", 60, HorizontalAlignment.Center);
            lvHeadOffset_Geo.Columns.Add("Error", 50, HorizontalAlignment.Center);
            lvHeadOffset_Geo.FullRowSelect = true;

            cbCamNum.SelectedIndex = 0;
            cbHeadNum.SelectedIndex = 0;

            lbCam_CoTheta_org.Text = "\u03F4" + "' :";
            btnCal_CoTheta_org.Text = "\u03F4" + "' Cal";
            btnSave_CoTheta_org.Text = "\u03F4" + "' Save";
            lbCamoffset_CoTheta_org.Text = "\u03F4" + "' :";
        }

        //----------------------------------------------------------------------------Mouse UP-------------------------------------------------------------------/
        #region
        private void btnJOG_X_P_MouseUp(object sender, MouseEventArgs e)
        {
            if (rdbMove_Con.Checked == true)
            {
                if (tcMotionControl.SelectedIndex < 1)
                {
                    EtherCAT.StopMoiton(0, (ushort)NodeID.SERVO_X, 0, dTdec);
                }
                else
                {
                    EtherCAT.StopMoiton(0, (ushort)NodeID.SERVO_C1, 0, dTdec);
                }
            }

        }
        private void btnJOG_X_N_MouseUp(object sender, MouseEventArgs e)
        {
            if (rdbMove_Con.Checked == true)
            {
                if (tcMotionControl.SelectedIndex < 1)
                {
                    EtherCAT.StopMoiton(0, (ushort)NodeID.SERVO_X, 0, dTdec);
                }
                else
                {
                    EtherCAT.StopMoiton(0, (ushort)NodeID.SERVO_C1, 0, dTdec);
                }
            }

        }
        private void btnJOG_Y_P_MouseUp(object sender, MouseEventArgs e)
        {
            if (rdbMove_Con.Checked == true)
            {
                if (tcMotionControl.SelectedIndex < 1)
                {
                    EtherCAT.StopMoiton(0, (ushort)NodeID.SERVO_Y, 0, dTdec);
                }
                else
                {
                    EtherCAT.StopMoiton(0, (ushort)NodeID.SERVO_C2, 0, dTdec);
                }
            }
        }
        private void btnJOG_Y_N_MouseUp(object sender, MouseEventArgs e)
        {
            if (rdbMove_Con.Checked == true)
            {
                EtherCAT.StopMoiton(0, (ushort)NodeID.SERVO_Y, 0, dTdec);
            }
        }
        private void btnJOG_Z_P_MouseUp(object sender, MouseEventArgs e)
        {
            if (rdbMove_Con.Checked == true)
            {
                EtherCAT.StopMoiton(0, (ushort)NodeID.SERVO_Z, 0, dTdec);
            }
        }

        private void btnJOG_Z_N_MouseUp(object sender, MouseEventArgs e)
        {
            if (rdbMove_Con.Checked == true)
            {
                EtherCAT.StopMoiton(0, (ushort)NodeID.SERVO_Z, 0, dTdec);
            }
        }

        private void btnJOG_R_P_MouseUp(object sender, MouseEventArgs e)
        {
            if (rdbMove_Con.Checked == true)
            {
                if (tcMotionControl.SelectedIndex < 1)
                {
                    EtherCAT.StopMoiton(0, (ushort)NodeID.SERVO_R, 0, dTdec);
                }
                else
                {
                    EtherCAT.StopMoiton(0, (ushort)NodeID.SERVO_C3, 0, dTdec);
                }
            }
        }
        private void btnJOG_R_N_MouseUp(object sender, MouseEventArgs e)
        {
            if (rdbMove_Con.Checked == true)
            {
                if (tcMotionControl.SelectedIndex < 1)
                {
                    EtherCAT.StopMoiton(0, (ushort)NodeID.SERVO_R, 0, dTdec);
                }
                else
                {
                    EtherCAT.StopMoiton(0, (ushort)NodeID.SERVO_C3, 0, dTdec);
                }
            }
        }

        private void btnJOG_V_P_MouseUp(object sender, MouseEventArgs e)
        {
            if (rdbMove_Con.Checked == true)
            {
                if (tcMotionControl.SelectedIndex < 1)
                {
                    EtherCAT.StopMoiton(0, (ushort)NodeID.SERVO_V, 0, dTdec);
                }
                else
                {
                    EtherCAT.StopMoiton(0, (ushort)NodeID.SERVO_C4, 0, dTdec);
                }
            }
        }
        private void btnJOG_V_N_MouseUp(object sender, MouseEventArgs e)
        {
            if (rdbMove_Con.Checked == true)
            {
                EtherCAT.StopMoiton(0, (ushort)NodeID.SERVO_V, 0, dTdec);
            }
        }
        #endregion // Mouse UP// #r


        //--------------------------------------  Mouse  Down------------------------------------------------------------------------------------------------/
        private void btnJOG_X_P_MouseDown(object sender, MouseEventArgs e)
        {
            if (rdbMove_Con.Checked == true)
            {
                if (tcMotionControl.SelectedIndex < 1)
                {
                    g_uRet = JogAxis((ushort)NodeID.SERVO_X, nDir_P);
                }
                else
                {
                    g_uRet = JogAxis((ushort)NodeID.SERVO_C1, nDir_P);
                }
            }
            if (rdbMove_Step.Checked == true)
            {
                int nPos = 0;
                try
                {
                    nPos = Convert.ToInt32(Convert.ToDouble(txtDis_Step.Text) * 100);
                    if (tcMotionControl.SelectedIndex < 1)
                    {
                        g_uRet = JogAxis((ushort)NodeID.SERVO_X, nDir_P, nPos);
                    }
                    else
                    {
                        g_uRet = JogAxis((ushort)NodeID.SERVO_C1, nDir_P, nPos);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please fill step vaule!");
                }
            }
        }
        private void btnJOG_X_N_MouseDown(object sender, MouseEventArgs e)
        {

            if (rdbMove_Con.Checked == true)
            {
                if (tcMotionControl.SelectedIndex < 1)
                {
                    g_uRet = JogAxis((ushort)NodeID.SERVO_X, nDir_N);
                }
                else
                {
                    g_uRet = JogAxis((ushort)NodeID.SERVO_C1, nDir_N);
                }
            }
            if (rdbMove_Step.Checked == true)
            {
                int nPos = 0;
                try
                {
                    nPos = Convert.ToInt32(Convert.ToDouble(txtDis_Step.Text) * 100);
                    if (tcMotionControl.SelectedIndex < 1)
                    {
                        g_uRet = JogAxis((ushort)NodeID.SERVO_X, nDir_N, nPos);
                    }
                    else
                    {
                        g_uRet = JogAxis((ushort)NodeID.SERVO_C1, nDir_N, nPos);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please fill step vaule!" + ex.Message);
                }
            }

        }
        private void btnJOG_Y_P_MouseDown(object sender, MouseEventArgs e)
        {
            if (rdbMove_Con.Checked == true)
            {
                if (tcMotionControl.SelectedIndex < 1)
                {
                    g_uRet = JogAxis((ushort)NodeID.SERVO_Y, nDir_P);
                }
                else
                {
                    g_uRet = JogAxis((ushort)NodeID.SERVO_C2, nDir_P);
                }
            }
            if (rdbMove_Step.Checked == true)
            {
                int nPos = 0;
                try
                {
                    nPos = Convert.ToInt32(Convert.ToDouble(txtDis_Step.Text) * 100);
                    if (tcMotionControl.SelectedIndex < 1)
                    {
                        g_uRet = JogAxis((ushort)NodeID.SERVO_Y, nDir_P, nPos);
                    }
                    else
                    {
                        g_uRet = JogAxis((ushort)NodeID.SERVO_C2, nDir_P, nPos);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please fill step vaule!");
                }
            }
        }
        private void btnJOG_Y_N_MouseDown(object sender, MouseEventArgs e)
        {
            if (rdbMove_Con.Checked == true)
            {
                if (tcMotionControl.SelectedIndex < 1)
                {
                    g_uRet = JogAxis((ushort)NodeID.SERVO_Y, nDir_N);
                }
                else
                {
                    g_uRet = JogAxis((ushort)NodeID.SERVO_C2, nDir_N);
                }
            }
            if (rdbMove_Step.Checked == true)
            {
                int nPos = 0;
                try
                {
                    nPos = Convert.ToInt32(Convert.ToDouble(txtDis_Step.Text) * 100);
                    if (tcMotionControl.SelectedIndex < 1)
                    {
                        g_uRet = JogAxis((ushort)NodeID.SERVO_Y, nDir_N, nPos);
                    }
                    else
                    {
                        g_uRet = JogAxis((ushort)NodeID.SERVO_C2, nDir_N, nPos);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please fill step vaule!");
                }
            }

        }
        private void btnJOG_Z_P_MouseDown(object sender, MouseEventArgs e)
        {
            if (rdbMove_Con.Checked == true)
            {
                g_uRet = JogAxis((ushort)NodeID.SERVO_Z, nDir_P);
            }
            if (rdbMove_Step.Checked == true)
            {
                int nPos = 0;
                try
                {
                    nPos = Convert.ToInt32(Convert.ToDouble(txtDis_Step.Text) * 100);
                    g_uRet = JogAxis((ushort)NodeID.SERVO_Z, nDir_P, nPos);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please fill step vaule!");
                }
            }
        }

        private void btnHomeRobot_Click(object sender, EventArgs e)
        {
            ushort zMode = (ushort)(Convert.ToDouble(ini.IniReadValue("SERVO_HOME_Mode", "Z")));
            ushort zStrVel = (ushort)(Convert.ToDouble(ini.IniReadValue("SERVO_HOME_StrVel", "Z")));
            ushort zMaxVel = (ushort)(Convert.ToDouble(ini.IniReadValue("SERVO_HOME_MaxVel", "Z")));
            ushort xMode = (ushort)(Convert.ToDouble(ini.IniReadValue("SERVO_HOME_Mode", "X")));
            ushort xStrVel = (ushort)(Convert.ToDouble(ini.IniReadValue("SERVO_HOME_StrVel", "X")));
            ushort xMaxVel = (ushort)(Convert.ToDouble(ini.IniReadValue("SERVO_HOME_MaxVel", "X")));
            ushort yMode = (ushort)(Convert.ToDouble(ini.IniReadValue("SERVO_HOME_Mode", "Y")));
            ushort yStrVel = (ushort)(Convert.ToDouble(ini.IniReadValue("SERVO_HOME_StrVel", "Y")));
            ushort yMaxVel = (ushort)(Convert.ToDouble(ini.IniReadValue("SERVO_HOME_MaxVel", "Y")));

            ushort[] cMode = new ushort[] {
                (ushort)(Convert.ToDouble(ini.IniReadValue("SERVO_HOME_Mode", "C1"))),
                (ushort)(Convert.ToDouble(ini.IniReadValue("SERVO_HOME_Mode", "C2"))),
                (ushort)(Convert.ToDouble(ini.IniReadValue("SERVO_HOME_Mode", "C3"))),
                (ushort)(Convert.ToDouble(ini.IniReadValue("SERVO_HOME_Mode", "C4")))
            };

            ushort[] cStrvel = new ushort[]
            {
                (ushort)(Convert.ToDouble(ini.IniReadValue("SERVO_HOME_StrVel", "C1"))),
                (ushort)(Convert.ToDouble(ini.IniReadValue("SERVO_HOME_StrVel", "C2"))),
                (ushort)(Convert.ToDouble(ini.IniReadValue("SERVO_HOME_StrVel", "C3"))),
                (ushort)(Convert.ToDouble(ini.IniReadValue("SERVO_HOME_StrVel", "C4")))
            };

            ushort[] cMaxVel = new ushort[]
            {
                (ushort)(Convert.ToDouble(ini.IniReadValue("SERVO_HOME_MaxVel", "C1"))),
                (ushort)(Convert.ToDouble(ini.IniReadValue("SERVO_HOME_MaxVel", "C2"))),
                (ushort)(Convert.ToDouble(ini.IniReadValue("SERVO_HOME_MaxVel", "C3"))),
                (ushort)(Convert.ToDouble(ini.IniReadValue("SERVO_HOME_MaxVel", "C4")))
            };


            int[] cHomeOffset = new int[]
            {
                 (Convert.ToInt16(ini.IniReadValue("SERVO_HOME_OFFSET", "C1"))),
                 (Convert.ToInt16(ini.IniReadValue("SERVO_HOME_OFFSET", "C2"))),
                 (Convert.ToInt16(ini.IniReadValue("SERVO_HOME_OFFSET", "C3"))),
                 (Convert.ToInt16(ini.IniReadValue("SERVO_HOME_OFFSET", "C4"))),
            };
            CheckBox[] cbServo_C = new CheckBox[]
            {
                cbServo_C1,cbServo_C2,cbServo_C3,cbServo_C4
            };
            if (tcMotionControl.SelectedIndex == 0)
            {

                do
                {
                    g_uRet = EtherCAT.HomeServo(g_uESCCardNo, (ushort)NodeID.SERVO_Z, zMode, zStrVel, zMaxVel, ref mDone);

                }
                while ((mDone) != 0);
                ushort StatusWord = 0;
                g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Get_StatusWord(0, (ushort)NodeID.SERVO_Z, 0, ref StatusWord);

                //System.Collections.BitArray ba = new BitArray(new byte[] { bytes[index] });

                if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                {

                }
                else
                {

                    ushort g_uRetx = EtherCAT.HomeServo(g_uESCCardNo, (ushort)NodeID.SERVO_X, xMode, xStrVel, xMaxVel, ref mDone);
                    ushort g_uRety = EtherCAT.HomeServo(g_uESCCardNo, (ushort)NodeID.SERVO_Y, yMode, yStrVel, yMaxVel, ref mDone);

                }
            }
            else
            {
                for (ushort i = 0; i <= 3; i++)
                {
                    if (cbServo_C[i].Checked == true)
                    {
                        g_uRet = EtherCAT.HomeServo(g_uESCCardNo, (ushort)(NodeID.SERVO_C1 + i), cMode[i], cStrvel[i], cMaxVel[i], ref mDone, cHomeOffset[i]);

                    }
                }
            }


        }

        private void btnHomeR_Click(object sender, EventArgs e)
        {
            ushort Mode = (ushort)(Convert.ToDouble(ini.IniReadValue("SERVO_HOME_Mode", "R")));
            ushort StrVel = (ushort)(Convert.ToDouble(ini.IniReadValue("SERVO_HOME_StrVel", "R")));
            ushort MaxVel = (ushort)(Convert.ToDouble(ini.IniReadValue("SERVO_HOME_MaxVel", "R")));
            int HomeOffset = (Convert.ToInt16(ini.IniReadValue("SERVO_HOME_OFFSET", "R")));

            int Temp_nPos = 0;
            g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Get_Position(0, (ushort)NodeID.SERVO_R, 0, ref Temp_nPos);
            if (Temp_nPos > 0)
            {
                g_uRet = JogAxis((ushort)NodeID.SERVO_R, nDir_N, Temp_nPos, 500);
            }
            else
            {
                g_uRet = JogAxis((ushort)NodeID.SERVO_R, nDir_P, Math.Abs(Temp_nPos), 500);
            }
        }

        private void btnHomeV_Click(object sender, EventArgs e)
        {
            ushort Mode = (ushort)(Convert.ToDouble(ini.IniReadValue("SERVO_HOME_Mode", "V")));
            ushort StrVel = (ushort)(Convert.ToDouble(ini.IniReadValue("SERVO_HOME_StrVel", "V")));
            ushort MaxVel = (ushort)(Convert.ToDouble(ini.IniReadValue("SERVO_HOME_MaxVel", "V")));
            int HomeOffset = (Convert.ToInt16(ini.IniReadValue("SERVO_HOME_OFFSET", "V")));

            g_uRet = EtherCAT.HomeServo(g_uESCCardNo, (ushort)NodeID.SERVO_V, Mode, StrVel, MaxVel, ref mDone, HomeOffset);

             int nPos = Convert.ToInt32(Convert.ToDouble(ini.IniReadValue("Head_pos", "H01")) * 100);
            absMoveHead_flag = 1;
            g_uRet = JogAxis((ushort)NodeID.SERVO_V, nDir_P, nPos);

            //    int Temp_nPos = 0;
            //    g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Get_Position(0, (ushort)NodeID.SERVO_V, 0, ref Temp_nPos);

            //    if (Temp_nPos > 0)
            //    {
            //        g_uRet = JogAxis((ushort)NodeID.SERVO_V, nDir_N, Temp_nPos, 1000);
            //    }
            //    else
            //    {
            //        g_uRet = JogAxis((ushort)NodeID.SERVO_V, nDir_P, Math.Abs(Temp_nPos), 1000);
            //    }
        }

        private void btnJOG_Z_N_MouseDown(object sender, MouseEventArgs e)
        {
            if (rdbMove_Con.Checked == true)
            {
                g_uRet = JogAxis((ushort)NodeID.SERVO_Z, nDir_N);
            }
            if (rdbMove_Step.Checked == true)
            {
                int nPos = 0;
                try
                {
                    nPos = Convert.ToInt32(Convert.ToDouble(txtDis_Step.Text) * 100);
                    g_uRet = JogAxis((ushort)NodeID.SERVO_Z, nDir_N, nPos);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please fill step vaule!");
                }
            }
        }
        private void btnJOG_R_P_MouseDown(object sender, MouseEventArgs e)
        {
            if (rdbMove_Con.Checked == true)
            {
                if (tcMotionControl.SelectedIndex < 1)
                {
                    g_uRet = JogAxis((ushort)NodeID.SERVO_R, nDir_P);
                }
                else
                {
                    g_uRet = JogAxis((ushort)NodeID.SERVO_C3, nDir_P);
                }
            }
            if (rdbMove_Step.Checked == true)
            {
                int nPos = 0;
                try
                {
                    nPos = Convert.ToInt32(Convert.ToDouble(txtDis_Step.Text) * 100);
                    if (tcMotionControl.SelectedIndex < 1)
                    {
                        g_uRet = JogAxis((ushort)NodeID.SERVO_R, nDir_P, nPos);
                    }
                    else
                    {
                        g_uRet = JogAxis((ushort)NodeID.SERVO_C3, nDir_P, nPos);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please fill step vaule!");
                }
            }
        }


        private void btnResetALL_Click_2(object sender, EventArgs e)
        {
            for (ushort i = (ushort)NodeID.SERVO_X; i <= (ushort)NodeID.SERVO_C4; i++)
            {
                g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Ralm(0, i, 0);
                ErrorLimit_count = 0;

                if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                {
                    AddErrMsg("_ECAT_Slave_Motion_Ralm, ErrorCode = " + g_uRet.ToString(), true);
                }
            }
            btnResetALL.Enabled = false;
        }

        private void btnJOG_R_N_MouseDown(object sender, MouseEventArgs e)
        {
            if (rdbMove_Con.Checked == true)
            {
                if (tcMotionControl.SelectedIndex < 1)
                {
                    g_uRet = JogAxis((ushort)NodeID.SERVO_R, nDir_N);
                }
                else
                {
                    g_uRet = JogAxis((ushort)NodeID.SERVO_C3, nDir_N);
                }
            }
            if (rdbMove_Step.Checked == true)
            {
                int nPos = 0;
                try
                {
                    nPos = Convert.ToInt32(Convert.ToDouble(txtDis_Step.Text) * 100);
                    if (tcMotionControl.SelectedIndex < 1)
                    {
                        g_uRet = JogAxis((ushort)NodeID.SERVO_R, nDir_N, nPos);
                    }
                    else
                    {
                        g_uRet = JogAxis((ushort)NodeID.SERVO_C3, nDir_N, nPos);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please fill step vaule!");
                }
            }

        }
        private void btnJOG_V_P_MouseDown(object sender, MouseEventArgs e)
        {
            if (rdbMove_Con.Checked == true)
            {
                if (tcMotionControl.SelectedIndex < 1)
                {
                    g_uRet = JogAxis((ushort)NodeID.SERVO_V, nDir_P);
                }
                else
                {
                    g_uRet = JogAxis((ushort)NodeID.SERVO_C4, nDir_P);
                }
            }
            if (rdbMove_Step.Checked == true)
            {
                int nPos = 0;
                try
                {
                    nPos = Convert.ToInt32(Convert.ToDouble(txtDis_Step.Text) * 100);
                    if (tcMotionControl.SelectedIndex < 1)
                    {
                        g_uRet = JogAxis((ushort)NodeID.SERVO_V, nDir_P, nPos);
                    }
                    else
                    {
                        g_uRet = JogAxis((ushort)NodeID.SERVO_C4, nDir_P, nPos);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please fill step vaule!");
                }
            }
        }
        private void btnJOG_V_N_MouseDown(object sender, MouseEventArgs e)
        {
            if (rdbMove_Con.Checked == true)
            {
                if (tcMotionControl.SelectedIndex < 1)
                {
                    g_uRet = JogAxis((ushort)NodeID.SERVO_V, nDir_N);
                }
                else
                {
                    g_uRet = JogAxis((ushort)NodeID.SERVO_C4, nDir_N);
                }
            }
            if (rdbMove_Step.Checked == true)
            {
                int nPos = 0;
                try
                {
                    nPos = Convert.ToInt32(Convert.ToDouble(txtDis_Step.Text) * 100);
                    if (tcMotionControl.SelectedIndex < 1)
                    {
                        g_uRet = JogAxis((ushort)NodeID.SERVO_V, nDir_N, nPos);
                    }
                    else
                    {
                        g_uRet = JogAxis((ushort)NodeID.SERVO_C4, nDir_N, nPos);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please fill step vaule!");
                }
            }

        }

        //-----------------------------------------------------JOG--------------------------------------------/
        private ushort JogAxis(ushort uAxisNo, int nDirection, int nTraget = 1000000, ushort uContSpd = 2500)
        {

            nTraget = Math.Abs(nTraget);
            if (absMoveHead_flag == 1)
            {
                g_uRet = EtherCAT.AxisMoveJog(0, uAxisNo, 0, uContSpd, 100, 100, nTraget, 1);

                absMoveHead_flag = 0;
            }
            else
            {
                if (nDirection == nDir_N)
                {
                    g_uRet = EtherCAT.AxisMoveJog(0, uAxisNo, 0, uContSpd, 100, 100, 0 - nTraget, 0);
                }
                if (nDirection == nDir_P)
                {
                    g_uRet = EtherCAT.AxisMoveJog(0, uAxisNo, 0, uContSpd, 100, 100, nTraget, 0);
                }
                if (g_uRet != 0)
                {
                    AddErrMsg("CS_ECAT_Slave_PP_Start_Move, ErrorCode = " + g_uRet.ToString(), true);
                }

            }

            return g_uRet;

        }

        private void btnServo_C1_Move_Click(object sender, EventArgs e)
        {
            int nPos = Math.Abs(Convert.ToInt32(Convert.ToDouble(txtServo_C1_Target.Text) * 100));

            g_uRet = EtherCAT.AxisMoveJog(0, (ushort)NodeID.SERVO_C1, 0, 2500, 100, 100, 0 - nPos, 1);
        }

        private void btnServo_C2_Move_Click(object sender, EventArgs e)
        {
            int nPos = Math.Abs(Convert.ToInt32(Convert.ToDouble(txtServo_C2_Target.Text) * 100));

            g_uRet = EtherCAT.AxisMoveJog(0, (ushort)NodeID.SERVO_C2, 0, 2500, 100, 100, 0 - nPos, 1);
        }

        private void btnServo_C3_Move_Click(object sender, EventArgs e)
        {

            int nPos = Math.Abs(Convert.ToInt32(Convert.ToDouble(txtServo_C3_Target.Text) * 100));

            g_uRet = EtherCAT.AxisMoveJog(0, (ushort)NodeID.SERVO_C3, 0, 2500, 100, 100, 0 - nPos, 1);
        }

        private void btnServo_C4_Move_Click(object sender, EventArgs e)
        {
            int nPos = Math.Abs(Convert.ToInt32(Convert.ToDouble(txtServo_C4_Target.Text) * 100));

            g_uRet = EtherCAT.AxisMoveJog(0, (ushort)NodeID.SERVO_C4, 0, 2500, 100, 100, 0 - nPos, 1);
        }

        private void AddErrMsg(string strMsg, bool bShowErr = false)
        {
            LstErrMsg.SelectedIndex = LstErrMsg.Items.Add(strMsg);

            if (bShowErr == true)
                MessageBox.Show(strMsg);
        }
        private void rdbMove_Step_CheckedChanged(object sender, EventArgs e)
        {
            txtDis_Step.Enabled = true;
        }

        private void rdbMove_Con_CheckedChanged(object sender, EventArgs e)
        {
            txtDis_Step.Enabled = false;
        }
        private void cbServo_C1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbServo_C1.Checked == true)
            {
                EtherCAT.setOnservo(0, (ushort)NodeID.SERVO_C1, ON);
            }
            else
            {
                EtherCAT.setOnservo(0, (ushort)NodeID.SERVO_C1, OFF);
            }
        }

        private void btnSave_Con_Spd_Click(object sender, EventArgs e)
        {
            string C1 = (Convert.ToDouble(txtC1_spd.Text) * 100).ToString();
            string C2 = (Convert.ToDouble(txtC2_spd.Text) * 100).ToString();
            string C3 = (Convert.ToDouble(txtC3_spd.Text) * 100).ToString();
            string C4 = (Convert.ToDouble(txtC4_spd.Text) * 100).ToString();

            ini.IniWriteValue("CONVERYOR_Spd", "C1", C1);
            ini.IniWriteValue("CONVERYOR_Spd", "C2", C2);
            ini.IniWriteValue("CONVERYOR_Spd", "C3", C3);
            ini.IniWriteValue("CONVERYOR_Spd", "C4", C4);
        }

        private void cbServo_C2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbServo_C2.Checked == true)
            {
                EtherCAT.setOnservo(0, (ushort)NodeID.SERVO_C2, ON);
            }
            else
            {
                EtherCAT.setOnservo(0, (ushort)NodeID.SERVO_C2, OFF);
            }
        }
        private void cbServo_C3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbServo_C3.Checked == true)
            {
                EtherCAT.setOnservo(0, (ushort)NodeID.SERVO_C3, ON);
            }
            else
            {
                EtherCAT.setOnservo(0, (ushort)NodeID.SERVO_C3, OFF);
            }
        }
        private void cbServo_C4_CheckedChanged(object sender, EventArgs e)
        {
            if (cbServo_C4.Checked == true)
            {
                EtherCAT.setOnservo(0, (ushort)NodeID.SERVO_C4, ON);
            }
            else
            {
                EtherCAT.setOnservo(0, (ushort)NodeID.SERVO_C4, OFF);
            }
        }
        private void cbCon_C1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCon_C1.Checked == true)
            {

                string sRet = Mod_Conveyor.Tx_Data("01", vfdAddress.frequencyComm, fdd.Frequncncy(Convert.ToInt32(ini.IniReadValue("CONVERYOR_Spd", "C1"))));
                sRet = Mod_Conveyor.Tx_Data("01", vfdAddress.operationComm, "0022");

            }
            else
            {
                string sRet = Mod_Conveyor.Tx_Data("01", vfdAddress.operationComm, "0001");

            }
        }

        private void cbCon_C2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCon_C2.Checked == true)
            {

                string sRet = Mod_Conveyor.Tx_Data("02", vfdAddress.frequencyComm, fdd.Frequncncy(Convert.ToInt32(ini.IniReadValue("CONVERYOR_Spd", "C2"))));
                sRet = Mod_Conveyor.Tx_Data("02", vfdAddress.operationComm, "0022");

            }
            else
            {
                string sRet = Mod_Conveyor.Tx_Data("02", vfdAddress.operationComm, "0001");

            }
        }

        private void cbCon_C3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCon_C3.Checked == true)
            {

                string sRet = Mod_Conveyor.Tx_Data("03", vfdAddress.frequencyComm, fdd.Frequncncy(Convert.ToInt32(ini.IniReadValue("CONVERYOR_Spd", "C3"))));
                sRet = Mod_Conveyor.Tx_Data("03", vfdAddress.operationComm, "0012");

            }
            else
            {
                string sRet = Mod_Conveyor.Tx_Data("03", vfdAddress.operationComm, "0001");

            }
        }

        private void btnIniFeedder_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 7; i++)
            {
                ushort uRet01 = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Set_Svon(g_uESCCardNo, IO_EtherCAT.OUTPUT_PO_FEEDDER_CON_NODE[i], 0, 1);
                ushort uRet02 = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Set_Svon(g_uESCCardNo, IO_EtherCAT.OUTPUT_PO_FEEDDER_ROLL_NODE[i], 0, 1);
                ushort uRet03 = EtherCAT.setDO(g_uESCCardNo, IO_EtherCAT.OUTPUT_DO_DISABLE_CON_NODE[i], IO_EtherCAT.OUTPUT_DO_DISABLE_CON_BIT[i], 1);
                if (uRet03 != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                {
                    AddErrMsg("CS_ECAT_Slave_DIO_Set_Single_Output_Value, ErrorCode = " + uRet03.ToString(), true);
                }
                ushort uRet04 = EtherCAT.setDO(g_uESCCardNo, IO_EtherCAT.OUTPUT_DO_DISABLE_ROLL_NODE[i], IO_EtherCAT.OUTPUT_DO_DISABLE_ROLL_BIT[i], 1);
                if (uRet04 != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                {
                    AddErrMsg("CS_ECAT_Slave_DIO_Set_Single_Output_Value, ErrorCode = " + uRet04.ToString(), true);
                }
                if ((uRet01 + uRet02 + uRet03 + uRet04) == CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                {
                    btnAutoFeeder.Enabled = true;
                    btnFeederJOG.Enabled = true;
                    btnFeedStop.Enabled = true;
                    btnIniFeedder.Enabled = false;

                }
            }
        }

        private void btnLoadROLL_Click(object sender, EventArgs e)
        {
            int iIndex = cbFeederNum.SelectedIndex;
            ushort uRet = EtherCAT.setDO(g_uESCCardNo, IO_EtherCAT.OUTPUT_DO_RELEASE_ROLL_NODE[iIndex], IO_EtherCAT.OUTPUT_DO_RELEASE_ROLL_BIT[iIndex], 0);
            if (uRet == CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                btnReleaseROLL.Enabled = true;
                btnLoadROLL.Enabled = false;
            }
            else
            {
                AddErrMsg("CS_ECAT_Slave_DIO_Set_Single_Output_Value, ErrorCode = " + g_uRet.ToString(), true);
            }
        }

        private void btnReleaseROLL_Click(object sender, EventArgs e)
        {
            int iIndex = cbFeederNum.SelectedIndex;
            ushort uRet = EtherCAT.setDO(g_uESCCardNo, IO_EtherCAT.OUTPUT_DO_RELEASE_ROLL_NODE[iIndex], IO_EtherCAT.OUTPUT_DO_RELEASE_ROLL_BIT[iIndex], 1);
            if (uRet == CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                btnLoadROLL.Enabled = true;
                btnReleaseROLL.Enabled = false;
            }
            else
            {
                AddErrMsg("CS_ECAT_Slave_DIO_Set_Single_Output_Value, ErrorCode = " + g_uRet.ToString(), true);
            }
        }

        private void btSensorLBRead_Click(object sender, EventArgs e)
        {

        }

        private void cbCon_C4_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCon_C4.Checked == true)
            {

                string sRet = Mod_Conveyor.Tx_Data("04", vfdAddress.frequencyComm, fdd.Frequncncy(Convert.ToInt32(ini.IniReadValue("CONVERYOR_Spd", "C4"))));
                sRet = Mod_Conveyor.Tx_Data("04", vfdAddress.operationComm, "0012");

            }
            else
            {
                string sRet = Mod_Conveyor.Tx_Data("04", vfdAddress.operationComm, "0001");

            }
        }

        private void cbStopperC1_CheckedChanged(object sender, EventArgs e)
        {
            ushort uValue = 0;
            if (cbStopperC1.Checked == true)
            {
                uValue = 1;
            }
            else
            {
                uValue = 0;
            }
            ushort uRet = EtherCAT.setDO(g_uESCCardNo, (ushort)IO_EtherCAT.OUTPUT_DO_CYC.NodeID, (ushort)IO_EtherCAT.OUTPUT_DO_CYC.BitID, uValue);
            if (uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                AddErrMsg("CS_ECAT_Slave_DIO_Set_Single_Output_Value, ErrorCode = " + uRet.ToString(), true);
            }
        }

        private void btnFeederJOG_Click(object sender, EventArgs e)
        {

        }

        private void btnFeedStop_Click(object sender, EventArgs e)
        {
            int iIndex = cbFeederNum.SelectedIndex;
            for (int i = 0; i <= 7; i++)
            {
                FeedStop(i);
            }

            AutoFeedClicked = 0;


            btnAutoFeeder.Enabled = true;
            btnFeederJOG.Enabled = true;

            btnFeedStop.Enabled = false;
        }

        private void FeedStop(int Index)
        {
            int i = Index;
            ushort uRet = EtherCAT.setDO(g_uESCCardNo, IO_EtherCAT.OUTPUT_DO_DISABLE_CON_NODE[i], IO_EtherCAT.OUTPUT_DO_DISABLE_CON_BIT[i], 1);
            if (uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                AddErrMsg("CS_ECAT_Slave_DIO_Set_Single_Output_Value, ErrorCode = " + g_uRet.ToString(), true);
            }
            uRet = EtherCAT.setDO(g_uESCCardNo, IO_EtherCAT.OUTPUT_DO_DISABLE_ROLL_NODE[i], IO_EtherCAT.OUTPUT_DO_DISABLE_ROLL_BIT[i], 1);
            if (uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                AddErrMsg("CS_ECAT_Slave_DIO_Set_Single_Output_Value, ErrorCode = " + g_uRet.ToString(), true);
            }

            uRet = EtherCAT.resetPO(g_uESCCardNo, IO_EtherCAT.OUTPUT_PO_FEEDDER_CON_NODE[i]);

            if (uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                AddErrMsg("_ECAT_Slave_Motion_Sd_Stop, ErrorCode = " + g_uRet.ToString(), true);
            }
            uRet = EtherCAT.resetPO(g_uESCCardNo, IO_EtherCAT.OUTPUT_PO_FEEDDER_ROLL_NODE[i]);

            if (uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                AddErrMsg("_ECAT_Slave_Motion_Sd_Stop, ErrorCode = " + g_uRet.ToString(), true);
            }
        }

        private void cbStopperC2_CheckedChanged(object sender, EventArgs e)
        {
            ushort uValue = 0;
            if (cbStopperC2.Checked == true)
            {
                uValue = 1;
            }
            else
            {
                uValue = 0;
            }
            ushort uRet = EtherCAT.setDO(g_uESCCardNo, (ushort)IO_EtherCAT.OUTPUT_DO_CYF.NodeID, (ushort)IO_EtherCAT.OUTPUT_DO_CYF.BitID, uValue);
            if (uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                AddErrMsg("CS_ECAT_Slave_DIO_Set_Single_Output_Value, ErrorCode = " + uRet.ToString(), true);
            }
        }

        private void cbStopperC3_CheckedChanged(object sender, EventArgs e)
        {
            ushort uValue = 0;
            if (cbStopperC3.Checked == true)
            {
                uValue = 1;
            }
            else
            {
                uValue = 0;
            }
            ushort uRet = EtherCAT.setDO(g_uESCCardNo, (ushort)IO_EtherCAT.OUTPUT_DO_CYH.NodeID, (ushort)IO_EtherCAT.OUTPUT_DO_CYH.BitID, uValue);
            if (uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                AddErrMsg("CS_ECAT_Slave_DIO_Set_Single_Output_Value, ErrorCode = " + uRet.ToString(), true);
            }
        }

        private void cbStopperC4_CheckedChanged(object sender, EventArgs e)
        {
            ushort uValue = 0;
            if (cbStopperC4.Checked == true)
            {
                uValue = 1;
            }
            else
            {
                uValue = 0;
            }
            ushort uRet = EtherCAT.setDO(g_uESCCardNo, (ushort)IO_EtherCAT.OUTPUT_DO_CYK.NodeID, (ushort)IO_EtherCAT.OUTPUT_DO_CYK.BitID, uValue);
            if (uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                AddErrMsg("CS_ECAT_Slave_DIO_Set_Single_Output_Value, ErrorCode = " + uRet.ToString(), true);
            }
        }
        private byte[] ReadLabelSensor()
        {
            byte[] bSensorLB;
            //Boolean[] BitSensor;
            bool bRet = false;
            Label[] TempLBindex = new Label[4];
            TempLBindex[0] = lbSensorLB01;
            TempLBindex[1] = lbSensorLB02;
            TempLBindex[2] = lbSensorLB03;
            TempLBindex[3] = lbSensorLB04;
            int iTempIndex = 0;
            CheckSensorRoll();

            if (cbFeederNum.SelectedIndex <= 3)
            {
                bRet = Keyence_NUEP1.getSensor(sKeyence1_IP, out bSensorLB);
                iTempIndex = cbFeederNum.SelectedIndex;
            }
            else
            {
                bRet = Keyence_NUEP1.getSensor(sKeyence2_IP, out bSensorLB);
                iTempIndex = cbFeederNum.SelectedIndex - 4;
            }
            if (bRet != false)
            {
                int k = (iTempIndex) * 4;
                for (int i = 0; i <= 3; i++)
                {
                    if (Keyence_NUEP1.GetBitX(bSensorLB, k + i) == true)
                    {
                        TempLBindex[i].BackColor = Color.LightGreen;
                    }
                    else
                    {
                        TempLBindex[i].BackColor = Color.LightPink;
                    }
                }
            }
            return bSensorLB;
        }
        private void btnFeederJOG_MouseDown(object sender, MouseEventArgs e)
        {
            int iIndex = cbFeederNum.SelectedIndex;
            string iTragetVel_CON = ini.IniReadValue("FEEDER_CONTROL", "Spd_CON");
            string iTragetVel_ROLL = ini.IniReadValue("FEEDER_CONTROL", "Spd_ROLL");

            ushort uRet = EtherCAT.setDO(g_uESCCardNo, IO_EtherCAT.OUTPUT_DO_DISABLE_CON_NODE[iIndex], IO_EtherCAT.OUTPUT_DO_DISABLE_CON_BIT[iIndex], 0);
            if (uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                AddErrMsg("CS_ECAT_Slave_DIO_Set_Single_Output_Value, ErrorCode = " + uRet.ToString(), true);
            }
            uRet = EtherCAT.setDO(g_uESCCardNo, IO_EtherCAT.OUTPUT_DO_DISABLE_ROLL_NODE[iIndex], IO_EtherCAT.OUTPUT_DO_DISABLE_ROLL_BIT[iIndex], 0);
            if (uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                AddErrMsg("CS_ECAT_Slave_DIO_Set_Single_Output_Value, ErrorCode = " + uRet.ToString(), true);
            }

            uRet = EtherCAT.setPO(g_uESCCardNo, IO_EtherCAT.OUTPUT_PO_FEEDDER_CON_NODE[iIndex], (ushort)(Convert.ToDouble(iTragetVel_CON)));
            if (uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                AddErrMsg("CS_ECAT_Slave_PV_Start_Move, ErrorCode = " + uRet.ToString(), true);
            }
            else
            {
                uRet = EtherCAT.setPO(g_uESCCardNo, IO_EtherCAT.OUTPUT_PO_FEEDDER_ROLL_NODE[iIndex], (ushort)(Convert.ToDouble(iTragetVel_ROLL)));
                if (uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                {
                    AddErrMsg("CS_ECAT_Slave_PV_Start_Move, ErrorCode = " + uRet.ToString(), true);
                }

            }
        }
        private void btnFeederJOG_MouseUp(object sender, MouseEventArgs e)
        {
            // int iIndex = cbFeederNum.SelectedIndex;
            for (int i = 0; i <= 7; i++)
            {
                ushort uRet = EtherCAT.setDO(g_uESCCardNo, IO_EtherCAT.OUTPUT_DO_DISABLE_CON_NODE[i], IO_EtherCAT.OUTPUT_DO_DISABLE_CON_BIT[i], 1);
                if (uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                {
                    AddErrMsg("CS_ECAT_Slave_DIO_Set_Single_Output_Value, ErrorCode = " + g_uRet.ToString(), true);
                }
                uRet = EtherCAT.setDO(g_uESCCardNo, IO_EtherCAT.OUTPUT_DO_DISABLE_ROLL_NODE[i], IO_EtherCAT.OUTPUT_DO_DISABLE_ROLL_BIT[i], 1);
                if (uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                {
                    AddErrMsg("CS_ECAT_Slave_DIO_Set_Single_Output_Value, ErrorCode = " + g_uRet.ToString(), true);
                }

                uRet = EtherCAT.resetPO(g_uESCCardNo, IO_EtherCAT.OUTPUT_PO_FEEDDER_CON_NODE[i]);

                if (uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                {
                    AddErrMsg("_ECAT_Slave_Motion_Sd_Stop, ErrorCode = " + g_uRet.ToString(), true);
                }
                uRet = EtherCAT.resetPO(g_uESCCardNo, IO_EtherCAT.OUTPUT_PO_FEEDDER_ROLL_NODE[i]);

                if (uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                {
                    AddErrMsg("_ECAT_Slave_Motion_Sd_Stop, ErrorCode = " + g_uRet.ToString(), true);
                }
            }

        }
        private void CheckSensorRoll()
        {
            if (cbFeederNum.SelectedIndex > -1)
            {
                ushort g_NodeID = 0, g_BitNum = 0;
                bool g_BitValue = false;
                if (g_nESCExistCards > 0)  //after initial card g_nESCExistCards=1
                {
                    int[] Feeder_NodeID = new int[8];
                    int[] Feeder_BitNum = new int[8];

                    Feeder_NodeID[0] = (int)IO_EtherCAT.INPUT_DI_CHECK_ROLL_LABEL_01.NodeID;
                    Feeder_NodeID[1] = (int)IO_EtherCAT.INPUT_DI_CHECK_ROLL_LABEL_02.NodeID;
                    Feeder_NodeID[2] = (int)IO_EtherCAT.INPUT_DI_CHECK_ROLL_LABEL_03.NodeID;
                    Feeder_NodeID[3] = (int)IO_EtherCAT.INPUT_DI_CHECK_ROLL_LABEL_04.NodeID;
                    Feeder_NodeID[4] = (int)IO_EtherCAT.INPUT_DI_CHECK_ROLL_LABEL_05.NodeID;
                    Feeder_NodeID[5] = (int)IO_EtherCAT.INPUT_DI_CHECK_ROLL_LABEL_06.NodeID;
                    Feeder_NodeID[6] = (int)IO_EtherCAT.INPUT_DI_CHECK_ROLL_LABEL_07.NodeID;
                    Feeder_NodeID[7] = (int)IO_EtherCAT.INPUT_DI_CHECK_ROLL_LABEL_08.NodeID;

                    Feeder_BitNum[0] = (int)IO_EtherCAT.INPUT_DI_CHECK_ROLL_LABEL_01.BitID;
                    Feeder_BitNum[1] = (int)IO_EtherCAT.INPUT_DI_CHECK_ROLL_LABEL_02.BitID;
                    Feeder_BitNum[2] = (int)IO_EtherCAT.INPUT_DI_CHECK_ROLL_LABEL_03.BitID;
                    Feeder_BitNum[3] = (int)IO_EtherCAT.INPUT_DI_CHECK_ROLL_LABEL_04.BitID;
                    Feeder_BitNum[4] = (int)IO_EtherCAT.INPUT_DI_CHECK_ROLL_LABEL_05.BitID;
                    Feeder_BitNum[5] = (int)IO_EtherCAT.INPUT_DI_CHECK_ROLL_LABEL_06.BitID;
                    Feeder_BitNum[6] = (int)IO_EtherCAT.INPUT_DI_CHECK_ROLL_LABEL_07.BitID;
                    Feeder_BitNum[7] = (int)IO_EtherCAT.INPUT_DI_CHECK_ROLL_LABEL_08.BitID;

                    if (cbFeederNum.SelectedIndex > -1)
                    {
                        g_NodeID = (ushort)Feeder_NodeID[cbFeederNum.SelectedIndex];
                        g_BitNum = (ushort)Feeder_BitNum[cbFeederNum.SelectedIndex];

                        ushort uRet = EtherCAT.getDI(g_NodeID, g_BitNum, out g_BitValue);
                        if (uRet == CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                        {
                            if (g_BitValue == true)
                            {
                                lbSensorRoll.BackColor = Color.LightPink;
                            }
                            else
                            {
                                lbSensorRoll.BackColor = Color.LightGreen;
                            }
                        }


                    }

                }
            }


        }

        private void cbVisionLightCam01_CheckedChanged(object sender, EventArgs e)
        {
            ushort uValue = 0;
            if (cbVisionLightCam01.Checked == true)
            {
                uValue = 1;
            }
            else
            {
                uValue = 0;
            }
            ushort uRet = EtherCAT.setDO(g_uESCCardNo, (ushort)IO_EtherCAT.OUTPUT_DO_LIGHTING_L1.NodeID, (ushort)IO_EtherCAT.OUTPUT_DO_LIGHTING_L1.BitID, uValue);
            if (uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                AddErrMsg("CS_ECAT_Slave_DIO_Set_Single_Output_Value, ErrorCode = " + uRet.ToString(), true);
            }
        }

        private void cbVisionLightCam02_CheckedChanged(object sender, EventArgs e)
        {
            ushort uValue = 0;
            if (cbVisionLightCam02.Checked == true)
            {
                uValue = 1;
            }
            else
            {
                uValue = 0;
            }
            ushort uRet = EtherCAT.setDO(g_uESCCardNo, (ushort)IO_EtherCAT.OUTPUT_DO_LIGHTING_L2.NodeID, (ushort)IO_EtherCAT.OUTPUT_DO_LIGHTING_L2.BitID, uValue);
            if (uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                AddErrMsg("CS_ECAT_Slave_DIO_Set_Single_Output_Value, ErrorCode = " + uRet.ToString(), true);
            }
        }
        private void cbVisionLightCam03_CheckedChanged(object sender, EventArgs e)
        {
            ushort uValue = 0;
            if (cbVisionLightCam03.Checked == true)
            {
                uValue = 1;
            }
            else
            {
                uValue = 0;
            }
            ushort uRet = EtherCAT.setDO(g_uESCCardNo, (ushort)IO_EtherCAT.OUTPUT_DO_LIGHTING_L3.NodeID, (ushort)IO_EtherCAT.OUTPUT_DO_LIGHTING_L3.BitID, uValue);
            if (uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                AddErrMsg("CS_ECAT_Slave_DIO_Set_Single_Output_Value, ErrorCode = " + uRet.ToString(), true);
            }
        }
        private void cbVisionLightCam04_CheckedChanged(object sender, EventArgs e)
        {
            ushort uValue = 0;
            if (cbVisionLightCam04.Checked == true)
            {
                uValue = 1;
            }
            else
            {
                uValue = 0;
            }
            ushort uRet = EtherCAT.setDO(g_uESCCardNo, (ushort)IO_EtherCAT.OUTPUT_DO_LIGHTING_L4.NodeID, (ushort)IO_EtherCAT.OUTPUT_DO_LIGHTING_L4.BitID, uValue);
            if (uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                AddErrMsg("CS_ECAT_Slave_DIO_Set_Single_Output_Value, ErrorCode = " + uRet.ToString(), true);
            }
        }

        private void cbVisionLightCam05_CheckedChanged(object sender, EventArgs e)
        {
            ushort uValue = 0;
            if (cbVisionLightCam05.Checked == true)
            {
                uValue = 1;
            }
            else
            {
                uValue = 0;
            }
            ushort uRet = EtherCAT.setDO(g_uESCCardNo, (ushort)IO_EtherCAT.OUTPUT_DO_LIGHTING_L5.NodeID, (ushort)IO_EtherCAT.OUTPUT_DO_LIGHTING_L5.BitID, uValue);
            if (uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                AddErrMsg("CS_ECAT_Slave_DIO_Set_Single_Output_Value, ErrorCode = " + uRet.ToString(), true);
            }
        }
        private void cbVisionLightCam06_CheckedChanged(object sender, EventArgs e)
        {
            ushort uValue = 0;
            if (cbVisionLightCam06.Checked == true)
            {
                uValue = 1;
            }
            else
            {
                uValue = 0;
            }
            ushort uRet = EtherCAT.setDO(g_uESCCardNo, (ushort)IO_EtherCAT.OUTPUT_DO_LIGHTING_L6.NodeID, (ushort)IO_EtherCAT.OUTPUT_DO_LIGHTING_L6.BitID, uValue);
            if (uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                AddErrMsg("CS_ECAT_Slave_DIO_Set_Single_Output_Value, ErrorCode = " + uRet.ToString(), true);
            }
        }

        private void VacuumControl(int Index)
        {
            ushort uValue = 0;

            CheckBox[] cbVaccum = { cbVacummControl01, cbVacummControl02, cbVacummControl03, cbVacummControl04, cbVacummControl05, cbVacummControl06, cbVacummControl07, cbVacummControl08, cbVacummControl09 };

            if (cbVaccum[Index].Checked == true)
            {
                uValue = 1;
            }
            else
            {
                uValue = 0;
            }
            ushort uRet = EtherCAT.setDO(g_uESCCardNo, (ushort)IO_EtherCAT.OUTPUT_DO_VACUUM_NODE[Index], (ushort)IO_EtherCAT.OUTPUT_DO_VACUUM_BIT[Index], uValue);
            if (uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                AddErrMsg("CS_ECAT_Slave_DIO_Set_Single_Output_Value, ErrorCode = " + uRet.ToString(), true);
            }
        }
        private void cbVacummControl01_CheckedChanged(object sender, EventArgs e)
        {
            VacuumControl(0);
        }

        private void cbVacummControl02_CheckedChanged(object sender, EventArgs e)
        {
            VacuumControl(1);
        }

        private void btnGetHeadPos_Click(object sender, EventArgs e)
        {
            int nPos = 0;

            ushort uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Get_Position(0, (ushort)NodeID.SERVO_V, 0, ref nPos);
            if (uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                return;
            }
            else
            {
                txtHeadV.Text = ((double)nPos / 100).ToString("0.00");
            }
        }

        private void btnHeadSave_Click(object sender, EventArgs e)
        {
            int nPos = 0;
            string[] HeadIndex = new[] { "H01", "H02", "H03", "H04", "H05", "H06", "H07", "H08", "H09" };
            string Savetxt = txtHeadV.Text;


            ini.IniWriteValue("Head_pos", HeadIndex[cbHeadNum.SelectedIndex], Savetxt);



        }

        private void btnGetPosCalib_Click(object sender, EventArgs e)
        {


            TextBox[] txtAxis = new[] { txtCalibX, txtCalibY, txtCalibZ, txtCalibR, txtCalibV };
            for (ushort i = (ushort)NodeID.SERVO_X; i <= (ushort)NodeID.SERVO_V; i++)
            {
                int nPos = 0;
                ushort uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Get_Position(0, i, 0, ref nPos);

                if (uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                {
                    return;
                }
                else
                {
                    txtAxis[i - (ushort)NodeID.SERVO_X].Text = ((double)nPos / 100).ToString("0.00");
                    txtAxis[i-36].BackColor = Color.Gray;
                }
            }



        }

        private void btnSavePosCalib_Click(object sender, EventArgs e)
        {

            string[] CamIndex = new[] { " Position_Calibration_Cam01", "Position_Calibration_Cam02", "Position_Calibration_Cam03", "Position_Calibration_Cam04" };
            string[] AxisIndex = new[] { "x", "Y", "Z", "R", "v" };
            TextBox[] txtAxis = new[] { txtCalibX, txtCalibY, txtCalibZ, txtCalibR, txtCalibV };

            for (ushort i = (ushort)NodeID.SERVO_X; i <= (ushort)NodeID.SERVO_V; i++)
            {
                int nPos = 0;
                ushort uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Get_Position(0, i, 0, ref nPos);

                if (uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                {
                    return;
                }
                else
                {
                    ini.IniWriteValue(CamIndex[cbCamNum.SelectedIndex], AxisIndex[i - (ushort)NodeID.SERVO_X], ((double)nPos / 100).ToString("0.00"));
                    txtAxis[i-36].BackColor = Color.White;
                }
            }


        }

        private void btnMovePosCalib_Click(object sender, EventArgs e)
        {
            string[] CamIndex = new[] { " Position_Calibration_Cam01", "Position_Calibration_Cam02", "Position_Calibration_Cam03", "Position_Calibration_Cam04" };
            string[] AxisIndex = new[] { "x", "Y", "Z", "R", "v" };
            int count = 0;
            int nPos;

            ushort zMode = (ushort)(Convert.ToDouble(ini.IniReadValue("SERVO_HOME_Mode", "Z")));
            ushort zStrVel = (ushort)(Convert.ToDouble(ini.IniReadValue("SERVO_HOME_StrVel", "Z")));
            ushort zMaxVel = (ushort)(Convert.ToDouble(ini.IniReadValue("SERVO_HOME_MaxVel", "Z")));
            do
            {
                g_uRet = EtherCAT.HomeServo(g_uESCCardNo, (ushort)NodeID.SERVO_Z, zMode, zStrVel, zMaxVel, ref mDone);

            }
            while ((mDone) != 0);

            btnMoveCalib = 1;

            nPos = Convert.ToInt32(Convert.ToDouble(ini.IniReadValue(CamIndex[cbCamNum.SelectedIndex], "Y")) * 100);
            absMoveHead_flag = 1;
            g_uRet = JogAxis((ushort)NodeID.SERVO_Y, nDir_P, nPos);

            absMoveHead_flag = 1;
            nPos = Convert.ToInt32(Convert.ToDouble(ini.IniReadValue(CamIndex[cbCamNum.SelectedIndex], "X")) * 100);
            g_uRet = JogAxis((ushort)NodeID.SERVO_X, nDir_P, nPos);
            Thread.Sleep(100);

            do
            {
                g_uRet = EtherCAT.ToTarget(0, (ushort)NodeID.SERVO_Y, ref mDone);

            }while ((mDone) != 0);


            //if (mDone == 0)
            //{
            //absMoveHead_flag = 1;
            //nPos = Convert.ToInt32(Convert.ToDouble(ini.IniReadValue(CamIndex[cbCamNum.SelectedIndex], "X")) * 100);
            //g_uRet = JogAxis((ushort)NodeID.SERVO_X, nDir_P, nPos);
            //}


            absMoveHead_flag = 1;
            nPos = Convert.ToInt32(Convert.ToDouble(ini.IniReadValue(CamIndex[cbCamNum.SelectedIndex], "Z")) * 100);
            g_uRet = JogAxis((ushort)NodeID.SERVO_Z, nDir_P, nPos);

            // btnMoveCalib = 0;
        }

        private void btnGetWidthCon_Click(object sender, EventArgs e)
        {
            TextBox[] txtConIndex = new TextBox[] {txtServo_C1_Target, txtServo_C2_Target, txtServo_C3_Target,txtServo_C4_Target };

            txtWidth.Text = txtConIndex[cbConIndex.SelectedIndex].Text;

        }

        private void btnSaveWidthCon_Click(object sender, EventArgs e)
        {
            string[] ConveyorIndex= new[] {"C1", "C2", "C3", "C4"};
            
            if(rdbCalib.Checked == true)
            {
                ini.IniWriteValue("CONVERYOR_Width_Calibration", ConveyorIndex[cbConIndex.SelectedIndex],txtWidth.Text);
            }
            else
            {
                 ini.IniWriteValue("CONVERYOR_Width_Board", ConveyorIndex[cbConIndex.SelectedIndex], txtWidth.Text);
            }
           
        }

        private void btnMoveWidthCon_Click(object sender, EventArgs e)
        {
            string[] ConveyorIndex = new[] { "C1", "C2", "C3", "C4" };
            ushort[] NodeCon = new[] { (ushort)NodeID.SERVO_C1, (ushort)NodeID.SERVO_C2, (ushort)NodeID.SERVO_C3, (ushort)NodeID.SERVO_C4 };
            int nPos;
            if (rdbCalib.Checked == true)
            {
                 nPos = Math.Abs(Convert.ToInt32(Convert.ToDouble(ini.IniReadValue("CONVERYOR_Width_Calibration", ConveyorIndex[cbConIndex.SelectedIndex])) * 100));
            }
            else
            {
                 nPos = Math.Abs(Convert.ToInt32(Convert.ToDouble(ini.IniReadValue("CONVERYOR_Width_Board", ConveyorIndex[cbConIndex.SelectedIndex])) * 100));
            }
                g_uRet = EtherCAT.AxisMoveJog(0,NodeCon[cbConIndex.SelectedIndex], 0, 2500, 100, 100, 0 - nPos, 1);
        }

        private void btnVisionLauch_Click(object sender, EventArgs e)
        {
            try
            {
                // passing an emtpy string for the version will launch the latest Vision Builder AI engine available on the system.
                //...........................................
                //...........................................
                engine = new VBAIEngine("VisionAPI", "", false);
                btnVisionLauch.Enabled = false;
                btnVisionOpen.Enabled = true;
                btnVisionStop.Enabled = true;

             
            }
            catch (VBAIException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVisionOpen_Click(object sender, EventArgs e)
        {
            string VisionPath = "";
           
                switch (cbCamNum.Text)
                {
                    case "CAMERA No.1":
                        {
                        VisionPath = Path + "VisionFile\\ErrorOffsetHeadAdjustCAM01.vbai";
                    }
                        break;
                    case "CAMERA No.2":
                        {
                        VisionPath = Path + "VisionFile\\ErrorOffsetHeadAdjustCAM02.vbai";
                    }
                        break;
                    case "CAMERA No.3":
                        {
                        VisionPath = Path + "VisionFile\\ErrorRotatetionHeadAdjustCAM03.vbai";
                    }
                        break;
                    case "CAMERA No.4":
                        {
                        VisionPath = Path + "VisionFile\\ErrorRotatetionHeadAdjustCAM04.vbai";
                    }
                        break;
             

                }
            try
            {
                engine.OpenInspection(VisionPath);
                InspectionInfo info = engine.GetInspectionInfo();
                btnVisionOpen.Enabled = false;
                string[] _spl = { "\\" };
                string[] _str = VisionPath.Split(_spl,StringSplitOptions.None);
                lbVisionConfigFileName.Text = "File Name : "+ _str[_str.Length-1];
                cbCamNum.Enabled = false;
                gbHeadOffsetConfig.Enabled = true;
            }
            catch (VBAIException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVisionStop_Click(object sender, EventArgs e)
        {
            try
            {
                if (engine != null)
                    engine.CloseConnection(true);
                btnVisionLauch.Enabled = true;
                btnVisionOpen.Enabled = false;
                btnVisionStop.Enabled = false;
                cbCamNum.Enabled = true;
                gbHeadOffsetConfig.Enabled = false;
            }
            catch (VBAIException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCaptureHeadError_Click(object sender, EventArgs e)
        {
            double[] data = Capture_One(28,3,4);
            txtHeadOffsetX.Text = (data[0]/1000).ToString();
            txtHeadOffsetY.Text = (data[1]/1000).ToString();


        }

        private void btnAdd_GeoDate_Click(object sender, EventArgs e)
        {
            double[] data = Capture_One(28,3,4);
            txtHeadOffsetX.Text = (data[0] / 1000).ToString();
            txtHeadOffsetY.Text = (data[1] / 1000).ToString();
            if (inspectionStatus != false)
            {
                int itemNo = lvHeadOffset_Geo.Items.Count;
                string[] Data = new string[4];
                Data[0] = (itemNo + 1).ToString();
                Data[1] = txtHeadOffsetX.Text;
                Data[2] = txtHeadOffsetY.Text;
                Data[3] = "0";
                ListViewItem itm;
                itm = new ListViewItem(Data);
                lvHeadOffset_Geo.Items.Add(itm);
            }
        }

        private void btnLastSqCal_Click(object sender, EventArgs e)
        {
            int iPointCount = lvHeadOffset_Geo.Items.Count;

            double[,] Data = new double[iPointCount, 2];
            for (int i = 0; i <= lvHeadOffset_Geo.Items.Count - 1; i++)
            {
                Data[i, 0] = Convert.ToDouble(lvHeadOffset_Geo.Items[i].SubItems[1].Text);
                Data[i, 1] = Convert.ToDouble(lvHeadOffset_Geo.Items[i].SubItems[2].Text);
            }


            double[] Error = new double[Data.GetLength(0)];
            double scale = 1;
            for (int i = 0; i <= Data.GetLength(0) - 1; i++)
            {
                Data[i, 0] = Data[i, 0] * scale;
                Data[i, 1] = Data[i, 1] * scale;
            }

            double Mean_X, Mean_Y;
            double Sum_X = 0, Sum_Y = 0;
            int N = Data.GetLength(0);
            for (int i = 0; i <= N - 1; i++)
            {
                Sum_X = Sum_X + Data[i, 0];
                Sum_Y = Sum_Y + Data[i, 1];
            }
            Mean_X = Sum_X / N;
            Mean_Y = Sum_Y / N;

            double[,] Data_New = new double[Data.GetLength(0), Data.GetLength(1)];
            double Suu = 0, Suv = 0, Svv = 0, Suuu = 0, Svvv = 0, Suvv = 0, Svuu = 0;
            for (int i = 0; i <= Data.GetLength(0) - 1; i++)
            {

                Data_New[i, 0] = Data[i, 0] - Mean_X;
                Data_New[i, 1] = Data[i, 1] - Mean_Y;

                Suu = Suu + Math.Pow(Data_New[i, 0], 2);
                Suv = Suv + (Data_New[i, 0] * Data_New[i, 1]);
                Svv = Svv + Math.Pow(Data_New[i, 1], 2);
                Suuu = Suuu + Math.Pow(Data_New[i, 0], 3);
                Svvv = Svvv + Math.Pow(Data_New[i, 1], 3);

                Suvv = Suvv + (Data_New[i, 0] * Math.Pow(Data_New[i, 1], 2));
                Svuu = Svuu + (Data_New[i, 1] * Math.Pow(Data_New[i, 0], 2));

            }
            double DetSum = (Suu * Svv) - (Suv * Suv);
            double C1 = (Suuu + Suvv) / 2;
            double C2 = (Svvv + Svuu) / 2;
            double DetU = (C1 * Svv) - (C2 * Suv);
            double DetV = (Suu * C2) - (Suv * C1);

            double Uc = DetU / DetSum;
            double Vc = DetV / DetSum;
            double Xc = Uc + Mean_X;
            double Yc = Vc + Mean_Y;

            double Alpha = (Math.Pow(Uc, 2) + Math.Pow(Vc, 2)) + ((Suu + Svv) / N);
            double R = Math.Sqrt(Alpha);
            //   MessageBox.Show(Uc.ToString("0.###") + ","+ Vc.ToString("0.###"));

            MessageBox.Show(Xc.ToString("0.###") + " , " + Yc.ToString("0.###") + " , " + R.ToString("0.###"));
            txt_Geo_Xc.Text = Xc.ToString("0.###");
            txt_Geo_Yc.Text = Yc.ToString("0.###");
            txt_Geo_rc.Text = R.ToString("0.###");

            for (int i = 0; i <= Data.GetLength(0) - 1; i++)
            {

                Error[i] = ErrorCheck(R, Xc, Yc, Data[i, 0], Data[i, 1]);
                lvHeadOffset_Geo.Items[i].SubItems[3].Text = Error[i].ToString("0.#####");


            }
        }

        private void btnMoveHead_Click(object sender, EventArgs e)
        {
            int nPos = 0;

            string[] HeadIndex = new[] { "H01", "H02", "H03", "H04", "H05", "H06", "H07", "H08", "H09" };

            nPos = Convert.ToInt32(Convert.ToDouble(ini.IniReadValue("Head_pos", HeadIndex[cbHeadNum.SelectedIndex])) * 100);
            absMoveHead_flag = 1;
            g_uRet = JogAxis((ushort)NodeID.SERVO_V, nDir_P, nPos);


        }

        private void btnDel_GeoData_Click(object sender, EventArgs e)
        {
            if (lvHeadOffset_Geo.SelectedItems.Count > 0)
            {
                for (int i = lvHeadOffset_Geo.Items.IndexOf(lvHeadOffset_Geo.SelectedItems[0]); i <= lvHeadOffset_Geo.Items.Count - 1; i++)
                {
                    lvHeadOffset_Geo.Items[i].SubItems[0].Text = (i).ToString();
                }

                lvHeadOffset_Geo.SelectedItems[0].Remove();
            }

        }

        private void btnSaveErr_Click(object sender, EventArgs e)
        {
          //  int nPos = 0;
            string[] HeadIndex_Cam = new[] { "_GEO_Error_Head01", "_GEO_Error_Head02", "_GEO_Error_Head03", "_GEO_Error_Head04"
                                              ,"_GEO_Error_Head05", "_GEO_Error_Head06", "_GEO_Error_Head07","_GEO_Error_Head08",
                                              "_GEO_Error_Head09"};
            string[] CamIndex = new[] { "Cam01", "Cam02", "Cam03", "Cam04" };

            ini.IniWriteValue(CamIndex[cbCamNum.SelectedIndex] +HeadIndex_Cam[cbHeadNum.SelectedIndex], "Xci", txt_Geo_Xc.Text);
            ini.IniWriteValue(CamIndex[cbCamNum.SelectedIndex] +HeadIndex_Cam[cbHeadNum.SelectedIndex], "Yci",txt_Geo_Yc.Text);
            ini.IniWriteValue(CamIndex[cbCamNum.SelectedIndex] +HeadIndex_Cam[cbHeadNum.SelectedIndex], "r", txt_Geo_rc.Text);

            
        }

        private void btnClearErrMsg_Click(object sender, EventArgs e)
        {
            LstErrMsg.Items.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lvHeadOffset_Geo.Items.Clear();
        }

        private void cbCamNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox[] _txtAxis = new[] { txtCalibX, txtCalibY, txtCalibZ, txtCalibR, txtCalibV };
            string[] _Axis = new[] { "X", "Y", "Z", "R","V" };
          
            try
            {
               // int i = 0;
                for (int i = 0; i <= 4; i = i+1) 
                {
                    _txtAxis[i].Text = ini.IniReadValue("Position_Calibration_Cam0" + (cbCamNum.SelectedIndex + 1), _Axis[i]);

                   
                }
                cbHeadNum.SelectedIndex = cbHeadNum.SelectedIndex;
                //       _txtAxis[4].Text = ini.IniReadValue("Position_Calibration_Cam01", "V");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
          /*  switch (cbCamNum.Text)
            {
                case : "CAM"
            }*/
        }

        private void cbHeadNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            string[] HeadIndex = new[] { "H01", "H02", "H03", "H04", "H05", "H06", "H07", "H08", "H09" };

            string Section = "";
            string Section_theta = "";
            if(cbCamNum.SelectedIndex == 3)
            {
                Section = "Cam04_GEO_Error_Head0";
                Section_theta = "Position_Calibration_Cam04";

            }
            else if (cbCamNum.SelectedIndex == 2)     
            {
                Section = "Cam03_GEO_Error_Head0";
                Section_theta = "Position_Calibration_Cam03";
            }

            try
            {
                txt_OrgCam_x.Text = ini.IniReadValue(Section + (cbHeadNum.SelectedIndex + 1).ToString(), "Xorg");
                txt_OrgCam_y.Text = ini.IniReadValue(Section + (cbHeadNum.SelectedIndex + 1).ToString(), "Yorg");
                txt_Geo_Xc.Text = ini.IniReadValue(Section + (cbHeadNum.SelectedIndex + 1).ToString(), "Xci");
                txt_Geo_Yc.Text = ini.IniReadValue(Section + (cbHeadNum.SelectedIndex + 1).ToString(), "Yci");
                txt_Geo_rc.Text = ini.IniReadValue(Section + (cbHeadNum.SelectedIndex + 1).ToString(), "r");
                txtHeadV.Text = ini.IniReadValue("Head_pos", HeadIndex[cbHeadNum.SelectedIndex]);

                txtCam_CoTheta_org.Text = ini.IniReadValue(Section_theta, "Theta");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSaveCAMorg_Click(object sender, EventArgs e)
        {
            string Section = "";
            if (cbCamNum.SelectedIndex == 3)
            {
                Section = "Cam04_GEO_Error_Head0";

            }
            else if (cbCamNum.SelectedIndex == 2)
            {
                Section = "Cam03_GEO_Error_Head0";
            }
            try
            {
                txt_OrgCam_x.Text = txtHeadOffsetX.Text;
                txt_OrgCam_y.Text = txtHeadOffsetY.Text;
                ini.IniWriteValue(Section + (cbHeadNum.SelectedIndex + 1).ToString(), "Xorg", txtHeadOffsetX.Text);
                ini.IniWriteValue(Section + (cbHeadNum.SelectedIndex + 1).ToString(), "Yorg", txtHeadOffsetY.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_CoTheta_P1_Click(object sender, EventArgs e)
        {
            double[] data = Capture_One(28, 3, 4);
            txtHeadOffsetX.Text = (data[0] / 1000).ToString();
            txtHeadOffsetY.Text = (data[1] / 1000).ToString();
            if (inspectionStatus != false)
            {
                txtCam_CoTheta_P1x.Text = (data[0] / 1000).ToString();
                txtCam_CoTheta_P1y.Text = (data[1] / 1000).ToString();
            }
        }

        private void btnAdd_CoTheta_P2_Click(object sender, EventArgs e)
        {
            double[] data = Capture_One(28, 3, 4);
            txtHeadOffsetX.Text = (data[0] / 1000).ToString();
            txtHeadOffsetY.Text = (data[1] / 1000).ToString();
            if (inspectionStatus != false)
            {
                txtCam_CoTheta_P2x.Text = (data[0] / 1000).ToString();
                txtCam_CoTheta_P2y.Text = (data[1] / 1000).ToString();
            }
        }

        private void btnCal_CoTheta_org_Click(object sender, EventArgs e)
        {
            double P1x, P2x, P1y, P2y, Theta;
            if(double.TryParse(txtCam_CoTheta_P1x.Text,out P1x ) != true)
            { return; }
            if (double.TryParse(txtCam_CoTheta_P1y.Text, out P1y) != true)
            { return; }
            if (double.TryParse(txtCam_CoTheta_P2x.Text, out P2x) != true)
            { return; }
            if (double.TryParse(txtCam_CoTheta_P2y.Text, out P2y) != true)
            { return; }
            try
            {
                double delta_X = P2x - P1x, delta_y = P2y - P1y;
                Theta = Math.Atan((delta_X / delta_y));
                if (cbCamNum.SelectedIndex >= 2)
                {
                    txtCam_CoTheta_org.Text = Theta.ToString("0.###");
                }
                else
                {
                    txtCamOffsetTheta.Text = Theta.ToString("0.###");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                
        }

        private void btnSave_CoTheta_org_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbCamNum.SelectedIndex >= 2)
                {
                    string Section = "Position_Calibration_Cam0" + (cbCamNum.SelectedIndex + 1).ToString();
                    ini.IniWriteValue(Section, "Theta", txtCam_CoTheta_org.Text);
                }
                else
                {
                    string Section = "Position_Origin_Cam0" + (cbCamNum.SelectedIndex + 1).ToString();
                    ini.IniWriteValue(Section, "Theta", txtCamOffsetTheta.Text);
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMoveCamORG_Click(object sender, EventArgs e)
        {
            if(cbCamNum.SelectedIndex > 2)
            {
                return;
            }
            string[] CamIndex = new[] { "Position_Origin_Cam01", "Position_Origin_Cam02" };
            string[] AxisIndex = new[] { "X", "Y", "Z", "R", "v" };
        
            int nPos;

            ushort zMode = (ushort)(Convert.ToDouble(ini.IniReadValue("SERVO_HOME_Mode", "Z")));
            ushort zStrVel = (ushort)(Convert.ToDouble(ini.IniReadValue("SERVO_HOME_StrVel", "Z")));
            ushort zMaxVel = (ushort)(Convert.ToDouble(ini.IniReadValue("SERVO_HOME_MaxVel", "Z")));
            do
            {
                g_uRet = EtherCAT.HomeServo(g_uESCCardNo, (ushort)NodeID.SERVO_Z, zMode, zStrVel, zMaxVel, ref mDone);

            }
            while ((mDone) != 0);

            btnMoveCalib = 1;

            nPos = Convert.ToInt32(Convert.ToDouble(ini.IniReadValue(CamIndex[cbCamNum.SelectedIndex], "Y")) * 100);
            absMoveHead_flag = 1;
            g_uRet = JogAxis((ushort)NodeID.SERVO_Y, nDir_P, nPos);

            absMoveHead_flag = 1;
            nPos = Convert.ToInt32(Convert.ToDouble(ini.IniReadValue(CamIndex[cbCamNum.SelectedIndex], "X")) * 100);
            g_uRet = JogAxis((ushort)NodeID.SERVO_X, nDir_P, nPos);
            Thread.Sleep(100);

            do
            {
                g_uRet = EtherCAT.ToTarget(0, (ushort)NodeID.SERVO_Y, ref mDone);

            } while ((mDone) != 0);

            absMoveHead_flag = 1;
            nPos = Convert.ToInt32(Convert.ToDouble(ini.IniReadValue(CamIndex[cbCamNum.SelectedIndex], "Z")) * 100);
            g_uRet = JogAxis((ushort)NodeID.SERVO_Z, nDir_P, nPos);
        }

        private void btnGetCamOrg_Click(object sender, EventArgs e)
        {
            TextBox[] txtAxis = new[] {txtCam_org_X, txtCam_org_Y, txtCam_org_Z, txtCam_org_R, txtCam_org_V };

            for (ushort i = (ushort)NodeID.SERVO_X; i <= (ushort)NodeID.SERVO_V; i++)
            {
                int nPos = 0;
                ushort uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Get_Position(0, i, 0, ref nPos);

                if (uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                {
                    return;
                }
                else
                {
                    txtAxis[i - (ushort)NodeID.SERVO_X].Text = ((double)nPos / 100).ToString("0.00");
                    txtAxis[i - 36].BackColor = Color.Gray;
                }
            }
        }

        private void btnSaveOffsetCamOrg_Click(object sender, EventArgs e)
        {
            if (cbCamNum.SelectedIndex > 2)
            {
                return;
            }
            string[] CamIndex = new[] { "Position_Origin_Cam01", "Position_Origin_Cam02" };
            string[] AxisIndex = new[] { "X", "Y", "Z", "R", "V" };

            TextBox[] txtAxis = new[] { txtCam_org_X, txtCam_org_Y, txtCam_org_Z, txtCam_org_R, txtCam_org_V };

            for (ushort i = (ushort)NodeID.SERVO_X; i <= (ushort)NodeID.SERVO_V; i++)
            {
                int nPos = 0;
                ushort uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Get_Position(0, i, 0, ref nPos);

                if (uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                {
                    return;
                }
                else
                {
                    ini.IniWriteValue(CamIndex[cbCamNum.SelectedIndex], AxisIndex[i - (ushort)NodeID.SERVO_X], ((double)nPos / 100).ToString("0.00"));
                    txtAxis[i - 36].BackColor = Color.DimGray;
                }
            }
            ini.IniWriteValue(CamIndex[cbCamNum.SelectedIndex], "Delta_Cam_x", txtCamOffsetX.Text);
            ini.IniWriteValue(CamIndex[cbCamNum.SelectedIndex], "Delta_Cam_y", txtCamOffsetY.Text);
        }

        private void btnCaptureCamError_Click(object sender, EventArgs e)
        {
            double[] data = Capture_One(28, 4, 3);
            txtCamOffsetX.Text = (data[0] / 1000).ToString();
            txtCamOffsetY.Text = (data[1] / 1000).ToString();
        }

        private void btnLoadDataCamOffset_Click(object sender, EventArgs e)
        {
            if (cbCamNum.SelectedIndex > 2)
            {
                return;
            }
            string[] CamIndex = new[] { "Position_Origin_Cam01", "Position_Origin_Cam02" };
            string[] AxisIndex = new[] { "X", "Y", "Z", "R", "V" };
            TextBox[] txtAxis = new[] { txtCam_org_X, txtCam_org_Y, txtCam_org_Z, txtCam_org_R, txtCam_org_V };
            for (int i = 0; i < 5; i++)
            {
                txtAxis[i].Text = ini.IniReadValue(CamIndex[cbCamNum.SelectedIndex], AxisIndex[i]);
            }
            txtCamOffsetX.Text = ini.IniReadValue(CamIndex[cbCamNum.SelectedIndex], "Delta_Cam_x");
            txtCamOffsetY.Text = ini.IniReadValue(CamIndex[cbCamNum.SelectedIndex], "Delta_Cam_y");

        }

    

        private void btnSavePosPic_Click(object sender, EventArgs e)
        {
            string[] FeederFile_Index = new[] {"FeederConfig_01.ini", "FeederConfig_02.ini", "FeederConfig_03.ini", "FeederConfig_04.ini", "FeederConfig_05.ini"
                                                  ,"FeederConfig_06.ini","FeederConfig_07.ini","FeederConfig_08.ini"};

            iniFiles iniFeeder = new iniFiles(System.IO.Path.GetFullPath(@".\\")+FeederFile_Index[cbFeederNum.SelectedIndex]);

            string[] FeederSection = new[] { "FeederNO.1", "FeederNO.2", "FeederNO.3", "FeederNO.4", "FeederNO.5", "FeederNO.6",
                                             "FeederNO.7","FeederNO.8"};

            string[] PickIndex_X = new[] {"px1", "px2", "px3", "px4"};
            string[] PickIndex_Y = new[] { "py1", "py2", "py3", "py4"};

          

            iniFeeder.IniWriteValue(FeederSection[cbFeederNum.SelectedIndex], PickIndex_X[cbPickNum.SelectedIndex],txtAxisPicX.Text);
            iniFeeder.IniWriteValue(FeederSection[cbFeederNum.SelectedIndex], PickIndex_Y[cbPickNum.SelectedIndex],txtAxisPicY.Text);


        }

        private void btnGetPosPick_Click(object sender, EventArgs e)
        {
            

            TextBox[] txtAxis = new[] {txtAxisPicX,txtAxisPicY};

            for (ushort i = (ushort)NodeID.SERVO_X; i <= (ushort)NodeID.SERVO_Y; i++)
            {
                int nPos = 0;
                ushort uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Get_Position(0, i, 0, ref nPos);

                if (uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                {
                    return;
                }
                else
                {
                    txtAxis[i - (ushort)NodeID.SERVO_X].Text = ((double)nPos / 100).ToString("0.00");
                  
                }
            }
        }

        private void btnAutoFeeder_Click(object sender, EventArgs e)
        {
            AutoFeedClicked = 1;
            TimAutoFeed.Enabled = true;

            btnAutoFeeder.Enabled = false;
            btnFeedStop.Enabled = true;
            btnFeederJOG.Enabled = false;
        }

        private void TimAutoFeed_Tick(object sender, EventArgs e)
        {

            if (AutoFeedClicked == 1)
            {

                int iTempIndex = 0;
                bool bretSen = false;
                byte[] bFeedSensor;
                int iIndex = cbFeederNum.SelectedIndex;
                string iTragetVel_CON = ini.IniReadValue("FEEDER_CONTROL", "Spd_CON");
                string iTragetVel_ROLL = ini.IniReadValue("FEEDER_CONTROL", "Spd_ROLL");

                ushort uret = EtherCAT.setDO(g_uESCCardNo, IO_EtherCAT.OUTPUT_DO_DISABLE_CON_NODE[iIndex], IO_EtherCAT.OUTPUT_DO_DISABLE_CON_BIT[iIndex], 0);
                if (uret != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                {
                    AddErrMsg("CS_ECAT_Slave_DIO_Set_Single_Output_Value, ErrorCode = " + uret.ToString(), true);
                }
                uret = EtherCAT.setDO(g_uESCCardNo, IO_EtherCAT.OUTPUT_DO_DISABLE_ROLL_NODE[iIndex], IO_EtherCAT.OUTPUT_DO_DISABLE_ROLL_BIT[iIndex], 0);
                if (uret != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                {
                    AddErrMsg("CS_ECAT_Slave_DIO_Set_Single_Output_Value, ErrorCode = " + uret.ToString(), true);
                }


                if (cbFeederNum.SelectedIndex <= 3)
                {
                    iTempIndex = cbFeederNum.SelectedIndex;
                }
                else
                {

                    iTempIndex = cbFeederNum.SelectedIndex - 4;
                }

                bFeedSensor = ReadLabelSensor();
                int k = (iTempIndex) * 4;
                for (int i = 0; i <= 3; i++)
                {
                    if (Keyence_NUEP1.GetBitX(bFeedSensor, k + i) == true)
                    {
                        bretSen = true; // found Label
                    }
                }

                if (bretSen == false) //not found
                {


                    uret = EtherCAT.setPO(g_uESCCardNo, IO_EtherCAT.OUTPUT_PO_FEEDDER_CON_NODE[iIndex], (ushort)(Convert.ToDouble(iTragetVel_CON)));
                    if (uret != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                    {
                        AddErrMsg("CS_ECAT_Slave_PV_Start_Move, ErrorCode = " + uret.ToString(), true);
                    }
                    else
                    {
                        uret = EtherCAT.setPO(g_uESCCardNo, IO_EtherCAT.OUTPUT_PO_FEEDDER_ROLL_NODE[iIndex], (ushort)(Convert.ToDouble(iTragetVel_ROLL)));
                        if (uret != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                        {
                            AddErrMsg("CS_ECAT_Slave_PV_Start_Move, ErrorCode = " + uret.ToString(), true);
                        }

                    }



                }
                else
                {
                    FeedStop(cbFeederNum.SelectedIndex);


                }


            }
        }

        private void cbVacummControl03_CheckedChanged(object sender, EventArgs e)
        {
            VacuumControl(2);
        }

        private void cbVacummControl04_CheckedChanged(object sender, EventArgs e)
        {
            VacuumControl(3);
        }

        private void cbVacummControl05_CheckedChanged(object sender, EventArgs e)
        {
            VacuumControl(4);
        }

        private void cbVacummControl06_CheckedChanged(object sender, EventArgs e)
        {
            VacuumControl(5);
        }

        private void cbVacummControl07_CheckedChanged(object sender, EventArgs e)
        {
            VacuumControl(6);
        }

        private void cbVacummControl08_CheckedChanged(object sender, EventArgs e)
        {
            VacuumControl(7);
        }

        private void cbVacummControl09_CheckedChanged(object sender, EventArgs e)
        {
            VacuumControl(8);
        }







        /// <summary>
        ///  FunCtion_Zone
        /// </summary>


        // Vision
        private double[] Capture_One(int Index, int Item_1 = 1, int Item_2 = 1, int Item_3 = 1, int Item_4 = 4)
        {
            VBAIDateTime timeStamp;
            
            int nPos = 0;
            double[] resMesures = new double[4];
            try
            {
                engine.RunInspectionOnce(-1);
                VisionImage image = engine.GetInspectionImage("", 1, 1, out newImageAvailable);
                Variable[] asd = engine.GetVariables();

                imvInspetion.Attach(image);
                engine.GetInspectionResults(out timeStamp, out inspectionStatus);
                // PassFailIndicator.Checked = inspectionStatus;

                InspectionMeasurements[]  measures = engine.GetInspectionMeasurements(null, out timeStamp);

                InspectionStateInfo s = engine.GetInspectionStateDiagram();

                engine.EnableInspectionMeasurements();
                Variable[] var;
                var = engine.GetVariables();
               if (measures.Length > 24)
                {
                   double dItem_1 = measures[Index].measurements[Item_1].measurement.numData;
                   double dItem_2 = measures[Index].measurements[Item_2].measurement.numData;
                   double dItem_3 = measures[Index].measurements[Item_3].measurement.numData;
                   double dItem_4 = measures[Index].measurements[Item_4].measurement.numData;

                   resMesures[0] = Math.Round(dItem_1);
                   resMesures[1] = Math.Round(dItem_2);
                   resMesures[2] = Math.Round(dItem_3);
                   resMesures[3] = Math.Round(dItem_4);

                }
               
            }
            catch (VBAIException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return resMesures;
        }

        private double ErrorCheck(double Rc, double Xc, double Yc, double Xi, double Yi)
        {
            double Ri = Math.Sqrt((Math.Pow((Xc - Xi), 2) + Math.Pow((Yc - Yi), 2)));
            return Math.Abs(Rc - Ri);
        }

    }
}
