using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace prtx_backend.Core
{
    public class SearchEngine
    {
        public async Task<IEnumerable<Product>> SearchProducts(string query)
        {

            PRTXEntities db = new PRTXEntities();

            var products = await db.Products.Where(p => p.name.Contains(query) || p.description.Contains(query)).ToListAsync();

            return products;

        }
    }
}