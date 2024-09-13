using System.Data.Common;
using Ingresso.Core.Models;
using Ingresso.Core.Models.Corporation;
using Microsoft.EntityFrameworkCore;

namespace Ingresso.Core.Data;

public class ConnectionDbContext : DbContext
{
    public ConnectionDbContext(DbContextOptions<ConnectionDbContext> options) : base(options)
    {
    }

    public DbSet<Horario> Horarios { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Preco> Precos { get; set; }
    public DbSet<Sala> Salas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Horario>()
            .HasOne<Sala>(e => e.sala)
            .WithMany(e => e.horario)
            .HasForeignKey(e => e.sala_Id)
            .IsRequired();
        
        modelBuilder.Entity<Horario>()
            .HasOne<Movie>(e => e.movie)
            .WithMany(e => e.horarios)
            .HasForeignKey(e => e.movie_Id)
            .IsRequired();
        modelBuilder.Entity<Preco>()
            .HasOne<Horario>( e=>e.horario)
            .WithOne(e => e.preco)
            .HasForeignKey<Preco>(e => e.horario_Id)
            .IsRequired();

        modelBuilder.Entity<Sala>()
            .HasOne<Corp>(e => e.corp)
            .WithMany(e => e.SalaCollection)
            .HasForeignKey(e => e.Corp_ID)
            .IsRequired();
    }
}