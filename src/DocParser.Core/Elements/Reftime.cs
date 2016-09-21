using DocParser.Core.Service;
using HtmlAgilityPack;

namespace DocParser.Core.Elements
{
    public class Reftime : BaseElement
    {
        private BaseElement Units;

        private BaseElement StandartName;

        private BaseElement LongName;

        public Reftime(string xpath) : base(xpath)
        {
            this.Units = new BaseElement("/html/body/ul/ul/li[9]");
            this.StandartName = new BaseElement("/html/body/ul/ul/li[10]");
            this.LongName = new BaseElement("/html/body/ul/ul/li[11]");
        }

        public override void LoadFromDocument(HtmlDocument htmlDocument)
        {
            base.LoadFromDocument(htmlDocument);

            this.Units.LoadFromDocument(htmlDocument);
            this.StandartName.LoadFromDocument(htmlDocument);
            this.LongName.LoadFromDocument(htmlDocument);
        }
    }
}
