using System;
using Newtonsoft.Json;
using NUnit.Framework;

namespace Spike.Navigation
{
    [TestFixture]
    public abstract class TestBase<T> where T: class
    {
        protected T Unit;

        [SetUp]
        public void Setup()
        {
            Unit = Activator.CreateInstance<T>();
        }

        [Test]
        public void ItShouldSerialseAndDeseralise()
        {
            Assert.IsNotNull(JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(Unit)));
        }
    }
}
