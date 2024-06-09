using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
//para definir o contexto do banco de dados.

namespace TOLYID.BANCO
{
    public class AppDbContext : DbContext
    {
        public DbSet<Tatu> Tatus { get; set; }  // DbSet para a entidade Tatu

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=yourdatabase.db");
        }
    }
}
