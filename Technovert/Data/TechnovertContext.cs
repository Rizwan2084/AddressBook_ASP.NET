using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Technovert.Models
{
    public class TechnovertContext : DbContext
    {
        public TechnovertContext (DbContextOptions<TechnovertContext> options)
            : base(options)
        {
        }

        public DbSet<Technovert.Models.ContactDetails> ContactDetails { get; set; }
    }
}
