using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace craftersmine.Packager.Cmd
{
    public sealed class ArgsMessages
    {
        public const string Help = 
            "Creates a package from files\r\n" +
            "\r\n" +
            "Usage: cmpkgrcmd --pack --name=[PACKAGENAME] --files=[FILE1];[FILE2] --outdir=[OUTFILE]\r\n" +
            "\r\n" +
            "Arguments:\r\n" +
            "\r\n" +
            "  --pack    - Creates package from files. Alias: -p\r\n" +
            "  --files   - Adds file in package. Splits files with semicolon \';\'. Alias: -f\r\n" +
            "  --pkgname - Sets a package name. Alias: -pn\r\n" +
            "  --outdir  - Sets a directory for output package file. Alias: -o\r\n" +
            "  --help    - Shows help. Alias: -h, -?\r\n";
    }
}
