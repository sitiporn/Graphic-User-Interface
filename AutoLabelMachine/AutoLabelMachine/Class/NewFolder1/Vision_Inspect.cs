using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using NationalInstruments.Vision;
using NationalInstruments.VBAI;
using NationalInstruments.VBAI.Structures;


namespace Auto_Label //.Class.Vision
{
  
    class Vision_Inspect
    {
        VBAIEngine engine;
        VBAIDateTime timeStamp;
        InspectionMeasurements[] measures;
      //  Variable[] Data01;
        VisionImage image;
        InspectionStep[] istep;
        string A,B,C,D,E,F,G;
      

   public string get_data (int datanum)

        {
         if ( datanum == 1)
            {
                return A;
            }
            else if (datanum == 2)
            {
                return B;
            }
            else if (datanum == 3)
            {
                return C;
            }
            else if (datanum == 4)
            {
                return D;
            }
            else if (datanum == 5)
            {
                return E;
            }
            else if (datanum == 6)
            {
                return F;
            }
            else if (datanum == 7)
            {
                return G;
            }
            return "";
        }
       
        public VBAIEngine Startengine()
        {
            engine = new VBAIEngine("APITest","", false);
            return engine;
        }

        public string Openfile(int file)
        {
           
            switch (file)
            {
                case  1:
                    engine.OpenInspection("C:\\Users\\User\\Desktop\\AutomaticLabel\\labelinspection.vbai");
                   break;
                case 2:
                    engine.OpenInspection("C:\\Users\\User\\Desktop\\AutomaticLabel\\Product Position.vbai");
                    break;
                case 3:
                    engine.OpenInspection("C:\\Users\\User\\Desktop\\AutomaticLabel\\Product Barcode.vbai");
                    break;
                    
            }
            
            return "";
        }

        public VisionImage Inspect(int InSt)//, out string strRes
        {
            bool newImageAvailable, inspectionStatus;
           // strRes = "";
            engine.RunInspectionOnce(-1);
            image = engine.GetInspectionImage("", 1, 1, out newImageAvailable);
           
            engine.GetInspectionResults(out timeStamp, out inspectionStatus);
            engine.EnableInspectionMeasurements();
            // PassFailIndicator.Checked = inspectionStatus;

            istep = engine.GetInspectionSteps();
            string[] res = new string[istep.Length];
            int x = 0;

            foreach (InspectionStep isSeq in istep)
            {
                // richTextBox1.AppendText(isSeq.stepGUID.ToString() + "\r\n");
                res[x] = isSeq.stepGUID;
                x++;
            }
            measures = engine.GetInspectionMeasurements(res, out timeStamp);

            switch (InSt)
            {
                case 1:
                
                       
                        //   Data01 =  engine.GetVariables();

                                try
                                {
                                    
                                    A = measures[12].measurements[1].measurement.numData.ToString();
                                    B = measures[12].measurements[2].measurement.numData.ToString();
                                    C = measures[6].measurements[9].measurement.numData.ToString();
                                }
                                catch (Exception e)
                                {
                                }
                                //strRes = A.ToString() + "," + B.ToString() + "," + C.ToString();
       
                
                    break;

                case 2:

                    measures = engine.GetInspectionMeasurements(res, out timeStamp);

                    for (int j = 0; j < measures.Length; j++)

                        if (j == 6)
                        {
                            D = (measures[j].measurements[4].measurement.numData.ToString());
                            E = (measures[j].measurements[5].measurement.numData.ToString());
                            F = (measures[4].measurements[9].measurement.numData.ToString());
                          
                            //strRes = D.ToString();

                        }
                    break;

                case 3:
                    measures = engine.GetInspectionMeasurements(res, out timeStamp);

                    for (int k = 0; k < measures.Length; k++)

                        if (k == 2)
                        {
                            G = (measures[k].measurements[2].measurement.numData.ToString());
                            // strRes = E.ToString() + "," + F.ToString() + "," + G.ToString();
                        }
                    break;

            }
            return image ;

        }
        
       
        
      
    }

}
