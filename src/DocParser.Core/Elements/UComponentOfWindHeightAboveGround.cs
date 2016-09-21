using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocParser.Core.Service;
using HtmlAgilityPack;

namespace DocParser.Core.Elements
{
    public class UComponentOfWindHeightAboveGround : BaseElement
    {
        private BaseElement LongName;

        private BaseElement Units;

        private BaseElement MissingValue;

        private BaseElement Description;

        private BaseElement GridMapping;

        private BaseElement Coordinates;

        private BaseElement GribVariableId;

        private BaseElement Grib1Center;

        private BaseElement Grib1Subcenter;

        private BaseElement Grib1TableVersion;

        private BaseElement Grib1Parameter;

        private BaseElement Grib1LevelType;

        private BaseElement Grib1LevelDesc;


        public UComponentOfWindHeightAboveGround(string xpath) : base(xpath)
        {
            this.LongName = new BaseElement("/html/body/ul/ul/li[39]");
            this.Units = new BaseElement("/html/body/ul/ul/li[40]");
            this.MissingValue = new BaseElement("/html/body/ul/ul/li[41]");
            this.Description = new BaseElement("/html/body/ul/ul/li[42]");
            this.GridMapping = new BaseElement("/html/body/ul/ul/li[43]");
            this.Coordinates = new BaseElement("/html/body/ul/ul/li[44]");
            this.GribVariableId = new BaseElement("/html/body/ul/ul/li[45]");
            this.Grib1Center = new BaseElement("/html/body/ul/ul/li[46]");
            this.Grib1Subcenter = new BaseElement("/html/body/ul/ul/li[47]");
            this.Grib1TableVersion = new BaseElement("/html/body/ul/ul/li[48]");
            this.Grib1Parameter = new BaseElement("/html/body/ul/ul/li[49]");
            this.Grib1LevelType = new BaseElement("/html/body/ul/ul/li[50]");
            this.Grib1LevelDesc = new BaseElement("/html/body/ul/ul/li[51]");
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
