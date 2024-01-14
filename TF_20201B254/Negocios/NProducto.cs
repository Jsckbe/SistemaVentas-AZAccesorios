using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NProducto
    {
        private DProducto dProducto = new DProducto();

        public String Registrar(Productos producto)
        {
            return dProducto.Registrar(producto);
        }

        public String Modificar(Productos producto)
        {
            return dProducto.Modificar(producto);
        }

        public String Eliminar(int id)
        {
            return dProducto.Eliminar(id);
        }

        public List<Productos> ListarTodo()
        {
            return dProducto.ListarTodo();
        }

        public List<Productos> ListarProductoxCod(int producCod)
        {
            return dProducto.ListarProductoxCod(producCod);
        }
    }
}