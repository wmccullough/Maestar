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

        public void CreateDocument<T>(string id, string indexName, T document) where T : class, new()
        {
            string typeName = document.GetType().Name;
            var response = _elasticsearchRestApi.Index(indexName, typeName.ToLower(), id, document).Result;
        }

        public void CreateDocument<T>(string indexName, T document) where T : class, new()
        {
            string typeName = document.GetType().Name;
            var response = _elasticsearchRestApi.IndexWithoutId(indexName, typeName, document).Result;
        }

        public void UpdateDocument<T>(string id, string indexName, T document) where T : class, new()
        {
            throw new NotImplementedException();
        }

        public void DeleteDocument<T>(string indexName, T document) where T : class, new()
        {
            throw new NotImplementedException();
        }
    }
}
