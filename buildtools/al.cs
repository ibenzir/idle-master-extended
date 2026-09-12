using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;

class Program {
    static int Main(string[] args) {
        var tokens = new List<string>();
        foreach (var arg in args) {
            string trimmed = arg.Trim();
            if (trimmed.StartsWith("@")) {
                string rspPath = trimmed.Substring(1).Trim('"', ' ');
                if (File.Exists(rspPath)) {
                    string[] lines = File.ReadAllLines(rspPath);
                    foreach (var line in lines) {
                        if (!string.IsNullOrWhiteSpace(line)) {
                            tokens.AddRange(line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                        }
                    }
                }
            } else {
                tokens.Add(arg);
            }
        }

        string outPath = null;
        string embedPath = null;
        foreach (var token in tokens) {
            if (token.StartsWith("/out:", StringComparison.OrdinalIgnoreCase)) outPath = token.Substring(5).Trim('"', ' ');
            if (token.StartsWith("/embed:", StringComparison.OrdinalIgnoreCase)) embedPath = token.Substring(7).Trim('"', ' ');
        }

        if (outPath != null) {
            string fullOut = Path.IsPathRooted(outPath) ? outPath : Path.Combine(Environment.CurrentDirectory, outPath);
            string dir = Path.GetDirectoryName(fullOut);
            string runtimeDir = System.Runtime.InteropServices.RuntimeEnvironment.GetRuntimeDirectory();
            string csc = Path.Combine(runtimeDir, "csc.exe");
            if (!File.Exists(csc)) {
                string windir = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
                csc = Path.Combine(windir, @"Microsoft.NET\Framework64\v4.0.30319\csc.exe");
                if (!File.Exists(csc)) {
                    csc = Path.Combine(windir, @"Microsoft.NET\Framework\v4.0.30319\csc.exe");
                }
            }
            string cscArgs = "/target:library /out:\"" + fullOut + "\"";
            if (embedPath != null) {
                cscArgs += " /res:\"" + embedPath + "\"";
            }
            var psi = new ProcessStartInfo(csc, cscArgs) {
                UseShellExecute = false,
                CreateNoWindow = true
            };
            var p = Process.Start(psi);
            p.WaitForExit();
            return p.ExitCode;
        }
        return 0;
    }
}
