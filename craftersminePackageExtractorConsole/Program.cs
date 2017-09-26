using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using craftersmine.Packager.Lib.Core;
using System.Threading;

namespace craftersmine.Packager.Extractor.Cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("\r\ncraftersmine package Extractor and Analyzer (c) 2017 - craftersmine\r\n");
            Dictionary<string, string> _args = new Dictionary<string, string>();
            foreach(var arg in args)
            {
                string[] argsplt = arg.Split('=');
                if (argsplt.Length > 1)
                    _args.Add(argsplt[0].Substring(1), argsplt[1]);
                else
                    _args.Add(argsplt[0].Substring(1), "");
            }

            if (_args.ContainsKey("h") || _args.ContainsKey("?") || _args.ContainsKey("-help"))
            {
                Console.WriteLine(ArgsMessages.Help);
                //Environment.Exit(0);
            }
            else if (_args.ContainsKey("e") || _args.ContainsKey("-extract"))
            {
                Console.WriteLine("Extracting package...");
                string fileArgRet = "";
                if (_args.TryGetValue("f", out fileArgRet) || _args.TryGetValue("-file", out fileArgRet))
                {
                    string dir = "";
                    if (_args.TryGetValue("-outdir", out dir) || _args.TryGetValue("o", out dir))
                    {
                        Lib.Core.Extractor _extr = new Lib.Core.Extractor(fileArgRet, dir);
                        _extr.ExtractingEvent += _extr_ExtractingEvent;
                        _extr.ExtractingDoneEvent += _extr_ExtractingDoneEvent;
                        for (int i = 0; i < Console.WindowWidth; i++)
                        {
                            whitespace += " ";
                        }
                        Console.SetCursorPosition(0, 5);
                        _extr.Extract();

                    }
                    else
                    {
                        Console.WriteLine("Argument --outdir is not set! Extracting failed!");
                        Console.WriteLine(ArgsMessages.Help);
                    }
                }
                else
                {
                    Console.WriteLine("Argument --file is not set! Extracting failed!");
                    Console.WriteLine(ArgsMessages.Help);
                }
                //Environment.Exit(0);
            }
            else if (_args.ContainsKey("a") || _args.ContainsKey("-analyze"))
            {
                Console.WriteLine("Analyzing package...");
                string fileArgRet = "";
                if (_args.TryGetValue("f", out fileArgRet) || _args.TryGetValue("-file", out fileArgRet))
                {
                    PackageMetadata _package = Analyzer.AnalyzePackage(fileArgRet);
                    Console.SetCursorPosition(0, 5);
                    Console.WriteLine(" Package " + _package.PackageName + " Contains " + _package.PackageFiles.Length + " files");
                    Console.Write(" Total package size ");
                    if (_package.TotalPackageFilesSize > 1024.0d)
                    {
                        double _flszk = _package.TotalPackageFilesSize / 1024.0d;
                        if (_flszk > 1024.0d)
                        {
                            _flszk /= 1024.0d;
                            if (_flszk > 1024.0d)
                            {
                                _flszk /= 1024.0d;
                                Console.WriteLine("{0:F2} GBytes", _flszk);
                            }
                            else Console.WriteLine("{0:F2} MBytes", _flszk);
                        }
                        else Console.WriteLine("{0:F2} KBytes", _flszk);
                    }
                    else Console.WriteLine(_package.TotalPackageFilesSize + " Bytes");
                    Console.WriteLine("\r\n========== Files ==========");
                    foreach (var _entry in _package.PackageFiles)
                    {
                        string flsz = "";
                        if (_entry.Filesize > 1024.0d)
                        {
                            double _flszk = _entry.Filesize / 1024.0d;
                            if (_flszk > 1024.0d)
                            {
                                _flszk /= 1024.0d;
                                if (_flszk > 1024.0d)
                                {
                                    _flszk /= 1024.0d;
                                    flsz = string.Format("{0:F2} GBytes", _flszk);
                                }
                                else flsz = string.Format("{0:F2} MBytes", _flszk);
                            }
                            else flsz = string.Format("{0:F2} KBytes", _flszk);
                        }
                        else flsz = _entry.Filesize.ToString() + " Bytes";
                        Console.WriteLine(" Filename: {0} | Size: {1}", _entry.Filename, flsz);
                    }
                    Console.WriteLine("\r\nAnalyze completed!\r\n");
                }
                else
                {
                    Console.WriteLine("Argument --file is not set! Extracting failed!");
                    Console.WriteLine(ArgsMessages.Help);
                }
            }
            else
            {
                Console.WriteLine("Argument --extract or --analyze is not set! Extracting failed!");
                Console.WriteLine(ArgsMessages.Help);
            }
        }

        static int _totalfiles = 0;

        private static void _extr_ExtractingDoneEvent(object sender, ExtractingDoneEventArgs e)
        {
            Console.SetCursorPosition(0, 6);
            Console.WriteLine("\r\nExtracting complete!\r\n");
        }

        static int curfl = 1;
        static int curind = 0;
        static string curfln = "";

        static string whitespace = "";

        private static void _extr_ExtractingEvent(object sender, ExtractingEventArgs e)
        {
            curind = e.CurrentFileIndex + 1;
            curfln = e.CurrentFilename;
            double perc = 0.0d;
            if (e.CurrentFileByte > 0 && e.TotalAllBytes > 0 && e.TotalFileByte > 0)
                perc = ((double)e.CurrentFileByte / e.TotalFileByte) * 100;
            curfl = e.CurrentFileIndex + e.CurrentFileIndex;
            Console.Write(whitespace);
            Console.SetCursorPosition(0, 5);
            Console.Write("Processing {0} of {1} file - Percentage: {2:F2}% Extracting file: {3}", curfl, _totalfiles, perc, e.CurrentFilename);
        }
    }
}
