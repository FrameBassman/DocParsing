using DocParser.Core.Service;
using HtmlAgilityPack;

namespace DocParser.Core.Elements
{
    internal class AltitudeAboveMsl : BaseElement
    {
        private readonly BaseElement Datum;

        private readonly BaseElement GribLevelType;

        private readonly BaseElement LongName;

        private readonly BaseElement Positive;
        private readonly BaseElement Units;

        public AltitudeAboveMsl(string xpath) : base(xpath)
        {
            Units = new BaseElement("/html/body/ul/ul/li[16]");
            LongName = new BaseElement("/html/body/ul/ul/li[17]");
            Positive = new BaseElement("/html/body/ul/ul/li[18]");
            GribLevelType = new BaseElement("/html/body/ul/ul/li[19]");
            Datum = new BaseElement("/html/body/ul/ul/li[20]");
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