using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;

public static class HardwareInfo
{
    ///
    /// Retrieving Processor Id.
    /// 
    /// 
    /// 
    public static String GetProcessorId()
    {

        ManagementClass mc = new ManagementClass("win32_processor");
        ManagementObjectCollection moc = mc.GetInstances();
        String Id = String.Empty;
        foreach (ManagementObject mo in moc)
        {

            Id = mo.Properties["processorID"].Value.ToString();
            break;
        }
        return Id;

    }
}
