using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace AssetTrackingSystem
{
    class SoftwareInfo
    {
        public static String GetVersion()
        {

            ManagementClass mc = new ManagementClass("win32_OperatingSystem");
            ManagementObjectCollection moc = mc.GetInstances();
            String Id = String.Empty;
            foreach (ManagementObject mo in moc)
            {

                Id = mo.Properties["Version"].Value.ToString();
                break;
            }
            return Id;

        }

        public static String GetManufacturer()
        {

            ManagementClass mc = new ManagementClass("win32_OperatingSystem");
            ManagementObjectCollection moc = mc.GetInstances();
            String Id = String.Empty;
            foreach (ManagementObject mo in moc)
            {

                Id = mo.Properties["Manufacturer"].Value.ToString();
                break;
            }
            return Id;

        }
        //https://social.msdn.microsoft.com/Forums/vstudio/en-US/62ab38ce-bf56-4fad-b96a-0ceebbe9e1c9/c-how-to-get-windows-version?forum=wpf
        public static string GetOSName()
        {
            string result = string.Empty;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem");
            foreach (ManagementObject os in searcher.Get())
            {
                result = os["Caption"].ToString();
                break;
            }
            return result;
        }
    }
}
