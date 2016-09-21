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
        private BaseElement LongName = new BaseElement("/html/body/ul/ul/li[52]");
        private BaseElement Units = new BaseElement("/html/body/ul/ul/li[53]");
        private BaseElement MissingValue = new BaseElement("/html/body/ul/ul/li[54]");
        private BaseElement Description = new BaseElement("/html/body/ul/ul/li[55]");
        private BaseElement GridMapping = new BaseElement("/html/body/ul/ul/li[56]");
        private BaseElement Coordinates = new BaseElement("/html/body/ul/ul/li[57]");
        private BaseElement GribVariableId = new BaseElement("/html/body/ul/ul/li[58]");
        private BaseElement Grib1Center = new BaseElement("/html/body/ul/ul/li[59]");
        private BaseElement Grib1Subcenter = new BaseElement("/html/body/ul/ul/li[60]");
        private BaseElement Grib1TableVersion = new BaseElement("/html/body/ul/ul/li[61]");
        private BaseElement Grib1Parameter = new BaseElement("/html/body/ul/ul/li[62]");
        private BaseElement Grib1LevelType = new BaseElement("/html/body/ul/ul/li[63]");
        private BaseElement Grib1LevelDesc = new BaseElement("/html/body/ul/ul/li[64]");


        public VComponentOfWindHeightAboveGround(string xpath) : base(xpath)
        {
            this.LongName = new BaseElement("/html/body/ul/ul/li[52]");
            this.Units = new BaseElement("/html/body/ul/ul/li[53]");
            this.MissingValue = new BaseElement("/html/body/ul/ul/li[54]");
            this.Description = new BaseElement("/html/body/ul/ul/li[55]");
            this.GridMapping = new BaseElement("/html/body/ul/ul/li[56]");
            this.Coordinates = new BaseElement("/html/body/ul/ul/li[57]");
            this.GribVariableId = new BaseElement("/html/body/ul/ul/li[58]");
            this.Grib1Center = new BaseElement("/html/body/ul/ul/li[59]");
            this.Grib1Subcenter = new BaseElement("/html/body/ul/ul/li[60]");
            this.Grib1TableVersion = new BaseElement("/html/body/ul/ul/li[61]");
            this.Grib1Parameter = new BaseElement("/html/body/ul/ul/li[62]");
            this.Grib1LevelType = new BaseElement("/html/body/ul/ul/li[63]");
            this.Grib1LevelDesc = new BaseElement("/html/body/ul/ul/li[64]");
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
