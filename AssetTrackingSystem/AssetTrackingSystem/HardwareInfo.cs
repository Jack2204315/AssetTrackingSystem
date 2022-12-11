using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;

public static class HardwareInfo
{
    public static String GetManufacturer()
    {

        ManagementClass mc = new ManagementClass("win32_ComputerSystem");
        ManagementObjectCollection moc = mc.GetInstances();
        String Id = String.Empty;
        foreach (ManagementObject mo in moc)
        {

            Id = mo.Properties["Manufacturer"].Value.ToString();
            break;
        }
        return Id;

    }

    public static String GetModel()
    {

        ManagementClass mc = new ManagementClass("win32_ComputerSystem");
        ManagementObjectCollection moc = mc.GetInstances();
        String Id = String.Empty;
        foreach (ManagementObject mo in moc)
        {

            Id = mo.Properties["Model"].Value.ToString();
            break;
        }
        return Id;

    }

    public static String GetSystemType()
    {

        ManagementClass mc = new ManagementClass("win32_ComputerSystem");
        ManagementObjectCollection moc = mc.GetInstances();
        String Id = String.Empty;
        foreach (ManagementObject mo in moc)
        {

            Id = mo.Properties["SystemType"].Value.ToString();
            break;
        }
        return Id;

    }

}

