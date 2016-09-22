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
        private BaseElement X;
        private BaseElement Y;
        private BaseElement Reftime;
        private BaseElement Time;
        private BaseElement AltitudeAboveMsl;
        private BaseElement HeightAboveGround;

        public Dimensions(string xpath) : base(xpath)
        {
            this.X = new BaseElement("/html/body/ul/li[1]");
            this.Y = new BaseElement("/html/body/ul/li[2]");
            this.Reftime = new BaseElement("/html/body/ul/li[3]");
            this.Time = new BaseElement("/html/body/ul/li[4]");
            this.AltitudeAboveMsl = new BaseElement("/html/body/ul/li[5]");
            this.HeightAboveGround = new BaseElement("/html/body/ul/li[6]");
        }

        public override void LoadFromDocument(HtmlDocument htmlDocument)
        {
            base.LoadFromDocument(htmlDocument);

            this.X.LoadFromDocument(htmlDocument);
            this.Y.LoadFromDocument(htmlDocument);
            this.Reftime.LoadFromDocument(htmlDocument);
            this.Time.LoadFromDocument(htmlDocument);
            this.AltitudeAboveMsl.LoadFromDocument(htmlDocument);
            this.HeightAboveGround.LoadFromDocument(htmlDocument);
        }
    }
}
