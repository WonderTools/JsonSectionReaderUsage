using NUnit.Framework;
using WonderTools.JsonSectionReader;

namespace JsonSectionReaderUsage
{
    [TestFixture]
    public class Example8ListOfList
    {
        [Test]
        public void Test()
        { 
            var data = new JSectionReader().Read("TableDataTests.json").GetSection("data")
                .GetTable(typeof(int), typeof(string), typeof(int));
        }
    }
}