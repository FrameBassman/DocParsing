using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocParser.Core.Elements
{
    using DocParser.Core.Service;

    using HtmlAgilityPack;

    public class Dimensions : BaseElement
    {
        public Dimensions(string xpath) : base(xpath)
        {
        }

        public override void LoadFromDocument(HtmlDocument htmlDocument)
        {
            base.LoadFromDocument(htmlDocument);
        }
    }
}
