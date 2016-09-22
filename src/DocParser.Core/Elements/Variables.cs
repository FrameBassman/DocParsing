using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DocParser.Core.Elements
{
    using DocParser.Core.Service;

    using HtmlAgilityPack;

    public class Variables : BaseElement
    {
        private RotatedLatLonProjection rotatedLatLonProjection;
        private X x;
        private Y y;
        private Reftime reftime;
        private ReftimeIso reftimeIso;
        private Time time;
        private AltitudeAboveMsl altitudeAboveMsl;
        private HeightAboveGround heightAboveGround;
        private PressureAltitudeAboveMsl pressureAltitudeAboveMsl;
        private UComponentOfWindHeightAboveGround uComponentOfWindHeightAboveGround;
        private VComponentOfWindHeightAboveGround vComponentOfWindHeightAboveGround;

        public Variables(string xpath) : base(xpath)
        {
            this.rotatedLatLonProjection = new RotatedLatLonProjection("/html/body/ul/ul/p[1]");
            this.x = new X("/html/body/ul/ul/p[2]");
            this.y = new Y("/html/body/ul/ul/p[3]");
            this.reftime = new Reftime("/html/body/ul/ul/p[4]");
            this.reftimeIso = new ReftimeIso("/html/body/ul/ul/p[5]");
            this.time = new Time("/html/body/ul/ul/p[6]");
            this.altitudeAboveMsl = new AltitudeAboveMsl("/html/body/ul/ul/p[7]");
            this.heightAboveGround = new HeightAboveGround("/html/body/ul/ul/p[8]");
            this.pressureAltitudeAboveMsl = new PressureAltitudeAboveMsl("/html/body/ul/ul/p[9]");
            this.uComponentOfWindHeightAboveGround = new UComponentOfWindHeightAboveGround("/html/body/ul/ul/p[10]");
            this.vComponentOfWindHeightAboveGround = new VComponentOfWindHeightAboveGround("/html/body/ul/ul/p[11]");
        }

        public override void LoadFromDocument(HtmlDocument htmlDocument)
        {
            base.LoadFromDocument(htmlDocument);

            this.rotatedLatLonProjection.LoadFromDocument(htmlDocument);
            this.x.LoadFromDocument(htmlDocument);
            this.y.LoadFromDocument(htmlDocument);
            this.reftime.LoadFromDocument(htmlDocument);
            this.reftimeIso.LoadFromDocument(htmlDocument);
            this.time.LoadFromDocument(htmlDocument);
            this.altitudeAboveMsl.LoadFromDocument(htmlDocument);
            this.heightAboveGround.LoadFromDocument(htmlDocument);
            this.pressureAltitudeAboveMsl.LoadFromDocument(htmlDocument);
            this.uComponentOfWindHeightAboveGround.LoadFromDocument(htmlDocument);
            this.vComponentOfWindHeightAboveGround.LoadFromDocument(htmlDocument);
        }
    }
}
