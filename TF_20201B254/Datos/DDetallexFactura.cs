using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DDetallexFactura
    {
        public String Asignar(DetallesxFactura detalllexFactura)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.DetallesxFactura.Add(detalllexFactura);
                    context.SaveChanges();
                }
                return "Asignado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<DetallesxFactura> ListarTodo()
        {
            List<DetallesxFactura> detallexFacturas = new List<DetallesxFactura>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    detallexFacturas = context.DetallesxFactura.ToList();
                }
                return detallexFacturas;
            }
            catch (Exception ex)
            {
                return detallexFacturas;
            }
        }
    }
}