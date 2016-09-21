using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocParser.Core.Service;
using HtmlAgilityPack;

namespace DocParser.Core.Elements
{
    class Y : BaseElement
    {
        private BaseElement StandardName;

        private BaseElement Units;

        public Y(string xpath) : base(xpath)
        {
            this.StandardName = new BaseElement("/html/body/ul/ul/li[7]");
            this.Units = new BaseElement("/html/body/ul/ul/li[8]");
        }

        public override void LoadFromDocument(HtmlDocument htmlDocument)
        {
            base.LoadFromDocument(htmlDocument);

            this.StandardName.LoadFromDocument(htmlDocument);
            this.Units.LoadFromDocument(htmlDocument);
        }
    }
}
