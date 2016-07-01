using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maester.Core;

namespace Maester.Elasticsearch
{
    public class ElasticsearchClient : ISearchClient
    {
        public ElasticsearchClient(string uri)
        {
            _uri = uri;

            Documents = new ElasticsearchDocumentClient(uri);
            Aliases = new ElasticsearchAliasClient();
            Indexes = new ElasticsearchIndexClient();
        }

        private string _uri;

        public IDocumentClient Documents { get; set; }
        public IAliasClient Aliases { get; set; }
        public IIndexClient Indexes { get; set; }
    }
}
