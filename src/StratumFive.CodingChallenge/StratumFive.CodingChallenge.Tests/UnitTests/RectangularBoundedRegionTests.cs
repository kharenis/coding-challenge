using Microsoft.VisualStudio.TestTools.UnitTesting;
using StratumFive.CodingChallenge.Core;
using StratumFive.CodingChallenge.Core.Interfaces;

namespace StratumFive.CodingChallenge.Tests
{
    [TestClass]
    public class RectangularBoundedRegionTests
    {
        private IBoundedRegion _boundedRegion;
        [TestInitialize]
        public void Init()
        {
            //Create a 10x10 test region
            _boundedRegion = new RectangularBoundedRegion(new IntVector2(10, 10));
        }

        [TestMethod]
        public void When_ExpectedValues_IsInRegion()
        {
            var position = new IntVector2(5, 5);
            var isInRegion = _boundedRegion.IsInRegion(position);

            Assert.IsTrue(isInRegion);
        }

        [TestMethod]
        public void When_NegativeValues_IsNotInRegion()
        {
            var position = new IntVector2(-4, 8);
            var isInRegion = _boundedRegion.IsInRegion(position);

            Assert.IsFalse(isInRegion);
        }

        [TestMethod]
        public void When_TooLargeValues_IsNotInRegion()
        {
            var position = new IntVector2(2, 100);
            var isInRegion = _boundedRegion.IsInRegion(position);

            Assert.IsFalse(isInRegion);
        }
    }
}
