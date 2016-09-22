using DocParser.Core.Service;
using HtmlAgilityPack;

namespace DocParser.Core.Elements
{
    internal class Y : BaseElement
    {
        private readonly BaseElement StandardName;

        private readonly BaseElement Units;

        public Y(string xpath) : base(xpath)
        {
            StandardName = new BaseElement("/html/body/ul/ul/li[7]");
            Units = new BaseElement("/html/body/ul/ul/li[8]");
        }

        public override void LoadFromDocument(HtmlDocument htmlDocument)
        {
            base.LoadFromDocument(htmlDocument);

            StandardName.LoadFromDocument(htmlDocument);
            Units.LoadFromDocument(htmlDocument);
        }
    }
}