using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maester.Core;
using RestEase;

namespace Maester.Elasticsearch
{
    public class ElasticsearchDocumentClient : IDocumentClient
    {
        public ElasticsearchDocumentClient(string uri)
        {
            _elasticsearchRestApi = RestClient.For<IElasticsearchRestApi>(uri);
        }

        private readonly IElasticsearchRestApi _elasticsearchRestApi;

        public void GetDocument<T>(string id, string indexName) where T : class, new()
        {
            string typeName = typeof(T).Name;
            var response = _elasticsearchRestApi.GetDocument(indexName, typeName.ToLower(), id).Result;
            string content = response.Content.ReadAsStringAsync().Result;

        }

        public void IndexDocument<T>(string id, string indexName, T document) where T : class, new()
        {
            string typeName = document.GetType().Name;
            var response = _elasticsearchRestApi.Index(indexName, typeName.ToLower(), id, document).Result;
        }

        public void IndexDocument<T>(string indexName, T document) where T : class, new()
        {
            string typeName = document.GetType().Name;
            var response = _elasticsearchRestApi.IndexWithoutId(indexName, typeName.ToLower(), document).Result;
        }

        public void UpdateDocument<T>(string id, string indexName, T document) where T : class, new()
        {
            string typeName = document.GetType().Name;
            var response = _elasticsearchRestApi.UpdateDocument(indexName, typeName.ToLower(), id, document).Result;
        }

        public void DeleteDocument<T>(string id, string indexName) where T : class, new()
        {
            string typeName = typeof(T).Name;
            var response = _elasticsearchRestApi.DeleteDocument(indexName, typeName.ToLower(), id).Result;
        }
    }
}
