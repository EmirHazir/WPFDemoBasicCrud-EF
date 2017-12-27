using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDemo_001.Models
{
    class MyDataContext : DbContext
    {
        public MyDataContext():base("name=MyConnection")
        {}

        public DbSet<Personel> Personels { get; set; }
    }
}
