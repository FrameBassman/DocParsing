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
        public BaseElement LongName = new BaseElement("/html/body/ul/ul/li[39]");
        public BaseElement Units = new BaseElement("/html/body/ul/ul/li[40]");
        public BaseElement MissingValue = new BaseElement("/html/body/ul/ul/li[41]");
        public BaseElement Description = new BaseElement("/html/body/ul/ul/li[42]");
        public BaseElement GridMapping = new BaseElement("/html/body/ul/ul/li[43]");
        public BaseElement Coordinates = new BaseElement("/html/body/ul/ul/li[44]");
        public BaseElement GribVariableId = new BaseElement("/html/body/ul/ul/li[45]");
        public BaseElement Grib1Center = new BaseElement("/html/body/ul/ul/li[46]");
        public BaseElement Grib1Subcenter = new BaseElement("/html/body/ul/ul/li[47]");
        public BaseElement Grib1TableVersion = new BaseElement("/html/body/ul/ul/li[48]");
        public BaseElement Grib1Parameter = new BaseElement("/html/body/ul/ul/li[49]");
        public BaseElement Grib1LevelType = new BaseElement("/html/body/ul/ul/li[50]");
        public BaseElement Grib1LevelDesc = new BaseElement("/html/body/ul/ul/li[51]");


        public UComponentOfWindHeightAboveGround(string xpath) : base(xpath)
        {
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
    }
}
