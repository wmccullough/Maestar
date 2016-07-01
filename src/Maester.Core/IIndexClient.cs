using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maester.Core
{
    public interface IIndexClient
    {
        void CreateIndex(string indexName);
        void DeleteIndex(string indexName);
    }
}
