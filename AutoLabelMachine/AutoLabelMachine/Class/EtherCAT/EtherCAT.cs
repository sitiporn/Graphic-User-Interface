using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoLabelMachine
{
    public class EtherCAT
    {
        ushort g_uESCCardNo = 0;
        ushort g_uRet;
        ushort g_nESCExistCards;
        uint gRevisionNo;
        ushort mDone;
        ushort SlotNo = 0, StatusMdone;



        public ushort openCard ()
        {
            g_uRet = 0;
           
            g_uRet = CEtherCAT_DLL.CS_ECAT_Master_Open(ref g_nESCExistCards);

            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                 MessageBox.Show("CS_ECAT_Master_Open, rt =" + g_uRet.ToString());
              //  return ("CS_ECAT_Master_Open, rt =" + g_uRet.ToString());
                
            }
    
                if (g_nESCExistCards == 0)
                {
                    MessageBox.Show("No EtherCAT can be found!");
                //  return ("No EtherCAT can be found!");
                g_uRet = 9999;
                }
             
                    return g_uRet;
                
                
   

        }

        public string initialCard(ushort nCardNumber = 0)

        {
            ushort nSeq = 0, 

                g_uRet = 0;
           
            {
                g_uRet = CEtherCAT_DLL.CS_ECAT_Master_Get_CardSeq(nSeq, ref nCardNumber);
                g_uRet = CEtherCAT_DLL.CS_ECAT_Master_Initial(nCardNumber);
                if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                {
                   MessageBox.Show("_ECAT_Master_Initial, ErrorCode = " + g_uRet.ToString());
                }
           
            }
            return ("INITIAL");
         
        }
        public string findSlave ()

        {
            short nSID = 0, Cnt = 0;
            ushort uNID = 0, uSlaveNum = 0, uReMapNodeID = 0;
            uint uVendorID = 0, uProductCode = 0, uRevisionNo = 0, uSlaveDCTime = 0;

            g_uRet = CEtherCAT_DLL.CS_ECAT_Master_Get_SlaveNum(g_uESCCardNo, ref uSlaveNum);

            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                MessageBox.Show("_ECAT_Master_Get_SlaveNum, ErrorCode = " + g_uRet.ToString());
            }
            else
            {
                if (uSlaveNum == 0)
                {
                    MessageBox.Show("Card NO: " + g_uESCCardNo.ToString() + " No slave found!");
                }
                else
                {
                   
                    for (uNID = 0; uNID < uSlaveNum; uNID++)
                    {
                        g_uRet = CEtherCAT_DLL.CS_ECAT_Master_Get_Slave_Info(g_uESCCardNo, uNID, ref uReMapNodeID, ref uVendorID, ref uProductCode, ref uRevisionNo, ref uSlaveDCTime);

                        if (uVendorID == 0x1DD && uProductCode == 0x10305070) // A2E
                        {
                            nSID = 0;
                        
                            Cnt++;
                        }
                        else if (uVendorID == 0x539 && uProductCode == 0x2200001) //Yaskawa
                        {
                            nSID = 0;
                      
                            Cnt++;
                        }
                        else if ((uVendorID == 0x1A05 || uVendorID == 0x1DD) && uProductCode == 0x0624) //Ec4Axis
                        {
                            for (nSID = 0; nSID < 4; nSID++)
                            {
                          
                                Cnt++;
                            }
                        }
                        else if ((uVendorID == 0x1A05 || uVendorID == 0x1DD) && uProductCode == 0x5621) //EcAxis
                        {
                            nSID = 0;
                         
                            Cnt++;
                        }
                        else if ((uVendorID == 0x1A05 || uVendorID == 0x1DD) && uProductCode == 0x8124) //EcAD
                            for (uNID = 0; uNID < uSlaveNum; uNID++)
                            {
                            gRevisionNo = uRevisionNo;

                            Cnt++;
                        }


                    }

                }
            }
            return  uSlaveNum.ToString(); 
        }

        public ushort setDO(ushort g_uESCCardNo, ushort g_uESCNodeID, ushort BitNum, ushort value)
        {
            ushort _SlotNo = 0;

            g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_DIO_Set_Single_Output_Value(g_uESCCardNo, g_uESCNodeID, _SlotNo, BitNum, value);
            //MessageBox.Show (g_uRet.ToString());
            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                MessageBox.Show("CS_ECAT_Slave_DIO_Set_Single_Output_Value, ErrorCode = " + g_uRet.ToString());

            }
            return g_uRet;
        }

        
        public bool getDO(ushort g_uESCCardNo, ushort g_uESCNodeID, ushort bitNum)
        {
            ushort _SlotNo = 0, _value = 0;

            g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_DIO_Get_Single_Output_Value(g_uESCCardNo, g_uESCNodeID, _SlotNo, bitNum, ref _value);
           // MessageBox.Show(g_uRet.ToString());

            if ((_value & (0x1 << bitNum)) == (0x1 << bitNum))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public ushort getDI(ushort g_uESCNodeID, ushort bitNum, out bool _bitValue)
        {
            ushort _uValue = 0, _SlotNo = 0;
            g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_DIO_Get_Input_Value(0, g_uESCNodeID, _SlotNo, ref _uValue);


            if ((_uValue & (0x1 << bitNum)) == (0x1 << bitNum))
            {
                _bitValue = true;
            }
            else
            {
                _bitValue = false;
            }

            return g_uRet;
        }
        public bool getDI(ushort g_uESCCardNo, ushort g_uESCNodeID,ushort bitNum)
        {
            ushort _uValue = 0, _SlotNo = 0 ;
            g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_DIO_Get_Input_Value(g_uESCCardNo, g_uESCNodeID, _SlotNo, ref _uValue);
          

            if ((_uValue & (0x1 << bitNum)) == (0x1 << bitNum))
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
        public ushort getDI(ushort g_uESCCardNo, ushort g_uESCNodeID)
        {
            ushort _uValue = 0, _SlotNo =0;
            g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_DIO_Get_Input_Value(g_uESCCardNo, g_uESCNodeID, _SlotNo, ref _uValue);
           
            return _uValue;
        }

        public string setOnservo(ushort g_uESCCardNo, ushort g_uESCNodeID, ushort _uCheckOnOff  )

        {
            
            ushort _g_uESCSlotID = 0;
           
           // _uCheckOnOff = 1;

            CEtherCAT_DLL.CS_ECAT_Slave_Motion_Set_Svon(g_uESCCardNo, g_uESCNodeID, _g_uESCSlotID, _uCheckOnOff);
             //MessageBox.Show("OK");
            return "";

        }
        public ushort resetPO(ushort g_uESCCardNo, ushort g_uESCNodeID)
        {
            double dTdec;
           // ushort Status = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Sd_Stop(g_uESCCardNo, g_uAxisNo, g_SlotNo, g_Tdec);
            dTdec = Convert.ToDouble(1);
            g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Sd_Stop(g_uESCCardNo, g_uESCNodeID, 0, 0);

            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                MessageBox.Show("_ECAT_Slave_Motion_Sd_Stop, ErrorCode = " + g_uRet.ToString());
            }
            return g_uRet;
        }
        public ushort setPO(ushort g_uESCCardNo, ushort g_uESCNodeID,uint nTargetVel)
        {
          uint  uAcceleration = Convert.ToUInt32(5000);
          uint  uDeceleration = Convert.ToUInt32(2000);
           
            ushort uRet = CEtherCAT_DLL.CS_ECAT_Slave_PP_Start_Move(g_uESCCardNo, g_uESCNodeID, 0,300000, nTargetVel, uAcceleration, uDeceleration,0);
            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                MessageBox.Show("CS_ECAT_Slave_PP_Start_Move, ErrorCode = " + g_uRet.ToString());
          
            }
            return uRet;
        }
        public bool controlPulse(ushort g_uESCCardNo, ushort g_uESCNodeID, bool bOnOff)
        {
            
            int _nTargetPos = 0;
            ushort _uAbsMove = 0, _g_uESCSlotID = 0;
            uint _uAcceleration = 0, _uDeceleration = 0, _uConstVel = 0;
            double _dTdec;

            _nTargetPos = Convert.ToInt32(300000);
            _uConstVel = Convert.ToUInt32(3000);
            _uAcceleration = Convert.ToUInt32(500);
            _uDeceleration = Convert.ToUInt32(500);


            if (bOnOff == true)

            {
                _uAbsMove = 0;
                g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_PP_Start_Move(g_uESCCardNo, g_uESCNodeID, _g_uESCSlotID, _nTargetPos, _uConstVel, _uAcceleration, _uDeceleration, _uAbsMove);

                if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                {
                    MessageBox.Show("CS_ECAT_Slave_PP_Start_Move, ErrorCode = " + g_uRet.ToString());

                }
            }
            else if (bOnOff == false)
            {

                _dTdec = Convert.ToDouble(0);

                g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Sd_Stop(g_uESCCardNo, g_uESCNodeID, _g_uESCSlotID, _dTdec);

                if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                {
                    MessageBox.Show("_ECAT_Slave_Motion_Sd_Stop, ErrorCode = " + g_uRet.ToString());

                }

            }
            return true;

        }
        public ushort HomeServo (ushort g_uESCCardNo , ushort g_uESCNodeID, ushort uMode,uint nStrVel,uint nMaxVel, ref ushort _mDone, int nOffset = 0)
        {
            uint _uTacc = Convert.ToUInt32(Convert.ToDouble(0.1));
            g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_Home_Config(g_uESCCardNo, g_uESCNodeID, 0, uMode, nOffset, nStrVel, nMaxVel, _uTacc);
            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                MessageBox.Show("_ECAT_Slave_Home_Config, ErrorCode = " + g_uRet.ToString());
                return g_uRet;
            }
            else
            {
                g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_Home_Move(g_uESCCardNo, g_uESCNodeID, 0);
                if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                {
                    MessageBox.Show("_ECAT_Slave_Home_Move, ErrorCode = " + g_uRet.ToString());

                }
                else
                { 
                do
                {
                    g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Get_Mdone(0, g_uESCNodeID, 0, ref _mDone);

                } while ((_mDone) != 0);
            }
                return  g_uRet;
            }
        }
        public ushort ToTarget(ushort g_uESCCardNo, ushort g_uESCNodeID,ref ushort Mdone)
        {
                    
            

            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                MessageBox.Show("_ECAT_Slave_JOG, ErrorCode = " + g_uRet.ToString());

            }
            else
            {
                do
                {
                    g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Get_Mdone(g_uESCCardNo, g_uESCNodeID,0, ref Mdone);
               
                } while (Mdone != 0);

            }
            return g_uRet;
        }
        public bool homeservo (ushort g_uESCCardNo, ushort g_uESCNodeID)
        {
            ushort _uMode = 0, _g_uESCSlotID = 0;
            int _nOffset = 0;
            uint _uTacc = 0, _nMaxVel = 0, _nStrVel = 0;

            _nStrVel = Convert.ToUInt16(2000);
            _nMaxVel = Convert.ToUInt16(2000);
           // uMode = Convert.ToUInt16(1);
            _nOffset = Convert.ToInt32(0);

            _uTacc = Convert.ToUInt32(Convert.ToDouble(0.1));

            if (g_uESCNodeID == 36)

            {
                _uMode = Convert.ToUInt16(1);
                _nStrVel = Convert.ToUInt16(800);
                _nMaxVel = Convert.ToUInt16(500);
            }

            else if (g_uESCNodeID == 37)
            {
                _uMode = Convert.ToUInt16(1);
                _nStrVel = Convert.ToUInt16(1000);
                _nMaxVel = Convert.ToUInt16(500);
            }
            else if (g_uESCNodeID == 38)
            {
                _uMode = Convert.ToUInt16(1);
                _nStrVel = Convert.ToUInt16(2000);
                _nMaxVel = Convert.ToUInt16(2000);
            }
            else if (g_uESCNodeID == 39)
            {

                _uMode = Convert.ToUInt16(4);
                _nStrVel = Convert.ToUInt16(800);
                _nMaxVel = Convert.ToUInt16(800);
            }
            else if (g_uESCNodeID == 40)
            {
                _uMode = Convert.ToUInt16(4);
                _nStrVel = Convert.ToUInt16(600);
                _nMaxVel = Convert.ToUInt16(600);
            }
            else if (g_uESCNodeID == 41)
            {
                _uMode = Convert.ToUInt16(1);
                _nStrVel = Convert.ToUInt16(2000);
                _nMaxVel = Convert.ToUInt16(2000);
            }
            else if (g_uESCNodeID == 42)
            {
                _uMode = Convert.ToUInt16(1);
                _nStrVel = Convert.ToUInt16(2000);
                _nMaxVel = Convert.ToUInt16(2000);
            }
            else if (g_uESCNodeID == 43)
            {
                _uMode = Convert.ToUInt16(2);
                _nStrVel = Convert.ToUInt16(2000);
                _nMaxVel = Convert.ToUInt16(2000);
            }
            else if (g_uESCNodeID == 44)
            {
                _uMode = Convert.ToUInt16(1);
                _nStrVel = Convert.ToUInt16(2000);
                _nMaxVel = Convert.ToUInt16(2000);
            }

            g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_Home_Config(g_uESCCardNo, g_uESCNodeID, _g_uESCSlotID, _uMode, _nOffset, _nStrVel, _nMaxVel, _uTacc);
            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                MessageBox.Show("_ECAT_Slave_Home_Config, ErrorCode = " + g_uRet.ToString());
                return false;
            }
            else
            {
                g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_Home_Move(g_uESCCardNo, g_uESCNodeID, _g_uESCSlotID);
                if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                {
                    MessageBox.Show("_ECAT_Slave_Home_Move, ErrorCode = " + g_uRet.ToString());
                    return false;
                }
            }

            return true;

        }

        

        public int getPosition(ushort g_uESCCardNo, ushort g_uESCNodeID)
        {
            int _ngetPos = 0;
            ushort _g_uESCSlotID = 0;


            g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Get_Position(g_uESCCardNo, g_uESCNodeID, _g_uESCSlotID, ref _ngetPos);
            // MessageBox.Show(_ngetPos.ToString());

            return _ngetPos;
            // return _ngetPos.ToString();
        }



        public bool controlAxis(ushort g_uESCCardNo, ushort g_uESCNodeID, int nSpeed,double nTarget)

            {
            int _ngetPos = 0, _nTargetPosN = 0, _nTargetP = 0;
            ushort _uAbsMove = 0, _g_uESCSlotID = 0;
            uint _uAcceleration = 0, _uDeceleration = 0, _uConstVel = 0;

            _nTargetPosN = Convert.ToInt32(100*nTarget);
            _uConstVel = Convert.ToUInt32(nSpeed);
            _uAcceleration = Convert.ToUInt32(2000);
            _uDeceleration = Convert.ToUInt32(2000);
            _nTargetP = _nTargetPosN;

            //_nTargetP = (_nTargetPosN - _ngetPos);

            // g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Get_Position(g_uESCCardNo, g_uESCNodeID, _g_uESCSlotID, ref _ngetPos);
            //MessageBox.Show(_ngetPos.ToString());

            if (g_uESCNodeID == 36)
            {

                _uAcceleration = Convert.ToUInt32(2000);
                _uDeceleration = Convert.ToUInt32(2000);

            }
            else if (g_uESCNodeID == 37)

            {

                _uAcceleration = Convert.ToUInt32(700);
                _uDeceleration = Convert.ToUInt32(700);
            }
            else if (g_uESCNodeID == 38)

            {

                _uAcceleration = Convert.ToUInt32(100);
                _uDeceleration = Convert.ToUInt32(100);
            }
            else if (g_uESCNodeID == 39)

            {

                _uAcceleration = Convert.ToUInt32(100);
                _uDeceleration = Convert.ToUInt32(100);
            }
            else if (g_uESCNodeID == 40)

            {

                _uAcceleration = Convert.ToUInt32(100);
                _uDeceleration = Convert.ToUInt32(100);
            }
            else if (g_uESCNodeID == 41)

            {

                _uAcceleration = Convert.ToUInt32(100);
                _uDeceleration = Convert.ToUInt32(100);
            }
            else if (g_uESCNodeID == 42)

            {

                _uAcceleration = Convert.ToUInt32(100);
                _uDeceleration = Convert.ToUInt32(100);
            }
            else if (g_uESCNodeID == 43)

            {

                _uAcceleration = Convert.ToUInt32(100);
                _uDeceleration = Convert.ToUInt32(100);
            }
            else if (g_uESCNodeID == 44)

            {

                _uAcceleration = Convert.ToUInt32(100);
                _uDeceleration = Convert.ToUInt32(100);
            }

            _uAbsMove = 1;

             g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_PP_Start_Move(g_uESCCardNo, g_uESCNodeID, _g_uESCSlotID, _nTargetP, _uConstVel, _uAcceleration, _uDeceleration, _uAbsMove);

            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                MessageBox.Show("CS_ECAT_Slave_PP_Start_Move, ErrorCode = " + g_uRet.ToString());

            }

            return true;
        }

        public ushort getAI(ushort g_uESCNodeID, ushort CH_Index, ref double uValue)
        {
            int[] g_nModeValue = new int[2];
            int[] g_nModeLength = new int[2];
            int nIndexMode = 0;
            double _dTempData = 0;
            uint uRevisionNo = 0;
            g_nModeValue[0] = -5;
            //g_nModeValue[1] = -10;
            ushort _uValue = 0;
            g_nModeLength[0] = 10;
            //g_nModeLength[1] = 20;

            gRevisionNo = uRevisionNo;

            g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_ESC8124_Set_Input_Enable(g_uESCCardNo, g_uESCNodeID, CH_Index, 1);
            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                MessageBox.Show("_ECAT_Slave_ESC8124_Set_Input_Enable, ErrorCode = " + g_uRet.ToString());
                
            }
            else
            {
                
                g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_AIO_Get_Input_Value(g_uESCCardNo, g_uESCNodeID, CH_Index, ref _uValue);
                if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                {
                    MessageBox.Show("_ECAT_Slave_AIO_Get_Input_Value, ErrorCode = " + g_uRet.ToString());
                    
                }
                else
                {
                    if (gRevisionNo == 0x100000)
                    {
                        _dTempData = _uValue + 0x8000;

                        if (_dTempData >= 0x10000)
                            _dTempData -= 0x10000;
                    }
                    else
                    {

                        _dTempData = _uValue;
                    }
                }
            }
            uValue = _dTempData;
            return g_uRet;
        }
        public string getAnalog (ushort g_uESCCardNo, ushort g_uESCNodeID, int CH_Index )

        {

            int[] g_nModeValue = new int[2];
            int[] g_nModeLength = new int[2];

            ushort  _uValue = 0, uRet = 0, _g_uESCSlotID = 0;
            int nIndexMode = 0;
            double _dTempData = 0;
            uint  uRevisionNo = 0;
            g_nModeValue[0] = -5;
            //g_nModeValue[1] = -10;

            g_nModeLength[0] =10;
            //g_nModeLength[1] = 20;

            gRevisionNo = uRevisionNo;

            _g_uESCSlotID = Convert.ToUInt16(CH_Index);
            
            g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_ESC8124_Set_Input_Enable(g_uESCCardNo, g_uESCNodeID, _g_uESCSlotID, 1);
            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
               MessageBox.Show ("_ECAT_Slave_ESC8124_Set_Input_Enable, ErrorCode = " + g_uRet.ToString());
            }
            uRet = CEtherCAT_DLL.CS_ECAT_Slave_AIO_Get_Input_Value(g_uESCCardNo, g_uESCNodeID, _g_uESCSlotID, ref _uValue);
                    if (uRet == CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                    {
                        if (gRevisionNo == 0x100000)
                        {
                            _dTempData = _uValue + 0x8000;

                            if (_dTempData >= 0x10000)
                                _dTempData -= 0x10000;
                        }
                        else
                        {
                            _dTempData = _uValue;
                        }


               _dTempData = g_nModeValue[nIndexMode] + (_dTempData * g_nModeLength[nIndexMode] / 0xFFFF);
              //  double _uPvalue = (2.489 * _dTempData) - 3.370 ;

                return _dTempData.ToString("0.###");
                    
                    }
                
            return "AD_FAIL";
        }

        public ushort StopMoiton(ushort g_uESCCardNo, ushort g_uAxisNo, ushort g_SlotNo, double g_Tdec)
        {
            ushort Status = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Sd_Stop(g_uESCCardNo, g_uAxisNo, g_SlotNo,g_Tdec);
            return Status;
        }
        public ushort AxisMoveJog(ushort g_uESCCardNo, ushort g_uESCNodeID, ushort g_SlotNo,ushort g_uConstVel,ushort g_uAccesleration,ushort g_uDeceleration, int g_nTarget ,ushort g_uAbsMove )
        {
            g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_PP_Start_Move(g_uESCCardNo, g_uESCNodeID, g_SlotNo, g_nTarget, g_uConstVel, g_uAccesleration, g_uDeceleration, g_uAbsMove);
            
            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR) 
            {
                MessageBox.Show("CS_ECAT_Slace_PP_Start_Move, ErrorCode = " + g_uRet.ToString());
            }
            return g_uRet;
        }
        public ushort MoveP( ushort g_uESCNodeID, ushort g_uConstVel, ushort g_uAccesleration, ushort g_uDeceleration, int g_nTarget)
        {
            g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_PP_Start_Move(0, g_uESCNodeID, 0, g_nTarget, g_uConstVel, g_uAccesleration, g_uDeceleration,1);

            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                MessageBox.Show("CS_ECAT_Slace_PP_Start_Move, ErrorCode = " + g_uRet.ToString());
            }
            return g_uRet;
        }

        public ushort getMdone( ushort CardNo, ushort NodeID)
        {
            
            g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Get_Mdone( CardNo,  NodeID,  SlotNo, ref StatusMdone);

            return StatusMdone;
        
    }

        public ushort getMdone(ushort NodeID)
        {
            g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Get_Mdone(0, NodeID, SlotNo, ref StatusMdone);
           // Mdone = StatusMdone;
            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                MessageBox.Show("CS_ECAT_Slave_Motion_Get_Mdone, ErrorCode = " + g_uRet.ToString());
                StatusMdone = 1;
            }
            return StatusMdone;
        }
    }
}
