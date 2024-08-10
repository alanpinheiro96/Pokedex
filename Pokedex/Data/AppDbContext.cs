using Microsoft.EntityFrameworkCore;
using Pokedex.Models;

namespace Pokedex.Data;

public class AppDbContext : DbContext
//ctor = criar construtor
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
//prop = criar propriedades

    public DbSet<Genero> Generos { get; set; }

    public DbSet<Pokemon> Pokemons { get; set; }

    public DbSet<PokemonTipo> PokemonTipos { get; set; }

    public DbSet<Regiao> Regioes { get; set; }

    public DbSet<Tipo> Tipos { get; set; }

//Conexão muitos para muitos
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        #region Configuração do Muitos Para Muitos - PokemonTipo
//Definindo Chave Primaria
        modelBuilder.Entity<PokemonTipo>()
            .HasKey(pt => new { pt.PokemonNumero, pt.TipoId });

        #endregion
    }
}