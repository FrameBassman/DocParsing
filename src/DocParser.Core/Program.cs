using System;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using DocParser.Core.Elements;
using DocParser.Core.Service;
using HtmlAgilityPack;

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
            var pathToFiles = ConfigurationManager.AppSettings["PathToFiles"];
            //var files = Directory.GetFiles(@"D:\Projects\git-docparsing\src\DocParser.Decoder\bin\Debug\OutputFiles");
            var files = Directory.GetFiles(@"D:\Project\git-docparsing\src\DocParser.Decoder\bin\Debug\OutputFiles");

            //var doc = new Document(new FileInfo(files.First()));
            //doc.Validate();

            List<Document> list = new List<Document>();
            foreach (string file in files)
            {
                list.Add(new Document(new FileInfo(file)));
            }

            var r = this.ValidateDocumentNames(list);

            //this.VerifyFile(htmlDocument);
        }



        private bool ValidateDocumentNames(List<Document> docs)
        {
            bool result = true;
            DateTime minFrom = DateTime.MaxValue;
            DateTime maxFrom = DateTime.MinValue;
            TimeSpan minTimeliness = TimeSpan.MinValue;
            TimeSpan maxTimeliness = TimeSpan.MaxValue;
            TimeSpan currentFromStep = docs[1].From - docs[0].From;
            TimeSpan previousFromStep = docs[1].From - docs[0].From;
            TimeSpan currentTimelinessStep = docs[1].Timeliness - docs[0].Timeliness;
            TimeSpan previousTimelinessStep = docs[1].Timeliness - docs[0].Timeliness;

            for (int i = 0; i < docs.Count; i++)
            {
                if (minFrom > docs[i].From)
                {
                    minFrom = docs[i].From;
                }

                if (maxFrom < docs[i].From)
                {
                    maxFrom = docs[i].From;
                }

                if (minTimeliness > docs[i].Timeliness)
                {
                    minTimeliness = docs[i].Timeliness;
                }

                if (maxTimeliness < docs[i].Timeliness)
                {
                    maxTimeliness = docs[i].Timeliness;
                }

                if (!(i + 1 > docs.Count))
                {
                    currentFromStep = docs[i + 1].From - docs[i].From;
                    currentTimelinessStep = docs[i + 1].Timeliness - docs[i].Timeliness;

                    if (currentFromStep != previousFromStep)
                    {
                        Console.WriteLine("Document list is invalid: missed file between {0} and {1}", docs[i].Name, docs[i + 1].Name);
                        i++;
                        result = false;
                        continue;
                    }

                    if (currentTimelinessStep != previousTimelinessStep)
                    {
                        Console.WriteLine("Document list is invalid: timeliness step is incorrect between the following files: {0} and {1}", docs[i].Name, docs[i + 1].Name);
                        i++;
                        result = false;
                        continue;
                    }

                    previousFromStep = currentFromStep;
                    previousTimelinessStep = currentTimelinessStep;
                }
            }

            return result;
        }
    }
}