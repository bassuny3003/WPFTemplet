using System;
using System.Linq;
using System.Management;

namespace WPFTemplet.Class
{
    class CheckHardDiskSerial
    {
        string[] AllowedHardDiskSerialNo = new string[] 
        { 
            "4A9CC6FCB5C36230A820EF809A74DFE08D5F1CD0",                 /*My PC*/ 
            "4A9CC6FCB5C36230A820EF809A74DFE08D5F1CD0FA141305",         /*My PC With My Flash */ 
            "A2655514285B778F04618E86",                                 /* AlforsanGym */ 
            "CCB1829B5300A5F050239DB04D689C604A8BE240"                  /*My Laptop*/ 
        };

        public bool GetHardDiskSerialNo()
        {
            bool DeviceStatus = false;

            ManagementClass magmnt = new ManagementClass("Win32_LogicalDisk");
            ManagementObjectCollection mcol = magmnt.GetInstances();

            string CurrentHardDiskSerialNo = "";

            foreach (ManagementObject strt in mcol)
            {
                CurrentHardDiskSerialNo += Convert.ToString(strt["VolumeSerialNumber"]);
            }


            if (AllowedHardDiskSerialNo.Contains(CurrentHardDiskSerialNo))
            {
                DeviceStatus = true;
            }

            return DeviceStatus;

        }

    }
}
