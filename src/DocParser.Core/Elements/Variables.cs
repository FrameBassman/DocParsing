using System;
using DocParser.Core.Service;
using HtmlAgilityPack;

namespace DocParser.Core.Elements
{
    public class Variables : BaseElement
    {
        private readonly AltitudeAboveMsl altitudeAboveMsl;
        private readonly HeightAboveGround heightAboveGround;
        private readonly PressureAltitudeAboveMsl pressureAltitudeAboveMsl;
        private readonly ReftimeIso reftimeIso;
        private readonly RotatedLatLonProjection rotatedLatLonProjection;
        private readonly Time time;
        private readonly UComponentOfWindHeightAboveGround uComponentOfWindHeightAboveGround;
        private readonly VComponentOfWindHeightAboveGround vComponentOfWindHeightAboveGround;
        private readonly X x;
        private readonly Y y;

        public Variables(string xpath) : base(xpath)
        {
            rotatedLatLonProjection = new RotatedLatLonProjection("/html/body/ul/ul/p[1]");
            x = new X("/html/body/ul/ul/p[2]");
            y = new Y("/html/body/ul/ul/p[3]");
            reftime = new Reftime("/html/body/ul/ul/p[4]");
            reftimeIso = new ReftimeIso("/html/body/ul/ul/p[5]");
            time = new Time("/html/body/ul/ul/p[6]");
            altitudeAboveMsl = new AltitudeAboveMsl("/html/body/ul/ul/p[7]");
            heightAboveGround = new HeightAboveGround("/html/body/ul/ul/p[8]");
            pressureAltitudeAboveMsl = new PressureAltitudeAboveMsl("/html/body/ul/ul/p[9]");
            uComponentOfWindHeightAboveGround = new UComponentOfWindHeightAboveGround("/html/body/ul/ul/p[10]");
            vComponentOfWindHeightAboveGround = new VComponentOfWindHeightAboveGround("/html/body/ul/ul/p[11]");
        }

        private Reftime reftime { get; }

        public override void LoadFromDocument(HtmlDocument htmlDocument)
        {
            base.LoadFromDocument(htmlDocument);

            rotatedLatLonProjection.LoadFromDocument(htmlDocument);
            x.LoadFromDocument(htmlDocument);
            y.LoadFromDocument(htmlDocument);
            reftime.LoadFromDocument(htmlDocument);
            reftimeIso.LoadFromDocument(htmlDocument);
            time.LoadFromDocument(htmlDocument);
            altitudeAboveMsl.LoadFromDocument(htmlDocument);
            heightAboveGround.LoadFromDocument(htmlDocument);
            pressureAltitudeAboveMsl.LoadFromDocument(htmlDocument);
            uComponentOfWindHeightAboveGround.LoadFromDocument(htmlDocument);
            vComponentOfWindHeightAboveGround.LoadFromDocument(htmlDocument);
        }

        public override bool Validate()
        {
            return pressureAltitudeAboveMsl.Validate()
                   && uComponentOfWindHeightAboveGround.Validate()
                   && vComponentOfWindHeightAboveGround.Validate();
        }

        public DateTime GetTime()
        {
            return time.GetTimeFromUnits();
        }
    }
}