using DocParser.Core.Service;
using HtmlAgilityPack;

namespace DocParser.Core.Elements
{
    internal class ReftimeIso : BaseElement
    {
        private readonly BaseElement Units;

        public ReftimeIso(string xpath) : base(xpath)
        {
            Units = new BaseElement("/html/body/ul/ul/li[8]");
        }

        public override void LoadFromDocument(HtmlDocument htmlDocument)
        {
            base.LoadFromDocument(htmlDocument);

            Units.LoadFromDocument(htmlDocument);
        }
    }
}