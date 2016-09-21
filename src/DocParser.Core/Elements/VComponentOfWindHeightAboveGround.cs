using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocParser.Core.Service;
using HtmlAgilityPack;

namespace DocParser.Core.Elements
{
    public class VComponentOfWindHeightAboveGround : BaseElement
    {
        public BaseElement LongName = new BaseElement("/html/body/ul/ul/li[52]");
        public BaseElement Units = new BaseElement("/html/body/ul/ul/li[53]");
        public BaseElement MissingValue = new BaseElement("/html/body/ul/ul/li[54]");
        public BaseElement Description = new BaseElement("/html/body/ul/ul/li[55]");
        public BaseElement GridMapping = new BaseElement("/html/body/ul/ul/li[56]");
        public BaseElement Coordinates = new BaseElement("/html/body/ul/ul/li[57]");
        public BaseElement GribVariableId = new BaseElement("/html/body/ul/ul/li[58]");
        public BaseElement Grib1Center = new BaseElement("/html/body/ul/ul/li[59]");
        public BaseElement Grib1Subcenter = new BaseElement("/html/body/ul/ul/li[60]");
        public BaseElement Grib1TableVersion = new BaseElement("/html/body/ul/ul/li[61]");
        public BaseElement Grib1Parameter = new BaseElement("/html/body/ul/ul/li[62]");
        public BaseElement Grib1LevelType = new BaseElement("/html/body/ul/ul/li[63]");
        public BaseElement Grib1LevelDesc = new BaseElement("/html/body/ul/ul/li[64]");


        public VComponentOfWindHeightAboveGround(string xpath) : base(xpath)
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
