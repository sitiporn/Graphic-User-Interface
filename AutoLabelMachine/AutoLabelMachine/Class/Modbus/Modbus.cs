using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLabelMachine
{
    class Modbus
    {
        public string Tx_Data(string Address, string Register, string Data)
        {
            clsInputValidation.function(4);
            string sendWord = string.Concat(Address, clsInputValidation.functionCode, Register, Data);

            string ChckBit = clsComms.checkSum(sendWord);

            return clsComms.Read(sendWord);
        }



    }
}
