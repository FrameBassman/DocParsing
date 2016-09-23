using System.Collections.Generic;

namespace DocParser.Core
{
    using System.Linq;

    public class DocumentProcessor
    {
        private List<Document> docsList;

        public int InvalidDocsCounter;

        public void Process(List<Document> documents)
        {
            foreach (var document in documents)
            {
                Process(document);
            }
        }

        public void Process(Document document)
        {
        }
    }
}