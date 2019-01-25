using prtx_backend.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace prtx_backend.Core
{
    public class SearchEngine: ISearch
    {

        private readonly IRepositoryContext repoContext;

        public SearchEngine(IRepositoryContext repoContext)
        {
            this.repoContext = repoContext;
        }

        public IEnumerable<Product> SearchProducts(string query)
        {
            IQueryable<Product> filteredProducts = repoContext.Products.Where(p => p.name.Contains(query) || p.description.Contains(query));

            return filteredProducts;
        }
    }
}