using prtx_backend.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace prtx_backend.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "GET")]
    public class SearchController : ApiController
    {

        private readonly ISearch _searchRepo;

        public SearchController(ISearch repo)
        {
            _searchRepo = repo;
        }

        // GET api/search/query
        public IEnumerable<Product> Get(string query)
        {

            return _searchRepo.SearchProducts(query);

        }

    }
}
