using System.Linq;
using AdventCode2;
using NUnit.Framework;

namespace AdventCode2Test
{
    public class DataFileTest
    {
        [Test]
        public void TestDataFileReturnSetOfActions()
        {
            var dataFile = new DataFile(new []{ "forward 1", "down 1" }) ;
            Assert.AreEqual(Direction.Forward, dataFile.GetMoves().First().direction);
            Assert.AreEqual(1, dataFile.GetMoves().First().amount);
        }
    }
}