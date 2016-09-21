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
        public BaseElement LongName = new BaseElement("/html/body/ul/ul/li[26]");
        public BaseElement Units = new BaseElement("/html/body/ul/ul/li[27]");
        public BaseElement MissingValue = new BaseElement("/html/body/ul/ul/li[28]");
        public BaseElement Description = new BaseElement("/html/body/ul/ul/li[29]");
        public BaseElement GridMapping = new BaseElement("/html/body/ul/ul/li[30]");
        public BaseElement Coordinates = new BaseElement("/html/body/ul/ul/li[31]");
        public BaseElement GribVariableId = new BaseElement("/html/body/ul/ul/li[32]");
        public BaseElement Grib1Center = new BaseElement("/html/body/ul/ul/li[33]");
        public BaseElement Grib1Subcenter = new BaseElement("/html/body/ul/ul/li[34]");
        public BaseElement Grib1TableVersion = new BaseElement("/html/body/ul/ul/li[35]");
        public BaseElement Grib1Parameter = new BaseElement("/html/body/ul/ul/li[36]");
        public BaseElement Grib1LevelType = new BaseElement("/html/body/ul/ul/li[37]");
        public BaseElement Grib1LevelDesc = new BaseElement("/html/body/ul/ul/li[38]");

        public PressureAltitudeAboveMsl(string xpath) : base(xpath)
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
