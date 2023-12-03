using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FASILKOMPOINT.App.Core
{
    internal class ShellExecutor
    {
        internal static void OpenFileUsingDefaultProgram(string filePath)
        {
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo(filePath)
            {
                UseShellExecute = true
            };
            process.Start();
            process.WaitForExit();
        }
    }
}
