using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NFactura
    {
        private DFactura dFactura = new DFactura();

        public String Registrar(Factura factura)
        {
            return dFactura.Registrar(factura);
        }

        public String Modificar(Factura factura)
        {
            return dFactura.Modificar(factura);
        }

        public String Eliminar(int id)
        {
            return dFactura.Eliminar(id);
        }

        public List<Factura> ListarTodo()
        {
            return dFactura.ListarTodo();
        }
    }
}