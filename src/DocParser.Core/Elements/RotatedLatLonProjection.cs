using System.Collections.Generic;
using DocParser.Core.Service;
using HtmlAgilityPack;

namespace DocParser.Core.Elements
{
    class RotatedLatLonProjection : BaseElement
    {
        private BaseElement GridMappingName;

        private BaseElement GridSouthPoleLatitude;

        private BaseElement GridSouthPoleLongitude;

        private BaseElement GridSouthPoleAngle;

        public RotatedLatLonProjection(string xpath) : base(xpath)
        {
            this.GridMappingName = new BaseElement("/html/body/ul/ul/li[1]");
            this.GridSouthPoleLatitude = new BaseElement("/html/body/ul/ul/li[2]");
            this.GridSouthPoleLongitude = new BaseElement("/html/body/ul/ul/li[3]");
            this.GridSouthPoleAngle = new BaseElement("/html/body/ul/ul/li[4]");
        }

        public override void LoadFromDocument(HtmlDocument htmlDocument)
        {
            base.LoadFromDocument(htmlDocument);

            this.GridMappingName.LoadFromDocument(htmlDocument);
            this.GridSouthPoleLatitude.LoadFromDocument(htmlDocument);
            this.GridSouthPoleLongitude.LoadFromDocument(htmlDocument);
            this.GridSouthPoleAngle.LoadFromDocument(htmlDocument);
        }
    }
}
