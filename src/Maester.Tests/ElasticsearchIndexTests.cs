using System;
using Maester.Core;
using Maester.Elasticsearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Maester.Tests
{
    [TestClass]
    public class ElasticsearchIndexTests
    {
        [TestMethod]
        public void IndexWithId()
        {
            ISearchClient searchClient = new ElasticsearchClient("http://localhost:9200");
            TestClass testClass = new TestClass()
            {
                Test = "testing"
            };

            searchClient.Documents.CreateDocument<TestClass>("1", "test", testClass);
        }

        [TestMethod]
        public void IndexWithoutId()
        {
            ISearchClient searchClient = new ElasticsearchClient("http://localhost:9200");
            TestClass testClass = new TestClass()
            {
                Test = "testing"
            };

            searchClient.Documents.CreateDocument<TestClass>("test", testClass);
        }
    }

    public class TestClass
    {
        public string Test { get; set; }
    }
}
