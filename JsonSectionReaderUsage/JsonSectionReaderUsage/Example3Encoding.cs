using NUnit.Framework;
using WonderTools.JsonSectionReader;

namespace JsonSectionReaderUsage
{
    [TestFixture]
    public class Example3Encoding
    {
        [Test]
        public void Test()
        {
            var word = "Mädchen";
            var actualWord = JSectionReader.Section("Example3Encoding.json").GetSection("words", 2).GetObject<string>();
            Assert.AreEqual(word, actualWord);
        }
    }
}