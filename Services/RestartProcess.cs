using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSTools
{
    public static class RestartProcess
    {
        public static void RestartProcessByFileName(string targetProc)
        {

            Process[] runningProcs = Process.GetProcessesByName(targetProc);

            foreach (Process proc in runningProcs)
            {
                proc.Kill();
            }
            Process.Start(targetProc + ".exe");
        }
        public static void KillProcessByFileName(string targetProc)
        {

            Process[] runningProcs = Process.GetProcessesByName(targetProc);

            foreach (Process proc in runningProcs)
            {
                proc.Kill();
            }
        }
    }
}


