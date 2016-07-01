using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maester.Core
{
    public interface IAliasClient
    {
        void CreateAlias(string aliasName, string indexName);
        void UpdateAlias(string aliasName, string newIndexName);
        void DeleteAlias(string aliasName);
    }
}
