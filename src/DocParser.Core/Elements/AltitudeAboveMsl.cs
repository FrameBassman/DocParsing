using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocParser.Core.Service;
using HtmlAgilityPack;

namespace DocParser.Core.Elements
{
    class AltitudeAboveMsl : BaseElement
    {
        public BaseElement Units = new BaseElement("/html/body/ul/ul/li[16]");
        public BaseElement LongName = new BaseElement("/html/body/ul/ul/li[17]");
        public BaseElement Positive = new BaseElement("/html/body/ul/ul/li[18]");
        public BaseElement GribLevelType = new BaseElement("/html/body/ul/ul/li[19]");
        public BaseElement Datum = new BaseElement("/html/body/ul/ul/li[20]");


        public AltitudeAboveMsl(string xpath) : base(xpath)
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
