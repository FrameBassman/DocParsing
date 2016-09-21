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
        public BaseElement Units = new BaseElement("/html/body/ul/ul/li[8]");

        public ReftimeIso(string xpath) : base(xpath)
        {
        }

        public override void LoadFromDocument(HtmlDocument htmlDocument)
        {
            base.LoadFromDocument(htmlDocument);

            Units.LoadFromDocument(htmlDocument);
        }
    }
}
