using DocParser.Core.Service;
using HtmlAgilityPack;

namespace DocParser.Core.Elements
{
    internal class RotatedLatLonProjection : BaseElement
    {
        private readonly BaseElement GridMappingName;

        private readonly BaseElement GridSouthPoleAngle;

        private readonly BaseElement GridSouthPoleLatitude;

        private readonly BaseElement GridSouthPoleLongitude;

        public RotatedLatLonProjection(string xpath) : base(xpath)
        {
            GridMappingName = new BaseElement("/html/body/ul/ul/li[1]");
            GridSouthPoleLatitude = new BaseElement("/html/body/ul/ul/li[2]");
            GridSouthPoleLongitude = new BaseElement("/html/body/ul/ul/li[3]");
            GridSouthPoleAngle = new BaseElement("/html/body/ul/ul/li[4]");
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