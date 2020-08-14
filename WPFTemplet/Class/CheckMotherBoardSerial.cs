using System;
using System.Linq;
using System.Management;

namespace WPFTemplet.Class
{
    class CheckMotherBoardSerial
    {
        string[] AllowedMotherbordIDs = new string[] 
        { 
          "..CN1374089701IT.",                   /*My Home PC*/
          "..CN1374085305DS.",                   /*My Company PC*/
          ".95560N1.CN701660CK00W6.",            /*lab D atef El sady*/
          "/J8XFXS2/CNCMC008CF039B/"             /*lab D atef El sady*/
        };

        public bool GetMotherboardSerialNo()
        {
            string CurrentMotherBordSerial = String.Empty;

            bool DeviceStatus = false;

            ManagementScope scope = new ManagementScope("\\\\" + Environment.MachineName + "\\root\\cimv2");

            scope.Connect();

            ManagementObject wmiClass = new ManagementObject(scope, new ManagementPath("Win32_BaseBoard.Tag=\"Base Board\""), new ObjectGetOptions());

            foreach (PropertyData propData in wmiClass.Properties)
            {
                if (propData.Name == "SerialNumber")
                    //mbInfo = String.Format("{0,-25}{1}", propData.Name, Convert.ToString(propData.Value));
                    CurrentMotherBordSerial = Convert.ToString(propData.Value);
            }

            if (AllowedMotherbordIDs.Contains(CurrentMotherBordSerial))
            {
                DeviceStatus = true;
            }

            return DeviceStatus;
        }
    }
}
