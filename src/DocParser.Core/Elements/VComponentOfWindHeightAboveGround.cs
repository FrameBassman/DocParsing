using DocParser.Core.Service;
using HtmlAgilityPack;

namespace DocParser.Core.Elements
{
    public class VComponentOfWindHeightAboveGround : BaseElement
    {
        private readonly BaseElement Coordinates = new BaseElement("/html/body/ul/ul/li[57]");
        private readonly BaseElement Description = new BaseElement("/html/body/ul/ul/li[55]");
        private readonly BaseElement Grib1Center = new BaseElement("/html/body/ul/ul/li[59]");
        private readonly BaseElement Grib1LevelDesc = new BaseElement("/html/body/ul/ul/li[64]");
        private readonly BaseElement Grib1LevelType = new BaseElement("/html/body/ul/ul/li[63]");
        private readonly BaseElement Grib1Parameter = new BaseElement("/html/body/ul/ul/li[62]");
        private readonly BaseElement Grib1Subcenter = new BaseElement("/html/body/ul/ul/li[60]");
        private readonly BaseElement Grib1TableVersion = new BaseElement("/html/body/ul/ul/li[61]");
        private readonly BaseElement GribVariableId = new BaseElement("/html/body/ul/ul/li[58]");
        private readonly BaseElement GridMapping = new BaseElement("/html/body/ul/ul/li[56]");
        private readonly BaseElement LongName = new BaseElement("/html/body/ul/ul/li[52]");
        private readonly BaseElement MissingValue = new BaseElement("/html/body/ul/ul/li[54]");
        private readonly BaseElement Units = new BaseElement("/html/body/ul/ul/li[53]");


        public VComponentOfWindHeightAboveGround(string xpath) : base(xpath)
        {
            LongName = new BaseElement("/html/body/ul/ul/li[52]");
            Units = new BaseElement("/html/body/ul/ul/li[53]");
            MissingValue = new BaseElement("/html/body/ul/ul/li[54]");
            Description = new BaseElement("/html/body/ul/ul/li[55]");
            GridMapping = new BaseElement("/html/body/ul/ul/li[56]");
            Coordinates = new BaseElement("/html/body/ul/ul/li[57]");
            GribVariableId = new BaseElement("/html/body/ul/ul/li[58]");
            Grib1Center = new BaseElement("/html/body/ul/ul/li[59]");
            Grib1Subcenter = new BaseElement("/html/body/ul/ul/li[60]");
            Grib1TableVersion = new BaseElement("/html/body/ul/ul/li[61]");
            Grib1Parameter = new BaseElement("/html/body/ul/ul/li[62]");
            Grib1LevelType = new BaseElement("/html/body/ul/ul/li[63]");
            Grib1LevelDesc = new BaseElement("/html/body/ul/ul/li[64]");
        }

        public override void LoadFromDocument(HtmlDocument htmlDocument)
        {
            base.LoadFromDocument(htmlDocument);

            LongName.LoadFromDocument(htmlDocument);
            Units.LoadFromDocument(htmlDocument);
            MissingValue.LoadFromDocument(htmlDocument);
            Description.LoadFromDocument(htmlDocument);
            GridMapping.LoadFromDocument(htmlDocument);
            Coordinates.LoadFromDocument(htmlDocument);
            GribVariableId.LoadFromDocument(htmlDocument);
            Grib1Center.LoadFromDocument(htmlDocument);
            Grib1Subcenter.LoadFromDocument(htmlDocument);
            Grib1TableVersion.LoadFromDocument(htmlDocument);
            Grib1Parameter.LoadFromDocument(htmlDocument);
            Grib1LevelType.LoadFromDocument(htmlDocument);
            Grib1LevelDesc.LoadFromDocument(htmlDocument);
        }

        public override bool Validate()
        {
            return LongName.Validate()
                   && Units.Validate()
                   && MissingValue.Validate()
                   && Description.Validate()
                   && GridMapping.Validate()
                   && Coordinates.Validate()
                   && GribVariableId.Validate()
                   && Grib1Center.Validate()
                   && Grib1Subcenter.Validate()
                   && Grib1TableVersion.Validate()
                   && Grib1Parameter.Validate()
                   && Grib1LevelType.Validate()
                   && Grib1LevelDesc.Validate();
        }
    }
}