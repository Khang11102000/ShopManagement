using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCH
{
    class Global_Name
    {
        public static string GlobalName { get; private set; }
        public static void SetGlobalName(string Name)
        {
            GlobalName = Name;
        }

        public static string GlobalUser { get; private set; }
        public static void SetGlobalUser(string user)
        {
            GlobalUser = user;
        }
        public static string GlobalPass { get; private set; }
        public static void SetGlobalPass(string pass)
        {
            GlobalPass = pass;
        }
        public static string GlobalSDT { get; private set; }
        public static void SetGlobalSDT(string sdt)
        {
            GlobalSDT = sdt;
        }
    }
}
