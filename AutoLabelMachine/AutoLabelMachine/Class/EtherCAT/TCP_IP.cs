using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KEYENCE_NU_EP1_Lib;
using System.Net.NetworkInformation;
using System.Collections;
namespace AutoLabelMachine
{
    class TCP_IP
    {

        public bool getSensor(string strIp, out byte[] byteOutput)
        { 
            bool bResult = false;
            byte[] byteTemp = new byte[2];
            CKeyence_NUEP1 cKeyence_sensor = new CKeyence_NUEP1();
            cKeyence_sensor.xReadKeyence_NUEP_SensorOutput(strIp, out byteTemp, out bResult);
            byteOutput = byteTemp;
            return bResult;

        }
        public bool GetBitX(byte[] bytes,int x)
        {
            int index = 0;
            if (x < 8)
            {
                index = 0;
            }
            else
            {
                index = 1;
                x = x - 8;
            }
        
                System.Collections.BitArray ba = new BitArray(new byte[] { bytes[index] });
                return ba.Get(x);
           
            
        }
    
    }

 }