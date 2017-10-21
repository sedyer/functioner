using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Functioner
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void FindLargestValueTest()
        {
            // 1. Arrange

            int[] testArray = { 1, 2, 5, 31, 6 };

            // 2. Act

            int largestValue = Methods.FindLargestValue(testArray);

            // 3. Assert

            Assert.IsTrue(largestValue == 31);
        }

        [TestMethod]
        public void ArrayIsSorted()
        {
            // 1. Arrange

            // 2. Act

            // 3. Assert

            Assert.IsTrue(false);
        }
    }
}
