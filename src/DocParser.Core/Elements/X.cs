using DocParser.Core.Service;
using HtmlAgilityPack;

namespace DocParser.Core.Elements
{
    internal class X : BaseElement
    {
        private readonly BaseElement StandardName;

        private readonly BaseElement Units;

        public X(string xpath) : base(xpath)
        {
            StandardName = new BaseElement("/html/body/ul/ul/li[5]");
            Units = new BaseElement("/html/body/ul/ul/li[6]");
        }

        public override void LoadFromDocument(HtmlDocument htmlDocument)
        {
            base.LoadFromDocument(htmlDocument);

            StandardName.LoadFromDocument(htmlDocument);
            Units.LoadFromDocument(htmlDocument);
        }
    }
}