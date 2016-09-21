﻿using System;
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
        public BaseElement StandardName = new BaseElement("/html/body/ul/ul/li[7]");
        public BaseElement Units = new BaseElement("/html/body/ul/ul/li[8]");

        public Y(string xpath) : base(xpath)
        {
        }

        public override void LoadFromDocument(HtmlDocument htmlDocument)
        {
            base.LoadFromDocument(htmlDocument);

            StandardName.LoadFromDocument(htmlDocument);
            Units.LoadFromDocument(htmlDocument);
        }
    }
}
