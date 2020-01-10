using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoLabelMachine
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MachineConfig());
        }

    }

    public class vfdCommand
    {
        //private string _frequncncy = "0000" ;

        public static string Stop { get { return "0001"; } }
        public static string FWD { get { return "0006"; } }
        public static string REV { get { return "000A"; } }

        public string Frequncncy(int _frequncncy)
        {
            //   _frequncncy = _frequncncy;
            string hexFeq = _frequncncy.ToString("X4");
            return hexFeq;
            //  _frequncncy = _frequncncy;
            //  return string.Format("{0:X4}",_frequncncy );
        }

    }
    public static class vfdAddress
    {
        public static string operationComm { get { return "2000"; } }
        public static string frequencyComm { get { return "2001"; } }
        public static string resetComm { get { return "2002"; } }
        public static string errorNum { get { return "2100"; } }
        public static string operationSta { get { return "2101"; } }
        public static string frequencySta { get { return "2102"; } }
        public static string outfrequncySta { get { return "2103"; } }
        public static string outCureent { get { return "2104"; } }
        public static string outVolte { get { return "2109"; } }

    }
}
