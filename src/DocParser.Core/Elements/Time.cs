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
        private BaseElement Units;

        private BaseElement StandartName;

        private BaseElement LongName;

        public Time(string xpath) : base(xpath)
        {
            this.Units = new BaseElement("/html/body/ul/ul/li[13]");
            this.StandartName = new BaseElement("/html/body/ul/ul/li[14]");
            this.LongName = new BaseElement("/html/body/ul/ul/li[15]");
        }

        public override void LoadFromDocument(HtmlDocument htmlDocument)
        {
            base.LoadFromDocument(htmlDocument);

            this.Units.LoadFromDocument(htmlDocument);
            this.StandartName.LoadFromDocument(htmlDocument);
            this.LongName.LoadFromDocument(htmlDocument);
        }
    }
}
