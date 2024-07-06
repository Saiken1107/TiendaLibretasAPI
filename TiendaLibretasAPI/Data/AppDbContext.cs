using Microsoft.EntityFrameworkCore;

public class TiendaLibretasContext : DbContext
{
    public TiendaLibretasContext(DbContextOptions<TiendaLibretasContext> options) : base(options) { }

    public DbSet<Producto> Productos { get; set; }
    public DbSet<Categoria> Categorias { get; set; }
}