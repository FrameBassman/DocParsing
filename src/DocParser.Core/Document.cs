using System;
using System.Globalization;
using System.IO;
using DocParser.Core.Elements;
using HtmlAgilityPack;

namespace DocParser.Core
{
    public class Document
    {
        private Dimensions dimensions;
        private readonly DateTime From;

        public string Name;

        public string Path;

        private TimeSpan Timeliness;

        private Variables variables;

        public Document(FileInfo fileInfo)
        {
            var document = new HtmlDocument();
            document.Load(fileInfo.FullName);
            LoadFromDocument(document);

            Path = fileInfo.FullName;
            string[] strings;
            string[] timeStrings;
            try
            {
                strings = System.IO.Path.GetFileNameWithoutExtension(fileInfo.Name).Split('_');
                timeStrings = strings[2].Split('+');
            }
            catch (IndexOutOfRangeException exception)
            {
                throw exception;
            }

            From = DateTime.ParseExact(timeStrings[0], "yyyyMMddHHmm", CultureInfo.GetCultureInfo("ru"));
            var parts = timeStrings[1].Substring(0, timeStrings[1].Length - 1).Split('H');
            var hours = int.Parse(parts[0]);
            var minutes = int.Parse(parts[1]);
            Timeliness = new TimeSpan(hours, minutes, 0);

            Name = fileInfo.Name;
        }

        public bool Validate()
        {
            return variables.Validate() && ValidateDates();
        }

        private bool ValidateDates()
        {
            return DateTime.Equals(variables.GetTime(), From);
        }

        private void LoadFromDocument(HtmlDocument doc)
        {
            dimensions = new Dimensions("/html/body/ul/text()");
            dimensions.LoadFromDocument(doc);
            variables = new Variables("/html/body/ul/ul/text()");
            variables.LoadFromDocument(doc);
        }
    }
}