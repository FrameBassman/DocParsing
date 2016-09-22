using DocParser.Core.Service;
using HtmlAgilityPack;

namespace DocParser.Core.Elements
{
    public class UComponentOfWindHeightAboveGround : BaseElement
    {
        private readonly BaseElement Coordinates;

        private readonly BaseElement Description;

        private readonly BaseElement Grib1Center;

        private readonly BaseElement Grib1LevelDesc;

        private readonly BaseElement Grib1LevelType;

        private readonly BaseElement Grib1Parameter;

        private readonly BaseElement Grib1Subcenter;

        private readonly BaseElement Grib1TableVersion;

        private readonly BaseElement GribVariableId;

        private readonly BaseElement GridMapping;

        private readonly BaseElement LongName;

        private readonly BaseElement MissingValue;

        private readonly BaseElement Units;


        public UComponentOfWindHeightAboveGround(string xpath) : base(xpath)
        {
            LongName = new BaseElement("/html/body/ul/ul/li[39]");
            Units = new BaseElement("/html/body/ul/ul/li[40]");
            MissingValue = new BaseElement("/html/body/ul/ul/li[41]");
            Description = new BaseElement("/html/body/ul/ul/li[42]");
            GridMapping = new BaseElement("/html/body/ul/ul/li[43]");
            Coordinates = new BaseElement("/html/body/ul/ul/li[44]");
            GribVariableId = new BaseElement("/html/body/ul/ul/li[45]");
            Grib1Center = new BaseElement("/html/body/ul/ul/li[46]");
            Grib1Subcenter = new BaseElement("/html/body/ul/ul/li[47]");
            Grib1TableVersion = new BaseElement("/html/body/ul/ul/li[48]");
            Grib1Parameter = new BaseElement("/html/body/ul/ul/li[49]");
            Grib1LevelType = new BaseElement("/html/body/ul/ul/li[50]");
            Grib1LevelDesc = new BaseElement("/html/body/ul/ul/li[51]");
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