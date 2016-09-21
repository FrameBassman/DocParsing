using System.Collections.Generic;
using DocParser.Core.Service;
using HtmlAgilityPack;

namespace DocParser.Core.Elements
{
    class RotatedLatLonProjection : BaseElement
    {
        public BaseElement GridMappingName = new BaseElement("/html/body/ul/ul/li[1]");
        public BaseElement GridSouthPoleLatitude = new BaseElement("/html/body/ul/ul/li[2]");
        public BaseElement GridSouthPoleLongitude = new BaseElement("/html/body/ul/ul/li[3]");
        public BaseElement GridSouthPoleAngle = new BaseElement("/html/body/ul/ul/li[4]");

        public RotatedLatLonProjection(string xpath) : base(xpath)
        {
        }

        public override void LoadFromDocument(HtmlDocument htmlDocument)
        {
            base.LoadFromDocument(htmlDocument);

            GridMappingName.LoadFromDocument(htmlDocument);
            GridSouthPoleLatitude.LoadFromDocument(htmlDocument);
            GridSouthPoleLongitude.LoadFromDocument(htmlDocument);
            GridSouthPoleAngle.LoadFromDocument(htmlDocument);
        }
    }
}
