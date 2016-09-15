using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class DocumentProcessor
    {
        private List<Document> docsList;

        private string AllowedExtention = "svc";

        public void Process(List<Document> documents)
        {
            foreach (Document document in documents)
            {
                if (string.Equals(AllowedExtention, document.Extention))
                {
                    this.Process(document);
                }
            }
        }

        public void Process(Document document)
        {
            List<string> listA = new List<string>();
            List<string> listB = new List<string>();

            using (var reader = new StreamReader(File.OpenRead(document.Path), document.Encoding))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    listA.Add(values[0]);
                    listB.Add(values[1]);
                }
            }
        }
    }
}
