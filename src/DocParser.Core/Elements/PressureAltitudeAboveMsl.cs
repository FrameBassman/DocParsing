using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocParser.Core.Service;
using HtmlAgilityPack;

namespace DocParser.Core.Elements
{
    class PressureAltitudeAboveMsl : BaseElement
    {
        public BaseElement LongName;

        public BaseElement Units;

        public BaseElement MissingValue;

        public BaseElement Description;

        public BaseElement GridMapping;

        public BaseElement Coordinates;

        public BaseElement GribVariableId;

        public BaseElement Grib1Center;

        public BaseElement Grib1Subcenter;

        public BaseElement Grib1TableVersion;

        public BaseElement Grib1Parameter;

        public BaseElement Grib1LevelType;

        public BaseElement Grib1LevelDesc;

        public PressureAltitudeAboveMsl(string xpath) : base(xpath)
        {
            this.LongName = new BaseElement("/html/body/ul/ul/li[26]");
            this.Units = new BaseElement("/html/body/ul/ul/li[27]");
            this.MissingValue = new BaseElement("/html/body/ul/ul/li[28]");
            this.Description = new BaseElement("/html/body/ul/ul/li[29]");
            this.GridMapping = new BaseElement("/html/body/ul/ul/li[30]");
            this.Coordinates = new BaseElement("/html/body/ul/ul/li[31]");
            this.GribVariableId = new BaseElement("/html/body/ul/ul/li[32]");
            this.Grib1Center = new BaseElement("/html/body/ul/ul/li[33]");
            this.Grib1Subcenter = new BaseElement("/html/body/ul/ul/li[34]");
            this.Grib1TableVersion = new BaseElement("/html/body/ul/ul/li[35]");
            this.Grib1Parameter = new BaseElement("/html/body/ul/ul/li[36]");
            this.Grib1LevelType = new BaseElement("/html/body/ul/ul/li[37]");
            this.Grib1LevelDesc = new BaseElement("/html/body/ul/ul/li[38]");
        }

        public override void LoadFromDocument(HtmlDocument htmlDocument)
        {
            base.LoadFromDocument(htmlDocument);

            this.LongName.LoadFromDocument(htmlDocument);
            this.Units.LoadFromDocument(htmlDocument);
            this.MissingValue.LoadFromDocument(htmlDocument);
            this.Description.LoadFromDocument(htmlDocument);
            this.GridMapping.LoadFromDocument(htmlDocument);
            this.Coordinates.LoadFromDocument(htmlDocument);
            this.GribVariableId.LoadFromDocument(htmlDocument);
            this.Grib1Center.LoadFromDocument(htmlDocument);
            this.Grib1Subcenter.LoadFromDocument(htmlDocument);
            this.Grib1TableVersion.LoadFromDocument(htmlDocument);
            this.Grib1Parameter.LoadFromDocument(htmlDocument);
            this.Grib1LevelType.LoadFromDocument(htmlDocument);
            this.Grib1LevelDesc.LoadFromDocument(htmlDocument);
        }
    }
}
