using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mongeon.Lib.Strings;

namespace Mongeon.Lib.Tests
{
    [TestClass]
    public class StringTests
    {
        [TestMethod]
        public void PadCenterWithoutCharacterTest()
        {
            string testString = "Hello";
            Assert.AreEqual(testString.PadCenter(15, ' '), "     Hello     ");
        }
        [TestMethod]
        public void PadCenterWithCharacterTest()
        {
            string testString = "Hello";
            Assert.AreEqual(testString.PadCenter(15), "     Hello     ");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void PadCenterTooLongTest()
        {
            string testString = "Hello";
            testString.PadCenter(3);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void PadCenterWithNullStringTest()
        {
            string testString = null;
            testString.PadCenter(15);
        }



    }
}
