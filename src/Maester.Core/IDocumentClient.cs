using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maester.Core
{
    public interface IDocumentClient
    {
        void CreateDocument<T>(string indexName, T document) where T : class, new();
        void UpdateDocument<T>(string indexName, T document) where T : class, new();
        void DeleteDocument<T>(string indexName, T document) where T : class, new();
    }
}
