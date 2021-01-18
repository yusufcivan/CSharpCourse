using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkDemo
{
    class ETradeContext:DbContext
    {
        public DbSet<Product> Products { get; set; }

    }

}
