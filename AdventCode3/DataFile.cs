using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventCode3
{
    public class DataFile
    {
        private readonly List<string> _contents;

        public DataFile(string[] contents)
        {
            _contents = new List<string>(contents);
        }

        public int GetEpsilonResult()
        { 
            var a = ConvertedData().ConvertAll(x => x.Split("1").Length < x.Split("0").Length ? "1" : "0").Aggregate((x, y) => x + y);
            return Convert.ToInt32(a, 2);
        }
        
        
        public int GetGammaResult()
        { 
            var a = ConvertedData().ConvertAll(x => x.Split("1").Length > x.Split("0").Length ? "1" : "0").Aggregate((x, y) => x + y);
            return Convert.ToInt32(a, 2);
        }

        public List<string> ConvertedData()
        {
            List<string> convertedData = new List<string>();
            _contents.ConvertAll((c) => c.ToCharArray()).ForEach(
                (c) =>
                {
                    for(var i =0; i < c.Length; i++)
                    {
                        if (convertedData.ElementAtOrDefault(i) == null)
                        {
                            convertedData.Add(c[i].ToString());
                        }
                        else
                        {
                            convertedData[i] += c[i].ToString();
                        }
                    }
                }
            );
            return convertedData;
        }
    }
}