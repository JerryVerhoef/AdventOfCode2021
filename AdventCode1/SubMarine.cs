using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventCode1
{
    public class SubMarine
    {
        public Depths DepthFile(string depthFile)
        {
            return new Depths(new DataFile(File.ReadAllLines(depthFile)).GetAsGroupedInt());
        }
    }
    
    public class Depths
    {
        public List<int> depthsCollection { get; private set; }
        
        public Depths(List<int> depthsCollection)
        {
            this.depthsCollection = depthsCollection;
        }

        public int GetAmountOfIncreases()
        {
            int amountOfIncreases = 0;
            for (int i = 0; i < depthsCollection.Count - 1; i++)
            {
                if (depthsCollection[i] < depthsCollection[i + 1])
                {
                    amountOfIncreases++;
                }
            }
            return amountOfIncreases;
        }
    }

    public class DataFile
    {
        private readonly List<string> _contents;

        public DataFile(string[] contents)
        {
            _contents = new List<string>(contents);
        }

        public List<int> GetAsNumbers()
        {
            return _contents.ConvertAll((Convert.ToInt32));
        }

        public List<int> GetAsGroupedInt()
        {
            var i = GetAsNumbers();
            var r = new List<int>();
            for (int j = 0; j < i.Count - 2; j++)
            {
                r.Add(i[j] + i[j + 1] + i[j + 2] );;
            }

            return r;
        }
    }
}