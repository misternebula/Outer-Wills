using OWML.ModHelper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outer_Wills
{
    public class Main : ModBehaviour
    {
        void Start()
        {
            ModHelper.Console.WriteLine("Start!");

            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = ModHelper.Manifest.ModFolderPath + "afarplay.exe",
                    Arguments = "\"this is a test\"",
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            process.Start();
        }
    }
}
