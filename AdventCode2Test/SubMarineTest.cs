using System.Collections.Generic;
using AdventCode2;
using NUnit.Framework;

namespace AdventCode2Test
{
    public class SubMarineTest
    {
        [Test]
        public void TestItWillMoveTheDistanceForward()
        {
            var subMarine = new SubMarine(new List<Move>(){ new() { direction = Direction.Forward, amount = 1 } });
            Assert.AreEqual(1, subMarine.GetForwardDistance());
        }
        
        [Test]
        public void TestItWillChangeTheDepthUp()
        {
            var subMarine = new SubMarine(new List<Move>(){ new() { direction = Direction.Up, amount = 1 } });
            Assert.AreEqual(-1, subMarine.GetDepth());
        }
        
        [Test]
        public void TestItWillChangeTheDepthDown()
        {
            var subMarine = new SubMarine(new List<Move>(){ new() { direction = Direction.Down, amount = 1 } });
            Assert.AreEqual(1, subMarine.GetDepth());
        }

        [Test]
        public void TestItWillCalculateDepthAndDistance()
        {
            var subMarine = new SubMarine(new List<Move>()
            {
                new() { direction = Direction.Forward, amount = 5 },
                new() { direction = Direction.Down, amount = 5 },
                new() { direction = Direction.Forward, amount = 8 },
                new() { direction = Direction.Up, amount = 3 },
                new() { direction = Direction.Down, amount = 8 },
                new() { direction = Direction.Forward, amount = 2 }
            });
            Assert.AreEqual(10, subMarine.GetDepth());
            Assert.AreEqual(15, subMarine.GetForwardDistance());
        }

        [Test]
        public void TestItWillCalculateValueBasedOnDepthAndDistance()
        {
            var subMarine = new SubMarine(new List<Move>()
            {
                new() { direction = Direction.Forward, amount = 5 },
                new() { direction = Direction.Down, amount = 5 },
                new() { direction = Direction.Forward, amount = 8 },
                new() { direction = Direction.Up, amount = 3 },
                new() { direction = Direction.Down, amount = 8 },
                new() { direction = Direction.Forward, amount = 2 }
            });
            Assert.AreEqual(150, subMarine.GetTravelDistance());
        }
    }
}
