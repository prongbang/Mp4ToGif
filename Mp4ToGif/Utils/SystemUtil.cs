using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mp4ToGif.Utils
{
    class SystemUtil
    {

        public static Boolean checkProcess(string name)
        {
            Process[] pname = Process.GetProcessesByName(name);
            if (pname.Length == 0)
                return false;

            return true;
        }

    }
}
