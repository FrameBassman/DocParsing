using HtmlAgilityPack;

namespace DocParser.Core.Service
{
    public class BaseElement
    {
        public CustomPair CustomPair;
        public string Xpath;

        public BaseElement(string xpath)
        {
            Xpath = xpath;
        }

        private string Value
        {
            get { return CustomPair.Value; }
            set { }
        }

        public virtual void LoadFromDocument(HtmlDocument htmlDocument)
        {
            CustomPair = new CustomPair(htmlDocument.DocumentNode.SelectNodes(Xpath)[0].InnerText);
            Value = CustomPair.Value;
        }

        public virtual bool Validate()
        {
            return !string.IsNullOrEmpty(CustomPair.Key) && !string.IsNullOrEmpty(CustomPair.Value);
        }
    }
}