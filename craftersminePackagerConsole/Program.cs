using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using craftersmine.Packager.Lib.Core;

namespace craftersmine.Packager.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            PackageFile _pak = new PackageFile("testPackage");

            foreach (var arg in args)
            {
                string[] argData = arg.Split('=');
                if (argData[0] == "-f")
                {
                    string[] filesa = argData[1].Split(',');
                    foreach (var ln in filesa)
                    {
                        _pak.AddFile(ln);
                        
                    }
                }
            }

            

            Lib.Core.Packager _packager = new Lib.Core.Packager("D:\\Test\\", _pak);

            _packager.PackingEvent += _packager_PackingEvent;
            _packager.PackingDoneEvent += _packager_PackingDoneEvent;

            _packager.Pack();
        }

        private static void _packager_PackingDoneEvent(object sender, PackingDoneEventArgs e)
        {
            System.Console.WriteLine("Operation completed successful: " + e.IsSuccessful);
            System.Console.ReadKey();
        }
        static int fileperc = 0;
        private static void _packager_PackingEvent(object sender, PackingEventArgs e)
        {
            
            if (e.CurrentFileByte != 0 || e.TotalFileByte != 0)
                 fileperc = (int)((e.CurrentFileByte / e.TotalFileByte) * 100);
            System.Console.WriteLine("Current file: " + e.CurrentFilename + " Percentage: " + fileperc + "%");
            //System.Console.WriteLine("Cur File: " + e.CurrentFilename + " Cur Byte: " + e.CurrentFileByte + " TotalAllByte: " + e.TotalAllBytes + " TotalFilebyte: " + e.TotalFileByte);
        }
    }
}
