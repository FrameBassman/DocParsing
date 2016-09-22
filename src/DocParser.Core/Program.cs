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
    internal class Program
    {
        private readonly string Reftime = @"/html/body/ul/ul/li[9]";
        private string ResourceName = @"/html/head/meta[3]";


        private static void Main(string[] args)
        {
            var p = new Program();
            p.Run();
        }

        private void Run()
        {
            var pathToFiles = ConfigurationManager.AppSettings["PathToFiles"];
            var files = Directory.GetFiles(@"D:\Projects\git-docparsing\src\DocParser.Decoder\bin\Debug\OutputFiles");

            var doc = new Document(new FileInfo(files.First()));
            doc.Validate();

            //List<Document> list = new List<Document>();
            //foreach (string file in files)
            //{
            //    list.Add(new Document(new FileInfo(file)));
            //}

            //this.VerifyFile(htmlDocument);
        }

        private void VerifyFile(HtmlDocument file)
        {
            var customPair = new CustomPair(file.DocumentNode.SelectNodes(Reftime)[0].InnerText);
            var dtTime = DateTime.ParseExact("2014-06-25T00:00:00Z", "yyyy-MM-ddThh:mm:ssZ", new DateTimeFormatInfo());

            var rotatedLatLonProjection = new RotatedLatLonProjection("/html/body/ul/ul/p[1]");
            rotatedLatLonProjection.LoadFromDocument(file);

            var reftime = new Reftime("/html/body/ul/ul/p[4]");
            reftime.LoadFromDocument(file);
        }
    }
}