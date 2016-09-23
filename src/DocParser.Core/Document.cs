using System;
using System.Globalization;
using System.IO;
using DocParser.Core.Elements;
using HtmlAgilityPack;

namespace DocParser.Core
{
    public class Document : IComparable
    {
        private Dimensions dimensions;

        public readonly DateTime From;

        public TimeSpan Timeliness;

        public string Name;

        public string Path;
        
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

            try
            {
                From = DateTime.ParseExact(timeStrings[0], "yyyyMMddHHmm", CultureInfo.GetCultureInfo("ru"));
                var parts = timeStrings[1].Substring(0, timeStrings[1].Length - 1).Split('H');
                var hours = int.Parse(parts[0]);
                var minutes = int.Parse(parts[1]);
                Timeliness = new TimeSpan(hours, minutes, 0);
            }
            catch (Exception e)
            {
                Console.WriteLine("File {0} contains incorrect name", this.Name);
            }

            Name = fileInfo.Name;
        }

        public string Validate()
        {
            string result = string.Empty;
            if (variables.Validate())
            {
                result += $"File {this.Name} is not contains pressure or wind variables\n";
            }

            result += ValidateDates();

            return result;
        }

        private string ValidateDates()
        {
            if (DateTime.Equals(variables.GetTime(), From))
            {
                return string.Empty;
            }

            return "From is different between content and filename\n";
        }

        private void LoadFromDocument(HtmlDocument doc)
        {
            dimensions = new Dimensions("/html/body/ul/text()");
            dimensions.LoadFromDocument(doc);
            variables = new Variables("/html/body/ul/ul/text()");
            variables.LoadFromDocument(doc);
        }

        public int CompareTo(object document)
        {
            if (this.From < ((Document)document).From)
            {
                return -1;
            }
            else
            {
                if (this.From > ((Document)document).From)
                {
                    return 1;
                }
                else
                {
                    if (this.Timeliness < ((Document)document).Timeliness)
                    {
                        return -1;
                    }
                    else
                    {
                        if (this.Timeliness > ((Document)document).Timeliness)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}