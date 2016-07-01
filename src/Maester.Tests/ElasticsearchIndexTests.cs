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

            searchClient.Documents.IndexDocument<TestClass>("1", "test", testClass);
        }

        [TestMethod]
        public void IndexWithoutId()
        {
            ISearchClient searchClient = new ElasticsearchClient("http://localhost:9200");
            TestClass testClass = new TestClass()
            {
                Test = "testing"
            };

            searchClient.Documents.IndexDocument<TestClass>("test", testClass);
        }

        [TestMethod]
        public void UpdateDocument()
        {
            ISearchClient searchClient = new ElasticsearchClient("http://localhost:9200");
            TestClass testClass = new TestClass()
            {
                Test = "updated 2"
            };

            searchClient.Documents.UpdateDocument<TestClass>("1", "test", testClass);
        }

        [TestMethod]
        public void DeleteDocument()
        {
            ISearchClient searchClient = new ElasticsearchClient("http://localhost:9200");
            searchClient.Documents.DeleteDocument<TestClass>("AVWnseVigvdMwul2_cIN", "test");
        }

        [TestMethod]
        public void GetDocument()
        {
            ISearchClient searchClient = new ElasticsearchClient("http://localhost:9200");
            searchClient.Documents.GetDocument<TestClass>("1", "test");
        }
    }

    public class TestClass
    {
        public string Test { get; set; }
    }
}
