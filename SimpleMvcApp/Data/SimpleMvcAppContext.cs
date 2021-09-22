using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SimpleMvcApp.Models
{
    public class SimpleMvcAppContext : DbContext
    {
        public SimpleMvcAppContext (DbContextOptions<SimpleMvcAppContext> options)
            : base(options)
        {
        }

        public DbSet<Message> Message { get; set; }
    }
}
