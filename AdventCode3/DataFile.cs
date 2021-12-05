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
            var a = ConvertedData(_contents).ConvertAll(x => x.Split("1").Length < x.Split("0").Length ? "1" : "0").Aggregate((x, y) => x + y);
            return Convert.ToInt32(a, 2);
        }
        
        
        public int GetGammaResult()
        { 
            var a = ConvertedData(_contents).ConvertAll(x => x.Split("1").Length > x.Split("0").Length ? "1" : "0").Aggregate((x, y) => x + y);
            return Convert.ToInt32(a, 2);
        }

        private List<string> ConvertedData(List<string> input)
        {
            List<string> convertedData = new List<string>();
            input.ConvertAll((c) => c.ToCharArray()).ForEach(
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

        public int GetOxygen()
        {
            var data = GetCo2OxygenDataPoint('1', false);

            return Convert.ToInt32(data, 2);
        }

        private string GetCo2OxygenDataPoint(char defaultValue, bool useLeastCommon)
        {
            var data = _contents;
            for (var i = 0; i < _contents.First().Length; i++)
            {
                data = FindDataWithNumberAtPosition(data, i, GetFindTheMostCommonAtIndex(data, i, defaultValue, useLeastCommon));
                if (data.Count == 1)
                {
                    return data.First();
                }
            }

            return data.First();
        }

        public List<string> FindDataWithNumberAtPosition(List<string> input, int position, char value)
        {
            return input.FindAll(x => x[position] == value);
        }
        
        public char GetFindTheMostCommonAtIndex(List<string> data, int position, char defaultValue, bool leastCommon = false )
        {
            var dataAtPosition = data.Select(x => x[position]).ToList();
            var mostCommon = dataAtPosition.GroupBy(x => x).OrderByDescending(x => x.Count());
            if (mostCommon.Count() == 2 && mostCommon.First().Count() == mostCommon.Last().Count())
            {
                return defaultValue;
            }
            if (leastCommon)
            {
                return mostCommon.First().Key == '0' ?  "1"[0] : "0"[0];
            }
            return mostCommon.First().Key == '1' ?  "1"[0] : "0"[0];
        }

        public int GetScrubber()
        {
            var data = GetCo2OxygenDataPoint('0', true);

            return Convert.ToInt32(data, 2);
        }
    }
}