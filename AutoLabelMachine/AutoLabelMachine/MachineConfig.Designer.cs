namespace AutoLabelMachine
{
    partial class MachineConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbEtherCAT = new System.Windows.Forms.GroupBox();
            this.btnEtherCATInt = new System.Windows.Forms.Button();
            this.gbMotionControl = new System.Windows.Forms.GroupBox();
            this.btnResetALL = new System.Windows.Forms.Button();
            this.btnHomeV = new System.Windows.Forms.Button();
            this.btnHomeR = new System.Windows.Forms.Button();
            this.btnJOG_Z_N = new System.Windows.Forms.Button();
            this.btnJOG_Z_P = new System.Windows.Forms.Button();
            this.btnHomeRobot = new System.Windows.Forms.Button();
            this.txtDis_Step = new System.Windows.Forms.TextBox();
            this.rdbMove_Step = new System.Windows.Forms.RadioButton();
            this.rdbMove_Con = new System.Windows.Forms.RadioButton();
            this.btnJOG_V_N = new System.Windows.Forms.Button();
            this.btnJOG_R_N = new System.Windows.Forms.Button();
            this.btnJOG_V_P = new System.Windows.Forms.Button();
            this.btnJOG_R_P = new System.Windows.Forms.Button();
            this.btnJOG_Y_P = new System.Windows.Forms.Button();
            this.lbAxisName_V = new System.Windows.Forms.Label();
            this.btnJOG_Y_N = new System.Windows.Forms.Button();
            this.btnJOG_X_N = new System.Windows.Forms.Button();
            this.lbAxisName_R = new System.Windows.Forms.Label();
            this.tcMotionControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtAxis_V = new System.Windows.Forms.TextBox();
            this.btnServoRobotOFF = new System.Windows.Forms.Button();
            this.btnServoRobotON = new System.Windows.Forms.Button();
            this.cbServo_Z = new System.Windows.Forms.CheckBox();
            this.txtAxis_R = new System.Windows.Forms.TextBox();
            this.txtAxis_X = new System.Windows.Forms.TextBox();
            this.txtAxis_Y = new System.Windows.Forms.TextBox();
            this.cbServo_R = new System.Windows.Forms.CheckBox();
            this.cbServo_X = new System.Windows.Forms.CheckBox();
            this.txtAxis_Z = new System.Windows.Forms.TextBox();
            this.cbServo_Y = new System.Windows.Forms.CheckBox();
            this.cbServo_V = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbTarget = new System.Windows.Forms.Label();
            this.btnServo_C4_Move = new System.Windows.Forms.Button();
            this.lbCurrent = new System.Windows.Forms.Label();
            this.cbServo_C1 = new System.Windows.Forms.CheckBox();
            this.txtAxis_C1 = new System.Windows.Forms.TextBox();
            this.txtServo_C3_Target = new System.Windows.Forms.TextBox();
            this.btnServo_C3_Move = new System.Windows.Forms.Button();
            this.txtServo_C4_Target = new System.Windows.Forms.TextBox();
            this.txtAxis_C2 = new System.Windows.Forms.TextBox();
            this.cbServo_C2 = new System.Windows.Forms.CheckBox();
            this.cbServo_C4 = new System.Windows.Forms.CheckBox();
            this.txtAxis_C4 = new System.Windows.Forms.TextBox();
            this.txtServo_C2_Target = new System.Windows.Forms.TextBox();
            this.btnServo_C2_Move = new System.Windows.Forms.Button();
            this.btnServo_C1_Move = new System.Windows.Forms.Button();
            this.txtServo_C1_Target = new System.Windows.Forms.TextBox();
            this.txtAxis_C3 = new System.Windows.Forms.TextBox();
            this.cbServo_C3 = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnSave_Con_Spd = new System.Windows.Forms.Button();
            this.txtC4_spd = new System.Windows.Forms.TextBox();
            this.cbCon_C1 = new System.Windows.Forms.CheckBox();
            this.txtC3_spd = new System.Windows.Forms.TextBox();
            this.cbCon_C2 = new System.Windows.Forms.CheckBox();
            this.txtC2_spd = new System.Windows.Forms.TextBox();
            this.cbCon_C3 = new System.Windows.Forms.CheckBox();
            this.txtC1_spd = new System.Windows.Forms.TextBox();
            this.cbCon_C4 = new System.Windows.Forms.CheckBox();
            this.cbStopperC4 = new System.Windows.Forms.CheckBox();
            this.cbStopperC1 = new System.Windows.Forms.CheckBox();
            this.cbStopperC3 = new System.Windows.Forms.CheckBox();
            this.cbStopperC2 = new System.Windows.Forms.CheckBox();
            this.lbAxisName_Z = new System.Windows.Forms.Label();
            this.btnJOG_X_P = new System.Windows.Forms.Button();
            this.lbAxisName_Y = new System.Windows.Forms.Label();
            this.lbAxisName_X = new System.Windows.Forms.Label();
            this.TimCheckStatus = new System.Windows.Forms.Timer(this.components);
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.gbConveyor = new System.Windows.Forms.GroupBox();
            this.rdbBoard = new System.Windows.Forms.RadioButton();
            this.rdbCalib = new System.Windows.Forms.RadioButton();
            this.cbConIndex = new System.Windows.Forms.ComboBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.btnMoveWidthCon = new System.Windows.Forms.Button();
            this.btnGetWidthCon = new System.Windows.Forms.Button();
            this.btnSaveWidthCon = new System.Windows.Forms.Button();
            this.gbFeederControl = new System.Windows.Forms.GroupBox();
            this.btnAutoFeeder = new System.Windows.Forms.Button();
            this.btnSavePosPic = new System.Windows.Forms.Button();
            this.cbPickNum = new System.Windows.Forms.ComboBox();
            this.btnGetPosPick = new System.Windows.Forms.Button();
            this.txtAxisPicY = new System.Windows.Forms.TextBox();
            this.txtAxisPicX = new System.Windows.Forms.TextBox();
            this.lbAxisY = new System.Windows.Forms.Label();
            this.lbAxisX = new System.Windows.Forms.Label();
            this.btnReleaseROLL = new System.Windows.Forms.Button();
            this.btnLoadROLL = new System.Windows.Forms.Button();
            this.cbFeederNum = new System.Windows.Forms.ComboBox();
            this.btnIniFeedder = new System.Windows.Forms.Button();
            this.lbSensorRoll = new System.Windows.Forms.Label();
            this.btnFeederJOG = new System.Windows.Forms.Button();
            this.chbRealTimeSensorLB = new System.Windows.Forms.CheckBox();
            this.btnFeedStop = new System.Windows.Forms.Button();
            this.lbSensorLB04 = new System.Windows.Forms.Label();
            this.lbSensorLB01 = new System.Windows.Forms.Label();
            this.lbSensorLB03 = new System.Windows.Forms.Label();
            this.lbSensorLB02 = new System.Windows.Forms.Label();
            this.btSensorLBRead = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.gbHeadOffsetConfig = new System.Windows.Forms.GroupBox();
            this.btnSave_CoTheta_org = new System.Windows.Forms.Button();
            this.tabHeadOffset = new System.Windows.Forms.TabControl();
            this.tabHeadOffsetCAM0403 = new System.Windows.Forms.TabPage();
            this.txtCam_CoTheta_org = new System.Windows.Forms.TextBox();
            this.lbCam_CoTheta_org = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_OrgCam_x = new System.Windows.Forms.TextBox();
            this.txt_OrgCam_y = new System.Windows.Forms.TextBox();
            this.btnSaveCAMorg = new System.Windows.Forms.Button();
            this.btnCaptureHeadError = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtHeadOffsetX = new System.Windows.Forms.TextBox();
            this.lvHeadOffset_Geo = new System.Windows.Forms.ListView();
            this.label23 = new System.Windows.Forms.Label();
            this.btnSaveErr = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.btnLastSqCal = new System.Windows.Forms.Button();
            this.txtHeadOffsetY = new System.Windows.Forms.TextBox();
            this.txt_Geo_Xc = new System.Windows.Forms.TextBox();
            this.btnAdd_GeoDate = new System.Windows.Forms.Button();
            this.txt_Geo_Yc = new System.Windows.Forms.TextBox();
            this.btnDel_GeoData = new System.Windows.Forms.Button();
            this.txt_Geo_rc = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.lbCamoffset_CoTheta_org = new System.Windows.Forms.Label();
            this.txtCamOffsetTheta = new System.Windows.Forms.TextBox();
            this.btnLoadDataCamOffset = new System.Windows.Forms.Button();
            this.btnSaveOffsetCamOrg = new System.Windows.Forms.Button();
            this.btnGetCamOrg = new System.Windows.Forms.Button();
            this.btnMoveCamORG = new System.Windows.Forms.Button();
            this.txtCam_org_V = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCam_org_R = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCam_org_Z = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCam_org_Y = new System.Windows.Forms.TextBox();
            this.txtCam_org_X = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCamOffsetX = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCamOffsetY = new System.Windows.Forms.TextBox();
            this.btnCaptureCamError = new System.Windows.Forms.Button();
            this.btnCal_CoTheta_org = new System.Windows.Forms.Button();
            this.txtCam_CoTheta_P1x = new System.Windows.Forms.TextBox();
            this.btnAdd_CoTheta_P2 = new System.Windows.Forms.Button();
            this.txtCam_CoTheta_P1y = new System.Windows.Forms.TextBox();
            this.btnAdd_CoTheta_P1 = new System.Windows.Forms.Button();
            this.txtCam_CoTheta_P2y = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCam_CoTheta_P2x = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.imvInspetion = new NationalInstruments.Vision.WindowsForms.ImageViewer();
            this.gbVisionControl = new System.Windows.Forms.GroupBox();
            this.lbVisionConfigFileName = new System.Windows.Forms.Label();
            this.btnVisionStop = new System.Windows.Forms.Button();
            this.btnVisionOpen = new System.Windows.Forms.Button();
            this.btnVisionLauch = new System.Windows.Forms.Button();
            this.gbVaccumControl = new System.Windows.Forms.GroupBox();
            this.lbVacuumValue09 = new System.Windows.Forms.Label();
            this.lbVacuumValue08 = new System.Windows.Forms.Label();
            this.lbVacuumValue07 = new System.Windows.Forms.Label();
            this.lbVacuumValue06 = new System.Windows.Forms.Label();
            this.lbVacuumValue05 = new System.Windows.Forms.Label();
            this.lbVacuumValue04 = new System.Windows.Forms.Label();
            this.lbVacuumValue03 = new System.Windows.Forms.Label();
            this.cbVacummControl09 = new System.Windows.Forms.CheckBox();
            this.lbVacuumValue02 = new System.Windows.Forms.Label();
            this.cbVacummControl08 = new System.Windows.Forms.CheckBox();
            this.lbVacuumValue01 = new System.Windows.Forms.Label();
            this.cbVacummControl07 = new System.Windows.Forms.CheckBox();
            this.cbVacummControl01 = new System.Windows.Forms.CheckBox();
            this.cbVacummControl06 = new System.Windows.Forms.CheckBox();
            this.cbVacummControl05 = new System.Windows.Forms.CheckBox();
            this.cbVacummControl02 = new System.Windows.Forms.CheckBox();
            this.cbVacummControl03 = new System.Windows.Forms.CheckBox();
            this.cbVacummControl04 = new System.Windows.Forms.CheckBox();
            this.gbVisionConfig = new System.Windows.Forms.GroupBox();
            this.cbCamNum = new System.Windows.Forms.ComboBox();
            this.cbVisionLightCam04 = new System.Windows.Forms.CheckBox();
            this.cbVisionLightCam06 = new System.Windows.Forms.CheckBox();
            this.cbVisionLightCam05 = new System.Windows.Forms.CheckBox();
            this.cbVisionLightCam03 = new System.Windows.Forms.CheckBox();
            this.cbVisionLightCam02 = new System.Windows.Forms.CheckBox();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.txtCalibV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCalibR = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCalibZ = new System.Windows.Forms.TextBox();
            this.btnGetPosCalib = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCalibY = new System.Windows.Forms.TextBox();
            this.txtCalibX = new System.Windows.Forms.TextBox();
            this.btnSavePosCalib = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMovePosCalib = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.cbVisionLightCam01 = new System.Windows.Forms.CheckBox();
            this.gbHeadConfig = new System.Windows.Forms.GroupBox();
            this.btnMoveHead = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHeadSave = new System.Windows.Forms.Button();
            this.btnGetHeadPos = new System.Windows.Forms.Button();
            this.cbHeadNum = new System.Windows.Forms.ComboBox();
            this.txtHeadV = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.gbErrMsg = new System.Windows.Forms.GroupBox();
            this.LstErrMsg = new System.Windows.Forms.ListBox();
            this.btnClearErrMsg = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.TimAutoFeed = new System.Windows.Forms.Timer(this.components);
            this.gbEtherCAT.SuspendLayout();
            this.gbMotionControl.SuspendLayout();
            this.tcMotionControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.gbConveyor.SuspendLayout();
            this.gbFeederControl.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.gbHeadOffsetConfig.SuspendLayout();
            this.tabHeadOffset.SuspendLayout();
            this.tabHeadOffsetCAM0403.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.gbVisionControl.SuspendLayout();
            this.gbVaccumControl.SuspendLayout();
            this.gbVisionConfig.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.gbHeadConfig.SuspendLayout();
            this.gbErrMsg.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEtherCAT
            // 
            this.gbEtherCAT.Controls.Add(this.btnEtherCATInt);
            this.gbEtherCAT.Location = new System.Drawing.Point(12, 12);
            this.gbEtherCAT.Name = "gbEtherCAT";
            this.gbEtherCAT.Size = new System.Drawing.Size(253, 46);
            this.gbEtherCAT.TabIndex = 0;
            this.gbEtherCAT.TabStop = false;
            this.gbEtherCAT.Text = "EtherCAT";
            // 
            // btnEtherCATInt
            // 
            this.btnEtherCATInt.Location = new System.Drawing.Point(21, 17);
            this.btnEtherCATInt.Name = "btnEtherCATInt";
            this.btnEtherCATInt.Size = new System.Drawing.Size(75, 23);
            this.btnEtherCATInt.TabIndex = 0;
            this.btnEtherCATInt.Text = "Intitial";
            this.btnEtherCATInt.UseVisualStyleBackColor = true;
            this.btnEtherCATInt.Click += new System.EventHandler(this.btnEtherCATInt_Click);
            // 
            // gbMotionControl
            // 
            this.gbMotionControl.Controls.Add(this.btnResetALL);
            this.gbMotionControl.Controls.Add(this.btnHomeV);
            this.gbMotionControl.Controls.Add(this.btnHomeR);
            this.gbMotionControl.Controls.Add(this.btnJOG_Z_N);
            this.gbMotionControl.Controls.Add(this.btnJOG_Z_P);
            this.gbMotionControl.Controls.Add(this.btnHomeRobot);
            this.gbMotionControl.Controls.Add(this.txtDis_Step);
            this.gbMotionControl.Controls.Add(this.rdbMove_Step);
            this.gbMotionControl.Controls.Add(this.rdbMove_Con);
            this.gbMotionControl.Controls.Add(this.btnJOG_V_N);
            this.gbMotionControl.Controls.Add(this.btnJOG_R_N);
            this.gbMotionControl.Controls.Add(this.btnJOG_V_P);
            this.gbMotionControl.Controls.Add(this.btnJOG_R_P);
            this.gbMotionControl.Controls.Add(this.btnJOG_Y_P);
            this.gbMotionControl.Controls.Add(this.lbAxisName_V);
            this.gbMotionControl.Controls.Add(this.btnJOG_Y_N);
            this.gbMotionControl.Controls.Add(this.btnJOG_X_N);
            this.gbMotionControl.Controls.Add(this.lbAxisName_R);
            this.gbMotionControl.Controls.Add(this.tcMotionControl);
            this.gbMotionControl.Controls.Add(this.lbAxisName_Z);
            this.gbMotionControl.Controls.Add(this.btnJOG_X_P);
            this.gbMotionControl.Controls.Add(this.lbAxisName_Y);
            this.gbMotionControl.Controls.Add(this.lbAxisName_X);
            this.gbMotionControl.Enabled = false;
            this.gbMotionControl.Location = new System.Drawing.Point(12, 64);
            this.gbMotionControl.Name = "gbMotionControl";
            this.gbMotionControl.Size = new System.Drawing.Size(253, 443);
            this.gbMotionControl.TabIndex = 1;
            this.gbMotionControl.TabStop = false;
            this.gbMotionControl.Text = "Motion Control";
            // 
            // btnResetALL
            // 
            this.btnResetALL.Location = new System.Drawing.Point(164, 398);
            this.btnResetALL.Name = "btnResetALL";
            this.btnResetALL.Size = new System.Drawing.Size(65, 23);
            this.btnResetALL.TabIndex = 4;
            this.btnResetALL.Text = "Reset";
            this.btnResetALL.UseVisualStyleBackColor = true;
            this.btnResetALL.Click += new System.EventHandler(this.btnResetALL_Click_2);
            // 
            // btnHomeV
            // 
            this.btnHomeV.Location = new System.Drawing.Point(164, 360);
            this.btnHomeV.Name = "btnHomeV";
            this.btnHomeV.Size = new System.Drawing.Size(65, 23);
            this.btnHomeV.TabIndex = 14;
            this.btnHomeV.Text = "Home V";
            this.btnHomeV.UseVisualStyleBackColor = true;
            this.btnHomeV.Click += new System.EventHandler(this.btnHomeV_Click);
            // 
            // btnHomeR
            // 
            this.btnHomeR.Location = new System.Drawing.Point(164, 331);
            this.btnHomeR.Name = "btnHomeR";
            this.btnHomeR.Size = new System.Drawing.Size(65, 23);
            this.btnHomeR.TabIndex = 2;
            this.btnHomeR.Text = "Home R";
            this.btnHomeR.UseVisualStyleBackColor = true;
            this.btnHomeR.Click += new System.EventHandler(this.btnHomeR_Click);
            // 
            // btnJOG_Z_N
            // 
            this.btnJOG_Z_N.Location = new System.Drawing.Point(90, 329);
            this.btnJOG_Z_N.Name = "btnJOG_Z_N";
            this.btnJOG_Z_N.Size = new System.Drawing.Size(48, 33);
            this.btnJOG_Z_N.TabIndex = 2;
            this.btnJOG_Z_N.Text = "UP";
            this.btnJOG_Z_N.UseVisualStyleBackColor = true;
            this.btnJOG_Z_N.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJOG_Z_N_MouseDown);
            this.btnJOG_Z_N.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJOG_Z_N_MouseUp);
            // 
            // btnJOG_Z_P
            // 
            this.btnJOG_Z_P.Location = new System.Drawing.Point(6, 329);
            this.btnJOG_Z_P.Name = "btnJOG_Z_P";
            this.btnJOG_Z_P.Size = new System.Drawing.Size(48, 34);
            this.btnJOG_Z_P.TabIndex = 2;
            this.btnJOG_Z_P.Text = "Down";
            this.btnJOG_Z_P.UseVisualStyleBackColor = true;
            this.btnJOG_Z_P.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJOG_Z_P_MouseDown);
            this.btnJOG_Z_P.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJOG_Z_P_MouseUp);
            // 
            // btnHomeRobot
            // 
            this.btnHomeRobot.Location = new System.Drawing.Point(168, 263);
            this.btnHomeRobot.Name = "btnHomeRobot";
            this.btnHomeRobot.Size = new System.Drawing.Size(59, 47);
            this.btnHomeRobot.TabIndex = 2;
            this.btnHomeRobot.Text = "Home";
            this.btnHomeRobot.UseVisualStyleBackColor = true;
            this.btnHomeRobot.Click += new System.EventHandler(this.btnHomeRobot_Click);
            // 
            // txtDis_Step
            // 
            this.txtDis_Step.Location = new System.Drawing.Point(162, 230);
            this.txtDis_Step.Name = "txtDis_Step";
            this.txtDis_Step.Size = new System.Drawing.Size(65, 20);
            this.txtDis_Step.TabIndex = 2;
            // 
            // rdbMove_Step
            // 
            this.rdbMove_Step.AutoSize = true;
            this.rdbMove_Step.Location = new System.Drawing.Point(109, 230);
            this.rdbMove_Step.Name = "rdbMove_Step";
            this.rdbMove_Step.Size = new System.Drawing.Size(47, 17);
            this.rdbMove_Step.TabIndex = 13;
            this.rdbMove_Step.TabStop = true;
            this.rdbMove_Step.Text = "Step";
            this.rdbMove_Step.UseVisualStyleBackColor = true;
            this.rdbMove_Step.CheckedChanged += new System.EventHandler(this.rdbMove_Step_CheckedChanged);
            // 
            // rdbMove_Con
            // 
            this.rdbMove_Con.AutoSize = true;
            this.rdbMove_Con.Location = new System.Drawing.Point(18, 230);
            this.rdbMove_Con.Name = "rdbMove_Con";
            this.rdbMove_Con.Size = new System.Drawing.Size(78, 17);
            this.rdbMove_Con.TabIndex = 2;
            this.rdbMove_Con.TabStop = true;
            this.rdbMove_Con.Text = "Continuous";
            this.rdbMove_Con.UseVisualStyleBackColor = true;
            this.rdbMove_Con.CheckedChanged += new System.EventHandler(this.rdbMove_Con_CheckedChanged);
            // 
            // btnJOG_V_N
            // 
            this.btnJOG_V_N.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJOG_V_N.Location = new System.Drawing.Point(98, 407);
            this.btnJOG_V_N.Name = "btnJOG_V_N";
            this.btnJOG_V_N.Size = new System.Drawing.Size(29, 31);
            this.btnJOG_V_N.TabIndex = 6;
            this.btnJOG_V_N.Text = "-";
            this.btnJOG_V_N.UseVisualStyleBackColor = true;
            this.btnJOG_V_N.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJOG_V_N_MouseDown);
            this.btnJOG_V_N.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJOG_V_N_MouseUp);
            // 
            // btnJOG_R_N
            // 
            this.btnJOG_R_N.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJOG_R_N.Location = new System.Drawing.Point(97, 370);
            this.btnJOG_R_N.Name = "btnJOG_R_N";
            this.btnJOG_R_N.Size = new System.Drawing.Size(29, 31);
            this.btnJOG_R_N.TabIndex = 12;
            this.btnJOG_R_N.Text = "-";
            this.btnJOG_R_N.UseVisualStyleBackColor = true;
            this.btnJOG_R_N.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJOG_R_N_MouseDown);
            this.btnJOG_R_N.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJOG_R_N_MouseUp);
            // 
            // btnJOG_V_P
            // 
            this.btnJOG_V_P.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJOG_V_P.Location = new System.Drawing.Point(18, 407);
            this.btnJOG_V_P.Name = "btnJOG_V_P";
            this.btnJOG_V_P.Size = new System.Drawing.Size(30, 31);
            this.btnJOG_V_P.TabIndex = 5;
            this.btnJOG_V_P.Text = "+";
            this.btnJOG_V_P.UseVisualStyleBackColor = true;
            this.btnJOG_V_P.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJOG_V_P_MouseDown);
            this.btnJOG_V_P.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJOG_V_P_MouseUp);
            // 
            // btnJOG_R_P
            // 
            this.btnJOG_R_P.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJOG_R_P.Location = new System.Drawing.Point(18, 370);
            this.btnJOG_R_P.Name = "btnJOG_R_P";
            this.btnJOG_R_P.Size = new System.Drawing.Size(30, 31);
            this.btnJOG_R_P.TabIndex = 11;
            this.btnJOG_R_P.Text = "+";
            this.btnJOG_R_P.UseVisualStyleBackColor = true;
            this.btnJOG_R_P.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJOG_R_P_MouseDown);
            this.btnJOG_R_P.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJOG_R_P_MouseUp);
            // 
            // btnJOG_Y_P
            // 
            this.btnJOG_Y_P.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJOG_Y_P.Location = new System.Drawing.Point(19, 294);
            this.btnJOG_Y_P.Name = "btnJOG_Y_P";
            this.btnJOG_Y_P.Size = new System.Drawing.Size(29, 31);
            this.btnJOG_Y_P.TabIndex = 6;
            this.btnJOG_Y_P.Text = "+";
            this.btnJOG_Y_P.UseVisualStyleBackColor = true;
            this.btnJOG_Y_P.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJOG_Y_P_MouseDown);
            this.btnJOG_Y_P.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJOG_Y_P_MouseUp);
            // 
            // lbAxisName_V
            // 
            this.lbAxisName_V.AutoSize = true;
            this.lbAxisName_V.Location = new System.Drawing.Point(65, 417);
            this.lbAxisName_V.Name = "lbAxisName_V";
            this.lbAxisName_V.Size = new System.Drawing.Size(14, 13);
            this.lbAxisName_V.TabIndex = 10;
            this.lbAxisName_V.Text = "V";
            // 
            // btnJOG_Y_N
            // 
            this.btnJOG_Y_N.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJOG_Y_N.Location = new System.Drawing.Point(98, 294);
            this.btnJOG_Y_N.Name = "btnJOG_Y_N";
            this.btnJOG_Y_N.Size = new System.Drawing.Size(29, 31);
            this.btnJOG_Y_N.TabIndex = 5;
            this.btnJOG_Y_N.Text = "-";
            this.btnJOG_Y_N.UseVisualStyleBackColor = true;
            this.btnJOG_Y_N.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJOG_Y_N_MouseDown);
            this.btnJOG_Y_N.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJOG_Y_N_MouseUp);
            // 
            // btnJOG_X_N
            // 
            this.btnJOG_X_N.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJOG_X_N.Location = new System.Drawing.Point(98, 253);
            this.btnJOG_X_N.Name = "btnJOG_X_N";
            this.btnJOG_X_N.Size = new System.Drawing.Size(29, 31);
            this.btnJOG_X_N.TabIndex = 6;
            this.btnJOG_X_N.Text = "-";
            this.btnJOG_X_N.UseVisualStyleBackColor = true;
            this.btnJOG_X_N.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJOG_X_N_MouseDown);
            this.btnJOG_X_N.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJOG_X_N_MouseUp);
            // 
            // lbAxisName_R
            // 
            this.lbAxisName_R.AutoSize = true;
            this.lbAxisName_R.Location = new System.Drawing.Point(64, 380);
            this.lbAxisName_R.Name = "lbAxisName_R";
            this.lbAxisName_R.Size = new System.Drawing.Size(15, 13);
            this.lbAxisName_R.TabIndex = 9;
            this.lbAxisName_R.Text = "R";
            // 
            // tcMotionControl
            // 
            this.tcMotionControl.Controls.Add(this.tabPage1);
            this.tcMotionControl.Controls.Add(this.tabPage2);
            this.tcMotionControl.Controls.Add(this.tabPage3);
            this.tcMotionControl.Location = new System.Drawing.Point(6, 17);
            this.tcMotionControl.Name = "tcMotionControl";
            this.tcMotionControl.SelectedIndex = 0;
            this.tcMotionControl.Size = new System.Drawing.Size(241, 207);
            this.tcMotionControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabPage1.Controls.Add(this.txtAxis_V);
            this.tabPage1.Controls.Add(this.btnServoRobotOFF);
            this.tabPage1.Controls.Add(this.btnServoRobotON);
            this.tabPage1.Controls.Add(this.cbServo_Z);
            this.tabPage1.Controls.Add(this.txtAxis_R);
            this.tabPage1.Controls.Add(this.txtAxis_X);
            this.tabPage1.Controls.Add(this.txtAxis_Y);
            this.tabPage1.Controls.Add(this.cbServo_R);
            this.tabPage1.Controls.Add(this.cbServo_X);
            this.tabPage1.Controls.Add(this.txtAxis_Z);
            this.tabPage1.Controls.Add(this.cbServo_Y);
            this.tabPage1.Controls.Add(this.cbServo_V);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(233, 181);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Robot";
            // 
            // txtAxis_V
            // 
            this.txtAxis_V.BackColor = System.Drawing.Color.Gainsboro;
            this.txtAxis_V.Location = new System.Drawing.Point(91, 154);
            this.txtAxis_V.Name = "txtAxis_V";
            this.txtAxis_V.Size = new System.Drawing.Size(51, 20);
            this.txtAxis_V.TabIndex = 11;
            // 
            // btnServoRobotOFF
            // 
            this.btnServoRobotOFF.Location = new System.Drawing.Point(117, 10);
            this.btnServoRobotOFF.Name = "btnServoRobotOFF";
            this.btnServoRobotOFF.Size = new System.Drawing.Size(75, 23);
            this.btnServoRobotOFF.TabIndex = 3;
            this.btnServoRobotOFF.Text = "Servo OFF";
            this.btnServoRobotOFF.UseVisualStyleBackColor = true;
            this.btnServoRobotOFF.Click += new System.EventHandler(this.btnServoRobotOFF_Click);
            // 
            // btnServoRobotON
            // 
            this.btnServoRobotON.Location = new System.Drawing.Point(19, 10);
            this.btnServoRobotON.Name = "btnServoRobotON";
            this.btnServoRobotON.Size = new System.Drawing.Size(75, 23);
            this.btnServoRobotON.TabIndex = 2;
            this.btnServoRobotON.Text = "Servo ON";
            this.btnServoRobotON.UseVisualStyleBackColor = true;
            this.btnServoRobotON.Click += new System.EventHandler(this.btnServoRobotON_Click);
            // 
            // cbServo_Z
            // 
            this.cbServo_Z.AutoSize = true;
            this.cbServo_Z.Location = new System.Drawing.Point(8, 103);
            this.cbServo_Z.Name = "cbServo_Z";
            this.cbServo_Z.Size = new System.Drawing.Size(61, 17);
            this.cbServo_Z.TabIndex = 4;
            this.cbServo_Z.Text = "Axis : Z";
            this.cbServo_Z.UseVisualStyleBackColor = true;
            // 
            // txtAxis_R
            // 
            this.txtAxis_R.BackColor = System.Drawing.Color.Gainsboro;
            this.txtAxis_R.Location = new System.Drawing.Point(91, 127);
            this.txtAxis_R.Name = "txtAxis_R";
            this.txtAxis_R.Size = new System.Drawing.Size(51, 20);
            this.txtAxis_R.TabIndex = 10;
            // 
            // txtAxis_X
            // 
            this.txtAxis_X.BackColor = System.Drawing.Color.Gainsboro;
            this.txtAxis_X.Location = new System.Drawing.Point(91, 45);
            this.txtAxis_X.Name = "txtAxis_X";
            this.txtAxis_X.Size = new System.Drawing.Size(51, 20);
            this.txtAxis_X.TabIndex = 7;
            // 
            // txtAxis_Y
            // 
            this.txtAxis_Y.BackColor = System.Drawing.Color.Gainsboro;
            this.txtAxis_Y.Location = new System.Drawing.Point(91, 73);
            this.txtAxis_Y.Name = "txtAxis_Y";
            this.txtAxis_Y.Size = new System.Drawing.Size(51, 20);
            this.txtAxis_Y.TabIndex = 8;
            // 
            // cbServo_R
            // 
            this.cbServo_R.AutoSize = true;
            this.cbServo_R.Location = new System.Drawing.Point(8, 130);
            this.cbServo_R.Name = "cbServo_R";
            this.cbServo_R.Size = new System.Drawing.Size(62, 17);
            this.cbServo_R.TabIndex = 5;
            this.cbServo_R.Text = "Axis : R";
            this.cbServo_R.UseVisualStyleBackColor = true;
            // 
            // cbServo_X
            // 
            this.cbServo_X.AutoSize = true;
            this.cbServo_X.Location = new System.Drawing.Point(8, 48);
            this.cbServo_X.Name = "cbServo_X";
            this.cbServo_X.Size = new System.Drawing.Size(61, 17);
            this.cbServo_X.TabIndex = 2;
            this.cbServo_X.Text = "Axis : X";
            this.cbServo_X.UseVisualStyleBackColor = true;
            // 
            // txtAxis_Z
            // 
            this.txtAxis_Z.BackColor = System.Drawing.Color.Gainsboro;
            this.txtAxis_Z.Location = new System.Drawing.Point(91, 100);
            this.txtAxis_Z.Name = "txtAxis_Z";
            this.txtAxis_Z.Size = new System.Drawing.Size(51, 20);
            this.txtAxis_Z.TabIndex = 9;
            // 
            // cbServo_Y
            // 
            this.cbServo_Y.AutoSize = true;
            this.cbServo_Y.Location = new System.Drawing.Point(8, 76);
            this.cbServo_Y.Name = "cbServo_Y";
            this.cbServo_Y.Size = new System.Drawing.Size(61, 17);
            this.cbServo_Y.TabIndex = 3;
            this.cbServo_Y.Text = "Axis : Y";
            this.cbServo_Y.UseVisualStyleBackColor = true;
            // 
            // cbServo_V
            // 
            this.cbServo_V.AutoSize = true;
            this.cbServo_V.Location = new System.Drawing.Point(8, 157);
            this.cbServo_V.Name = "cbServo_V";
            this.cbServo_V.Size = new System.Drawing.Size(61, 17);
            this.cbServo_V.TabIndex = 6;
            this.cbServo_V.Text = "Axis : V";
            this.cbServo_V.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbTarget);
            this.tabPage2.Controls.Add(this.btnServo_C4_Move);
            this.tabPage2.Controls.Add(this.lbCurrent);
            this.tabPage2.Controls.Add(this.cbServo_C1);
            this.tabPage2.Controls.Add(this.txtAxis_C1);
            this.tabPage2.Controls.Add(this.txtServo_C3_Target);
            this.tabPage2.Controls.Add(this.btnServo_C3_Move);
            this.tabPage2.Controls.Add(this.txtServo_C4_Target);
            this.tabPage2.Controls.Add(this.txtAxis_C2);
            this.tabPage2.Controls.Add(this.cbServo_C2);
            this.tabPage2.Controls.Add(this.cbServo_C4);
            this.tabPage2.Controls.Add(this.txtAxis_C4);
            this.tabPage2.Controls.Add(this.txtServo_C2_Target);
            this.tabPage2.Controls.Add(this.btnServo_C2_Move);
            this.tabPage2.Controls.Add(this.btnServo_C1_Move);
            this.tabPage2.Controls.Add(this.txtServo_C1_Target);
            this.tabPage2.Controls.Add(this.txtAxis_C3);
            this.tabPage2.Controls.Add(this.cbServo_C3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(233, 181);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Conveyor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbTarget
            // 
            this.lbTarget.AutoSize = true;
            this.lbTarget.Location = new System.Drawing.Point(125, 12);
            this.lbTarget.Name = "lbTarget";
            this.lbTarget.Size = new System.Drawing.Size(63, 13);
            this.lbTarget.TabIndex = 3;
            this.lbTarget.Text = "Target (mm)";
            // 
            // btnServo_C4_Move
            // 
            this.btnServo_C4_Move.Location = new System.Drawing.Point(187, 119);
            this.btnServo_C4_Move.Name = "btnServo_C4_Move";
            this.btnServo_C4_Move.Size = new System.Drawing.Size(35, 23);
            this.btnServo_C4_Move.TabIndex = 17;
            this.btnServo_C4_Move.Text = "Go";
            this.btnServo_C4_Move.UseVisualStyleBackColor = true;
            this.btnServo_C4_Move.Click += new System.EventHandler(this.btnServo_C4_Move_Click);
            // 
            // lbCurrent
            // 
            this.lbCurrent.AutoSize = true;
            this.lbCurrent.Location = new System.Drawing.Point(53, 12);
            this.lbCurrent.Name = "lbCurrent";
            this.lbCurrent.Size = new System.Drawing.Size(66, 13);
            this.lbCurrent.TabIndex = 2;
            this.lbCurrent.Text = "Current (mm)";
            // 
            // cbServo_C1
            // 
            this.cbServo_C1.AutoSize = true;
            this.cbServo_C1.Location = new System.Drawing.Point(6, 34);
            this.cbServo_C1.Name = "cbServo_C1";
            this.cbServo_C1.Size = new System.Drawing.Size(67, 17);
            this.cbServo_C1.TabIndex = 2;
            this.cbServo_C1.Text = "Axis : C1";
            this.cbServo_C1.UseVisualStyleBackColor = true;
            this.cbServo_C1.CheckedChanged += new System.EventHandler(this.cbServo_C1_CheckedChanged);
            // 
            // txtAxis_C1
            // 
            this.txtAxis_C1.Location = new System.Drawing.Point(79, 31);
            this.txtAxis_C1.Name = "txtAxis_C1";
            this.txtAxis_C1.Size = new System.Drawing.Size(46, 20);
            this.txtAxis_C1.TabIndex = 6;
            // 
            // txtServo_C3_Target
            // 
            this.txtServo_C3_Target.Location = new System.Drawing.Point(136, 91);
            this.txtServo_C3_Target.Name = "txtServo_C3_Target";
            this.txtServo_C3_Target.Size = new System.Drawing.Size(45, 20);
            this.txtServo_C3_Target.TabIndex = 12;
            // 
            // btnServo_C3_Move
            // 
            this.btnServo_C3_Move.Location = new System.Drawing.Point(187, 88);
            this.btnServo_C3_Move.Name = "btnServo_C3_Move";
            this.btnServo_C3_Move.Size = new System.Drawing.Size(35, 23);
            this.btnServo_C3_Move.TabIndex = 16;
            this.btnServo_C3_Move.Text = "Go";
            this.btnServo_C3_Move.UseVisualStyleBackColor = true;
            this.btnServo_C3_Move.Click += new System.EventHandler(this.btnServo_C3_Move_Click);
            // 
            // txtServo_C4_Target
            // 
            this.txtServo_C4_Target.Location = new System.Drawing.Point(136, 122);
            this.txtServo_C4_Target.Name = "txtServo_C4_Target";
            this.txtServo_C4_Target.Size = new System.Drawing.Size(45, 20);
            this.txtServo_C4_Target.TabIndex = 13;
            // 
            // txtAxis_C2
            // 
            this.txtAxis_C2.Location = new System.Drawing.Point(79, 61);
            this.txtAxis_C2.Name = "txtAxis_C2";
            this.txtAxis_C2.Size = new System.Drawing.Size(46, 20);
            this.txtAxis_C2.TabIndex = 7;
            // 
            // cbServo_C2
            // 
            this.cbServo_C2.AutoSize = true;
            this.cbServo_C2.Location = new System.Drawing.Point(6, 64);
            this.cbServo_C2.Name = "cbServo_C2";
            this.cbServo_C2.Size = new System.Drawing.Size(67, 17);
            this.cbServo_C2.TabIndex = 3;
            this.cbServo_C2.Text = "Axis : C2";
            this.cbServo_C2.UseVisualStyleBackColor = true;
            this.cbServo_C2.CheckedChanged += new System.EventHandler(this.cbServo_C2_CheckedChanged);
            // 
            // cbServo_C4
            // 
            this.cbServo_C4.AutoSize = true;
            this.cbServo_C4.Location = new System.Drawing.Point(6, 125);
            this.cbServo_C4.Name = "cbServo_C4";
            this.cbServo_C4.Size = new System.Drawing.Size(67, 17);
            this.cbServo_C4.TabIndex = 5;
            this.cbServo_C4.Text = "Axis : C4";
            this.cbServo_C4.UseVisualStyleBackColor = true;
            this.cbServo_C4.CheckedChanged += new System.EventHandler(this.cbServo_C4_CheckedChanged);
            // 
            // txtAxis_C4
            // 
            this.txtAxis_C4.Location = new System.Drawing.Point(79, 122);
            this.txtAxis_C4.Name = "txtAxis_C4";
            this.txtAxis_C4.Size = new System.Drawing.Size(46, 20);
            this.txtAxis_C4.TabIndex = 9;
            // 
            // txtServo_C2_Target
            // 
            this.txtServo_C2_Target.Location = new System.Drawing.Point(136, 61);
            this.txtServo_C2_Target.Name = "txtServo_C2_Target";
            this.txtServo_C2_Target.Size = new System.Drawing.Size(45, 20);
            this.txtServo_C2_Target.TabIndex = 11;
            // 
            // btnServo_C2_Move
            // 
            this.btnServo_C2_Move.Location = new System.Drawing.Point(187, 59);
            this.btnServo_C2_Move.Name = "btnServo_C2_Move";
            this.btnServo_C2_Move.Size = new System.Drawing.Size(35, 23);
            this.btnServo_C2_Move.TabIndex = 15;
            this.btnServo_C2_Move.Text = "Go";
            this.btnServo_C2_Move.UseVisualStyleBackColor = true;
            this.btnServo_C2_Move.Click += new System.EventHandler(this.btnServo_C2_Move_Click);
            // 
            // btnServo_C1_Move
            // 
            this.btnServo_C1_Move.Location = new System.Drawing.Point(187, 28);
            this.btnServo_C1_Move.Name = "btnServo_C1_Move";
            this.btnServo_C1_Move.Size = new System.Drawing.Size(35, 23);
            this.btnServo_C1_Move.TabIndex = 14;
            this.btnServo_C1_Move.Text = "Go";
            this.btnServo_C1_Move.UseVisualStyleBackColor = true;
            this.btnServo_C1_Move.Click += new System.EventHandler(this.btnServo_C1_Move_Click);
            // 
            // txtServo_C1_Target
            // 
            this.txtServo_C1_Target.Location = new System.Drawing.Point(136, 31);
            this.txtServo_C1_Target.Name = "txtServo_C1_Target";
            this.txtServo_C1_Target.Size = new System.Drawing.Size(45, 20);
            this.txtServo_C1_Target.TabIndex = 10;
            // 
            // txtAxis_C3
            // 
            this.txtAxis_C3.Location = new System.Drawing.Point(79, 90);
            this.txtAxis_C3.Name = "txtAxis_C3";
            this.txtAxis_C3.Size = new System.Drawing.Size(46, 20);
            this.txtAxis_C3.TabIndex = 8;
            // 
            // cbServo_C3
            // 
            this.cbServo_C3.AutoSize = true;
            this.cbServo_C3.Location = new System.Drawing.Point(6, 92);
            this.cbServo_C3.Name = "cbServo_C3";
            this.cbServo_C3.Size = new System.Drawing.Size(67, 17);
            this.cbServo_C3.TabIndex = 4;
            this.cbServo_C3.Text = "Axis : C3";
            this.cbServo_C3.UseVisualStyleBackColor = true;
            this.cbServo_C3.CheckedChanged += new System.EventHandler(this.cbServo_C3_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnSave_Con_Spd);
            this.tabPage3.Controls.Add(this.txtC4_spd);
            this.tabPage3.Controls.Add(this.cbCon_C1);
            this.tabPage3.Controls.Add(this.txtC3_spd);
            this.tabPage3.Controls.Add(this.cbCon_C2);
            this.tabPage3.Controls.Add(this.txtC2_spd);
            this.tabPage3.Controls.Add(this.cbCon_C3);
            this.tabPage3.Controls.Add(this.txtC1_spd);
            this.tabPage3.Controls.Add(this.cbCon_C4);
            this.tabPage3.Controls.Add(this.cbStopperC4);
            this.tabPage3.Controls.Add(this.cbStopperC1);
            this.tabPage3.Controls.Add(this.cbStopperC3);
            this.tabPage3.Controls.Add(this.cbStopperC2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(233, 181);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Conveyor Speed";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnSave_Con_Spd
            // 
            this.btnSave_Con_Spd.Location = new System.Drawing.Point(70, 135);
            this.btnSave_Con_Spd.Name = "btnSave_Con_Spd";
            this.btnSave_Con_Spd.Size = new System.Drawing.Size(94, 32);
            this.btnSave_Con_Spd.TabIndex = 14;
            this.btnSave_Con_Spd.Text = "Save";
            this.btnSave_Con_Spd.UseVisualStyleBackColor = true;
            this.btnSave_Con_Spd.Click += new System.EventHandler(this.btnSave_Con_Spd_Click);
            // 
            // txtC4_spd
            // 
            this.txtC4_spd.Location = new System.Drawing.Point(92, 101);
            this.txtC4_spd.Name = "txtC4_spd";
            this.txtC4_spd.Size = new System.Drawing.Size(54, 20);
            this.txtC4_spd.TabIndex = 13;
            // 
            // cbCon_C1
            // 
            this.cbCon_C1.AutoSize = true;
            this.cbCon_C1.Location = new System.Drawing.Point(5, 23);
            this.cbCon_C1.Name = "cbCon_C1";
            this.cbCon_C1.Size = new System.Drawing.Size(67, 17);
            this.cbCon_C1.TabIndex = 2;
            this.cbCon_C1.Text = "Axis : C1";
            this.cbCon_C1.UseVisualStyleBackColor = true;
            this.cbCon_C1.CheckedChanged += new System.EventHandler(this.cbCon_C1_CheckedChanged);
            // 
            // txtC3_spd
            // 
            this.txtC3_spd.Location = new System.Drawing.Point(92, 74);
            this.txtC3_spd.Name = "txtC3_spd";
            this.txtC3_spd.Size = new System.Drawing.Size(54, 20);
            this.txtC3_spd.TabIndex = 12;
            // 
            // cbCon_C2
            // 
            this.cbCon_C2.AutoSize = true;
            this.cbCon_C2.Location = new System.Drawing.Point(5, 50);
            this.cbCon_C2.Name = "cbCon_C2";
            this.cbCon_C2.Size = new System.Drawing.Size(67, 17);
            this.cbCon_C2.TabIndex = 3;
            this.cbCon_C2.Text = "Axis : C2";
            this.cbCon_C2.UseVisualStyleBackColor = true;
            this.cbCon_C2.CheckedChanged += new System.EventHandler(this.cbCon_C2_CheckedChanged);
            // 
            // txtC2_spd
            // 
            this.txtC2_spd.Location = new System.Drawing.Point(92, 47);
            this.txtC2_spd.Name = "txtC2_spd";
            this.txtC2_spd.Size = new System.Drawing.Size(54, 20);
            this.txtC2_spd.TabIndex = 11;
            // 
            // cbCon_C3
            // 
            this.cbCon_C3.AutoSize = true;
            this.cbCon_C3.Location = new System.Drawing.Point(5, 77);
            this.cbCon_C3.Name = "cbCon_C3";
            this.cbCon_C3.Size = new System.Drawing.Size(67, 17);
            this.cbCon_C3.TabIndex = 4;
            this.cbCon_C3.Text = "Axis : C3";
            this.cbCon_C3.UseVisualStyleBackColor = true;
            this.cbCon_C3.CheckedChanged += new System.EventHandler(this.cbCon_C3_CheckedChanged);
            // 
            // txtC1_spd
            // 
            this.txtC1_spd.Location = new System.Drawing.Point(92, 23);
            this.txtC1_spd.Name = "txtC1_spd";
            this.txtC1_spd.Size = new System.Drawing.Size(54, 20);
            this.txtC1_spd.TabIndex = 10;
            // 
            // cbCon_C4
            // 
            this.cbCon_C4.AutoSize = true;
            this.cbCon_C4.Location = new System.Drawing.Point(5, 104);
            this.cbCon_C4.Name = "cbCon_C4";
            this.cbCon_C4.Size = new System.Drawing.Size(67, 17);
            this.cbCon_C4.TabIndex = 5;
            this.cbCon_C4.Text = "Axis : C4";
            this.cbCon_C4.UseVisualStyleBackColor = true;
            this.cbCon_C4.CheckedChanged += new System.EventHandler(this.cbCon_C4_CheckedChanged);
            // 
            // cbStopperC4
            // 
            this.cbStopperC4.AutoSize = true;
            this.cbStopperC4.Location = new System.Drawing.Point(152, 104);
            this.cbStopperC4.Name = "cbStopperC4";
            this.cbStopperC4.Size = new System.Drawing.Size(63, 17);
            this.cbStopperC4.TabIndex = 9;
            this.cbStopperC4.Text = "Stopper";
            this.cbStopperC4.UseVisualStyleBackColor = true;
            this.cbStopperC4.CheckedChanged += new System.EventHandler(this.cbStopperC4_CheckedChanged);
            // 
            // cbStopperC1
            // 
            this.cbStopperC1.AutoSize = true;
            this.cbStopperC1.Location = new System.Drawing.Point(152, 23);
            this.cbStopperC1.Name = "cbStopperC1";
            this.cbStopperC1.Size = new System.Drawing.Size(63, 17);
            this.cbStopperC1.TabIndex = 6;
            this.cbStopperC1.Text = "Stopper";
            this.cbStopperC1.UseVisualStyleBackColor = true;
            this.cbStopperC1.CheckedChanged += new System.EventHandler(this.cbStopperC1_CheckedChanged);
            // 
            // cbStopperC3
            // 
            this.cbStopperC3.AutoSize = true;
            this.cbStopperC3.Location = new System.Drawing.Point(152, 76);
            this.cbStopperC3.Name = "cbStopperC3";
            this.cbStopperC3.Size = new System.Drawing.Size(63, 17);
            this.cbStopperC3.TabIndex = 8;
            this.cbStopperC3.Text = "Stopper";
            this.cbStopperC3.UseVisualStyleBackColor = true;
            this.cbStopperC3.CheckedChanged += new System.EventHandler(this.cbStopperC3_CheckedChanged);
            // 
            // cbStopperC2
            // 
            this.cbStopperC2.AutoSize = true;
            this.cbStopperC2.Location = new System.Drawing.Point(152, 50);
            this.cbStopperC2.Name = "cbStopperC2";
            this.cbStopperC2.Size = new System.Drawing.Size(63, 17);
            this.cbStopperC2.TabIndex = 7;
            this.cbStopperC2.Text = "Stopper";
            this.cbStopperC2.UseVisualStyleBackColor = true;
            this.cbStopperC2.CheckedChanged += new System.EventHandler(this.cbStopperC2_CheckedChanged);
            // 
            // lbAxisName_Z
            // 
            this.lbAxisName_Z.AutoSize = true;
            this.lbAxisName_Z.Location = new System.Drawing.Point(66, 340);
            this.lbAxisName_Z.Name = "lbAxisName_Z";
            this.lbAxisName_Z.Size = new System.Drawing.Size(14, 13);
            this.lbAxisName_Z.TabIndex = 8;
            this.lbAxisName_Z.Text = "Z";
            // 
            // btnJOG_X_P
            // 
            this.btnJOG_X_P.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJOG_X_P.Location = new System.Drawing.Point(19, 253);
            this.btnJOG_X_P.Name = "btnJOG_X_P";
            this.btnJOG_X_P.Size = new System.Drawing.Size(29, 31);
            this.btnJOG_X_P.TabIndex = 2;
            this.btnJOG_X_P.Text = "+";
            this.btnJOG_X_P.UseVisualStyleBackColor = true;
            this.btnJOG_X_P.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJOG_X_P_MouseDown);
            this.btnJOG_X_P.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJOG_X_P_MouseUp);
            // 
            // lbAxisName_Y
            // 
            this.lbAxisName_Y.AutoSize = true;
            this.lbAxisName_Y.Location = new System.Drawing.Point(65, 304);
            this.lbAxisName_Y.Name = "lbAxisName_Y";
            this.lbAxisName_Y.Size = new System.Drawing.Size(14, 13);
            this.lbAxisName_Y.TabIndex = 7;
            this.lbAxisName_Y.Text = "Y";
            // 
            // lbAxisName_X
            // 
            this.lbAxisName_X.AutoSize = true;
            this.lbAxisName_X.Location = new System.Drawing.Point(66, 263);
            this.lbAxisName_X.Name = "lbAxisName_X";
            this.lbAxisName_X.Size = new System.Drawing.Size(14, 13);
            this.lbAxisName_X.TabIndex = 6;
            this.lbAxisName_X.Text = "X";
            // 
            // TimCheckStatus
            // 
            this.TimCheckStatus.Tick += new System.EventHandler(this.TimCheckStatus_Tick);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Location = new System.Drawing.Point(271, 12);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(771, 681);
            this.tabControl2.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.gbConveyor);
            this.tabPage4.Controls.Add(this.gbFeederControl);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(763, 655);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Feeder and Conveyor System";
            // 
            // gbConveyor
            // 
            this.gbConveyor.Controls.Add(this.rdbBoard);
            this.gbConveyor.Controls.Add(this.rdbCalib);
            this.gbConveyor.Controls.Add(this.cbConIndex);
            this.gbConveyor.Controls.Add(this.txtWidth);
            this.gbConveyor.Controls.Add(this.btnMoveWidthCon);
            this.gbConveyor.Controls.Add(this.btnGetWidthCon);
            this.gbConveyor.Controls.Add(this.btnSaveWidthCon);
            this.gbConveyor.Location = new System.Drawing.Point(6, 293);
            this.gbConveyor.Name = "gbConveyor";
            this.gbConveyor.Size = new System.Drawing.Size(358, 185);
            this.gbConveyor.TabIndex = 3;
            this.gbConveyor.TabStop = false;
            this.gbConveyor.Text = "Conveyor manual System";
            // 
            // rdbBoard
            // 
            this.rdbBoard.AutoSize = true;
            this.rdbBoard.Location = new System.Drawing.Point(207, 24);
            this.rdbBoard.Name = "rdbBoard";
            this.rdbBoard.Size = new System.Drawing.Size(53, 17);
            this.rdbBoard.TabIndex = 6;
            this.rdbBoard.TabStop = true;
            this.rdbBoard.Text = "Board";
            this.rdbBoard.UseVisualStyleBackColor = true;
            // 
            // rdbCalib
            // 
            this.rdbCalib.AutoSize = true;
            this.rdbCalib.Location = new System.Drawing.Point(135, 24);
            this.rdbCalib.Name = "rdbCalib";
            this.rdbCalib.Size = new System.Drawing.Size(66, 17);
            this.rdbCalib.TabIndex = 5;
            this.rdbCalib.TabStop = true;
            this.rdbCalib.Text = "Calibrate";
            this.rdbCalib.UseVisualStyleBackColor = true;
            // 
            // cbConIndex
            // 
            this.cbConIndex.FormattingEnabled = true;
            this.cbConIndex.Items.AddRange(new object[] {
            "Conveyor NO.1",
            "Conveyor NO.2",
            "Conveyor NO.3",
            "Conveyor NO.4"});
            this.cbConIndex.Location = new System.Drawing.Point(17, 23);
            this.cbConIndex.Name = "cbConIndex";
            this.cbConIndex.Size = new System.Drawing.Size(99, 21);
            this.cbConIndex.TabIndex = 4;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(279, 24);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(70, 20);
            this.txtWidth.TabIndex = 3;
            // 
            // btnMoveWidthCon
            // 
            this.btnMoveWidthCon.Location = new System.Drawing.Point(279, 55);
            this.btnMoveWidthCon.Name = "btnMoveWidthCon";
            this.btnMoveWidthCon.Size = new System.Drawing.Size(70, 23);
            this.btnMoveWidthCon.TabIndex = 2;
            this.btnMoveWidthCon.Text = "Move";
            this.btnMoveWidthCon.UseVisualStyleBackColor = true;
            this.btnMoveWidthCon.Click += new System.EventHandler(this.btnMoveWidthCon_Click);
            // 
            // btnGetWidthCon
            // 
            this.btnGetWidthCon.Location = new System.Drawing.Point(117, 55);
            this.btnGetWidthCon.Name = "btnGetWidthCon";
            this.btnGetWidthCon.Size = new System.Drawing.Size(71, 23);
            this.btnGetWidthCon.TabIndex = 0;
            this.btnGetWidthCon.Text = "Get ";
            this.btnGetWidthCon.UseVisualStyleBackColor = true;
            this.btnGetWidthCon.Click += new System.EventHandler(this.btnGetWidthCon_Click);
            // 
            // btnSaveWidthCon
            // 
            this.btnSaveWidthCon.Location = new System.Drawing.Point(201, 55);
            this.btnSaveWidthCon.Name = "btnSaveWidthCon";
            this.btnSaveWidthCon.Size = new System.Drawing.Size(71, 23);
            this.btnSaveWidthCon.TabIndex = 1;
            this.btnSaveWidthCon.Text = "Save";
            this.btnSaveWidthCon.UseVisualStyleBackColor = true;
            this.btnSaveWidthCon.Click += new System.EventHandler(this.btnSaveWidthCon_Click);
            // 
            // gbFeederControl
            // 
            this.gbFeederControl.Controls.Add(this.btnAutoFeeder);
            this.gbFeederControl.Controls.Add(this.btnSavePosPic);
            this.gbFeederControl.Controls.Add(this.cbPickNum);
            this.gbFeederControl.Controls.Add(this.btnGetPosPick);
            this.gbFeederControl.Controls.Add(this.txtAxisPicY);
            this.gbFeederControl.Controls.Add(this.txtAxisPicX);
            this.gbFeederControl.Controls.Add(this.lbAxisY);
            this.gbFeederControl.Controls.Add(this.lbAxisX);
            this.gbFeederControl.Controls.Add(this.btnReleaseROLL);
            this.gbFeederControl.Controls.Add(this.btnLoadROLL);
            this.gbFeederControl.Controls.Add(this.cbFeederNum);
            this.gbFeederControl.Controls.Add(this.btnIniFeedder);
            this.gbFeederControl.Controls.Add(this.lbSensorRoll);
            this.gbFeederControl.Controls.Add(this.btnFeederJOG);
            this.gbFeederControl.Controls.Add(this.chbRealTimeSensorLB);
            this.gbFeederControl.Controls.Add(this.btnFeedStop);
            this.gbFeederControl.Controls.Add(this.lbSensorLB04);
            this.gbFeederControl.Controls.Add(this.lbSensorLB01);
            this.gbFeederControl.Controls.Add(this.lbSensorLB03);
            this.gbFeederControl.Controls.Add(this.lbSensorLB02);
            this.gbFeederControl.Controls.Add(this.btSensorLBRead);
            this.gbFeederControl.Location = new System.Drawing.Point(6, 6);
            this.gbFeederControl.Name = "gbFeederControl";
            this.gbFeederControl.Size = new System.Drawing.Size(751, 271);
            this.gbFeederControl.TabIndex = 2;
            this.gbFeederControl.TabStop = false;
            this.gbFeederControl.Text = "Feeder manual Control System";
            // 
            // btnAutoFeeder
            // 
            this.btnAutoFeeder.Location = new System.Drawing.Point(253, 139);
            this.btnAutoFeeder.Name = "btnAutoFeeder";
            this.btnAutoFeeder.Size = new System.Drawing.Size(50, 85);
            this.btnAutoFeeder.TabIndex = 25;
            this.btnAutoFeeder.Text = "Auto Feed";
            this.btnAutoFeeder.UseVisualStyleBackColor = true;
            this.btnAutoFeeder.Click += new System.EventHandler(this.btnAutoFeeder_Click);
            // 
            // btnSavePosPic
            // 
            this.btnSavePosPic.Location = new System.Drawing.Point(544, 70);
            this.btnSavePosPic.Name = "btnSavePosPic";
            this.btnSavePosPic.Size = new System.Drawing.Size(75, 23);
            this.btnSavePosPic.TabIndex = 24;
            this.btnSavePosPic.Text = "Save";
            this.btnSavePosPic.UseVisualStyleBackColor = true;
            this.btnSavePosPic.Click += new System.EventHandler(this.btnSavePosPic_Click);
            // 
            // cbPickNum
            // 
            this.cbPickNum.FormattingEnabled = true;
            this.cbPickNum.Items.AddRange(new object[] {
            "Pick NO.1",
            "Pick NO.2",
            "Pick NO.3",
            "Pick NO.4"});
            this.cbPickNum.Location = new System.Drawing.Point(414, 24);
            this.cbPickNum.Name = "cbPickNum";
            this.cbPickNum.Size = new System.Drawing.Size(81, 21);
            this.cbPickNum.TabIndex = 23;
            // 
            // btnGetPosPick
            // 
            this.btnGetPosPick.Location = new System.Drawing.Point(664, 24);
            this.btnGetPosPick.Name = "btnGetPosPick";
            this.btnGetPosPick.Size = new System.Drawing.Size(81, 23);
            this.btnGetPosPick.TabIndex = 22;
            this.btnGetPosPick.Text = "Get";
            this.btnGetPosPick.UseVisualStyleBackColor = true;
            this.btnGetPosPick.Click += new System.EventHandler(this.btnGetPosPick_Click);
            // 
            // txtAxisPicY
            // 
            this.txtAxisPicY.Location = new System.Drawing.Point(602, 27);
            this.txtAxisPicY.Name = "txtAxisPicY";
            this.txtAxisPicY.Size = new System.Drawing.Size(47, 20);
            this.txtAxisPicY.TabIndex = 20;
            // 
            // txtAxisPicX
            // 
            this.txtAxisPicX.BackColor = System.Drawing.Color.White;
            this.txtAxisPicX.Location = new System.Drawing.Point(533, 27);
            this.txtAxisPicX.Name = "txtAxisPicX";
            this.txtAxisPicX.Size = new System.Drawing.Size(47, 20);
            this.txtAxisPicX.TabIndex = 18;
            // 
            // lbAxisY
            // 
            this.lbAxisY.AutoSize = true;
            this.lbAxisY.Location = new System.Drawing.Point(582, 29);
            this.lbAxisY.Name = "lbAxisY";
            this.lbAxisY.Size = new System.Drawing.Size(17, 13);
            this.lbAxisY.TabIndex = 21;
            this.lbAxisY.Text = "Y:";
            // 
            // lbAxisX
            // 
            this.lbAxisX.AutoSize = true;
            this.lbAxisX.Location = new System.Drawing.Point(504, 29);
            this.lbAxisX.Name = "lbAxisX";
            this.lbAxisX.Size = new System.Drawing.Size(20, 13);
            this.lbAxisX.TabIndex = 19;
            this.lbAxisX.Text = "X :";
            // 
            // btnReleaseROLL
            // 
            this.btnReleaseROLL.Location = new System.Drawing.Point(147, 161);
            this.btnReleaseROLL.Name = "btnReleaseROLL";
            this.btnReleaseROLL.Size = new System.Drawing.Size(98, 33);
            this.btnReleaseROLL.TabIndex = 17;
            this.btnReleaseROLL.Text = "Release";
            this.btnReleaseROLL.UseVisualStyleBackColor = true;
            this.btnReleaseROLL.Click += new System.EventHandler(this.btnReleaseROLL_Click);
            // 
            // btnLoadROLL
            // 
            this.btnLoadROLL.Location = new System.Drawing.Point(145, 113);
            this.btnLoadROLL.Name = "btnLoadROLL";
            this.btnLoadROLL.Size = new System.Drawing.Size(100, 33);
            this.btnLoadROLL.TabIndex = 16;
            this.btnLoadROLL.Text = "Load ROLL";
            this.btnLoadROLL.UseVisualStyleBackColor = true;
            this.btnLoadROLL.Click += new System.EventHandler(this.btnLoadROLL_Click);
            // 
            // cbFeederNum
            // 
            this.cbFeederNum.FormattingEnabled = true;
            this.cbFeederNum.Items.AddRange(new object[] {
            "Feeder NO.01",
            "Feeder NO.02",
            "Feeder NO.03",
            "Feeder NO.04",
            "Feeder NO.05",
            "Feeder NO.06",
            "Feeder NO.07",
            "Feeder NO.08"});
            this.cbFeederNum.Location = new System.Drawing.Point(16, 26);
            this.cbFeederNum.Name = "cbFeederNum";
            this.cbFeederNum.Size = new System.Drawing.Size(121, 21);
            this.cbFeederNum.TabIndex = 4;
            // 
            // btnIniFeedder
            // 
            this.btnIniFeedder.Location = new System.Drawing.Point(17, 59);
            this.btnIniFeedder.Name = "btnIniFeedder";
            this.btnIniFeedder.Size = new System.Drawing.Size(121, 34);
            this.btnIniFeedder.TabIndex = 13;
            this.btnIniFeedder.Text = "Intial Feedder";
            this.btnIniFeedder.UseVisualStyleBackColor = true;
            this.btnIniFeedder.Click += new System.EventHandler(this.btnIniFeedder_Click);
            // 
            // lbSensorRoll
            // 
            this.lbSensorRoll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbSensorRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSensorRoll.Location = new System.Drawing.Point(146, 60);
            this.lbSensorRoll.Name = "lbSensorRoll";
            this.lbSensorRoll.Size = new System.Drawing.Size(99, 50);
            this.lbSensorRoll.TabIndex = 10;
            this.lbSensorRoll.Text = "Label Roll";
            this.lbSensorRoll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFeederJOG
            // 
            this.btnFeederJOG.Location = new System.Drawing.Point(312, 138);
            this.btnFeederJOG.Name = "btnFeederJOG";
            this.btnFeederJOG.Size = new System.Drawing.Size(37, 60);
            this.btnFeederJOG.TabIndex = 7;
            this.btnFeederJOG.Text = "JOG";
            this.btnFeederJOG.UseVisualStyleBackColor = true;
            this.btnFeederJOG.Click += new System.EventHandler(this.btnFeederJOG_Click);
            this.btnFeederJOG.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnFeederJOG_MouseDown);
            this.btnFeederJOG.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnFeederJOG_MouseUp);
            // 
            // chbRealTimeSensorLB
            // 
            this.chbRealTimeSensorLB.AutoSize = true;
            this.chbRealTimeSensorLB.Location = new System.Drawing.Point(282, 30);
            this.chbRealTimeSensorLB.Name = "chbRealTimeSensorLB";
            this.chbRealTimeSensorLB.Size = new System.Drawing.Size(74, 17);
            this.chbRealTimeSensorLB.TabIndex = 9;
            this.chbRealTimeSensorLB.Text = "Real Time";
            this.chbRealTimeSensorLB.UseVisualStyleBackColor = true;
            // 
            // btnFeedStop
            // 
            this.btnFeedStop.Location = new System.Drawing.Point(253, 99);
            this.btnFeedStop.Name = "btnFeedStop";
            this.btnFeedStop.Size = new System.Drawing.Size(96, 33);
            this.btnFeedStop.TabIndex = 8;
            this.btnFeedStop.Text = "Stop Feed";
            this.btnFeedStop.UseVisualStyleBackColor = true;
            this.btnFeedStop.Click += new System.EventHandler(this.btnFeedStop_Click);
            // 
            // lbSensorLB04
            // 
            this.lbSensorLB04.AutoSize = true;
            this.lbSensorLB04.BackColor = System.Drawing.Color.LightGray;
            this.lbSensorLB04.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSensorLB04.Location = new System.Drawing.Point(252, 27);
            this.lbSensorLB04.Name = "lbSensorLB04";
            this.lbSensorLB04.Size = new System.Drawing.Size(20, 20);
            this.lbSensorLB04.TabIndex = 5;
            this.lbSensorLB04.Text = "X";
            // 
            // lbSensorLB01
            // 
            this.lbSensorLB01.AutoSize = true;
            this.lbSensorLB01.BackColor = System.Drawing.Color.LightGray;
            this.lbSensorLB01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSensorLB01.Location = new System.Drawing.Point(143, 27);
            this.lbSensorLB01.Name = "lbSensorLB01";
            this.lbSensorLB01.Size = new System.Drawing.Size(20, 20);
            this.lbSensorLB01.TabIndex = 2;
            this.lbSensorLB01.Text = "X";
            // 
            // lbSensorLB03
            // 
            this.lbSensorLB03.AutoSize = true;
            this.lbSensorLB03.BackColor = System.Drawing.Color.LightGray;
            this.lbSensorLB03.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSensorLB03.Location = new System.Drawing.Point(217, 27);
            this.lbSensorLB03.Name = "lbSensorLB03";
            this.lbSensorLB03.Size = new System.Drawing.Size(20, 20);
            this.lbSensorLB03.TabIndex = 4;
            this.lbSensorLB03.Text = "X";
            // 
            // lbSensorLB02
            // 
            this.lbSensorLB02.AutoSize = true;
            this.lbSensorLB02.BackColor = System.Drawing.Color.LightGray;
            this.lbSensorLB02.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSensorLB02.Location = new System.Drawing.Point(178, 27);
            this.lbSensorLB02.Name = "lbSensorLB02";
            this.lbSensorLB02.Size = new System.Drawing.Size(20, 20);
            this.lbSensorLB02.TabIndex = 3;
            this.lbSensorLB02.Text = "X";
            // 
            // btSensorLBRead
            // 
            this.btSensorLBRead.Location = new System.Drawing.Point(253, 59);
            this.btSensorLBRead.Name = "btSensorLBRead";
            this.btSensorLBRead.Size = new System.Drawing.Size(96, 34);
            this.btSensorLBRead.TabIndex = 1;
            this.btSensorLBRead.Text = "Read";
            this.btSensorLBRead.UseVisualStyleBackColor = true;
            this.btSensorLBRead.Click += new System.EventHandler(this.btSensorLBRead_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage5.Controls.Add(this.gbHeadOffsetConfig);
            this.tabPage5.Controls.Add(this.imvInspetion);
            this.tabPage5.Controls.Add(this.gbVisionControl);
            this.tabPage5.Controls.Add(this.gbVaccumControl);
            this.tabPage5.Controls.Add(this.gbVisionConfig);
            this.tabPage5.Controls.Add(this.gbHeadConfig);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(763, 655);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Vision System";
            // 
            // gbHeadOffsetConfig
            // 
            this.gbHeadOffsetConfig.Controls.Add(this.btnSave_CoTheta_org);
            this.gbHeadOffsetConfig.Controls.Add(this.tabHeadOffset);
            this.gbHeadOffsetConfig.Controls.Add(this.btnCal_CoTheta_org);
            this.gbHeadOffsetConfig.Controls.Add(this.txtCam_CoTheta_P1x);
            this.gbHeadOffsetConfig.Controls.Add(this.btnAdd_CoTheta_P2);
            this.gbHeadOffsetConfig.Controls.Add(this.txtCam_CoTheta_P1y);
            this.gbHeadOffsetConfig.Controls.Add(this.btnAdd_CoTheta_P1);
            this.gbHeadOffsetConfig.Controls.Add(this.txtCam_CoTheta_P2y);
            this.gbHeadOffsetConfig.Controls.Add(this.label12);
            this.gbHeadOffsetConfig.Controls.Add(this.txtCam_CoTheta_P2x);
            this.gbHeadOffsetConfig.Controls.Add(this.label9);
            this.gbHeadOffsetConfig.Controls.Add(this.label10);
            this.gbHeadOffsetConfig.Controls.Add(this.label11);
            this.gbHeadOffsetConfig.Enabled = false;
            this.gbHeadOffsetConfig.Location = new System.Drawing.Point(7, 351);
            this.gbHeadOffsetConfig.Name = "gbHeadOffsetConfig";
            this.gbHeadOffsetConfig.Size = new System.Drawing.Size(734, 298);
            this.gbHeadOffsetConfig.TabIndex = 35;
            this.gbHeadOffsetConfig.TabStop = false;
            this.gbHeadOffsetConfig.Text = "Head offset Config";
            // 
            // btnSave_CoTheta_org
            // 
            this.btnSave_CoTheta_org.Location = new System.Drawing.Point(465, 149);
            this.btnSave_CoTheta_org.Name = "btnSave_CoTheta_org";
            this.btnSave_CoTheta_org.Size = new System.Drawing.Size(114, 26);
            this.btnSave_CoTheta_org.TabIndex = 56;
            this.btnSave_CoTheta_org.Text = "Theta Save";
            this.btnSave_CoTheta_org.UseVisualStyleBackColor = true;
            this.btnSave_CoTheta_org.Click += new System.EventHandler(this.btnSave_CoTheta_org_Click);
            // 
            // tabHeadOffset
            // 
            this.tabHeadOffset.Controls.Add(this.tabHeadOffsetCAM0403);
            this.tabHeadOffset.Controls.Add(this.tabPage10);
            this.tabHeadOffset.Location = new System.Drawing.Point(10, 19);
            this.tabHeadOffset.Name = "tabHeadOffset";
            this.tabHeadOffset.SelectedIndex = 0;
            this.tabHeadOffset.Size = new System.Drawing.Size(430, 254);
            this.tabHeadOffset.TabIndex = 38;
            // 
            // tabHeadOffsetCAM0403
            // 
            this.tabHeadOffsetCAM0403.Controls.Add(this.txtCam_CoTheta_org);
            this.tabHeadOffsetCAM0403.Controls.Add(this.lbCam_CoTheta_org);
            this.tabHeadOffsetCAM0403.Controls.Add(this.label7);
            this.tabHeadOffsetCAM0403.Controls.Add(this.label8);
            this.tabHeadOffsetCAM0403.Controls.Add(this.txt_OrgCam_x);
            this.tabHeadOffsetCAM0403.Controls.Add(this.txt_OrgCam_y);
            this.tabHeadOffsetCAM0403.Controls.Add(this.btnSaveCAMorg);
            this.tabHeadOffsetCAM0403.Controls.Add(this.btnCaptureHeadError);
            this.tabHeadOffsetCAM0403.Controls.Add(this.btnClear);
            this.tabHeadOffsetCAM0403.Controls.Add(this.txtHeadOffsetX);
            this.tabHeadOffsetCAM0403.Controls.Add(this.lvHeadOffset_Geo);
            this.tabHeadOffsetCAM0403.Controls.Add(this.label23);
            this.tabHeadOffsetCAM0403.Controls.Add(this.btnSaveErr);
            this.tabHeadOffsetCAM0403.Controls.Add(this.label22);
            this.tabHeadOffsetCAM0403.Controls.Add(this.btnLastSqCal);
            this.tabHeadOffsetCAM0403.Controls.Add(this.txtHeadOffsetY);
            this.tabHeadOffsetCAM0403.Controls.Add(this.txt_Geo_Xc);
            this.tabHeadOffsetCAM0403.Controls.Add(this.btnAdd_GeoDate);
            this.tabHeadOffsetCAM0403.Controls.Add(this.txt_Geo_Yc);
            this.tabHeadOffsetCAM0403.Controls.Add(this.btnDel_GeoData);
            this.tabHeadOffsetCAM0403.Controls.Add(this.txt_Geo_rc);
            this.tabHeadOffsetCAM0403.Controls.Add(this.label29);
            this.tabHeadOffsetCAM0403.Controls.Add(this.label27);
            this.tabHeadOffsetCAM0403.Controls.Add(this.label28);
            this.tabHeadOffsetCAM0403.Location = new System.Drawing.Point(4, 22);
            this.tabHeadOffsetCAM0403.Name = "tabHeadOffsetCAM0403";
            this.tabHeadOffsetCAM0403.Padding = new System.Windows.Forms.Padding(3);
            this.tabHeadOffsetCAM0403.Size = new System.Drawing.Size(422, 228);
            this.tabHeadOffsetCAM0403.TabIndex = 0;
            this.tabHeadOffsetCAM0403.Text = "Camera NO.03 & 04";
            this.tabHeadOffsetCAM0403.UseVisualStyleBackColor = true;
            // 
            // txtCam_CoTheta_org
            // 
            this.txtCam_CoTheta_org.Location = new System.Drawing.Point(340, 116);
            this.txtCam_CoTheta_org.Name = "txtCam_CoTheta_org";
            this.txtCam_CoTheta_org.ReadOnly = true;
            this.txtCam_CoTheta_org.Size = new System.Drawing.Size(53, 20);
            this.txtCam_CoTheta_org.TabIndex = 49;
            this.txtCam_CoTheta_org.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbCam_CoTheta_org
            // 
            this.lbCam_CoTheta_org.AutoSize = true;
            this.lbCam_CoTheta_org.Location = new System.Drawing.Point(317, 119);
            this.lbCam_CoTheta_org.Name = "lbCam_CoTheta_org";
            this.lbCam_CoTheta_org.Size = new System.Drawing.Size(15, 13);
            this.lbCam_CoTheta_org.TabIndex = 50;
            this.lbCam_CoTheta_org.Text = "O";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(306, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Xorg :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(306, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Yorg :";
            // 
            // txt_OrgCam_x
            // 
            this.txt_OrgCam_x.Location = new System.Drawing.Point(341, 64);
            this.txt_OrgCam_x.Name = "txt_OrgCam_x";
            this.txt_OrgCam_x.ReadOnly = true;
            this.txt_OrgCam_x.Size = new System.Drawing.Size(53, 20);
            this.txt_OrgCam_x.TabIndex = 39;
            this.txt_OrgCam_x.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_OrgCam_y
            // 
            this.txt_OrgCam_y.Location = new System.Drawing.Point(341, 90);
            this.txt_OrgCam_y.Name = "txt_OrgCam_y";
            this.txt_OrgCam_y.ReadOnly = true;
            this.txt_OrgCam_y.Size = new System.Drawing.Size(53, 20);
            this.txt_OrgCam_y.TabIndex = 40;
            this.txt_OrgCam_y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSaveCAMorg
            // 
            this.btnSaveCAMorg.Location = new System.Drawing.Point(332, 168);
            this.btnSaveCAMorg.Name = "btnSaveCAMorg";
            this.btnSaveCAMorg.Size = new System.Drawing.Size(72, 32);
            this.btnSaveCAMorg.TabIndex = 38;
            this.btnSaveCAMorg.Text = "ORG Save";
            this.btnSaveCAMorg.UseVisualStyleBackColor = true;
            this.btnSaveCAMorg.Click += new System.EventHandler(this.btnSaveCAMorg_Click);
            // 
            // btnCaptureHeadError
            // 
            this.btnCaptureHeadError.Location = new System.Drawing.Point(4, 10);
            this.btnCaptureHeadError.Name = "btnCaptureHeadError";
            this.btnCaptureHeadError.Size = new System.Drawing.Size(75, 23);
            this.btnCaptureHeadError.TabIndex = 21;
            this.btnCaptureHeadError.Text = "Capture";
            this.btnCaptureHeadError.UseVisualStyleBackColor = true;
            this.btnCaptureHeadError.Click += new System.EventHandler(this.btnCaptureHeadError_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(4, 203);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 37;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtHeadOffsetX
            // 
            this.txtHeadOffsetX.Location = new System.Drawing.Point(183, 10);
            this.txtHeadOffsetX.Name = "txtHeadOffsetX";
            this.txtHeadOffsetX.ReadOnly = true;
            this.txtHeadOffsetX.Size = new System.Drawing.Size(53, 20);
            this.txtHeadOffsetX.TabIndex = 17;
            this.txtHeadOffsetX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lvHeadOffset_Geo
            // 
            this.lvHeadOffset_Geo.GridLines = true;
            this.lvHeadOffset_Geo.Location = new System.Drawing.Point(3, 36);
            this.lvHeadOffset_Geo.Name = "lvHeadOffset_Geo";
            this.lvHeadOffset_Geo.Size = new System.Drawing.Size(206, 164);
            this.lvHeadOffset_Geo.TabIndex = 34;
            this.lvHeadOffset_Geo.UseCompatibleStateImageBehavior = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(164, 13);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(20, 13);
            this.label23.TabIndex = 18;
            this.label23.Text = "X :";
            // 
            // btnSaveErr
            // 
            this.btnSaveErr.Location = new System.Drawing.Point(227, 142);
            this.btnSaveErr.Name = "btnSaveErr";
            this.btnSaveErr.Size = new System.Drawing.Size(87, 21);
            this.btnSaveErr.TabIndex = 36;
            this.btnSaveErr.Text = "Save";
            this.btnSaveErr.UseVisualStyleBackColor = true;
            this.btnSaveErr.Click += new System.EventHandler(this.btnSaveErr_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(239, 14);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(20, 13);
            this.label22.TabIndex = 20;
            this.label22.Text = "Y :";
            // 
            // btnLastSqCal
            // 
            this.btnLastSqCal.Location = new System.Drawing.Point(227, 168);
            this.btnLastSqCal.Name = "btnLastSqCal";
            this.btnLastSqCal.Size = new System.Drawing.Size(87, 32);
            this.btnLastSqCal.TabIndex = 33;
            this.btnLastSqCal.Text = "Cal";
            this.btnLastSqCal.UseVisualStyleBackColor = true;
            this.btnLastSqCal.Click += new System.EventHandler(this.btnLastSqCal_Click);
            // 
            // txtHeadOffsetY
            // 
            this.txtHeadOffsetY.Location = new System.Drawing.Point(261, 9);
            this.txtHeadOffsetY.Name = "txtHeadOffsetY";
            this.txtHeadOffsetY.ReadOnly = true;
            this.txtHeadOffsetY.Size = new System.Drawing.Size(53, 20);
            this.txtHeadOffsetY.TabIndex = 19;
            this.txtHeadOffsetY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Geo_Xc
            // 
            this.txt_Geo_Xc.Location = new System.Drawing.Point(251, 64);
            this.txt_Geo_Xc.Name = "txt_Geo_Xc";
            this.txt_Geo_Xc.ReadOnly = true;
            this.txt_Geo_Xc.Size = new System.Drawing.Size(53, 20);
            this.txt_Geo_Xc.TabIndex = 27;
            this.txt_Geo_Xc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAdd_GeoDate
            // 
            this.btnAdd_GeoDate.Location = new System.Drawing.Point(115, 202);
            this.btnAdd_GeoDate.Name = "btnAdd_GeoDate";
            this.btnAdd_GeoDate.Size = new System.Drawing.Size(48, 23);
            this.btnAdd_GeoDate.TabIndex = 23;
            this.btnAdd_GeoDate.Text = "Add";
            this.btnAdd_GeoDate.UseVisualStyleBackColor = true;
            this.btnAdd_GeoDate.Click += new System.EventHandler(this.btnAdd_GeoDate_Click);
            // 
            // txt_Geo_Yc
            // 
            this.txt_Geo_Yc.Location = new System.Drawing.Point(251, 90);
            this.txt_Geo_Yc.Name = "txt_Geo_Yc";
            this.txt_Geo_Yc.ReadOnly = true;
            this.txt_Geo_Yc.Size = new System.Drawing.Size(53, 20);
            this.txt_Geo_Yc.TabIndex = 29;
            this.txt_Geo_Yc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDel_GeoData
            // 
            this.btnDel_GeoData.Location = new System.Drawing.Point(164, 202);
            this.btnDel_GeoData.Name = "btnDel_GeoData";
            this.btnDel_GeoData.Size = new System.Drawing.Size(45, 23);
            this.btnDel_GeoData.TabIndex = 24;
            this.btnDel_GeoData.Text = "Del";
            this.btnDel_GeoData.UseVisualStyleBackColor = true;
            this.btnDel_GeoData.Click += new System.EventHandler(this.btnDel_GeoData_Click);
            // 
            // txt_Geo_rc
            // 
            this.txt_Geo_rc.Location = new System.Drawing.Point(251, 116);
            this.txt_Geo_rc.Name = "txt_Geo_rc";
            this.txt_Geo_rc.ReadOnly = true;
            this.txt_Geo_rc.Size = new System.Drawing.Size(53, 20);
            this.txt_Geo_rc.TabIndex = 31;
            this.txt_Geo_rc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(224, 67);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(26, 13);
            this.label29.TabIndex = 28;
            this.label29.Text = "Xc :";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(234, 119);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(16, 13);
            this.label27.TabIndex = 32;
            this.label27.Text = "r :";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(224, 93);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(26, 13);
            this.label28.TabIndex = 30;
            this.label28.Text = "Yc :";
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.lbCamoffset_CoTheta_org);
            this.tabPage10.Controls.Add(this.txtCamOffsetTheta);
            this.tabPage10.Controls.Add(this.btnLoadDataCamOffset);
            this.tabPage10.Controls.Add(this.btnSaveOffsetCamOrg);
            this.tabPage10.Controls.Add(this.btnGetCamOrg);
            this.tabPage10.Controls.Add(this.btnMoveCamORG);
            this.tabPage10.Controls.Add(this.txtCam_org_V);
            this.tabPage10.Controls.Add(this.label15);
            this.tabPage10.Controls.Add(this.txtCam_org_R);
            this.tabPage10.Controls.Add(this.label16);
            this.tabPage10.Controls.Add(this.txtCam_org_Z);
            this.tabPage10.Controls.Add(this.label17);
            this.tabPage10.Controls.Add(this.txtCam_org_Y);
            this.tabPage10.Controls.Add(this.txtCam_org_X);
            this.tabPage10.Controls.Add(this.label18);
            this.tabPage10.Controls.Add(this.label19);
            this.tabPage10.Controls.Add(this.txtCamOffsetX);
            this.tabPage10.Controls.Add(this.label13);
            this.tabPage10.Controls.Add(this.label14);
            this.tabPage10.Controls.Add(this.txtCamOffsetY);
            this.tabPage10.Controls.Add(this.btnCaptureCamError);
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(422, 228);
            this.tabPage10.TabIndex = 1;
            this.tabPage10.Text = "Camera NO. 02&01";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // lbCamoffset_CoTheta_org
            // 
            this.lbCamoffset_CoTheta_org.AutoSize = true;
            this.lbCamoffset_CoTheta_org.Location = new System.Drawing.Point(258, 13);
            this.lbCamoffset_CoTheta_org.Name = "lbCamoffset_CoTheta_org";
            this.lbCamoffset_CoTheta_org.Size = new System.Drawing.Size(21, 13);
            this.lbCamoffset_CoTheta_org.TabIndex = 71;
            this.lbCamoffset_CoTheta_org.Text = "O :";
            // 
            // txtCamOffsetTheta
            // 
            this.txtCamOffsetTheta.Location = new System.Drawing.Point(285, 9);
            this.txtCamOffsetTheta.Name = "txtCamOffsetTheta";
            this.txtCamOffsetTheta.ReadOnly = true;
            this.txtCamOffsetTheta.Size = new System.Drawing.Size(53, 20);
            this.txtCamOffsetTheta.TabIndex = 70;
            this.txtCamOffsetTheta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLoadDataCamOffset
            // 
            this.btnLoadDataCamOffset.Location = new System.Drawing.Point(100, 36);
            this.btnLoadDataCamOffset.Name = "btnLoadDataCamOffset";
            this.btnLoadDataCamOffset.Size = new System.Drawing.Size(45, 40);
            this.btnLoadDataCamOffset.TabIndex = 69;
            this.btnLoadDataCamOffset.Text = "Load";
            this.btnLoadDataCamOffset.UseVisualStyleBackColor = true;
            this.btnLoadDataCamOffset.Click += new System.EventHandler(this.btnLoadDataCamOffset_Click);
            // 
            // btnSaveOffsetCamOrg
            // 
            this.btnSaveOffsetCamOrg.Location = new System.Drawing.Point(22, 196);
            this.btnSaveOffsetCamOrg.Name = "btnSaveOffsetCamOrg";
            this.btnSaveOffsetCamOrg.Size = new System.Drawing.Size(75, 23);
            this.btnSaveOffsetCamOrg.TabIndex = 8;
            this.btnSaveOffsetCamOrg.Text = "Save";
            this.btnSaveOffsetCamOrg.UseVisualStyleBackColor = true;
            this.btnSaveOffsetCamOrg.Click += new System.EventHandler(this.btnSaveOffsetCamOrg_Click);
            // 
            // btnGetCamOrg
            // 
            this.btnGetCamOrg.Location = new System.Drawing.Point(21, 167);
            this.btnGetCamOrg.Name = "btnGetCamOrg";
            this.btnGetCamOrg.Size = new System.Drawing.Size(75, 23);
            this.btnGetCamOrg.TabIndex = 38;
            this.btnGetCamOrg.Text = "Get Position";
            this.btnGetCamOrg.UseVisualStyleBackColor = true;
            this.btnGetCamOrg.Click += new System.EventHandler(this.btnGetCamOrg_Click);
            // 
            // btnMoveCamORG
            // 
            this.btnMoveCamORG.Location = new System.Drawing.Point(100, 121);
            this.btnMoveCamORG.Name = "btnMoveCamORG";
            this.btnMoveCamORG.Size = new System.Drawing.Size(45, 40);
            this.btnMoveCamORG.TabIndex = 37;
            this.btnMoveCamORG.Text = "Move";
            this.btnMoveCamORG.UseVisualStyleBackColor = true;
            this.btnMoveCamORG.Click += new System.EventHandler(this.btnMoveCamORG_Click);
            // 
            // txtCam_org_V
            // 
            this.txtCam_org_V.BackColor = System.Drawing.Color.DimGray;
            this.txtCam_org_V.ForeColor = System.Drawing.Color.Yellow;
            this.txtCam_org_V.Location = new System.Drawing.Point(41, 141);
            this.txtCam_org_V.Name = "txtCam_org_V";
            this.txtCam_org_V.Size = new System.Drawing.Size(48, 20);
            this.txtCam_org_V.TabIndex = 35;
            this.txtCam_org_V.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 144);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "V :";
            // 
            // txtCam_org_R
            // 
            this.txtCam_org_R.BackColor = System.Drawing.Color.DimGray;
            this.txtCam_org_R.ForeColor = System.Drawing.Color.Yellow;
            this.txtCam_org_R.Location = new System.Drawing.Point(41, 117);
            this.txtCam_org_R.Name = "txtCam_org_R";
            this.txtCam_org_R.Size = new System.Drawing.Size(47, 20);
            this.txtCam_org_R.TabIndex = 33;
            this.txtCam_org_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 120);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "R :";
            // 
            // txtCam_org_Z
            // 
            this.txtCam_org_Z.BackColor = System.Drawing.Color.DimGray;
            this.txtCam_org_Z.ForeColor = System.Drawing.Color.Yellow;
            this.txtCam_org_Z.Location = new System.Drawing.Point(41, 91);
            this.txtCam_org_Z.Name = "txtCam_org_Z";
            this.txtCam_org_Z.Size = new System.Drawing.Size(48, 20);
            this.txtCam_org_Z.TabIndex = 31;
            this.txtCam_org_Z.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 94);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(20, 13);
            this.label17.TabIndex = 32;
            this.label17.Text = "Z :";
            // 
            // txtCam_org_Y
            // 
            this.txtCam_org_Y.BackColor = System.Drawing.Color.DimGray;
            this.txtCam_org_Y.ForeColor = System.Drawing.Color.Yellow;
            this.txtCam_org_Y.Location = new System.Drawing.Point(41, 65);
            this.txtCam_org_Y.Name = "txtCam_org_Y";
            this.txtCam_org_Y.ReadOnly = true;
            this.txtCam_org_Y.Size = new System.Drawing.Size(47, 20);
            this.txtCam_org_Y.TabIndex = 29;
            this.txtCam_org_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCam_org_X
            // 
            this.txtCam_org_X.BackColor = System.Drawing.Color.DimGray;
            this.txtCam_org_X.ForeColor = System.Drawing.Color.Yellow;
            this.txtCam_org_X.Location = new System.Drawing.Point(41, 39);
            this.txtCam_org_X.Name = "txtCam_org_X";
            this.txtCam_org_X.ReadOnly = true;
            this.txtCam_org_X.Size = new System.Drawing.Size(47, 20);
            this.txtCam_org_X.TabIndex = 27;
            this.txtCam_org_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(19, 68);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 13);
            this.label18.TabIndex = 30;
            this.label18.Text = "Y:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(18, 42);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(20, 13);
            this.label19.TabIndex = 28;
            this.label19.Text = "X :";
            // 
            // txtCamOffsetX
            // 
            this.txtCamOffsetX.Location = new System.Drawing.Point(116, 10);
            this.txtCamOffsetX.Name = "txtCamOffsetX";
            this.txtCamOffsetX.ReadOnly = true;
            this.txtCamOffsetX.Size = new System.Drawing.Size(53, 20);
            this.txtCamOffsetX.TabIndex = 23;
            this.txtCamOffsetX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(97, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "X :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(172, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Y :";
            // 
            // txtCamOffsetY
            // 
            this.txtCamOffsetY.Location = new System.Drawing.Point(194, 9);
            this.txtCamOffsetY.Name = "txtCamOffsetY";
            this.txtCamOffsetY.ReadOnly = true;
            this.txtCamOffsetY.Size = new System.Drawing.Size(53, 20);
            this.txtCamOffsetY.TabIndex = 25;
            this.txtCamOffsetY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCaptureCamError
            // 
            this.btnCaptureCamError.Location = new System.Drawing.Point(16, 8);
            this.btnCaptureCamError.Name = "btnCaptureCamError";
            this.btnCaptureCamError.Size = new System.Drawing.Size(75, 23);
            this.btnCaptureCamError.TabIndex = 22;
            this.btnCaptureCamError.Text = "Capture";
            this.btnCaptureCamError.UseVisualStyleBackColor = true;
            this.btnCaptureCamError.Click += new System.EventHandler(this.btnCaptureCamError_Click);
            // 
            // btnCal_CoTheta_org
            // 
            this.btnCal_CoTheta_org.Location = new System.Drawing.Point(465, 118);
            this.btnCal_CoTheta_org.Name = "btnCal_CoTheta_org";
            this.btnCal_CoTheta_org.Size = new System.Drawing.Size(114, 25);
            this.btnCal_CoTheta_org.TabIndex = 55;
            this.btnCal_CoTheta_org.Text = "Cal";
            this.btnCal_CoTheta_org.UseVisualStyleBackColor = true;
            this.btnCal_CoTheta_org.Click += new System.EventHandler(this.btnCal_CoTheta_org_Click);
            // 
            // txtCam_CoTheta_P1x
            // 
            this.txtCam_CoTheta_P1x.Location = new System.Drawing.Point(467, 39);
            this.txtCam_CoTheta_P1x.Name = "txtCam_CoTheta_P1x";
            this.txtCam_CoTheta_P1x.ReadOnly = true;
            this.txtCam_CoTheta_P1x.Size = new System.Drawing.Size(53, 20);
            this.txtCam_CoTheta_P1x.TabIndex = 43;
            this.txtCam_CoTheta_P1x.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAdd_CoTheta_P2
            // 
            this.btnAdd_CoTheta_P2.Location = new System.Drawing.Point(526, 91);
            this.btnAdd_CoTheta_P2.Name = "btnAdd_CoTheta_P2";
            this.btnAdd_CoTheta_P2.Size = new System.Drawing.Size(55, 20);
            this.btnAdd_CoTheta_P2.TabIndex = 54;
            this.btnAdd_CoTheta_P2.Text = "Add";
            this.btnAdd_CoTheta_P2.UseVisualStyleBackColor = true;
            this.btnAdd_CoTheta_P2.Click += new System.EventHandler(this.btnAdd_CoTheta_P2_Click);
            // 
            // txtCam_CoTheta_P1y
            // 
            this.txtCam_CoTheta_P1y.Location = new System.Drawing.Point(467, 65);
            this.txtCam_CoTheta_P1y.Name = "txtCam_CoTheta_P1y";
            this.txtCam_CoTheta_P1y.ReadOnly = true;
            this.txtCam_CoTheta_P1y.Size = new System.Drawing.Size(53, 20);
            this.txtCam_CoTheta_P1y.TabIndex = 44;
            this.txtCam_CoTheta_P1y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAdd_CoTheta_P1
            // 
            this.btnAdd_CoTheta_P1.Location = new System.Drawing.Point(465, 91);
            this.btnAdd_CoTheta_P1.Name = "btnAdd_CoTheta_P1";
            this.btnAdd_CoTheta_P1.Size = new System.Drawing.Size(55, 20);
            this.btnAdd_CoTheta_P1.TabIndex = 53;
            this.btnAdd_CoTheta_P1.Text = "Add";
            this.btnAdd_CoTheta_P1.UseVisualStyleBackColor = true;
            this.btnAdd_CoTheta_P1.Click += new System.EventHandler(this.btnAdd_CoTheta_P1_Click);
            // 
            // txtCam_CoTheta_P2y
            // 
            this.txtCam_CoTheta_P2y.Location = new System.Drawing.Point(526, 65);
            this.txtCam_CoTheta_P2y.Name = "txtCam_CoTheta_P2y";
            this.txtCam_CoTheta_P2y.ReadOnly = true;
            this.txtCam_CoTheta_P2y.Size = new System.Drawing.Size(53, 20);
            this.txtCam_CoTheta_P2y.TabIndex = 46;
            this.txtCam_CoTheta_P2y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(542, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 13);
            this.label12.TabIndex = 52;
            this.label12.Text = "P2";
            // 
            // txtCam_CoTheta_P2x
            // 
            this.txtCam_CoTheta_P2x.Location = new System.Drawing.Point(526, 39);
            this.txtCam_CoTheta_P2x.Name = "txtCam_CoTheta_P2x";
            this.txtCam_CoTheta_P2x.ReadOnly = true;
            this.txtCam_CoTheta_P2x.Size = new System.Drawing.Size(53, 20);
            this.txtCam_CoTheta_P2x.TabIndex = 45;
            this.txtCam_CoTheta_P2x.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(481, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "P1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(442, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "X\' :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(442, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "Y\' :";
            // 
            // imvInspetion
            // 
            this.imvInspetion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imvInspetion.Location = new System.Drawing.Point(7, 14);
            this.imvInspetion.Margin = new System.Windows.Forms.Padding(4);
            this.imvInspetion.Name = "imvInspetion";
            this.imvInspetion.Size = new System.Drawing.Size(324, 236);
            this.imvInspetion.TabIndex = 34;
            this.imvInspetion.ZoomToFit = true;
            // 
            // gbVisionControl
            // 
            this.gbVisionControl.Controls.Add(this.lbVisionConfigFileName);
            this.gbVisionControl.Controls.Add(this.btnVisionStop);
            this.gbVisionControl.Controls.Add(this.btnVisionOpen);
            this.gbVisionControl.Controls.Add(this.btnVisionLauch);
            this.gbVisionControl.Location = new System.Drawing.Point(7, 251);
            this.gbVisionControl.Name = "gbVisionControl";
            this.gbVisionControl.Size = new System.Drawing.Size(324, 89);
            this.gbVisionControl.TabIndex = 3;
            this.gbVisionControl.TabStop = false;
            this.gbVisionControl.Text = "Vision System Control";
            // 
            // lbVisionConfigFileName
            // 
            this.lbVisionConfigFileName.AutoSize = true;
            this.lbVisionConfigFileName.Location = new System.Drawing.Point(14, 66);
            this.lbVisionConfigFileName.Name = "lbVisionConfigFileName";
            this.lbVisionConfigFileName.Size = new System.Drawing.Size(61, 13);
            this.lbVisionConfigFileName.TabIndex = 3;
            this.lbVisionConfigFileName.Text = "File name : ";
            // 
            // btnVisionStop
            // 
            this.btnVisionStop.Enabled = false;
            this.btnVisionStop.Location = new System.Drawing.Point(216, 19);
            this.btnVisionStop.Name = "btnVisionStop";
            this.btnVisionStop.Size = new System.Drawing.Size(102, 38);
            this.btnVisionStop.TabIndex = 2;
            this.btnVisionStop.Text = "Stop Engine";
            this.btnVisionStop.UseVisualStyleBackColor = true;
            this.btnVisionStop.Click += new System.EventHandler(this.btnVisionStop_Click);
            // 
            // btnVisionOpen
            // 
            this.btnVisionOpen.Enabled = false;
            this.btnVisionOpen.Location = new System.Drawing.Point(120, 19);
            this.btnVisionOpen.Name = "btnVisionOpen";
            this.btnVisionOpen.Size = new System.Drawing.Size(89, 38);
            this.btnVisionOpen.TabIndex = 1;
            this.btnVisionOpen.Text = "Open File";
            this.btnVisionOpen.UseVisualStyleBackColor = true;
            this.btnVisionOpen.Click += new System.EventHandler(this.btnVisionOpen_Click);
            // 
            // btnVisionLauch
            // 
            this.btnVisionLauch.Location = new System.Drawing.Point(10, 20);
            this.btnVisionLauch.Name = "btnVisionLauch";
            this.btnVisionLauch.Size = new System.Drawing.Size(104, 38);
            this.btnVisionLauch.TabIndex = 0;
            this.btnVisionLauch.Text = "Lanch Engine";
            this.btnVisionLauch.UseVisualStyleBackColor = true;
            this.btnVisionLauch.Click += new System.EventHandler(this.btnVisionLauch_Click);
            // 
            // gbVaccumControl
            // 
            this.gbVaccumControl.Controls.Add(this.lbVacuumValue09);
            this.gbVaccumControl.Controls.Add(this.lbVacuumValue08);
            this.gbVaccumControl.Controls.Add(this.lbVacuumValue07);
            this.gbVaccumControl.Controls.Add(this.lbVacuumValue06);
            this.gbVaccumControl.Controls.Add(this.lbVacuumValue05);
            this.gbVaccumControl.Controls.Add(this.lbVacuumValue04);
            this.gbVaccumControl.Controls.Add(this.lbVacuumValue03);
            this.gbVaccumControl.Controls.Add(this.cbVacummControl09);
            this.gbVaccumControl.Controls.Add(this.lbVacuumValue02);
            this.gbVaccumControl.Controls.Add(this.cbVacummControl08);
            this.gbVaccumControl.Controls.Add(this.lbVacuumValue01);
            this.gbVaccumControl.Controls.Add(this.cbVacummControl07);
            this.gbVaccumControl.Controls.Add(this.cbVacummControl01);
            this.gbVaccumControl.Controls.Add(this.cbVacummControl06);
            this.gbVaccumControl.Controls.Add(this.cbVacummControl05);
            this.gbVaccumControl.Controls.Add(this.cbVacummControl02);
            this.gbVaccumControl.Controls.Add(this.cbVacummControl03);
            this.gbVaccumControl.Controls.Add(this.cbVacummControl04);
            this.gbVaccumControl.Location = new System.Drawing.Point(341, 251);
            this.gbVaccumControl.Name = "gbVaccumControl";
            this.gbVaccumControl.Size = new System.Drawing.Size(419, 97);
            this.gbVaccumControl.TabIndex = 2;
            this.gbVaccumControl.TabStop = false;
            this.gbVaccumControl.Text = "Vaccum Head  Control ";
            // 
            // lbVacuumValue09
            // 
            this.lbVacuumValue09.AutoSize = true;
            this.lbVacuumValue09.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbVacuumValue09.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbVacuumValue09.Location = new System.Drawing.Point(352, 64);
            this.lbVacuumValue09.Name = "lbVacuumValue09";
            this.lbVacuumValue09.Size = new System.Drawing.Size(36, 15);
            this.lbVacuumValue09.TabIndex = 20;
            this.lbVacuumValue09.Text = "0.000";
            // 
            // lbVacuumValue08
            // 
            this.lbVacuumValue08.AutoSize = true;
            this.lbVacuumValue08.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbVacuumValue08.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbVacuumValue08.Location = new System.Drawing.Point(219, 64);
            this.lbVacuumValue08.Name = "lbVacuumValue08";
            this.lbVacuumValue08.Size = new System.Drawing.Size(36, 15);
            this.lbVacuumValue08.TabIndex = 19;
            this.lbVacuumValue08.Text = "0.000";
            // 
            // lbVacuumValue07
            // 
            this.lbVacuumValue07.AutoSize = true;
            this.lbVacuumValue07.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbVacuumValue07.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbVacuumValue07.Location = new System.Drawing.Point(79, 67);
            this.lbVacuumValue07.Name = "lbVacuumValue07";
            this.lbVacuumValue07.Size = new System.Drawing.Size(36, 15);
            this.lbVacuumValue07.TabIndex = 18;
            this.lbVacuumValue07.Text = "0.000";
            // 
            // lbVacuumValue06
            // 
            this.lbVacuumValue06.AutoSize = true;
            this.lbVacuumValue06.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbVacuumValue06.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbVacuumValue06.Location = new System.Drawing.Point(352, 41);
            this.lbVacuumValue06.Name = "lbVacuumValue06";
            this.lbVacuumValue06.Size = new System.Drawing.Size(36, 15);
            this.lbVacuumValue06.TabIndex = 17;
            this.lbVacuumValue06.Text = "0.000";
            // 
            // lbVacuumValue05
            // 
            this.lbVacuumValue05.AutoSize = true;
            this.lbVacuumValue05.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbVacuumValue05.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbVacuumValue05.Location = new System.Drawing.Point(219, 42);
            this.lbVacuumValue05.Name = "lbVacuumValue05";
            this.lbVacuumValue05.Size = new System.Drawing.Size(36, 15);
            this.lbVacuumValue05.TabIndex = 16;
            this.lbVacuumValue05.Text = "0.000";
            // 
            // lbVacuumValue04
            // 
            this.lbVacuumValue04.AutoSize = true;
            this.lbVacuumValue04.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbVacuumValue04.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbVacuumValue04.Location = new System.Drawing.Point(78, 44);
            this.lbVacuumValue04.Name = "lbVacuumValue04";
            this.lbVacuumValue04.Size = new System.Drawing.Size(36, 15);
            this.lbVacuumValue04.TabIndex = 15;
            this.lbVacuumValue04.Text = "0.000";
            // 
            // lbVacuumValue03
            // 
            this.lbVacuumValue03.AutoSize = true;
            this.lbVacuumValue03.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbVacuumValue03.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbVacuumValue03.Location = new System.Drawing.Point(352, 19);
            this.lbVacuumValue03.Name = "lbVacuumValue03";
            this.lbVacuumValue03.Size = new System.Drawing.Size(36, 15);
            this.lbVacuumValue03.TabIndex = 14;
            this.lbVacuumValue03.Text = "0.000";
            // 
            // cbVacummControl09
            // 
            this.cbVacummControl09.AutoSize = true;
            this.cbVacummControl09.Location = new System.Drawing.Point(279, 64);
            this.cbVacummControl09.Name = "cbVacummControl09";
            this.cbVacummControl09.Size = new System.Drawing.Size(67, 17);
            this.cbVacummControl09.TabIndex = 13;
            this.cbVacummControl09.Text = "Head 09";
            this.cbVacummControl09.UseVisualStyleBackColor = true;
            this.cbVacummControl09.CheckedChanged += new System.EventHandler(this.cbVacummControl09_CheckedChanged);
            // 
            // lbVacuumValue02
            // 
            this.lbVacuumValue02.AutoSize = true;
            this.lbVacuumValue02.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbVacuumValue02.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbVacuumValue02.Location = new System.Drawing.Point(219, 19);
            this.lbVacuumValue02.Name = "lbVacuumValue02";
            this.lbVacuumValue02.Size = new System.Drawing.Size(36, 15);
            this.lbVacuumValue02.TabIndex = 8;
            this.lbVacuumValue02.Text = "0.000";
            // 
            // cbVacummControl08
            // 
            this.cbVacummControl08.AutoSize = true;
            this.cbVacummControl08.Location = new System.Drawing.Point(142, 65);
            this.cbVacummControl08.Name = "cbVacummControl08";
            this.cbVacummControl08.Size = new System.Drawing.Size(67, 17);
            this.cbVacummControl08.TabIndex = 12;
            this.cbVacummControl08.Text = "Head 08";
            this.cbVacummControl08.UseVisualStyleBackColor = true;
            this.cbVacummControl08.CheckedChanged += new System.EventHandler(this.cbVacummControl08_CheckedChanged);
            // 
            // lbVacuumValue01
            // 
            this.lbVacuumValue01.AutoSize = true;
            this.lbVacuumValue01.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbVacuumValue01.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbVacuumValue01.Location = new System.Drawing.Point(78, 20);
            this.lbVacuumValue01.Name = "lbVacuumValue01";
            this.lbVacuumValue01.Size = new System.Drawing.Size(36, 15);
            this.lbVacuumValue01.TabIndex = 0;
            this.lbVacuumValue01.Text = "0.000";
            // 
            // cbVacummControl07
            // 
            this.cbVacummControl07.AutoSize = true;
            this.cbVacummControl07.Location = new System.Drawing.Point(6, 65);
            this.cbVacummControl07.Name = "cbVacummControl07";
            this.cbVacummControl07.Size = new System.Drawing.Size(67, 17);
            this.cbVacummControl07.TabIndex = 11;
            this.cbVacummControl07.Text = "Head 07";
            this.cbVacummControl07.UseVisualStyleBackColor = true;
            this.cbVacummControl07.CheckedChanged += new System.EventHandler(this.cbVacummControl07_CheckedChanged);
            // 
            // cbVacummControl01
            // 
            this.cbVacummControl01.AutoSize = true;
            this.cbVacummControl01.Location = new System.Drawing.Point(6, 19);
            this.cbVacummControl01.Name = "cbVacummControl01";
            this.cbVacummControl01.Size = new System.Drawing.Size(67, 17);
            this.cbVacummControl01.TabIndex = 5;
            this.cbVacummControl01.Text = "Head 01";
            this.cbVacummControl01.UseVisualStyleBackColor = true;
            this.cbVacummControl01.CheckedChanged += new System.EventHandler(this.cbVacummControl01_CheckedChanged);
            // 
            // cbVacummControl06
            // 
            this.cbVacummControl06.AutoSize = true;
            this.cbVacummControl06.Location = new System.Drawing.Point(279, 41);
            this.cbVacummControl06.Name = "cbVacummControl06";
            this.cbVacummControl06.Size = new System.Drawing.Size(67, 17);
            this.cbVacummControl06.TabIndex = 9;
            this.cbVacummControl06.Text = "Head 06";
            this.cbVacummControl06.UseVisualStyleBackColor = true;
            this.cbVacummControl06.CheckedChanged += new System.EventHandler(this.cbVacummControl06_CheckedChanged);
            // 
            // cbVacummControl05
            // 
            this.cbVacummControl05.AutoSize = true;
            this.cbVacummControl05.Location = new System.Drawing.Point(142, 42);
            this.cbVacummControl05.Name = "cbVacummControl05";
            this.cbVacummControl05.Size = new System.Drawing.Size(67, 17);
            this.cbVacummControl05.TabIndex = 10;
            this.cbVacummControl05.Text = "Head 05";
            this.cbVacummControl05.UseVisualStyleBackColor = true;
            this.cbVacummControl05.CheckedChanged += new System.EventHandler(this.cbVacummControl05_CheckedChanged);
            // 
            // cbVacummControl02
            // 
            this.cbVacummControl02.AutoSize = true;
            this.cbVacummControl02.Location = new System.Drawing.Point(142, 19);
            this.cbVacummControl02.Name = "cbVacummControl02";
            this.cbVacummControl02.Size = new System.Drawing.Size(67, 17);
            this.cbVacummControl02.TabIndex = 7;
            this.cbVacummControl02.Text = "Head 02";
            this.cbVacummControl02.UseVisualStyleBackColor = true;
            this.cbVacummControl02.CheckedChanged += new System.EventHandler(this.cbVacummControl02_CheckedChanged);
            // 
            // cbVacummControl03
            // 
            this.cbVacummControl03.AutoSize = true;
            this.cbVacummControl03.Location = new System.Drawing.Point(279, 18);
            this.cbVacummControl03.Name = "cbVacummControl03";
            this.cbVacummControl03.Size = new System.Drawing.Size(67, 17);
            this.cbVacummControl03.TabIndex = 8;
            this.cbVacummControl03.Text = "Head 03";
            this.cbVacummControl03.UseVisualStyleBackColor = true;
            this.cbVacummControl03.CheckedChanged += new System.EventHandler(this.cbVacummControl03_CheckedChanged);
            // 
            // cbVacummControl04
            // 
            this.cbVacummControl04.AutoSize = true;
            this.cbVacummControl04.Location = new System.Drawing.Point(6, 42);
            this.cbVacummControl04.Name = "cbVacummControl04";
            this.cbVacummControl04.Size = new System.Drawing.Size(67, 17);
            this.cbVacummControl04.TabIndex = 6;
            this.cbVacummControl04.Text = "Head 04";
            this.cbVacummControl04.UseVisualStyleBackColor = true;
            this.cbVacummControl04.CheckedChanged += new System.EventHandler(this.cbVacummControl04_CheckedChanged);
            // 
            // gbVisionConfig
            // 
            this.gbVisionConfig.Controls.Add(this.cbCamNum);
            this.gbVisionConfig.Controls.Add(this.cbVisionLightCam04);
            this.gbVisionConfig.Controls.Add(this.cbVisionLightCam06);
            this.gbVisionConfig.Controls.Add(this.cbVisionLightCam05);
            this.gbVisionConfig.Controls.Add(this.cbVisionLightCam03);
            this.gbVisionConfig.Controls.Add(this.cbVisionLightCam02);
            this.gbVisionConfig.Controls.Add(this.tabControl3);
            this.gbVisionConfig.Controls.Add(this.cbVisionLightCam01);
            this.gbVisionConfig.Location = new System.Drawing.Point(338, 6);
            this.gbVisionConfig.Name = "gbVisionConfig";
            this.gbVisionConfig.Size = new System.Drawing.Size(419, 183);
            this.gbVisionConfig.TabIndex = 1;
            this.gbVisionConfig.TabStop = false;
            this.gbVisionConfig.Text = "Vision System Configuration";
            // 
            // cbCamNum
            // 
            this.cbCamNum.FormattingEnabled = true;
            this.cbCamNum.Items.AddRange(new object[] {
            "CAMERA No.1",
            "CAMERA No.2",
            "CAMERA No.3",
            "CAMERA No.4"});
            this.cbCamNum.Location = new System.Drawing.Point(10, 20);
            this.cbCamNum.Name = "cbCamNum";
            this.cbCamNum.Size = new System.Drawing.Size(117, 21);
            this.cbCamNum.TabIndex = 3;
            this.cbCamNum.SelectedIndexChanged += new System.EventHandler(this.cbCamNum_SelectedIndexChanged);
            // 
            // cbVisionLightCam04
            // 
            this.cbVisionLightCam04.AutoSize = true;
            this.cbVisionLightCam04.Location = new System.Drawing.Point(136, 42);
            this.cbVisionLightCam04.Name = "cbVisionLightCam04";
            this.cbVisionLightCam04.Size = new System.Drawing.Size(82, 17);
            this.cbVisionLightCam04.TabIndex = 8;
            this.cbVisionLightCam04.Text = "LightCam04";
            this.cbVisionLightCam04.UseVisualStyleBackColor = true;
            this.cbVisionLightCam04.CheckedChanged += new System.EventHandler(this.cbVisionLightCam04_CheckedChanged);
            // 
            // cbVisionLightCam06
            // 
            this.cbVisionLightCam06.AutoSize = true;
            this.cbVisionLightCam06.Location = new System.Drawing.Point(321, 42);
            this.cbVisionLightCam06.Name = "cbVisionLightCam06";
            this.cbVisionLightCam06.Size = new System.Drawing.Size(82, 17);
            this.cbVisionLightCam06.TabIndex = 9;
            this.cbVisionLightCam06.Text = "LightCam06";
            this.cbVisionLightCam06.UseVisualStyleBackColor = true;
            this.cbVisionLightCam06.CheckedChanged += new System.EventHandler(this.cbVisionLightCam06_CheckedChanged);
            // 
            // cbVisionLightCam05
            // 
            this.cbVisionLightCam05.AutoSize = true;
            this.cbVisionLightCam05.Location = new System.Drawing.Point(227, 42);
            this.cbVisionLightCam05.Name = "cbVisionLightCam05";
            this.cbVisionLightCam05.Size = new System.Drawing.Size(82, 17);
            this.cbVisionLightCam05.TabIndex = 8;
            this.cbVisionLightCam05.Text = "LightCam05";
            this.cbVisionLightCam05.UseVisualStyleBackColor = true;
            this.cbVisionLightCam05.CheckedChanged += new System.EventHandler(this.cbVisionLightCam05_CheckedChanged);
            // 
            // cbVisionLightCam03
            // 
            this.cbVisionLightCam03.AutoSize = true;
            this.cbVisionLightCam03.Location = new System.Drawing.Point(321, 19);
            this.cbVisionLightCam03.Name = "cbVisionLightCam03";
            this.cbVisionLightCam03.Size = new System.Drawing.Size(82, 17);
            this.cbVisionLightCam03.TabIndex = 7;
            this.cbVisionLightCam03.Text = "LightCam03";
            this.cbVisionLightCam03.UseVisualStyleBackColor = true;
            this.cbVisionLightCam03.CheckedChanged += new System.EventHandler(this.cbVisionLightCam03_CheckedChanged);
            // 
            // cbVisionLightCam02
            // 
            this.cbVisionLightCam02.AutoSize = true;
            this.cbVisionLightCam02.Location = new System.Drawing.Point(227, 19);
            this.cbVisionLightCam02.Name = "cbVisionLightCam02";
            this.cbVisionLightCam02.Size = new System.Drawing.Size(82, 17);
            this.cbVisionLightCam02.TabIndex = 6;
            this.cbVisionLightCam02.Text = "LightCam02";
            this.cbVisionLightCam02.UseVisualStyleBackColor = true;
            this.cbVisionLightCam02.CheckedChanged += new System.EventHandler(this.cbVisionLightCam02_CheckedChanged);
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage7);
            this.tabControl3.Controls.Add(this.tabPage8);
            this.tabControl3.Location = new System.Drawing.Point(6, 65);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(407, 104);
            this.tabControl3.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.txtCalibV);
            this.tabPage7.Controls.Add(this.label6);
            this.tabPage7.Controls.Add(this.txtCalibR);
            this.tabPage7.Controls.Add(this.label5);
            this.tabPage7.Controls.Add(this.txtCalibZ);
            this.tabPage7.Controls.Add(this.btnGetPosCalib);
            this.tabPage7.Controls.Add(this.label4);
            this.tabPage7.Controls.Add(this.txtCalibY);
            this.tabPage7.Controls.Add(this.txtCalibX);
            this.tabPage7.Controls.Add(this.btnSavePosCalib);
            this.tabPage7.Controls.Add(this.label3);
            this.tabPage7.Controls.Add(this.btnMovePosCalib);
            this.tabPage7.Controls.Add(this.label2);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(399, 78);
            this.tabPage7.TabIndex = 0;
            this.tabPage7.Text = "Calibration Position";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // txtCalibV
            // 
            this.txtCalibV.Location = new System.Drawing.Point(342, 10);
            this.txtCalibV.Name = "txtCalibV";
            this.txtCalibV.Size = new System.Drawing.Size(48, 20);
            this.txtCalibV.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "V :";
            // 
            // txtCalibR
            // 
            this.txtCalibR.Location = new System.Drawing.Point(262, 10);
            this.txtCalibR.Name = "txtCalibR";
            this.txtCalibR.Size = new System.Drawing.Size(47, 20);
            this.txtCalibR.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "R :";
            // 
            // txtCalibZ
            // 
            this.txtCalibZ.Location = new System.Drawing.Point(183, 10);
            this.txtCalibZ.Name = "txtCalibZ";
            this.txtCalibZ.Size = new System.Drawing.Size(48, 20);
            this.txtCalibZ.TabIndex = 5;
            // 
            // btnGetPosCalib
            // 
            this.btnGetPosCalib.Location = new System.Drawing.Point(24, 48);
            this.btnGetPosCalib.Name = "btnGetPosCalib";
            this.btnGetPosCalib.Size = new System.Drawing.Size(75, 23);
            this.btnGetPosCalib.TabIndex = 4;
            this.btnGetPosCalib.Text = "Get Position";
            this.btnGetPosCalib.UseVisualStyleBackColor = true;
            this.btnGetPosCalib.Click += new System.EventHandler(this.btnGetPosCalib_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Z :";
            // 
            // txtCalibY
            // 
            this.txtCalibY.Location = new System.Drawing.Point(104, 10);
            this.txtCalibY.Name = "txtCalibY";
            this.txtCalibY.Size = new System.Drawing.Size(47, 20);
            this.txtCalibY.TabIndex = 4;
            // 
            // txtCalibX
            // 
            this.txtCalibX.BackColor = System.Drawing.Color.White;
            this.txtCalibX.Location = new System.Drawing.Point(29, 10);
            this.txtCalibX.Name = "txtCalibX";
            this.txtCalibX.Size = new System.Drawing.Size(47, 20);
            this.txtCalibX.TabIndex = 3;
            // 
            // btnSavePosCalib
            // 
            this.btnSavePosCalib.Location = new System.Drawing.Point(114, 48);
            this.btnSavePosCalib.Name = "btnSavePosCalib";
            this.btnSavePosCalib.Size = new System.Drawing.Size(75, 23);
            this.btnSavePosCalib.TabIndex = 5;
            this.btnSavePosCalib.Text = "Save";
            this.btnSavePosCalib.UseVisualStyleBackColor = true;
            this.btnSavePosCalib.Click += new System.EventHandler(this.btnSavePosCalib_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Y:";
            // 
            // btnMovePosCalib
            // 
            this.btnMovePosCalib.Location = new System.Drawing.Point(209, 48);
            this.btnMovePosCalib.Name = "btnMovePosCalib";
            this.btnMovePosCalib.Size = new System.Drawing.Size(75, 23);
            this.btnMovePosCalib.TabIndex = 3;
            this.btnMovePosCalib.Text = "Move";
            this.btnMovePosCalib.UseVisualStyleBackColor = true;
            this.btnMovePosCalib.Click += new System.EventHandler(this.btnMovePosCalib_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "X :";
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(399, 78);
            this.tabPage8.TabIndex = 1;
            this.tabPage8.Text = "tabPage8";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // cbVisionLightCam01
            // 
            this.cbVisionLightCam01.AutoSize = true;
            this.cbVisionLightCam01.Location = new System.Drawing.Point(136, 19);
            this.cbVisionLightCam01.Name = "cbVisionLightCam01";
            this.cbVisionLightCam01.Size = new System.Drawing.Size(82, 17);
            this.cbVisionLightCam01.TabIndex = 5;
            this.cbVisionLightCam01.Text = "LightCam01";
            this.cbVisionLightCam01.UseVisualStyleBackColor = true;
            this.cbVisionLightCam01.CheckedChanged += new System.EventHandler(this.cbVisionLightCam01_CheckedChanged);
            // 
            // gbHeadConfig
            // 
            this.gbHeadConfig.Controls.Add(this.btnMoveHead);
            this.gbHeadConfig.Controls.Add(this.label1);
            this.gbHeadConfig.Controls.Add(this.btnHeadSave);
            this.gbHeadConfig.Controls.Add(this.btnGetHeadPos);
            this.gbHeadConfig.Controls.Add(this.cbHeadNum);
            this.gbHeadConfig.Controls.Add(this.txtHeadV);
            this.gbHeadConfig.Location = new System.Drawing.Point(343, 196);
            this.gbHeadConfig.Name = "gbHeadConfig";
            this.gbHeadConfig.Size = new System.Drawing.Size(419, 52);
            this.gbHeadConfig.TabIndex = 0;
            this.gbHeadConfig.TabStop = false;
            this.gbHeadConfig.Text = "Head Configuration";
            // 
            // btnMoveHead
            // 
            this.btnMoveHead.Location = new System.Drawing.Point(102, 19);
            this.btnMoveHead.Name = "btnMoveHead";
            this.btnMoveHead.Size = new System.Drawing.Size(54, 23);
            this.btnMoveHead.TabIndex = 6;
            this.btnMoveHead.Text = "Move";
            this.btnMoveHead.UseVisualStyleBackColor = true;
            this.btnMoveHead.Click += new System.EventHandler(this.btnMoveHead_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "V:";
            // 
            // btnHeadSave
            // 
            this.btnHeadSave.Location = new System.Drawing.Point(306, 20);
            this.btnHeadSave.Name = "btnHeadSave";
            this.btnHeadSave.Size = new System.Drawing.Size(73, 23);
            this.btnHeadSave.TabIndex = 5;
            this.btnHeadSave.Text = "Save";
            this.btnHeadSave.UseVisualStyleBackColor = true;
            this.btnHeadSave.Click += new System.EventHandler(this.btnHeadSave_Click);
            // 
            // btnGetHeadPos
            // 
            this.btnGetHeadPos.Location = new System.Drawing.Point(246, 20);
            this.btnGetHeadPos.Name = "btnGetHeadPos";
            this.btnGetHeadPos.Size = new System.Drawing.Size(54, 23);
            this.btnGetHeadPos.TabIndex = 5;
            this.btnGetHeadPos.Text = "Get";
            this.btnGetHeadPos.UseVisualStyleBackColor = true;
            this.btnGetHeadPos.Click += new System.EventHandler(this.btnGetHeadPos_Click);
            // 
            // cbHeadNum
            // 
            this.cbHeadNum.FormattingEnabled = true;
            this.cbHeadNum.Items.AddRange(new object[] {
            "Head NO.01",
            "Head NO.02",
            "Head NO.03",
            "Head NO.04",
            "Head NO.05",
            "Head NO.06",
            "Head NO.07",
            "Head NO.08",
            "Head NO.09"});
            this.cbHeadNum.Location = new System.Drawing.Point(10, 19);
            this.cbHeadNum.Name = "cbHeadNum";
            this.cbHeadNum.Size = new System.Drawing.Size(86, 21);
            this.cbHeadNum.TabIndex = 0;
            this.cbHeadNum.SelectedIndexChanged += new System.EventHandler(this.cbHeadNum_SelectedIndexChanged);
            // 
            // txtHeadV
            // 
            this.txtHeadV.Location = new System.Drawing.Point(185, 21);
            this.txtHeadV.Name = "txtHeadV";
            this.txtHeadV.Size = new System.Drawing.Size(55, 20);
            this.txtHeadV.TabIndex = 3;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(763, 655);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // gbErrMsg
            // 
            this.gbErrMsg.Controls.Add(this.LstErrMsg);
            this.gbErrMsg.Controls.Add(this.btnClearErrMsg);
            this.gbErrMsg.Location = new System.Drawing.Point(12, 508);
            this.gbErrMsg.Name = "gbErrMsg";
            this.gbErrMsg.Size = new System.Drawing.Size(253, 84);
            this.gbErrMsg.TabIndex = 3;
            this.gbErrMsg.TabStop = false;
            this.gbErrMsg.Text = "Error Message";
            // 
            // LstErrMsg
            // 
            this.LstErrMsg.FormattingEnabled = true;
            this.LstErrMsg.Location = new System.Drawing.Point(6, 20);
            this.LstErrMsg.Name = "LstErrMsg";
            this.LstErrMsg.Size = new System.Drawing.Size(241, 30);
            this.LstErrMsg.TabIndex = 4;
            // 
            // btnClearErrMsg
            // 
            this.btnClearErrMsg.Location = new System.Drawing.Point(81, 56);
            this.btnClearErrMsg.Name = "btnClearErrMsg";
            this.btnClearErrMsg.Size = new System.Drawing.Size(75, 23);
            this.btnClearErrMsg.TabIndex = 4;
            this.btnClearErrMsg.Text = "Clear";
            this.btnClearErrMsg.UseVisualStyleBackColor = true;
            this.btnClearErrMsg.Click += new System.EventHandler(this.btnClearErrMsg_Click);
            // 
            // TimAutoFeed
            // 
            this.TimAutoFeed.Tick += new System.EventHandler(this.TimAutoFeed_Tick);
            // 
            // MachineConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 753);
            this.Controls.Add(this.gbErrMsg);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.gbMotionControl);
            this.Controls.Add(this.gbEtherCAT);
            this.Name = "MachineConfig";
            this.Text = "MachineConfig";
            this.Load += new System.EventHandler(this.MachineConfig_Load);
            this.gbEtherCAT.ResumeLayout(false);
            this.gbMotionControl.ResumeLayout(false);
            this.gbMotionControl.PerformLayout();
            this.tcMotionControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.gbConveyor.ResumeLayout(false);
            this.gbConveyor.PerformLayout();
            this.gbFeederControl.ResumeLayout(false);
            this.gbFeederControl.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.gbHeadOffsetConfig.ResumeLayout(false);
            this.gbHeadOffsetConfig.PerformLayout();
            this.tabHeadOffset.ResumeLayout(false);
            this.tabHeadOffsetCAM0403.ResumeLayout(false);
            this.tabHeadOffsetCAM0403.PerformLayout();
            this.tabPage10.ResumeLayout(false);
            this.tabPage10.PerformLayout();
            this.gbVisionControl.ResumeLayout(false);
            this.gbVisionControl.PerformLayout();
            this.gbVaccumControl.ResumeLayout(false);
            this.gbVaccumControl.PerformLayout();
            this.gbVisionConfig.ResumeLayout(false);
            this.gbVisionConfig.PerformLayout();
            this.tabControl3.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.gbHeadConfig.ResumeLayout(false);
            this.gbHeadConfig.PerformLayout();
            this.gbErrMsg.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEtherCAT;
        private System.Windows.Forms.Button btnEtherCATInt;
        private System.Windows.Forms.TabControl tcMotionControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnServoRobotOFF;
        private System.Windows.Forms.Button btnServoRobotON;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtAxis_V;
        private System.Windows.Forms.CheckBox cbServo_Z;
        private System.Windows.Forms.TextBox txtAxis_R;
        private System.Windows.Forms.TextBox txtAxis_X;
        private System.Windows.Forms.TextBox txtAxis_Y;
        private System.Windows.Forms.CheckBox cbServo_R;
        private System.Windows.Forms.CheckBox cbServo_X;
        private System.Windows.Forms.TextBox txtAxis_Z;
        private System.Windows.Forms.CheckBox cbServo_Y;
        private System.Windows.Forms.CheckBox cbServo_V;
        private System.Windows.Forms.Label lbTarget;
        private System.Windows.Forms.Button btnServo_C4_Move;
        private System.Windows.Forms.Label lbCurrent;
        private System.Windows.Forms.CheckBox cbServo_C1;
        private System.Windows.Forms.TextBox txtAxis_C1;
        private System.Windows.Forms.TextBox txtServo_C3_Target;
        private System.Windows.Forms.Button btnServo_C3_Move;
        private System.Windows.Forms.TextBox txtServo_C4_Target;
        private System.Windows.Forms.TextBox txtAxis_C2;
        private System.Windows.Forms.CheckBox cbServo_C2;
        private System.Windows.Forms.CheckBox cbServo_C4;
        private System.Windows.Forms.TextBox txtAxis_C4;
        private System.Windows.Forms.TextBox txtServo_C2_Target;
        private System.Windows.Forms.Button btnServo_C2_Move;
        private System.Windows.Forms.Button btnServo_C1_Move;
        private System.Windows.Forms.TextBox txtServo_C1_Target;
        private System.Windows.Forms.TextBox txtAxis_C3;
        private System.Windows.Forms.CheckBox cbServo_C3;
        private System.Windows.Forms.Button btnSave_Con_Spd;
        private System.Windows.Forms.TextBox txtC4_spd;
        private System.Windows.Forms.CheckBox cbCon_C1;
        private System.Windows.Forms.TextBox txtC3_spd;
        private System.Windows.Forms.CheckBox cbCon_C2;
        private System.Windows.Forms.TextBox txtC2_spd;
        private System.Windows.Forms.CheckBox cbCon_C3;
        private System.Windows.Forms.TextBox txtC1_spd;
        private System.Windows.Forms.CheckBox cbCon_C4;
        private System.Windows.Forms.CheckBox cbStopperC4;
        private System.Windows.Forms.CheckBox cbStopperC1;
        private System.Windows.Forms.CheckBox cbStopperC3;
        private System.Windows.Forms.CheckBox cbStopperC2;
        private System.Windows.Forms.Button btnJOG_V_N;
        private System.Windows.Forms.Button btnJOG_R_N;
        private System.Windows.Forms.Button btnJOG_V_P;
        private System.Windows.Forms.Button btnJOG_R_P;
        private System.Windows.Forms.Button btnJOG_Y_P;
        private System.Windows.Forms.Label lbAxisName_V;
        private System.Windows.Forms.Button btnJOG_Y_N;
        private System.Windows.Forms.Button btnJOG_X_N;
        private System.Windows.Forms.Label lbAxisName_R;
        private System.Windows.Forms.Label lbAxisName_Z;
        private System.Windows.Forms.Button btnJOG_X_P;
        private System.Windows.Forms.Label lbAxisName_Y;
        private System.Windows.Forms.Label lbAxisName_X;
        private System.Windows.Forms.Button btnHomeV;
        private System.Windows.Forms.Button btnHomeR;
        private System.Windows.Forms.Button btnJOG_Z_N;
        private System.Windows.Forms.Button btnJOG_Z_P;
        private System.Windows.Forms.Button btnHomeRobot;
        private System.Windows.Forms.RadioButton rdbMove_Step;
        private System.Windows.Forms.RadioButton rdbMove_Con;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox gbFeederControl;
        private System.Windows.Forms.Button btnFeedStop;
        private System.Windows.Forms.Button btnFeederJOG;
        private System.Windows.Forms.Button btnAutoFeed;
        private System.Windows.Forms.Label lbSensorLB04;
        private System.Windows.Forms.Label lbSensorLB01;
        private System.Windows.Forms.Label lbSensorLB03;
        private System.Windows.Forms.Label lbSensorLB02;
        private System.Windows.Forms.Button btSensorLBRead;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.GroupBox gbConveyor;
        private System.Windows.Forms.CheckBox chbRealTimeSensorLB;
        private System.Windows.Forms.GroupBox gbVisionConfig;
        private System.Windows.Forms.GroupBox gbHeadConfig;
        private System.Windows.Forms.GroupBox gbVaccumControl;
        private System.Windows.Forms.Label lbVacuumValue09;
        private System.Windows.Forms.Label lbVacuumValue08;
        private System.Windows.Forms.Label lbVacuumValue07;
        private System.Windows.Forms.Label lbVacuumValue06;
        private System.Windows.Forms.Label lbVacuumValue05;
        private System.Windows.Forms.Label lbVacuumValue04;
        private System.Windows.Forms.Label lbVacuumValue03;
        private System.Windows.Forms.CheckBox cbVacummControl09;
        private System.Windows.Forms.Label lbVacuumValue02;
        private System.Windows.Forms.CheckBox cbVacummControl08;
        private System.Windows.Forms.Label lbVacuumValue01;
        private System.Windows.Forms.CheckBox cbVacummControl07;
        private System.Windows.Forms.CheckBox cbVacummControl01;
        private System.Windows.Forms.CheckBox cbVacummControl06;
        private System.Windows.Forms.CheckBox cbVacummControl05;
        private System.Windows.Forms.CheckBox cbVacummControl02;
        private System.Windows.Forms.CheckBox cbVacummControl03;
        private System.Windows.Forms.CheckBox cbVacummControl04;
        private System.Windows.Forms.Button btnMoveHead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHeadSave;
        private System.Windows.Forms.Button btnGetHeadPos;
        private System.Windows.Forms.ComboBox cbHeadNum;
        private System.Windows.Forms.TextBox txtHeadV;
        private System.Windows.Forms.CheckBox cbVisionLightCam01;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TextBox txtCalibV;
        private System.Windows.Forms.TextBox txtCalibR;
        private System.Windows.Forms.TextBox txtCalibZ;
        private System.Windows.Forms.CheckBox cbVisionLightCam04;
        private System.Windows.Forms.CheckBox cbVisionLightCam06;
        private System.Windows.Forms.CheckBox cbVisionLightCam05;
        private System.Windows.Forms.TextBox txtCalibY;
        private System.Windows.Forms.CheckBox cbVisionLightCam03;
        private System.Windows.Forms.CheckBox cbVisionLightCam02;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGetPosCalib;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCalibX;
        private System.Windows.Forms.Button btnSavePosCalib;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMovePosCalib;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbErrMsg;
        private System.Windows.Forms.Button btnClearErrMsg;
        private System.Windows.Forms.ListBox LstErrMsg;
        private System.Windows.Forms.GroupBox gbMotionControl;
        private System.Windows.Forms.Button btnResetALL;
        private System.Windows.Forms.Label lbSensorRoll;
        private System.Windows.Forms.Button btnIniFeedder;
        private System.Windows.Forms.ComboBox cbFeederNum;
        private System.Windows.Forms.ComboBox cbCamNum;
        private System.Windows.Forms.Button btnReleaseROLL;
        private System.Windows.Forms.Button btnLoadROLL;
        private System.Windows.Forms.TextBox txtDis_Step;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Button btnMoveWidthCon;
        private System.Windows.Forms.Button btnSaveWidthCon;
        private System.Windows.Forms.Button btnGetWidthCon;
        private System.Windows.Forms.ComboBox cbConIndex;
        private System.Windows.Forms.RadioButton rdbBoard;
        private System.Windows.Forms.RadioButton rdbCalib;
        private System.Windows.Forms.GroupBox gbVisionControl;
        private System.Windows.Forms.Button btnVisionStop;
        private System.Windows.Forms.Button btnVisionOpen;
        private System.Windows.Forms.Button btnVisionLauch;
        private NationalInstruments.Vision.WindowsForms.ImageViewer imvInspetion;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbHeadOffsetConfig;
        private System.Windows.Forms.Button btnCaptureHeadError;
        private System.Windows.Forms.TextBox txtHeadOffsetY;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtHeadOffsetX;
        private System.Windows.Forms.Button btnDel_GeoData;
        private System.Windows.Forms.Button btnAdd_GeoDate;
        private System.Windows.Forms.Button btnLastSqCal;
        private System.Windows.Forms.TextBox txt_Geo_Xc;
        private System.Windows.Forms.TextBox txt_Geo_Yc;
        private System.Windows.Forms.TextBox txt_Geo_rc;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ListView lvHeadOffset_Geo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSaveErr;
        private System.Windows.Forms.TabControl tabHeadOffset;
        private System.Windows.Forms.TabPage tabHeadOffsetCAM0403;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_OrgCam_x;
        private System.Windows.Forms.TextBox txt_OrgCam_y;
        private System.Windows.Forms.Button btnSaveCAMorg;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCam_CoTheta_P2x;
        private System.Windows.Forms.TextBox txtCam_CoTheta_P2y;
        private System.Windows.Forms.TextBox txtCam_CoTheta_P1x;
        private System.Windows.Forms.TextBox txtCam_CoTheta_P1y;
        private System.Windows.Forms.TextBox txtCam_CoTheta_org;
        private System.Windows.Forms.Label lbCam_CoTheta_org;
        private System.Windows.Forms.Button btnAdd_CoTheta_P2;
        private System.Windows.Forms.Button btnAdd_CoTheta_P1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCal_CoTheta_org;
        private System.Windows.Forms.Label lbVisionConfigFileName;
        private System.Windows.Forms.Button btnMoveCamORG;
        private System.Windows.Forms.TextBox txtCam_org_V;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCam_org_R;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCam_org_Z;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtCam_org_Y;
        private System.Windows.Forms.TextBox txtCam_org_X;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtCamOffsetX;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCamOffsetY;
        private System.Windows.Forms.Button btnCaptureCamError;
        private System.Windows.Forms.Button btnSaveOffsetCamOrg;
        private System.Windows.Forms.Button btnGetCamOrg;
        private System.Windows.Forms.Button btnLoadDataCamOffset;
        private System.Windows.Forms.Button btnSave_CoTheta_org;
        private System.Windows.Forms.Label lbCamoffset_CoTheta_org;
        private System.Windows.Forms.TextBox txtCamOffsetTheta;
        private System.Windows.Forms.Button btnSavePosPic;
        private System.Windows.Forms.ComboBox cbPickNum;
        private System.Windows.Forms.Button btnGetPosPick;
        private System.Windows.Forms.TextBox txtAxisPicY;
        private System.Windows.Forms.TextBox txtAxisPicX;
        private System.Windows.Forms.Label lbAxisY;
        private System.Windows.Forms.Label lbAxisX;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Timer TimCheckStatus;
        private System.Windows.Forms.Button btnAutoFeeder;
        private System.Windows.Forms.Timer TimAutoFeed;
    }
}