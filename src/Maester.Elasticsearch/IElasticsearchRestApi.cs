using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using RestEase;

namespace Maester.Elasticsearch
{
    public interface IElasticsearchRestApi
    {
        [Put("{indexName}/{type}/{id}")]
        [Header("Content-Type", "application/json")]
        Task<HttpResponseMessage> Index([Path] string indexName, [Path] string type, [Path] string id, [Body] object document);

        [Get("{indexName}/{type}/{id}")]
        Task<HttpResponseMessage> GetDocument([Path] string indexName, [Path] string type, [Path] string id);

        [Post("{indexName}/{type}")]
        [Header("Content-Type", "application/json")]
        Task<HttpResponseMessage> IndexWithoutId([Path] string indexName, [Path] string type, [Body] object document);

        [Post("{indexName}/{type}/{id}")]
        [Header("Content-Type", "application/json")]
        Task<HttpResponseMessage> UpdateDocument([Path] string indexName, [Path] string type, [Path] string id, [Body] object document);

        [Delete("{indexName}/{type}/{id}")]
        Task<HttpResponseMessage> DeleteDocument([Path] string indexName, [Path] string type, [Path] string id);
    }
}
