using System.Collections.Generic;
using AdventCode1;
using NUnit.Framework;
 

namespace AdventCode1Test
{
    public class DepthsTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestItCountsTheAmountOfIncreases()
        {
            var l = new List<int> { 1, 2, 3 };
            Depths depths = new Depths(l);
            Assert.AreEqual(2, depths.GetAmountOfIncreases());
        }

        [Test]
        public void TestItReturns0WhenThereAreNoIncreases()
        {
            var l = new List<int> { 3, 3, 3 };
            Depths depths = new Depths(l);
            Assert.AreEqual(0, depths.GetAmountOfIncreases());
        }


    }
}