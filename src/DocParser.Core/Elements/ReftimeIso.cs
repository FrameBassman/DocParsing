using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocParser.Core.Service;
using HtmlAgilityPack;

namespace DocParser.Core.Elements
{
    class ReftimeIso : BaseElement
    {
        private BaseElement Units;

        public ReftimeIso(string xpath) : base(xpath)
        {
            this.Units = new BaseElement("/html/body/ul/ul/li[8]");
        }

        public override void LoadFromDocument(HtmlDocument htmlDocument)
        {
            base.LoadFromDocument(htmlDocument);

            this.Units.LoadFromDocument(htmlDocument);
        }
    }
}
