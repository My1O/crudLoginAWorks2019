using System;
using System.Collections.Generic;

namespace CRUDloginSQLwithEntityFramework.Models
{
    public partial class ProductosActivo
    {
        public int? ProductId { get; set; }
        public int? ProductoModelo { get; set; }
        public string? Name { get; set; }
        public string? ProductNumber { get; set; }
        public int? ProductCategoryId { get; set; }
        public string? NombreCategoria { get; set; }
        public int? ProductSubcategoryId { get; set; }
        public string? NombreSubCategoria { get; set; }
        public int? ProductoModeloSubCategoria { get; set; }
        public string? NombreModelo { get; set; }
        public string? CatalogDescription { get; set; }
    }
}
