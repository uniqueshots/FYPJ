using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FYPJ4.Models
{
    public class FYPJ4Context : DbContext
    {
        public FYPJ4Context (DbContextOptions<FYPJ4Context> options)
            : base(options)
        {
        }

        public DbSet<FYPJ4.Models.News> News { get; set; }
    }
}
