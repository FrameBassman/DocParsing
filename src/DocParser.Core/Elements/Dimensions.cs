using DocParser.Core.Service;
using HtmlAgilityPack;

namespace DocParser.Core.Elements
{
    public class Dimensions : BaseElement
    {
        private readonly BaseElement AltitudeAboveMsl;
        private readonly BaseElement HeightAboveGround;
        private readonly BaseElement Reftime;
        private readonly BaseElement Time;
        private readonly BaseElement X;
        private readonly BaseElement Y;

        public Dimensions(string xpath) : base(xpath)
        {
            X = new BaseElement("/html/body/ul/li[1]");
            Y = new BaseElement("/html/body/ul/li[2]");
            Reftime = new BaseElement("/html/body/ul/li[3]");
            Time = new BaseElement("/html/body/ul/li[4]");
            AltitudeAboveMsl = new BaseElement("/html/body/ul/li[5]");
            HeightAboveGround = new BaseElement("/html/body/ul/li[6]");
        }

        public override void LoadFromDocument(HtmlDocument htmlDocument)
        {
            base.LoadFromDocument(htmlDocument);

            X.LoadFromDocument(htmlDocument);
            Y.LoadFromDocument(htmlDocument);
            Reftime.LoadFromDocument(htmlDocument);
            Time.LoadFromDocument(htmlDocument);
            AltitudeAboveMsl.LoadFromDocument(htmlDocument);
            HeightAboveGround.LoadFromDocument(htmlDocument);
        }

        public override bool Validate()
        {
            return X.Validate()
                   && Y.Validate()
                   && Reftime.Validate()
                   && Time.Validate()
                   && AltitudeAboveMsl.Validate()
                   && HeightAboveGround.Validate();
        }
    }
}