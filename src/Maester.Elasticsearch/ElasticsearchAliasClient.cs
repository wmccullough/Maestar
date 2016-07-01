using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maester.Core;

namespace Maester.Elasticsearch
{
    public class ElasticsearchAliasClient : IAliasClient
    {
        public void CreateAlias(string aliasName, string indexName)
        {
            throw new NotImplementedException();
        }

        public void UpdateAlias(string aliasName, string newIndexName)
        {
            throw new NotImplementedException();
        }

        public void DeleteAlias(string aliasName)
        {
            throw new NotImplementedException();
        }
    }
}
