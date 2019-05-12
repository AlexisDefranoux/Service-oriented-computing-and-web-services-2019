using Microsoft.VisualStudio.TestTools.UnitTesting;
using Serveur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serveur.Tests
{
    [TestClass()]
    public class CacheTests
    {
        [TestMethod()]
        public void GetResourceTestNeverReload()
        {
            TestCacheFeeder testFeeder = new TestCacheFeeder();
            Cache<String> cache = new Cache<String>(0, testFeeder);
            String resource = cache.GetResource("world");
            Assert.AreEqual("Test: " + "world", resource);
            Assert.AreEqual(1, testFeeder.Cpt);
            resource = cache.GetResource("world");
            Assert.AreEqual("Test: " + "world", resource);
            Assert.AreEqual(1, testFeeder.Cpt);
        }

        [TestMethod()]
        public void GetResourceTestReloadAllTime()
        {
            TestCacheFeeder testFeeder = new TestCacheFeeder();
            Cache<String> cache = new Cache<String>(-1, testFeeder);
            String resource = cache.GetResource("world");
            Assert.AreEqual("Test: " + "world", resource);
            Assert.AreEqual(1, testFeeder.Cpt);
            resource = cache.GetResource("world");
            Assert.AreEqual("Test: " + "world", resource);
            Assert.AreEqual(2, testFeeder.Cpt);
        }

        [TestMethod()]
        public void GetResourceTestNoname()
        {
            TestCacheFeeder testFeeder = new TestCacheFeeder();
            Cache<String> cache = new Cache<String>(0, testFeeder);
            String resource = cache.GetResource("");
            Assert.AreEqual("Test: " + "", resource);
            Assert.AreEqual(1, testFeeder.Cpt);
        }
    }

    class TestCacheFeeder : ICacheFeeder<String>
    {
        public int Cpt { get; set; }

        public TestCacheFeeder()
        {
            this.Cpt = 0;
        }

        public string GetResource(string name)
        {
            this.Cpt++; 
            return "Test: " + name;
        }
    }
}