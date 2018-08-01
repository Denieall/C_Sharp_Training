using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpeningEXE
{
    class Program
    {
        static void Main(string[] args)
        {
            Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + @"\Internet Download Manager\idman.exe", "/n /d http://vlt.animeheaven.eu/720kl/msl/High_School_DxD_Hero--8--1528215023__47c1b3.mp4?ww5w124");
            Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + @"\Internet Download Manager\idman.exe", "/n /d http://vlt.animeheaven.eu/720kl/msl/High_School_DxD_Hero--9--1528820835__bc935d.mp4?ww5w124");

            foreach (var process in Process.GetProcessesByName("IDMan"))
            {
                process.Kill();
            }

            Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + @"\Internet Download Manager\idman.exe", "/s");

            Console.Read();
        }
    }
}
