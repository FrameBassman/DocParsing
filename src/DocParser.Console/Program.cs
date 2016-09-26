using System.Collections.Generic;
using System.Configuration;
using System.IO;
using DocParser.Core;

namespace DocParser.Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var decoderProgram = new Decoder.Program();
            decoderProgram.Run();

            var p = new Program();
            p.Run();
        }

        private void Run()
        {
            if (string.IsNullOrEmpty(ConfigurationManager.AppSettings["PathToOutputFiles"]))
            {
                System.Console.WriteLine("PathToOutputFiles confing is empty.");
                return;
            }

            var files = Directory.GetFiles(ConfigurationManager.AppSettings["PathToOutputFiles"]);
            var documentProcessor = new DocumentProcessor();
            var list = new List<Document>();

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);
                var candidate = Document.Parse(fileInfo);
                if (candidate.NameIsValid)
                {
                    list.Add(candidate);
                }
                else
                {
                    System.Console.WriteLine("File name is not valid: {0}", fileInfo.Name);
                }
            }

            var r = documentProcessor.ValidateDocumentNames(list);
            System.Console.WriteLine(r);
        }
    }
}