using TiendaLibretasAPI.Models;

public class Producto
{
    public int ProductoID { get; set; }
    public string Nombre { get; set; }
    public string Descripción { get; set; }
    public decimal Precio { get; set; }
    public string ImagenURL { get; set; }
    public int CategoriaID { get; set; }
    public Categoria Categoria { get; set; }
}