using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using RestEase;

namespace Maester.Elasticsearch
{
    [Header("Content-Type", "application/json")]
    public interface IElasticsearchRestApi
    {
        [Put("{indexName}/{type}/{id}")]
        Task<HttpResponseMessage> Index([Path] string indexName, [Path] string type, [Path] string id, [Body] object document);

        [Post("{indexName}/{type}")]
        Task<HttpResponseMessage> IndexWithoutId([Path] string indexName, [Path] string type, [Body] object document);
    }
}
