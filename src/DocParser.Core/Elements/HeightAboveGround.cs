using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocParser.Core.Service;
using HtmlAgilityPack;

namespace DocParser.Core.Elements
{
    class HeightAboveGround : BaseElement
    {
        private BaseElement Units;

        private BaseElement LongName;

        private BaseElement Positive;

        private BaseElement GribLevelType;

        private BaseElement Datum;

        public HeightAboveGround(string xpath) : base(xpath)
        {
            this.Units = new BaseElement("/html/body/ul/ul/li[21]");
            this.LongName = new BaseElement("/html/body/ul/ul/li[22]");
            this.Positive = new BaseElement("/html/body/ul/ul/li[23]");
            this.GribLevelType = new BaseElement("/html/body/ul/ul/li[24]");
            this.Datum = new BaseElement("/html/body/ul/ul/li[25]");
        }

        public override void LoadFromDocument(HtmlDocument htmlDocument)
        {
            base.LoadFromDocument(htmlDocument);

            this.Units.LoadFromDocument(htmlDocument);
            this.LongName.LoadFromDocument(htmlDocument);
            this.Positive.LoadFromDocument(htmlDocument);
            this.GribLevelType.LoadFromDocument(htmlDocument);
            this.Datum.LoadFromDocument(htmlDocument);
        }
    }
}
