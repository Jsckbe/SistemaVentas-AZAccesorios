using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NDetallexBoleta
    {
        private DDetallexBoleta dDetallexBoleta = new DDetallexBoleta();

        public String Asignar(DetallesxBoleta detallexBoleta)
        {
            return dDetallexBoleta.Asignar(detallexBoleta);
        }

        public List<DetallesxBoleta> ListarTodo()
        {
            return dDetallexBoleta.ListarTodo();
        }
    }
}