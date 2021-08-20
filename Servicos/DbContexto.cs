using System;
using EntityFrameWork.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameWork.Servicos
{
    public class DbContexto : DbContext
    {
        public DbContexto(DbContextOptions<DbContexto> options) : base(options){}
        public DbSet<Cliente> Clientes {get; set;}
        public DbSet<EntityFrameWork.Models.Produto> Produto { get; set; }
    }
}