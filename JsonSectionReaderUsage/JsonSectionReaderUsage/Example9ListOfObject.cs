using System;
using NUnit.Framework;
using WonderTools.JsonSectionReader;

namespace JsonSectionReaderUsage
{
    [TestFixture]
    public class Example9ListOfObject
    {
        [Test]
        public void Test()
        {
            var data = new JSectionReader().Read("TableDataTests.json").GetSection("data")
                .GetTableAsObjectList<Employee, int, string, int>(
                    (id, name, age) => { return new Employee()
                    {
                        Id = id,
                        Name = name,
                        Age = age,
                    }; });
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}