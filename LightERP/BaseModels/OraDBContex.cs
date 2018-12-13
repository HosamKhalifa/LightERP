using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightERP.BaseModels
{
    class OraDBContext:DbContext
    {
        public OraDBContext()
            :base("name=OracleDBContext")
        {

        }
        public DbSet<SecUser> Users { get; set; }
    }
}
