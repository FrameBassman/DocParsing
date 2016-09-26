using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DocParser.Decoder
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var p = new Program();
            p.Run();
        }

        public void Run()
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

            var outputDirectory = ConfigurationManager.AppSettings["PathToOutputFiles"];
            if (Directory.Exists(outputDirectory))
            {
                Directory.Delete(outputDirectory);
            }
            Directory.CreateDirectory(outputDirectory);

            var files = Directory.GetFiles(pathToFiles);
            Parallel.ForEach(files, ProcessFile);
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
            var outputDirectory = ConfigurationManager.AppSettings["PathToOutputFiles"];

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

            File.Delete(inputFile + ".ncx2");
            File.Delete(inputFile + ".gbx9");

            return clientProcess.ExitCode;
        }
    }
}