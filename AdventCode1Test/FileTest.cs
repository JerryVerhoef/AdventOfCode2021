using System.Collections.Generic;
using AdventCode1;
using NUnit.Framework;

namespace AdventCode1Test
{
    public class FileTest
    {
        [Test]
        public void TestItConvertsAListOfStrings()
        {
            string[] input = { "1", "2", "3" };
            DataFile f = new DataFile(input);    
            Assert.AreEqual(new List<int>() { 1, 2, 3}, f.GetAsNumbers());
        }
        
        [Test]
        public void TestItReturnsGrouped()
        {

            string[] input = { "199", "200", "208", "210", "200", "207", "240", "269", "260", "263" };;
            DataFile f = new DataFile(input);
            
            Assert.AreEqual(new List<int>() { 607, 618, 618, 617, 647, 716, 769, 792 }, f.GetAsGroupedInt());
        }
    }
}