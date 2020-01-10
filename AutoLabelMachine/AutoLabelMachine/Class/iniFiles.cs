using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
namespace AutoLabelMachine
{
    class iniFiles
    {
        public string path;
        [DllImport("Kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("Kernel32")]
        private static extern int GetPrivateProfileString(string section, string key,string def,StringBuilder retVal,int size,string filePath);

        public iniFiles(string INIPath)
        {
            path = INIPath;
        }

        public void IniWriteValue(string Section,string Key,string Value)
        {
            WritePrivateProfileString(Section, Key, Value, this.path);
        }
        public string IniReadValue(string Section,string Key)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(Section, Key, "", temp, 255, this.path);
            return temp.ToString();
        }

    }
}
