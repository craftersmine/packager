using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using craftersmine.Packager.Lib.Core;

namespace craftersmine.Packager.Extractor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========  craftersmine packager  ===========");
            Console.WriteLine(@" Analyzing package: D:\test\testPackage.cmpkg...");
            PackageMetadata _pkgMeta = Analyzer.AnalyzePackage(@"D:\test\testPackage.cmpkg");
            Console.SetCursorPosition(0, 2);
            Console.WriteLine(" Package name: {0}, Package creation time: {1}", _pkgMeta.PackageName, _pkgMeta.CreationTime);
            Console.WriteLine(" Contains: ");
            int count = 0;
            foreach (var file in _pkgMeta.PackageFiles)
            {
                double filesz = file.Filesize / 1024.0D / 1024.0D;
                Console.WriteLine(" " + file.Filename + " | Size: {0:F2} MBytes", filesz);
                count++;
            }
            Console.WriteLine("===============================================");
            Console.WriteLine(" Total files count: " + count);
            double totsz = _pkgMeta.TotalPackageFilesSize / 1024.0D / 1024.0D;
            Console.WriteLine(" Total package files size: {0:F2} MBytes", totsz);
            Console.ReadKey();
        }
    }
}
