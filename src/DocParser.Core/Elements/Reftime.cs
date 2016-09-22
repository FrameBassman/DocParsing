using DocParser.Core.Service;
using HtmlAgilityPack;

namespace DocParser.Core.Elements
{
    public class Reftime : BaseElement
    {
        private readonly BaseElement LongName;

        private readonly BaseElement StandartName;

        private readonly BaseElement Units;

        public Reftime(string xpath) : base(xpath)
        {
            Units = new BaseElement("/html/body/ul/ul/li[9]");
            StandartName = new BaseElement("/html/body/ul/ul/li[10]");
            LongName = new BaseElement("/html/body/ul/ul/li[11]");
        }

        public override void LoadFromDocument(HtmlDocument htmlDocument)
        {
            base.LoadFromDocument(htmlDocument);

            Units.LoadFromDocument(htmlDocument);
            StandartName.LoadFromDocument(htmlDocument);
            LongName.LoadFromDocument(htmlDocument);
        }
    }
}