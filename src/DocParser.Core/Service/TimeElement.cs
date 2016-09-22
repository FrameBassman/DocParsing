using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace DocParser.Core.Service
{
    class TimeElement : BaseElement
    {
        public TimeElement(string xpath) : base(xpath)
        {
        }

        public DateTime GetTime()
        {
            DateTime result = new DateTime();
            Regex regex = new Regex(@"[0-9].*?[Z]");
            Match match = regex.Match(this.CustomPair.Value);
            if (match.Success)
            {
                result = DateTime.ParseExact(match.Value, "yyyy-MM-ddTHHmm00Z", CultureInfo.GetCultureInfo("ru")).ToUniversalTime();
            }

            return result;
        }
    }
}
