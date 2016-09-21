using HtmlAgilityPack;

namespace DocParser.Core.Service
{
    public class BaseElement
    {
        public string Xpath;
        
        protected CustomPair CustomPair;

        public BaseElement(string xpath)
        {
            this.Xpath = xpath;
        }

        public virtual void LoadFromDocument(HtmlDocument htmlDocument)
        {
            this.CustomPair = new CustomPair(htmlDocument.DocumentNode.SelectNodes(this.Xpath)[0].InnerText);
        }
    }
}
