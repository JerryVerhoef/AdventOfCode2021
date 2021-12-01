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
    }
}