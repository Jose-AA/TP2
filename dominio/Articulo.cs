using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        public int id { get; set; }

        public string codigo { get; set; }

        public string nombre { get; set; }

        public string descripcion { get; set; }

        public decimal precio { get; set; }

        public Marca marcaArticulo { get; set; } 
        
        public Categoria categoriaArticulo { get; set; } 

        List<Imagen> imagenes;
    }
}
