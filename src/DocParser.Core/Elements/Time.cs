using System;
using DocParser.Core.Service;
using HtmlAgilityPack;

namespace DocParser.Core.Elements
{
    internal class Time : BaseElement
    {
        private readonly BaseElement LongName;

        private readonly BaseElement StandartName;

        private readonly TimeElement Units;

        public Time(string xpath) : base(xpath)
        {
            Units = new TimeElement("/html/body/ul/ul/li[13]");
            StandartName = new BaseElement("/html/body/ul/ul/li[14]");
            LongName = new BaseElement("/html/body/ul/ul/li[15]");
        }

        public override void LoadFromDocument(HtmlDocument htmlDocument)
        {
            base.LoadFromDocument(htmlDocument);

            Units.LoadFromDocument(htmlDocument);
            StandartName.LoadFromDocument(htmlDocument);
            LongName.LoadFromDocument(htmlDocument);
        }


        public DateTime GetTimeFromUnits()
        {
            return Units.GetTime();
        }
    }
}