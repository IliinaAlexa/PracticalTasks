using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberSystem;
using System;

namespace ConvertNumberTests
{
    [TestClass]
    public class ConverterTests
    {
        [TestMethod]
        public void BinarySystemConvertTest()
        {
            DecimalToOtherBaseConverter convertor = new DecimalToOtherBaseConverter();
            string result = convertor.Convert(4, 2);
            Assert.AreEqual("100", result);
        }
        [TestMethod]
        public void ElevenSystemConvertTest()
        {
            DecimalToOtherBaseConverter convertor = new DecimalToOtherBaseConverter();
            string result = convertor.Convert(500, 11);
            Assert.AreEqual("415", result);
        }
        [TestMethod]
        public void DecimalSystemConvertTest()
        {
            DecimalToOtherBaseConverter convertor = new DecimalToOtherBaseConverter();
            string result = convertor.Convert(17, 20);
            Assert.AreEqual("H", result);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]

        public void ArgumentOutOfRangeExceptionLargerValueConvertTest()
        {
            DecimalToOtherBaseConverter convertor = new DecimalToOtherBaseConverter();
            string result = convertor.Convert(42, 25);    
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ArgumentOutOfRangeExceptionLowerValueConvertTest()
        {
            DecimalToOtherBaseConverter convertor = new DecimalToOtherBaseConverter();
            string result = convertor.Convert(42, 1);
        }
  
    }
}
