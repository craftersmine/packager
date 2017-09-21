﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using craftersmine.Packager.Lib.Core;
using System.Threading;

namespace craftersmine.Packager.Cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("\r\ncraftersmine Packager (c) 2017 - craftersmine\r\n");
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
            else if (_args.ContainsKey("p") || _args.ContainsKey("-pack"))
            {
                Console.WriteLine("Preparing package...");
                string filesArgRet = "";
                if (_args.TryGetValue("f", out filesArgRet) || _args.TryGetValue("-files", out filesArgRet))
                {
                    string[] fls = filesArgRet.Split(';');
                    string name = "";
                    if (_args.TryGetValue("pn", out name) || _args.TryGetValue("-pkgname", out name))
                    {
                        PackageFile _pkg = new PackageFile(name);
                        foreach(var fl in fls)
                        {
                            _pkg.AddFile(fl);
                        }
                        _totalfiles = fls.Length;
                        string dir = "";
                        if (_args.TryGetValue("-outdir", out dir) || _args.TryGetValue("o", out dir))
                        {
                            Lib.Core.Packager _pkgr = new Lib.Core.Packager(dir, _pkg);
                            _pkgr.PackingEvent += _pkgr_PackingEvent;
                            _pkgr.PackingDoneEvent += _pkgr_PackingDoneEvent;
                            for (int i = 0; i < Console.WindowWidth; i++)
                            {
                                whitespace += " ";
                            }
                            Console.SetCursorPosition(0, 5);
                            _pkgr.Pack();
                            
                        }
                        else
                        {
                            Console.WriteLine("Argument --outdir is not set! Packaging failed!");

                            Console.WriteLine(ArgsMessages.Help);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Argument --pkgname is not set! Packaging failed!");

                        Console.WriteLine(ArgsMessages.Help);
                    }
                }
                else
                {
                    Console.WriteLine("Argument --files is not set! Packaging failed!");

                    Console.WriteLine(ArgsMessages.Help);
                }
                //Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Argument --pack is not set! Packaging failed!");

                Console.WriteLine(ArgsMessages.Help);
            }
        }

        static int _totalfiles = 0;

        private static void _pkgr_PackingDoneEvent(object sender, PackingDoneEventArgs e)
        {
            Console.SetCursorPosition(0, 6);
            Console.WriteLine("\r\nPackaging complete!\r\n");
        }

        static int curfl = 1;
        static int curind = 0;
        static string curfln = "";

        static string whitespace = "";

        private static void _pkgr_PackingEvent(object sender, PackingEventArgs e)
        {
            curind = e.CurrentFileIndex + 1;
            curfln = e.CurrentFilename;
            double perc = 0.0d;
            if (e.CurrentFileByte > 0 && e.TotalAllBytes > 0 && e.TotalFileByte > 0)
                perc = ((double)e.CurrentFileByte / e.TotalFileByte) * 100;
            curfl = e.CurrentFileIndex + e.CurrentFileIndex;
            Console.Write(whitespace);
            Console.SetCursorPosition(0, 5);
            Console.Write("Processing {0} of {1} file - Percentage: {2:F2}% Packing file: {3}", curfl, _totalfiles, perc, e.CurrentFilename);
        }
    }

    public class ProgressBar : IDisposable, IProgress<double>
    {
        private const int blockCount = 10;
        private readonly TimeSpan animationInterval = TimeSpan.FromSeconds(1.0 / 8);
        private const string animation = @"|/-\";

        private readonly Timer timer;

        private double currentProgress = 0;
        private string currentText = string.Empty;
        private bool disposed = false;
        private int animationIndex = 0;

        public ProgressBar()
        {
            timer = new Timer(TimerHandler);
        }

        public void Report(double value)
        {
            value = Math.Max(0, Math.Min(1, value));
            Interlocked.Exchange(ref currentProgress, value);
        }

        private void TimerHandler(object state)
        {
            lock (timer)
            {
                if (disposed) return;

                int progressBlockCount = (int)(currentProgress * blockCount);
                int percent = (int)(currentProgress * 100);
                string text = string.Format("[{0}{1}] {2,3}% {3}",
                    new string('#', progressBlockCount), new string('-', blockCount - progressBlockCount),
                    percent,
                    animation[animationIndex++ % animation.Length]);
                UpdateText(text);

                ResetTimer();
            }
        }

        public void UpdateText(string text)
        {
            int commonPrefixLength = 0;
            int commonLength = Math.Min(currentText.Length, text.Length);
            while (commonPrefixLength < commonLength && text[commonPrefixLength] == currentText[commonPrefixLength])
            {
                commonPrefixLength++;
            }
            StringBuilder outputBuilder = new StringBuilder();
            outputBuilder.Append('\b', currentText.Length - commonPrefixLength);
            outputBuilder.Append(text.Substring(commonPrefixLength));
            int overlapCount = currentText.Length - text.Length;
            if (overlapCount > 0)
            {
                outputBuilder.Append(' ', overlapCount);
                outputBuilder.Append('\b', overlapCount);
            }

            Console.Write(outputBuilder);
            currentText = text;
        }

        private void ResetTimer()
        {
            timer.Change(animationInterval, TimeSpan.FromMilliseconds(-1));
        }

        public void Dispose()
        {
            lock (timer)
            {
                disposed = true;
                UpdateText(string.Empty);
            }
        }

    }
}
