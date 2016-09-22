using DocParser.Core.Service;
using HtmlAgilityPack;

namespace DocParser.Core.Elements
{
    internal class PressureAltitudeAboveMsl : BaseElement
    {
        public BaseElement Coordinates;

        public BaseElement Description;

        public BaseElement Grib1Center;

        public BaseElement Grib1LevelDesc;

        public BaseElement Grib1LevelType;

        public BaseElement Grib1Parameter;

        public BaseElement Grib1Subcenter;

        public BaseElement Grib1TableVersion;

        public BaseElement GribVariableId;

        public BaseElement GridMapping;

        public BaseElement LongName;

        public BaseElement MissingValue;

        public BaseElement Units;

        public PressureAltitudeAboveMsl(string xpath) : base(xpath)
        {
            LongName = new BaseElement("/html/body/ul/ul/li[26]");
            Units = new BaseElement("/html/body/ul/ul/li[27]");
            MissingValue = new BaseElement("/html/body/ul/ul/li[28]");
            Description = new BaseElement("/html/body/ul/ul/li[29]");
            GridMapping = new BaseElement("/html/body/ul/ul/li[30]");
            Coordinates = new BaseElement("/html/body/ul/ul/li[31]");
            GribVariableId = new BaseElement("/html/body/ul/ul/li[32]");
            Grib1Center = new BaseElement("/html/body/ul/ul/li[33]");
            Grib1Subcenter = new BaseElement("/html/body/ul/ul/li[34]");
            Grib1TableVersion = new BaseElement("/html/body/ul/ul/li[35]");
            Grib1Parameter = new BaseElement("/html/body/ul/ul/li[36]");
            Grib1LevelType = new BaseElement("/html/body/ul/ul/li[37]");
            Grib1LevelDesc = new BaseElement("/html/body/ul/ul/li[38]");
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