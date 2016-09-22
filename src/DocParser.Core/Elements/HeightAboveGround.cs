using DocParser.Core.Service;
using HtmlAgilityPack;

namespace DocParser.Core.Elements
{
    internal class HeightAboveGround : BaseElement
    {
        private readonly BaseElement Datum;

        private readonly BaseElement GribLevelType;

        private readonly BaseElement LongName;

        private readonly BaseElement Positive;
        private readonly BaseElement Units;

        public HeightAboveGround(string xpath) : base(xpath)
        {
            Units = new BaseElement("/html/body/ul/ul/li[21]");
            LongName = new BaseElement("/html/body/ul/ul/li[22]");
            Positive = new BaseElement("/html/body/ul/ul/li[23]");
            GribLevelType = new BaseElement("/html/body/ul/ul/li[24]");
            Datum = new BaseElement("/html/body/ul/ul/li[25]");
        }

        public override void LoadFromDocument(HtmlDocument htmlDocument)
        {
            base.LoadFromDocument(htmlDocument);

            Units.LoadFromDocument(htmlDocument);
            LongName.LoadFromDocument(htmlDocument);
            Positive.LoadFromDocument(htmlDocument);
            GribLevelType.LoadFromDocument(htmlDocument);
            Datum.LoadFromDocument(htmlDocument);
        }
    }
}