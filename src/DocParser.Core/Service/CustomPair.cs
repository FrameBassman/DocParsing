using System.Text.RegularExpressions;

namespace DocParser.Core.Service
{
    public class CustomPair
    {
        public string Key;

        public string Value;

        public CustomPair(string s)
        {
            string s1 = s.Replace('"', '\'');
            Regex keyRegex = new Regex(@"(?<=\:)(.*?)(?=\s)");
            Regex valueRegex = new Regex(@"(?<=\')(.*?)(?=\')");

            Match keyMatch = keyRegex.Match(s1);
            Match valueMatch = valueRegex.Match(s1);

            if (keyMatch.Success)
            {
                this.Key = keyMatch.Value.Trim(':');
            }
            if (valueMatch.Success)
            {
                this.Value = valueMatch.Value;
            }
        }
    }
}
