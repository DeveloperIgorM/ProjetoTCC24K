using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Aula14DAAWW.Models;

namespace Aula14DAAWW.Data
{
    public class Aula14DAAWWContext : DbContext
    {
        public Aula14DAAWWContext (DbContextOptions<Aula14DAAWWContext> options)
            : base(options)
        {
        }

        public DbSet<Aula14DAAWW.Models.Jogo> Jogo { get; set; } = default!;
    }
}
