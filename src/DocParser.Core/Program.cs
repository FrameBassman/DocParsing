using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace DocParser.Core
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var appSettings = ConfigurationManager.AppSettings;
            var documentProcessor = new DocumentProcessor();
            var docs = PrepareDocuments(appSettings["PathToFiles"]);

            Environment.SetEnvironmentVariable("GRIB_API_DIR_ROOT", @"D:\Projects\git-docparsing\src\Grib.Api",
                EnvironmentVariableTarget.Process);

            foreach (var document in docs)
            {
                documentProcessor.Process(document);
            }

            Console.WriteLine(documentProcessor.InvalidDocsCounter);
            Console.WriteLine(docs.Count);
            Console.ReadLine();
        }

        private static List<Document> PrepareDocuments(string pathToDir)
        {
            var docsList = new List<Document>();
            foreach (var path in Directory.GetFiles(pathToDir))
            {
                try
                {
                    var candidateDocument = new Document(new FileInfo(path));
                    docsList.Add(candidateDocument);
                }
                catch (Exception e)
                {
                }
            }
            return docsList;
        }
    }
}