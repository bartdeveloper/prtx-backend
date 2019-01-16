using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prtx_backend.Core
{
    public interface ISearch
    {
        Task<IEnumerable<Product>> SearchProducts(string query);
    }
}
