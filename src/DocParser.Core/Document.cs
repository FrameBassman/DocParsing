namespace DocParser.Core
{
    using System;
    using System.Globalization;
    using System.IO;

    using DocParser.Core.Elements;

    using HtmlAgilityPack;

    public class Document : IComparable
    {
        public readonly DateTime From;

        public bool NameIsValid;

        public string Name;

        public string Path;

        public TimeSpan Timeliness;

        private Dimensions Dimensions;

        private readonly Variables Variables;

        private Document(
            DateTime from,
            TimeSpan timeliness,
            string name,
            string path,
            Dimensions dimensions,
            Variables variables,
            bool nameIsValid)
        {
            this.From = from;
            this.Timeliness = timeliness;
            this.Name = name;
            this.Path = path;
            this.Dimensions = dimensions;
            this.Variables = variables;
            this.NameIsValid = nameIsValid;
        }

        public int CompareTo(object document)
        {
            if (this.From < ((Document)document).From)
            {
                return -1;
            }
            if (this.From > ((Document)document).From)
            {
                return 1;
            }
            if (this.Timeliness < ((Document)document).Timeliness)
            {
                return -1;
            }
            if (this.Timeliness > ((Document)document).Timeliness)
            {
                return 1;
            }
            return 0;
        }

        public static Document Parse(FileInfo fileInfo)
        {
            string[] strings;
            string[] timeStrings;
            var document = new HtmlDocument();
            var from = DateTime.MinValue;
            var timeliness = TimeSpan.MinValue;
            var dims = new Dimensions("/html/body/ul/text()");
            var vars = new Variables("/html/body/ul/ul/text()");
            var path = fileInfo.FullName;
            var name = fileInfo.Name;
            bool nameIsValid = true;

            document.Load(fileInfo.FullName);
            dims.LoadFromDocument(document);
            vars.LoadFromDocument(document);

            try
            {
                strings = System.IO.Path.GetFileNameWithoutExtension(fileInfo.Name).Split('_');
                timeStrings = strings[2].Split('+');
                from = DateTime.ParseExact(timeStrings[0], "yyyyMMddHHmm", CultureInfo.GetCultureInfo("ru"));

                var parts = timeStrings[1].Substring(0, timeStrings[1].Length - 1).Split('H');
                var hours = int.Parse(parts[0]);
                var minutes = int.Parse(parts[1]);
                timeliness = new TimeSpan(hours, minutes, 0);
            }
            catch (Exception e)
            {
                nameIsValid = false;
            }

            return new Document(from, timeliness, name, path, dims, vars, nameIsValid);
        }

        public string Validate()
        {
            var result = string.Empty;
            if (this.Variables.Validate())
            {
                result += $"File {this.Name} is not contains pressure or wind variables\n";
            }

            result += this.ValidateDates();

            return result;
        }

        private string ValidateDates()
        {
            if (DateTime.Equals(this.Variables.GetTime(), this.From))
            {
                return string.Empty;
            }

            return "From is different between content and filename\n";
        }
    }
}