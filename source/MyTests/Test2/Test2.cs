using Newtonsoft.Json;
using NUnit.Framework;

namespace Test2
{
    public class Test2
    {
        [Test]
        public void Test2_Json()
        {
            var obj = new {Id = 42, Name = "Galaxy"};
            var str = JsonConvert.SerializeObject(obj);
            Assert.That(str, Is.EqualTo(@"{""Id"":42,""Name"":""Galaxy""}"));
        }
    }
}
