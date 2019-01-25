using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prtx_backend.Repository
{
    public interface IRepositoryContext
    {
        IDbSet<Product> Products { get; set; }
    }
}
