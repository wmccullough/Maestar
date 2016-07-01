using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maester.Core
{
    public interface IDocumentClient
    {
        void GetDocument<T>(string id, string indexName) where T : class, new();
        void IndexDocument<T>(string id, string indexName, T document) where T : class, new();
        void IndexDocument<T>(string indexName, T document) where T : class, new();
        void UpdateDocument<T>(string id, string indexName, T document) where T : class, new();
        void DeleteDocument<T>(string id, string indexName) where T : class, new();
    }
}
