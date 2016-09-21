using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocParser.Core.Service;
using HtmlAgilityPack;

namespace DocParser.Core.Elements
{
    class Time : BaseElement
    {
        public BaseElement Units = new BaseElement("/html/body/ul/ul/li[13]");
        public BaseElement StandartName = new BaseElement("/html/body/ul/ul/li[14]");
        public BaseElement LongName = new BaseElement("/html/body/ul/ul/li[15]");

        public Time(string xpath) : base(xpath)
        {
        }

        public override void LoadFromDocument(HtmlDocument htmlDocument)
        {
            base.LoadFromDocument(htmlDocument);

            Units.LoadFromDocument(htmlDocument);
            StandartName.LoadFromDocument(htmlDocument);
            LongName.LoadFromDocument(htmlDocument);
        }
    }
}
