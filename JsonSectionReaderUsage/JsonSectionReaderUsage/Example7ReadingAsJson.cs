using NUnit.Framework;
using WonderTools.JsonSectionReader;

namespace JsonSectionReaderUsage
{
    [TestFixture]
    public class Example7ReadingAsJson
    {
        [Test]
        public void Test()
        {
            var data = new JSectionReader().Read("TableDataTests.json").GetSection("person").GetJson();
        }
    }
}