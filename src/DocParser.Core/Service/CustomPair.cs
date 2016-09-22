using System.Text.RegularExpressions;

namespace DocParser.Core.Service
{
    public class CustomPair
    {
        public string Key;

        public string Value;

        public CustomPair(string s)
        {
            string preparedString = s.Replace(":", "").Replace("\"", "").Replace(" ", "").Replace(";", "");
            string[] stringArray = preparedString.Split('=');

            int c = stringArray.Length;
            
            if (c > 0 && !string.IsNullOrEmpty(stringArray[0]))
            {
                this.Key = stringArray[0];
            }
            if (c > 1 && !string.IsNullOrEmpty(stringArray[1]))
            {
                this.Value = stringArray[1];
            }
        }
    }
}
