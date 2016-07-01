using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maester.Core;

namespace Maester.Elasticsearch
{
    public class ElasticsearchDocumentClient : IDocumentClient
    {
        public void CreateDocument<T>(string indexName, T document) where T : class, new()
        {
            throw new NotImplementedException();
        }

        public void UpdateDocument<T>(string indexName, T document) where T : class, new()
        {
            throw new NotImplementedException();
        }

        public void DeleteDocument<T>(string indexName, T document) where T : class, new()
        {
            throw new NotImplementedException();
        }
    }
}
