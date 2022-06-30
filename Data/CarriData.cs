using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCMerchandising.Models;

namespace MVCMerchandising.Data
{
    public class CarriData : DbContext
    {
        public CarriData(DbContextOptions<CarriData> options)
            : base(options)
        {
        }

        public DbSet<MVCMerchandising.Models.Merchandising> Merchandising { get; set; }

        public DbSet<MVCMerchandising.Models.Producto> Producto { get; set; }
    }
}
