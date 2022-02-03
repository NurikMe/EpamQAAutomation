using FirstTask;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FirstTaskTests
{
    [TestClass]
    public class TextAnalyzerTest
    {
        [TestMethod]
        [DataRow("absddabssdfansfekol", 8)]
        [DataRow("zx.clk390xc;;f0935m", 9)]
        [DataRow("23r0z/astlvn; d", 15)]
        [DataRow("asd98hgoia4eli", 12)]
        [DataRow("wq0tzvxlg,abscdbascd", 15)]
        public void FindLengtOfLongestUniqueSymbolSequenceTest(string sequence, int expectedLength)
        {
            var textAnalyzer = new TextAnalyzer();
            int length = textAnalyzer.FindLengtOfLongestUniqueSymbolSequence(sequence);

            Assert.AreEqual(expectedLength, length);
        }
    }
}
