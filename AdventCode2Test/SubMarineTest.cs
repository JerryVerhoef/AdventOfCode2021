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
            Assert.AreEqual(1, subMarine.Distance);
        }
        
        [Test]
        public void TestItWillChangeTheDepthUp()
        {
            var subMarine = new SubMarine(new List<Move>(){ new() { direction = Direction.Up, amount = 1 } });
            Assert.AreEqual(-1, subMarine.Depth);
        }
        
        [Test]
        public void TestItWillChangeTheDepthUpWithAim()
        {
            var subMarine = new SubMarine(new List<Move>(){ new() { direction = Direction.Up, amount = 1 },  new() { direction = Direction.Forward, amount = 5 } }, true);
            Assert.AreEqual(-5, subMarine.Depth);
        }

        [Test]
        public void TestItWillChangeTheDepthDown()
        {
            var subMarine = new SubMarine(new List<Move>(){ new() { direction = Direction.Down, amount = 1 } });
            Assert.AreEqual(1, subMarine.Depth);
        }

        [Test]
        public void TestItWillChangeTheDepthDownWithDown()
        {
            var subMarine = new SubMarine(new List<Move>(){ new() { direction = Direction.Down, amount = 3 }, new() { direction = Direction.Forward, amount = 5 } }, true);
            Assert.AreEqual(15, subMarine.Depth);
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
            Assert.AreEqual(10, subMarine.Depth);
            Assert.AreEqual(15, subMarine.Distance);
        }

        [Test]
        public void TestItWillCalculateDepthAndDistanceWithAim()
        {
            var subMarine = new SubMarine(new List<Move>()
            {
                new() { direction = Direction.Forward, amount = 5 },
                new() { direction = Direction.Down, amount = 5 },
                new() { direction = Direction.Forward, amount = 8 },
                new() { direction = Direction.Up, amount = 3 },
                new() { direction = Direction.Down, amount = 8 },
                new() { direction = Direction.Forward, amount = 2 }
            }, true);
            Assert.AreEqual(60, subMarine.Depth);
            Assert.AreEqual(15, subMarine.Distance);
        }

        [Test]
        public void TestItWillCalculateValueBasedOnDepthAndDistanceWithAim()
        {
            var subMarine = new SubMarine(new List<Move>()
            {
                new() { direction = Direction.Forward, amount = 5 },
                new() { direction = Direction.Down, amount = 5 },
                new() { direction = Direction.Forward, amount = 8 },
                new() { direction = Direction.Up, amount = 3 },
                new() { direction = Direction.Down, amount = 8 },
                new() { direction = Direction.Forward, amount = 2 }
            }, true);
            Assert.AreEqual(900, subMarine.GetTravelDistance());
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
