﻿public class Categoria
{
    public int CategoriaID { get; set; }
    public string Nombre { get; set; }
    public List<Producto> Productos { get; set; }
}