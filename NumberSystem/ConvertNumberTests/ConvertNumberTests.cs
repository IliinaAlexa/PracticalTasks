using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberSystem;
using System;

namespace ConvertNumberTests
{
    [TestClass]
    public class ConvertNumberTests
    {
        [TestMethod]
        public void BinarySystemConvertTest()
        {
            ConvertToNewNumberSystem convertor = new ConvertToNewNumberSystem();
            string result = convertor.Convert(4, 2);
            Assert.AreEqual("100", result);
        }
        [TestMethod]
        public void ElevenSystemConvertTest()
        {
            ConvertToNewNumberSystem convertor = new ConvertToNewNumberSystem();
            string result = convertor.Convert(500, 11);
            Assert.AreEqual("415", result);
        }
        [TestMethod]
        public void DecimalSystemConvertTest()
        {
            ConvertToNewNumberSystem convertor = new ConvertToNewNumberSystem();
            string result = convertor.Convert(17, 20);
            Assert.AreEqual("H", result);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]

        public void ArgumentOutOfRangeExceptionLargerValueConvertTest()
        {
            ConvertToNewNumberSystem convertor = new ConvertToNewNumberSystem();
            string result = convertor.Convert(42, 25);
            
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ArgumentOutOfRangeExceptionLowerValueConvertTest()
        {
            ConvertToNewNumberSystem convertor = new ConvertToNewNumberSystem();
            string result = convertor.Convert(42, 1);
        }
  
    }
}
