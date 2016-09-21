using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace DocParser.Decoder
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var p = new Program();
            p.Run();
        }

        private void Run()
        {
            var pathToFiles = ConfigurationManager.AppSettings["PathToFiles"];
            var pathToJavaBin = ConfigurationManager.AppSettings["PathToJavaBin"];
            if (string.IsNullOrEmpty(pathToFiles))
            {
                Console.WriteLine("PathToFiles config is empty.");
                return;
            }

            if (string.IsNullOrEmpty(pathToJavaBin))
            {
                Console.WriteLine("PathToJavaBin config is empty.");
                return;
            }

            var files = Directory.GetFiles(pathToFiles);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Parallel.ForEach(files, ProcessFile);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
        }

        private void ProcessFile(string file)
        {
            var candidate = new FileInfo(file);
            if (string.IsNullOrEmpty(candidate.Extension))
            {
                var code = DecodeFile(candidate);
                if (code != 0)
                {
                    Console.WriteLine("File {0} is incorrect. Decode process finished with error code {1}",
                        candidate.Name, code);
                }
                Console.WriteLine("File {0} is proceedeed.", candidate.Name);
            }
        }

        private int DecodeFile(FileInfo fileInfo)
        {
            var currentPath = Directory.GetCurrentDirectory();
            var jarPath = Path.Combine(currentPath, @"..\..\..\3dparty\grib-parser\grib.jar");
            var pathToJavaBin = ConfigurationManager.AppSettings["PathToJavaBin"];

            var outputDirectory = Path.Combine(currentPath, "OutputFiles");
            Directory.CreateDirectory(outputDirectory);

            var inputFile = Path.Combine(fileInfo.FullName);
            var outputFile = Path.Combine(outputDirectory, fileInfo.Name + ".html");

            var clientProcess = new Process();
            clientProcess.StartInfo = new ProcessStartInfo
            {
                FileName = Path.Combine(pathToJavaBin, "java.exe"),
                Arguments = @"-jar " + jarPath + " " + inputFile + " " + outputFile,
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = false,
                RedirectStandardOutput = true
            };
            clientProcess.Start();
            clientProcess.WaitForExit();

            return clientProcess.ExitCode;
        }
    }
}