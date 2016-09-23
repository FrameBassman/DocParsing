using System;
using System.Configuration;
using System.IO;

namespace DocParser.Core
{
    using System.Collections.Generic;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var p = new Program();
            p.Run();
        }

        private void Run()
        {
            var files = Directory.GetFiles(ConfigurationManager.AppSettings["PathToOutputFiles"]);
            DocumentProcessor documentProcessor = new DocumentProcessor();
            List<Document> list = new List<Document>();

            foreach (string file in files)
            {

                list.Add(new Document(new FileInfo(file)));
            }

            string r = documentProcessor.ValidateDocumentNames(list);
            Console.WriteLine(r);
        }
    }
}