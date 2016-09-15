using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            var appSettings = ConfigurationManager.AppSettings;
            DocumentProcessor documentProcessor = new DocumentProcessor();
            List<Document> docs = PrepareDocuments(appSettings["PathToFiles"]);

            foreach (Document document in docs)
            {
                documentProcessor.Process(document);
            }
        }

        private static List<Document> PrepareDocuments(string pathToDir)
        {
            List<Document> docsList = new List<Document>();
            foreach (string path in Directory.GetFiles(pathToDir))
            {
                try
                {
                    Document candidateDocument = new Document(new FileInfo(path));
                    docsList.Add(candidateDocument);
                }
                catch (InvalidDataException e)
                {
                    continue;
                }
                
            }
            return docsList;
        }
    }
}
