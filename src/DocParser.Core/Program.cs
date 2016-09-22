using System;
using System.Collections.Generic;
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
        private string ResourceName = @"/html/head/meta[3]";

        private string Reftime = @"/html/body/ul/ul/li[9]";


        
        private static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();
        }

        private void Run()
        {
            var pathToFiles = ConfigurationManager.AppSettings["PathToFiles"];
            var files = Directory.GetFiles(@"D:\Projects\git-docparsing\src\DocParser.Decoder\bin\Debug\OutputFiles");
            HtmlDocument htmlDocument = new HtmlDocument();
            htmlDocument.Load(files.First());

            Document document = new Document(new FileInfo(files.First()));

            this.VerifyFile(htmlDocument);
        }

        private void VerifyFile(HtmlDocument file)
        {
            CustomPair customPair = new CustomPair(file.DocumentNode.SelectNodes(this.Reftime)[0].InnerText);
            DateTime dtTime = DateTime.ParseExact("2014-06-25T00:00:00Z", "yyyy-MM-ddThh:mm:ssZ", new DateTimeFormatInfo());

            RotatedLatLonProjection rotatedLatLonProjection = new RotatedLatLonProjection("/html/body/ul/ul/p[1]");
            rotatedLatLonProjection.LoadFromDocument(file);

            Reftime reftime = new Reftime("/html/body/ul/ul/p[4]");
            reftime.LoadFromDocument(file);
        }
    }
}