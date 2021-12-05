using System.Collections.Generic;
using AdventCode3;
using NUnit.Framework;

namespace AdventCode3Test
{
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
        
        [Test]
        public void TestItWillReturnTheConvertedData()
        {

            var expected = new[] {"110", "101", "001"};
            var input = new[] { "110", "100", "011"};


            var result = new DataFile(input);

            Assert.AreEqual(expected, result.ConvertedData());
        }
    }
}