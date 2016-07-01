using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maester.Core
{
    public interface ISearchClient
    {
        IDocumentClient Documents { get; set; }
        IAliasClient Aliases { get; set; }
        IIndexClient Indexes { get; set; }
    }
}
