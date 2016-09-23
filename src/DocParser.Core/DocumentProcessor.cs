using System;
using System.Collections.Generic;
using System.Linq;

namespace DocParser.Core
{
    public class DocumentProcessor
    {
        private Random rand = new Random();

        public string ValidateDocumentNames(List<Document> docs1)
        {
            string result = string.Empty;

            foreach (Document document in docs1)
            {
                result += document.Validate();
            }

            List<Document> docs = this.Quicksort(docs1);

            DateTime minFrom = docs[0].From;
            DateTime maxFrom = docs[docs.Count - 1].From;

            TimeSpan minTimeliness = docs[0].Timeliness;
            TimeSpan maxTimeliness = docs[docs.Count - 1].Timeliness;

            result += string.Format("MinFrom is {0}", minFrom) + "\n";
            result += string.Format("MaxFrom is {0}", maxFrom) + "\n";
            result += string.Format("MinTimeliness is {0}", minTimeliness) + "\n";
            result += string.Format("MaxTimeliness is {0}", maxTimeliness) + "\n";

            TimeSpan currentFromStep = docs[1].From - docs[0].From;
            TimeSpan previousFromStep = docs[1].From - docs[0].From;
            TimeSpan currentTimelinessStep = docs[1].Timeliness - docs[0].Timeliness;
            TimeSpan previousTimelinessStep = docs[1].Timeliness - docs[0].Timeliness;

            for (int i = 0; i < docs.Count; i++)
            {
                if (minTimeliness > docs[i].Timeliness)
                {
                    minTimeliness = docs[i].Timeliness;
                }

                if (maxTimeliness < docs[i].Timeliness)
                {
                    maxTimeliness = docs[i].Timeliness;
                }

                if (!(i + 2 > docs.Count))
                {
                    currentFromStep = docs[i + 1].From - docs[i].From;
                    currentTimelinessStep = docs[i + 1].Timeliness - docs[i].Timeliness;

                    if (currentFromStep != previousFromStep)
                    {
                        result += string.Format("Document list is invalid: missed file between {0} and {1}", docs[i].Name, docs[i + 1].Name) + "\n";
                        i++;
                    }

                    if (currentTimelinessStep != previousTimelinessStep)
                    {
                        result += string.Format("Document list is invalid: timeliness step is incorrect between the following files: {0} and {1}", docs[i].Name, docs[i + 1].Name) + "\n";
                        i++;
                    }

                    previousFromStep = currentFromStep;
                    previousTimelinessStep = currentTimelinessStep;
                }
            }

            result += string.Format("FromStep is {0}", currentFromStep) + "\n";
            result += string.Format("TimelinessFrom is {0}", currentTimelinessStep) + "\n";

            return result;
        }

        public List<T> Quicksort<T>(List<T> elements) where T : IComparable
        {
            if (elements.Count() < 2) return elements;
            var pivot = rand.Next(elements.Count());
            var val = elements[pivot];
            var lesser = new List<T>();
            var greater = new List<T>();
            for (int i = 0; i < elements.Count(); i++)
            {
                if (i != pivot)
                {
                    if (elements[i].CompareTo(val) < 0)
                    {
                        lesser.Add(elements[i]);
                    }
                    else
                    {
                        greater.Add(elements[i]);
                    }
                }
            }

            var merged = Quicksort(lesser);
            merged.Add(val);
            merged.AddRange(Quicksort(greater));
            return merged;
        }
    }
}