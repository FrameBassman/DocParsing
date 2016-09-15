using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class Document
    {
        public Encoding Encoding;

        private DateTime From;

        private DateTime To;

        public string Extention;

        public string Path;

        public Document(FileInfo fileInfo)
        {
            if (!this.IsValidFileName(fileInfo.Name))
            {
                throw new InvalidDataException("Invalid file name.");
            }

            this.Path = fileInfo.FullName;
            this.Extention = fileInfo.Extension;
            string[] strings = fileInfo.Name.Split('.');
            this.From = new DateTime(Convert.ToInt32(strings[3]), Convert.ToInt32(strings[2]), Convert.ToInt32(strings[1]));
            this.To = new DateTime(Convert.ToInt32(strings[6]), Convert.ToInt32(strings[5]), Convert.ToInt32(strings[4]));
            switch (strings[11].ToLower())
            {
                case "ansi":
                    this.Encoding = Encoding.ASCII;
                    break;
                case "bigendianunicode":
                    this.Encoding = Encoding.BigEndianUnicode;
                    break;
                case "utf32":
                    this.Encoding = Encoding.UTF32;
                    break;
                case "utf7":
                    this.Encoding = Encoding.UTF7;
                    break;
                case "utf8":
                    this.Encoding = Encoding.UTF8;
                    break;
                case "unicode":
                    this.Encoding = Encoding.Unicode;
                    break;
                default:
                    this.Encoding = Encoding.Default;
                    break;
            }
        }

        private bool IsValidFileName(string fileName)
        {
            string pattern = @"\d{5}.\d{2}.\d{2}.\d{4}.\d{2}.\d{2}.\d{4}.\d.\d.\d.\w{2}.\w{4}.\d{8}";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            MatchCollection matches = regex.Matches(fileName);

            if (matches.Count > 0 && matches[0].Groups.Count > 0)
            {
                return (fileName.Length - matches[0].Groups[0].Length == 4);
            }
            return false;
        }
    }
}
