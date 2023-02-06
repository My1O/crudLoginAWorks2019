using System;
using System.Collections.Generic;

namespace CRUDloginSQLwithEntityFramework.Models
{
    public partial class ProductosDescontinuado
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = null!;
        public DateTime? DiscontinuedDate { get; set; }
    }
}
