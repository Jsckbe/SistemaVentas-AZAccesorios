using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NDetallexFactura
    {
        private DDetallexFactura dDetallexFactura = new DDetallexFactura();

        public String Asignar(DetallesxFactura detallexFactura)
        {
            return dDetallexFactura.Asignar(detallexFactura);
        }

        public List<DetallesxFactura> ListarTodo()
        {
            return dDetallexFactura.ListarTodo();
        }
    }
}