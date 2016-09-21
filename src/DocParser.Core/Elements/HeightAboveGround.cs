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
        public BaseElement Units = new BaseElement("/html/body/ul/ul/li[21]");
        public BaseElement LongName = new BaseElement("/html/body/ul/ul/li[22]");
        public BaseElement Positive = new BaseElement("/html/body/ul/ul/li[23]");
        public BaseElement GribLevelType = new BaseElement("/html/body/ul/ul/li[24]");
        public BaseElement Datum = new BaseElement("/html/body/ul/ul/li[25]");

        public HeightAboveGround(string xpath) : base(xpath)
        {
        }

        public override void LoadFromDocument(HtmlDocument htmlDocument)
        {
            base.LoadFromDocument(htmlDocument);

            Units.LoadFromDocument(htmlDocument);
            LongName.LoadFromDocument(htmlDocument);
            Positive.LoadFromDocument(htmlDocument);
            GribLevelType.LoadFromDocument(htmlDocument);
            Datum.LoadFromDocument(htmlDocument);
        }
    }
}
