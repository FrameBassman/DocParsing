using DocParser.Core.Service;
using HtmlAgilityPack;

namespace DocParser.Core.Elements
{
    public class Reftime : BaseElement
    {
        public BaseElement Units = new BaseElement("/html/body/ul/ul/li[9]");
        public BaseElement StandartName = new BaseElement("/html/body/ul/ul/li[10]");
        public BaseElement LongName = new BaseElement("/html/body/ul/ul/li[11]");

        public Reftime(string xpath) : base(xpath)
        {
        }

        public override void LoadFromDocument(HtmlDocument htmlDocument)
        {
            base.LoadFromDocument(htmlDocument);

            Units.LoadFromDocument(htmlDocument);
            StandartName.LoadFromDocument(htmlDocument);
            LongName.LoadFromDocument(htmlDocument);
        }
    }
}
