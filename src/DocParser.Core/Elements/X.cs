using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocParser.Core.Service;
using HtmlAgilityPack;

namespace DocParser.Core.Elements
{
    class X : BaseElement
    {
        private BaseElement StandardName;

        private BaseElement Units;

        public X(string xpath) : base(xpath)
        {
            this.StandardName = new BaseElement("/html/body/ul/ul/li[5]");
            this.Units = new BaseElement("/html/body/ul/ul/li[6]");
        }

        public override void LoadFromDocument(HtmlDocument htmlDocument)
        {
            base.LoadFromDocument(htmlDocument);

            this.StandardName.LoadFromDocument(htmlDocument);
            this.Units.LoadFromDocument(htmlDocument);
        }
    }
}
