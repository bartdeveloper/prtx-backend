using Microsoft.VisualStudio.TestTools.UnitTesting;
using prtx_backend;
using prtx_backend.Controllers;
using prtx_backend.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prtx_backend_tests
{
    [TestClass]
    public class SearchTest
    {
       
        [TestMethod]
        public void TestSearchEngine()
        {
            SearchEngine se = new SearchEngine();

            Task<IEnumerable<Product>> searchingProducts = se.SearchProducts("profil");

            Assert.IsNotNull(searchingProducts);
        }

    }
}
