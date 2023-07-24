using DAL.Db.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Db
{
    public class TierContext : DbContext
    {
        public DbSet<Catagory> Catagories { get; set; }
    }
}
