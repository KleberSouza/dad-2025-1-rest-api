﻿using Microsoft.EntityFrameworkCore;

namespace apiRest.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Veiculo> Veiculos { get; set; }

    }
}
