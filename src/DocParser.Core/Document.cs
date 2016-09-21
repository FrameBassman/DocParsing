using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using DocParser.Core.Service;

namespace DocParser.Core
{
    public class Document
    {
        private DateTime From;

        public string Name;

        public string Path;

        private TimeSpan Timeliness;

        public Document(FileInfo fileInfo)
        {
            Path = fileInfo.FullName;
            string[] strings;
            string[] timeStrings;
            try
            {
                strings = fileInfo.Name.Split('_');
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
    }
}