using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NProveedor
    {
        private DProveedor dProveedor = new DProveedor();

        public String Registrar(Proveedores proveedor)
        {
            return dProveedor.Registrar(proveedor);
        }

        public String Modificar(Proveedores proveedor)
        {
            return dProveedor.Modificar(proveedor);
        }

        public String Eliminar(int id)
        {
            return dProveedor.Eliminar(id);
        }

        public List<Proveedores> ListarTodo()
        {
            return dProveedor.ListarTodo();
        }
    }
}