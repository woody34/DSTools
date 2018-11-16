using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSTools
{
    static class ActivateWindows
    {
        public static void Activate(string _key)
        {
            //ProcessStartInfo psi = new ProcessStartInfo("cmd", "slmgr /ipk " + _key);
            //psi.UseShellExecute = false;
            //psi.CreateNoWindow = true;
            //Process p = new Process();
            //p.StartInfo = psi;
            //p.Start();

            ProcessStartInfo psi = new ProcessStartInfo("cmd","/c " + "slmgr /ipk " + _key);
            Process p = new Process();
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            p.StartInfo = psi;
            p.Start();
        }
    }
}
