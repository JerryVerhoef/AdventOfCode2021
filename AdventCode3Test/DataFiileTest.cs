using System.Collections.Generic;
using AdventCode3;
using NUnit.Framework;

namespace AdventCode3Test
{
     public class Part2Tests
    {
        [Test]
        public void TestItWilFindTheMostCommonAtIndex()
        {
            var input = new[] { "110", "100", "011"};

            var result = new DataFile(input);

            Assert.AreEqual('1', result.GetFindTheMostCommonAtIndex(new List<string>(input), 0, '0'));
            Assert.AreEqual('1', result.GetFindTheMostCommonAtIndex(new List<string>(input), 1, '1'));
            Assert.AreEqual('0', result.GetFindTheMostCommonAtIndex(new List<string>(input), 2, '1'));
        }

        [Test]
        public void TestItWilFindTheMostCommonAtIndexWhenTheSameItUsesDefault()
        {
            var input = new[] {"0011", "0000", "1111", "1100"};

            var result = new DataFile(input);

            Assert.AreEqual('1', result.GetFindTheMostCommonAtIndex(new List<string>(input), 0, '1'));

        }


        [Test]
        public void TestItWillReturnTheOxygen2()
        {

            int expectedOxygen = 23;
            var input = new[] { 
                "00100",
                "11110",
                "10110",
                "10111",
                "10101",
                "01111",
                "00111",
                "11100",
                "10000",
                "11001",
                "00010",
                "01010"
            };


            var result = new DataFile(input);

            Assert.AreEqual(expectedOxygen, result.GetOxygen());
        }
        
        
        [Test]
        public void TestItWillReturnTheCO2()
        {

            int expectedScrubber = 10;
            var input = new[] { 
                "00100",
                "11110",
                "10110",
                "10111",
                "10101",
                "01111",
                "00111",
                "11100",
                "10000",
                "11001",
                "00010",
                "01010"
            };


            var result = new DataFile(input);

            Assert.AreEqual(expectedScrubber, result.GetScrubber());
        }
    }
    public class Tests
    {
        [Test]
        public void TestItWillReturnTheGammaResult()
        {

            int expectedGammaResult = 6;
            var input = new[] { "110", "100", "011"};


            var result = new DataFile(input);

            Assert.AreEqual(expectedGammaResult, result.GetGammaResult());
        }
        
        [Test]
        public void TestItWillReturnTheEpsilonResult()
        {

            int expectedGammaResult = 1;
            var input = new[] { "110", "100", "011"};


            var result = new DataFile(input);

            Assert.AreEqual(expectedGammaResult, result.GetEpsilonResult());
        }

        
        [Test]
        public void TestItWillReturnTheGammaResult2()
        {

            int expectedGammaResult = 22;
            var input = new[] { 
                "00100",
                "11110",
                "10110",
                "10111",
                "10101",
                "01111",
                "00111",
                "11100",
                "10000",
                "11001",
                "00010",
                "01010"
            };


            var result = new DataFile(input);

            Assert.AreEqual(expectedGammaResult, result.GetGammaResult());
        }
        
        
        [Test]
        public void TestItWillReturnTheEpsilonResult2()
        {

            int expectedGammaResult = 9;
            var input = new[] { 
                "00100",
                "11110",
                "10110",
                "10111",
                "10101",
                "01111",
                "00111",
                "11100",
                "10000",
                "11001",
                "00010",
                "01010"
            };


            var result = new DataFile(input);

            Assert.AreEqual(expectedGammaResult, result.GetEpsilonResult());
        }
    }
}