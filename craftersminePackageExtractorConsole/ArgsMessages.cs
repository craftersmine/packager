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
            "Extracts files from package\r\n" +
            "\r\n" +
            "Usage: cmextrcmd --[extract/analyze] --file[PACKAGEPATH] --outdir=[OUTDIR]\r\n" +
            "\r\n" +
            "Arguments:\r\n" +
            "\r\n" +
            "  --extract - Creates package from files. Alias: -e\r\n" +
            "  --analyze - Analyzes package for including files. No need --outdir argument. Alias -a\r\n" +
            "  --file    - Adds file in package. Alias: -f\r\n" +
            "  --outdir  - Sets a directory for output package file. Alias: -o\r\n" +
            "  --help    - Shows help. Alias: -h, -?\r\n";
    }
}
