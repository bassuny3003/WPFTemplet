using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;
using System.Runtime.InteropServices;     // Check internet connection is available


namespace WPFTemplet.Class
{
    class CheckInternetConnection
    {
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);

        public bool InternetConnectionStatuse()
        {
            int Desc;
            if (InternetGetConnectedState(out Desc, 0) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
