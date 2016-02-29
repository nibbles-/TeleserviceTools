/*
 * Teleservice Tools 
 * License: Free, Open, Do with as you will. But keep the credit.
 * Credit: Johan Åhman
 * Version: 0.0006
 */

using System;

namespace TeleserviceTools
{
    static class Program
    {
        
        static void Main()
        {
            //The main entry point for the application.    
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new mainForm());
        }
        public static string CIPCencode(string Extension, int Length = 15, string DevicePrefix = "CIPC")
        {
            /*
             * Encodes the EXTENSION number to a devicename up to LENGTH characters long.
             * If the EXTENSION is longer than LENGTH it will fail.
             * LENGTH is customable but defaults to 15 including DEVICEPREFIX
             * DEVICEPREFIX is customable but defaults to "CIPC"
             */
            try
            {
                string Devicename = DevicePrefix + long.Parse(Extension).ToString("X2");
                if (Devicename.Length > 15)
                {
                    return "Extension is to long for DeviceName";
                }
                else
                {
                    while (Devicename.Length < 15)
                    {
                        Devicename += "X";
                    }
                }
                return Devicename;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return e.Message;
            }
        }
        public static string CIPCdecode(string Devicename, string DevicePrefix = "CIPC", string Filler = "X")
        {
            /*
             * Decodes the DEVICENAME to an extension. 
             * Only works if the DEVICENAME is encoded with the encode function. 
             * If it is not. Strange things might happen.
             */
            try
            {
                string[] Extension = Devicename.Substring(DevicePrefix.Length).Split(Filler[0]);
                return long.Parse(Extension[0], System.Globalization.NumberStyles.AllowHexSpecifier).ToString();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return e.Message;
            }
        }
        public static string IPEIChkSumCalc(string IPEI)
        {
            /* The checksum of an IPEI is calculated by adding each digit multiplied by its position from 1 to 12 % 11
             * e.g 002020807544 -> 0+0+6+0+10+0+56+0+63+50+44+48 % 11 = 2
            */
            try
            {
                string IPEIWithChkSum;
                int IPEIChkSum = 0;
                int position = 1;
                int partialChkSum = 0;
                if(IPEI.Length < 12)
                {
                    System.Windows.Forms.MessageBox.Show("An IPEI w/o checksum is 12 digits", "Error");
                    return "";
                }
                foreach (char digit in IPEI)
                {
                    partialChkSum = int.Parse(digit.ToString()) * position;
                    IPEIChkSum = IPEIChkSum + partialChkSum;
                    position++;
                }
                IPEIChkSum = IPEIChkSum % 11;
                if (IPEIChkSum >= 10)
                {
                    IPEIWithChkSum = IPEI + "*";
                }
                else
                {
                    IPEIWithChkSum = IPEI + IPEIChkSum.ToString();
                }
                return IPEIWithChkSum;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return e.Message;
            }
        }
    }
}
