using Microsoft.AspNetCore.Mvc.Rendering;

using System.Collections.Generic;

namespace MVCMerchandising.Models
{
    public class Producto
    {
            public int Id { get; set; }
            public string Nombre { get; set; }

            public List<Producto> Productos { get; set; }

            public string Talles { get; set; }

            public string Descripcion { get; set; }

            public decimal Precio { get; set; }

        
    }
}
