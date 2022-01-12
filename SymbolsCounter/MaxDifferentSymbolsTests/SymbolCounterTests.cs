using Microsoft.VisualStudio.TestTools.UnitTesting;
using SymbolsCounter;

namespace MaxDifferentSymbolsTests
{
    [TestClass]
    public class SymbolCounterTests
    {
        [TestMethod]
        [DataRow(0, "")]
        [DataRow(6, "asdfgj")]
        [DataRow(1, "bbbbb")]
        [DataRow(5, "ghjkll")]
        [DataRow(5, "llghjk")]
        public void DifferentSymbolsTest(int expected, string actualData)
        {
            Assert.AreEqual(expected, DifferentSymbolsCounter.MaxDifferentSymbols(actualData));  
        }
      
    }
}
