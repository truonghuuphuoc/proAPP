using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appTARGET
{
    class phnSysConfig
    {
        public static string mSerialPort = "COM1";
        public static byte mStartAddress = 0x01;
        public static byte mDestinationAddress = 0x02;


        public static void phnReadConfig()
        {
            string temp_str;
            string[] tempData_str;
            StreamReader sr_ConfData = new StreamReader(System.Windows.Forms.Application.StartupPath + @"\system\sys.conf");

            while (!sr_ConfData.EndOfStream)
            {
                temp_str = sr_ConfData.ReadLine();
                temp_str.TrimStart();
                temp_str.TrimEnd();
                tempData_str = temp_str.Split(',');

                if (tempData_str[0] == "com")
                {
                    mSerialPort = tempData_str[1];
                }
                else if (tempData_str[0] == "start")
                {
                    mStartAddress = (byte)int.Parse(tempData_str[1]);
                }
                else if (tempData_str[0] == "des")
                {
                    mDestinationAddress = (byte)int.Parse(tempData_str[1]);
                }
            }
            sr_ConfData.Close();
        }
    }
}
