using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLabelMachine//.Class.EtherCAT
{
    class IO_EtherCAT
    {
        //----------------------------Vacuum------------------------------------
        public static int[] OUTPUT_DO_VACUUM_NODE = new int[]
        {
            17,17,17,17,17,17,17,17,17
        };
        public static int[] OUTPUT_DO_VACUUM_BIT = new int[]
        {
            0,1,2,3,4,5,6,7,8
        };
        public static int[] INPUT_DI_VACUUM_NODE = new int[]
{
            3,3,3,3,3,3,3,3,3
};
        public static int[] INPUT_DI_VACUUM_BIT = new int[]
        {
            0,1,2,3,4,5,6,7,8
        };
        public static int[] INPUT_AI_VACUUM_NODE = new int[]
        {
            24,24,24,25,25,25,25,26,26
        };
        public static int[] INPUT_AI_VACUUM_CH = new int[]
{
            1,2,3,0,1,2,3,0,1
};
        public enum OUTPUT_DO_VACUUM_01 { NodeID = 17, BitID = 0 }
        public enum INPUT_AI_VACUUM_01 { NodeID = 24, ChID = 1 }
        public enum INPUT_DI_VACUUM_01 { NodeID = 3, BitID = 0 }

        public enum OUTPUT_DO_VACUUM_02 { NodeID = 17, BitID = 1 }
        public enum INPUT_AI_VACUUM_02 { NodeID = 24, ChID = 2 }
        public enum INPUT_DI_VACUUM_02 { NodeID = 3, BitID = 1 }

        public enum OUTPUT_DO_VACUUM_03 { NodeID = 17, BitID = 2 }
        public enum INPUT_AI_VACUUM_03 { NodeID = 24, ChID = 3 }
        public enum INPUT_DI_VACUUM_03 { NodeID = 3, BitID = 2 }

        public enum OUTPUT_DO_VACUUM_04 { NodeID = 17, BitID = 3 }
        public enum INPUT_AI_VACUUM_04 { NodeID = 25, ChID = 0 }
        public enum INPUT_DI_VACUUM_04 { NodeID = 3, BitID = 3 }

        public enum OUTPUT_DO_VACUUM_05 { NodeID = 17, BitID = 4 }
        public enum INPUT_AI_VACUUM_05 { NodeID = 25, ChID = 1 }
        public enum INPUT_DI_VACUUM_05 { NodeID = 3, BitID = 4 }

        public enum OUTPUT_DO_VACUUM_06 { NodeID = 17, BitID = 5 }
        public enum INPUT_AI_VACUUM_06 { NodeID = 25, ChID = 2 }
        public enum INPUT_DI_VACUUM_06 { NodeID = 3, BitID = 5 }

        public enum OUTPUT_DO_VACUUM_07 { NodeID = 17, BitID = 6 }
        public enum INPUT_AI_VACUUM_07 { NodeID = 25, ChID = 3 }
        public enum INPUT_DI_VACUUM_07 { NodeID = 3, BitID = 6 }

        public enum OUTPUT_DO_VACUUM_08 { NodeID = 17, BitID = 7 }
        public enum INPUT_AI_VACUUM_08 { NodeID = 26, ChID = 0 }
        public enum INPUT_DI_VACUUM_08 { NodeID = 3, BitID = 7 }

        public enum OUTPUT_DO_VACUUM_09 { NodeID = 17, BitID = 8 }
        public enum INPUT_AI_VACUUM_09 { NodeID = 26, ChID = 1 }
        public enum INPUT_DI_VACUUM_09 { NodeID = 3, BitID = 8 }

        //-----------------------------------------Lighting---------------------------------------

        public enum OUTPUT_DO_LIGHTING_L1 { NodeID = 16, BitID = 8 }
        public enum OUTPUT_DO_LIGHTING_L2 { NodeID = 16, BitID = 9 }
        public enum OUTPUT_DO_LIGHTING_L3 { NodeID = 16, BitID = 10 }
        public enum OUTPUT_DO_LIGHTING_L4 { NodeID = 16, BitID = 11 }
        public enum OUTPUT_DO_LIGHTING_L5 { NodeID = 16, BitID = 14 }
        public enum OUTPUT_DO_LIGHTING_L6 { NodeID = 16, BitID = 15 }

        //---------------------------------------------Feedder-------------------------------------------------

        public static ushort[] OUTPUT_PO_FEEDDER_CON_NODE = new ushort[]
        {
            28,28,30,30,32,32,34,34
        };
        public static ushort[] OUTPUT_PO_FEEDDER_ROLL_NODE = new ushort[]
        {
            29,29,31,31,33,33,35,35
       };
        public enum OUTPUT_PO_FEEDDER_01 { ConNodeID = 28, RollNodeID = 29 }
        public enum OUTPUT_PO_FEEDDER_02 { ConNodeID = 28, RollNodeID = 29 }
        public enum OUTPUT_PO_FEEDDER_03 { ConNodeID = 30, RollNodeID = 31 }
        public enum OUTPUT_PO_FEEDDER_04 { ConNodeID = 30, RollNodeID = 31 }
        public enum OUTPUT_PO_FEEDDER_05 { ConNodeID = 32, RollNodeID = 33 }
        public enum OUTPUT_PO_FEEDDER_06 { ConNodeID = 32, RollNodeID = 33 }
        public enum OUTPUT_PO_FEEDDER_07 { ConNodeID = 34, RollNodeID = 35 }
        public enum OUTPUT_PO_FEEDDER_08 { ConNodeID = 34, RollNodeID = 35 }



        //------------disable_Conveyor_Label------------
        public static ushort[] OUTPUT_DO_DISABLE_CON_NODE = new ushort[]
                {
                    20,20,20,20,20,20,20,20
                };
        public static ushort[] OUTPUT_DO_DISABLE_CON_BIT = new ushort[]
         {
                    0,2,4,6,8,10,12,14
         };
        public enum OUTPUT_DO_DISABLE_CON_01 { NodeID = 20, BitID = 0 }
        public enum OUTPUT_DO_DISABLE_CON_02 { NodeID = 20, BitID = 2 }
        public enum OUTPUT_DO_DISABLE_CON_03 { NodeID = 20, BitID = 4 }
        public enum OUTPUT_DO_DISABLE_CON_04 { NodeID = 20, BitID = 6 }
        public enum OUTPUT_DO_DISABLE_CON_05 { NodeID = 20, BitID = 8 }
        public enum OUTPUT_DO_DISABLE_CON_06 { NodeID = 20, BitID = 10 }
        public enum OUTPUT_DO_DISABLE_CON_07 { NodeID = 20, BitID = 12 }
        public enum OUTPUT_DO_DISABLE_CON_08 { NodeID = 20, BitID = 14 }

        //------------disable_Feed_label------------
        public static ushort[] OUTPUT_DO_DISABLE_ROLL_NODE = new ushort[]
        {
                    20,20,20,20,20,20,20,20
        };
        public static ushort[] OUTPUT_DO_DISABLE_ROLL_BIT = new ushort[]
         {
                    1,3,5,7,9,11,13,15
         };
        public enum OUTPUT_DO_DISABLE_FEED_01 { NodeID = 20, BitID = 1 }
        public enum OUTPUT_DO_DISABLE_FEED_02 { NodeID = 20, BitID = 3 }
        public enum OUTPUT_DO_DISABLE_FEED_03 { NodeID = 20, BitID = 5 }
        public enum OUTPUT_DO_DISABLE_FEED_04 { NodeID = 20, BitID = 7 }
        public enum OUTPUT_DO_DISABLE_FEED_05 { NodeID = 20, BitID = 9 }
        public enum OUTPUT_DO_DISABLE_FEED_06 { NodeID = 20, BitID = 11 }
        public enum OUTPUT_DO_DISABLE_FEED_07 { NodeID = 20, BitID = 13 }
        public enum OUTPUT_DO_DISABLE_FEED_08 { NodeID = 20, BitID = 15 }

        //------------Cylinder_Feedder------------
        public static ushort[] OUTPUT_DO_RELEASE_ROLL_NODE = new ushort[]
        {
            16,16,16,16,15,15,15,15
        };
        public static ushort[] OUTPUT_DO_RELEASE_ROLL_BIT = new ushort[]
        {
            0,1,2,3,12,13,14,15
        };
        public enum OUTPUT_DO_CYQ { NodeID = 16, BitID = 0 } // Cylinder Feedder 01
        public enum OUTPUT_DO_CYR { NodeID = 16, BitID = 1 }
        public enum OUTPUT_DO_CYS { NodeID = 16, BitID = 2 }
        public enum OUTPUT_DO_CYT { NodeID = 16, BitID = 3 }
        public enum OUTPUT_DO_CYM { NodeID = 15, BitID = 12 }
        public enum OUTPUT_DO_CYN { NodeID = 15, BitID = 13 }
        public enum OUTPUT_DO_CYO { NodeID = 15, BitID = 14 }
        public enum OUTPUT_DO_CYP { NodeID = 15, BitID = 15 } // Cylinder Feedder 08

             //------------Input_ALM_Conveyor_Label------------

        public enum INPUT_DI_ALM_CON_01 { NodeID = 8, BitID = 0 }
        public enum INPUT_DI_ALM_CON_02 { NodeID = 8, BitID = 2 }
        public enum INPUT_DI_ALM_CON_03 { NodeID = 8, BitID = 4 }
        public enum INPUT_DI_ALM_CON_04 { NodeID = 8, BitID = 6 }
        public enum INPUT_DI_ALM_CON_05 { NodeID = 8, BitID = 8 }
        public enum INPUT_DI_ALM_CON_06 { NodeID = 8, BitID = 10 }
        public enum INPUT_DI_ALM_CON_07 { NodeID = 8, BitID = 12 }
        public enum INPUT_DI_ALM_CON_08 { NodeID = 8, BitID = 14 }

             //------------Input_ALM_Feed------------

        public enum INPUT_DI_ALM_FEED_01 { NodeID = 8, BitID = 1 }
        public enum INPUT_DI_ALM_FEED_02 { NodeID = 8, BitID = 3 }
        public enum INPUT_DI_ALM_FEED_03 { NodeID = 8, BitID = 5 }
        public enum INPUT_DI_ALM_FEED_04 { NodeID = 8, BitID = 7 }
        public enum INPUT_DI_ALM_FEED_05 { NodeID = 8, BitID = 9 }
        public enum INPUT_DI_ALM_FEED_06 { NodeID = 8, BitID = 11 }
        public enum INPUT_DI_ALM_FEED_07 { NodeID = 8, BitID = 13 }
        public enum INPUT_DI_ALM_FEED_08 { NodeID = 8, BitID = 15 }

              //------------Input_TIM_Conveyor_Label------------

        public enum INPUT_DI_TIM_CON_01 { NodeID = 4, BitID = 8 }
        public enum INPUT_DI_TIM_CON_02 { NodeID = 4, BitID = 10 }
        public enum INPUT_DI_TIM_CON_03 { NodeID = 4, BitID = 12 }
        public enum INPUT_DI_TIM_CON_04 { NodeID = 4, BitID = 14 }
        public enum INPUT_DI_TIM_CON_05 { NodeID = 6, BitID = 8 }
        public enum INPUT_DI_TIM_CON_06 { NodeID = 6, BitID = 10 }
        public enum INPUT_DI_TIM_CON_07 { NodeID = 6, BitID = 12 }
        public enum INPUT_DI_TIM_CON_08 { NodeID = 6, BitID = 14 }

               //------------Input_TIM_Feed------------

        public enum INPUT_DI_TIM_FEED_01 { NodeID = 4, BitID = 9 }
        public enum INPUT_DI_TIM_FEED_02 { NodeID = 4, BitID = 11 }
        public enum INPUT_DI_TIM_FEED_03 { NodeID = 4, BitID = 13 }
        public enum INPUT_DI_TIM_FEED_04 { NodeID = 4, BitID = 15 }
        public enum INPUT_DI_TIM_FEED_05 { NodeID = 6, BitID = 9 }
        public enum INPUT_DI_TIM_FEED_06 { NodeID = 6, BitID = 11 }
        public enum INPUT_DI_TIM_FEED_07 { NodeID = 6, BitID = 13 }
        public enum INPUT_DI_TIM_FEED_08 { NodeID = 6, BitID = 15 }

               //------------INput_Cylinder_Stroke_IN------------

        public enum INPUT_DI_CYQ_b { NodeID = 2, BitID = 1 } // Feedder 01
        public enum INPUT_DI_CYR_b { NodeID = 2, BitID = 3 } // Feedder 02
        public enum INPUT_DI_CYS_b { NodeID = 2, BitID = 5 } // Feedder 03
        public enum INPUT_DI_CYT_b { NodeID = 2, BitID = 7 } // Feedder 04
        public enum INPUT_DI_CYM_b { NodeID = 1, BitID = 9 } // Feedder 05
        public enum INPUT_DI_CYN_b { NodeID = 1, BitID = 11 } // Feedder 06
        public enum INPUT_DI_CYO_b { NodeID = 1, BitID = 13 } // Feedder 07
        public enum INPUT_DI_CYP_b { NodeID = 1, BitID = 15 } // Feedder 08

                //------------INput_Cylinder_Stroke_OUT------------

        public enum INPUT_DI_CYQ_a { NodeID = 2, BitID = 2 } // Feedder 01
        public enum INPUT_DI_CYR_a { NodeID = 2, BitID = 4 }
        public enum INPUT_DI_CYS_a { NodeID = 2, BitID = 6 }
        public enum INPUT_DI_CYT_a { NodeID = 2, BitID = 8 }
        public enum INPUT_DI_CYM_a { NodeID = 1, BitID = 10 }
        public enum INPUT_DI_CYN_a { NodeID = 1, BitID = 12 }
        public enum INPUT_DI_CYO_a { NodeID = 1, BitID = 14 }
        public enum INPUT_DI_CYP_a { NodeID = 2, BitID = 0 } // Feedder 08

               //------------Input_Check_Roll_Label------------

        public enum INPUT_DI_CHECK_ROLL_LABEL_01 { NodeID = 5, BitID = 0 }
        public enum INPUT_DI_CHECK_ROLL_LABEL_02 { NodeID = 5, BitID = 1 }
        public enum INPUT_DI_CHECK_ROLL_LABEL_03 { NodeID = 5, BitID = 2 }
        public enum INPUT_DI_CHECK_ROLL_LABEL_04 { NodeID = 5, BitID = 3 }
        public enum INPUT_DI_CHECK_ROLL_LABEL_05 { NodeID = 5, BitID = 4 }
        public enum INPUT_DI_CHECK_ROLL_LABEL_06 { NodeID = 5, BitID = 5 }
        public enum INPUT_DI_CHECK_ROLL_LABEL_07 { NodeID = 5, BitID = 6 }
        public enum INPUT_DI_CHECK_ROLL_LABEL_08 { NodeID = 5, BitID = 7 }

        //------------------------------------------Conveyor-------------------------------------------------

        public enum OUTPUT_PO_CONVEYOR_01 { NodeID = 41 }
        public enum OUTPUT_PO_CONVEYOR_02 { NodeID = 42 }
        public enum OUTPUT_PO_CONVEYOR_03 { NodeID = 43 }
        public enum OUTPUT_PO_CONVEYOR_04 { NodeID = 44 }

        //-----------------INPUT_Servo_Ready--------------

        public enum INPUT_DI_SERVO_READY_CONVEYOR_01 { NodeID = 9, BitID = 0 }
        public enum INPUT_DI_SERVO_READY_CONVEYOR_02 { NodeID = 9, BitID = 3 }
        public enum INPUT_DI_SERVO_READY_CONVEYOR_03 { NodeID = 9, BitID = 6 }
        public enum INPUT_DI_SERVO_READY_CONVEYOR_04 { NodeID = 9, BitID = 9 }

        //----------------INPUT_Servo_Target_Position------------------------------

        public enum INPUT_DI_SERVO_TARGET_CONVEYOR_01 { NodeID = 9, BitID = 1 }
        public enum INPUT_DI_SERVO_TARGET_CONVEYOR_02 { NodeID = 9, BitID = 4 }
        public enum INPUT_DI_SERVO_TARGET_CONVEYOR_03 { NodeID = 9, BitID = 7 }
        public enum INPUT_DI_SERVO_TARGET_CONVEYOR_04 { NodeID = 9, BitID = 10 }

        //-----------------INPUT_Servo_Homing_Complrted--------------------------

        public enum INPUT_DI_SERVO_HOME_COMPLETED_CONVEYOR_01 { NodeID = 9, BitID = 2 }
        public enum INPUT_DI_SERVO_HOME_COMPLETED_CONVEYOR_02 { NodeID = 9, BitID = 5 }
        public enum INPUT_DI_SERVO_HOME_COMPLETED_CONVEYOR_03 { NodeID = 9, BitID = 8 }
        public enum INPUT_DI_SERVO_HOME_COMPLETED_CONVEYOR_04 { NodeID = 9, BitID = 11 }

        //------------------OUTPUT_Move_Conveyor--------------------------

        public enum OUTPUT_DO_CYA { NodeID = 15, BitID = 0 } // Silde conveyor input
        public enum OUTPUT_DO_CYI { NodeID = 15, BitID = 8 } // Silde conveyor output


        //-----------------OUTPUT_Cylinder_PWB Clamp-----------------------------

        public enum OUTPUT_DO_CYB { NodeID = 15, BitID = 1 } // PWB Clamp 01
        public enum OUTPUT_DO_CYE { NodeID = 15, BitID = 4 } // PWB Clamp 02
        public enum OUTPUT_DO_CYG { NodeID = 15, BitID = 6 } // PWB Clamp 03
        public enum OUTPUT_DO_CYJ { NodeID = 15, BitID = 9 } // PWB Clamp 04

        //-----------------OUTPUT_Cylinder_Stop PCB-------------------------

        public enum OUTPUT_DO_CYC { NodeID = 15, BitID = 2 } // Stopper PCB conveyor 01
        public enum OUTPUT_DO_CYF { NodeID = 15, BitID = 5 } // Stopper PCB conveyor 02
        public enum OUTPUT_DO_CYH { NodeID = 15, BitID = 7 } // Stopper PCB conveyor 03
        public enum OUTPUT_DO_CYK { NodeID = 15, BitID = 10 } // Stopper PCB conveyor 04

        //--------------INPUT_Senser_Check_PCB---------------

        public enum INPUT_DI_SENSER_PCB_01 { NodeID = 4, BitID = 0 }
        public enum INPUT_DI_SENSER_PCB_02 { NodeID = 4, BitID = 1 }
        public enum INPUT_DI_SENSER_PCB_03 { NodeID = 4, BitID = 2 }
        public enum INPUT_DI_SENSER_PCB_04 { NodeID = 4, BitID = 3 }

        //-------------INPUT_Cylinder_Stroke_IN_Silde Conveyor----------

        public enum INPUT_DI_CYA_b { NodeID = 1, BitID = 1 } // Silde conveyor input_Stroke_IN
        public enum INPUT_DI_CYI_b { NodeID = 1, BitID = 5 } // Silde conveyor Output_Stroke_IN

        //-------------INPUT_Cylinder_Stroke_Out_Silde Conveyor----------


        public enum INPUT_DI_CYA_a { NodeID = 1, BitID = 2 } // Silde conveyor input_Stroke_Out
        public enum INPUT_DI_CYI_a { NodeID = 1, BitID = 6 } // Silde conveyor Output_Stroke_Out

        //----------------INPUT_Switch มือจับ  ---------------

        public enum INPUT_DI_SWITCH_L { NodeID = 11, BitID = 0 } // ซ้าย
        public enum INPUT_DI_SWITCH_R { NodeID = 11, BitID = 1 } // ขวา
        public enum INPUT_DI_SWITCH_G { NodeID = 11, BitID = 2 } // กำ

        //------------INPUT_PRESSURE Sensor ----------------

        public enum INPUT_DI_PRESSURE { NodeID = 1, BitID = 0 } // 
        public enum INPUT_AI_PRESSURE { NodeID = 24, BitID = 0 } // 

        //-----------OUTPUT_OFF_sensor Check PCB conveyor 02-------------

        public enum OUTPUT_DO_OFF_SENSOR { NodeID = 19, BitID = 8 } // 

        //--------------OUTPUT_Towerlight---------------

        public enum OUTPUT_DO_RED { NodeID = 17, BitID = 10 } // 
        public enum OUTPUT_DO_YELLOW { NodeID = 17, BitID = 11 } // 
        public enum OUTPUT_DO_BLUE { NodeID = 17, BitID = 12 } // 
        public enum OUTPUT_DO_GREEN { NodeID = 17, BitID = 13 } // 
        public enum OUTPUT_DO_BUZZER_1 { NodeID = 17, BitID = 14 } // 
        public enum OUTPUT_DO_BUZZER_2 { NodeID = 17, BitID = 15 } // 


        //-----------------OUTPUT_Air Static Control --------------------------

        public enum OUTPUT_DO_CYD { NodeID = 15, BitID = 4 } // Static Control


        //-----------------INPUT_VISION--------------------------

        public enum INPUT_DI_P2_0 { NodeID = 7,BitID = 0 }
        public enum INPUT_DI_P2_2 { NodeID = 7, BitID = 1 }
        public enum INPUT_DI_P2_4 { NodeID = 7, BitID = 2 }
        public enum INPUT_DI_P2_6 { NodeID = 7, BitID = 3 }
        public enum INPUT_DI_P3_0 { NodeID = 7, BitID = 4 }
        public enum INPUT_DI_P3_2 { NodeID = 7, BitID = 5 }
        public enum INPUT_DI_P3_4 { NodeID = 7, BitID = 6 }
        public enum INPUT_DI_P3_6 { NodeID = 7, BitID = 7 }
        public enum INPUT_DI_P2_1 { NodeID = 7, BitID = 8 }
        public enum INPUT_DI_P2_3 { NodeID = 7, BitID = 9 }
        public enum INPUT_DI_P2_5 { NodeID = 7, BitID = 10 }
        public enum INPUT_DI_P2_7 { NodeID = 7, BitID = 11 }
        public enum INPUT_DI_P3_1 { NodeID = 7, BitID = 12 }
        public enum INPUT_DI_P3_3 { NodeID = 7, BitID = 13 }
        public enum INPUT_DI_P3_5 { NodeID = 7, BitID = 14 }
        public enum INPUT_DI_P3_7 { NodeID = 7, BitID = 15 }

        //---------------OUTPUT_VISION------------------------------

        public enum OUTPUT_DI_P0_0 { NodeID = 18, BitID = 0 }
        public enum OUTPUT_DI_P0_2 { NodeID = 18, BitID = 1 }
        public enum OUTPUT_DI_P0_4 { NodeID = 18, BitID = 2 }
        public enum OUTPUT_DI_P0_6 { NodeID = 18, BitID = 3 }
        public enum OUTPUT_DI_P1_0 { NodeID = 18, BitID = 4 }
        public enum OUTPUT_DI_P1_2 { NodeID = 18, BitID = 5 }
        public enum OUTPUT_DI_P1_4 { NodeID = 18, BitID = 6 }
        public enum OUTPUT_DI_P1_6 { NodeID = 18, BitID = 7 }
        public enum OUTPUT_DI_P0_1 { NodeID = 18, BitID = 8 }
        public enum OUTPUT_DI_P0_3 { NodeID = 18, BitID = 9 }
        public enum OUTPUT_DI_P0_5 { NodeID = 18, BitID = 10 }
        public enum OUTPUT_DI_P0_7 { NodeID = 18, BitID = 11 }
        public enum OUTPUT_DI_P1_1 { NodeID = 18, BitID = 12 }
        public enum OUTPUT_DI_P1_3 { NodeID = 18, BitID = 13 }
        public enum OUTPUT_DI_P1_5 { NodeID = 18, BitID = 14 }
        public enum OUTPUT_DI_P1_7 { NodeID = 18, BitID = 15 }


    }
}