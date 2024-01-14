using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DDetallexBoleta
    {
        public String Asignar(DetallesxBoleta detallexBoleta)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.DetallesxBoleta.Add(detallexBoleta);
                    context.SaveChanges();
                }
                return "Asignado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<DetallesxBoleta> ListarTodo()
        {
            List<DetallesxBoleta> detallexBoletas = new List<DetallesxBoleta>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    detallexBoletas = context.DetallesxBoleta.ToList();
                }
                return detallexBoletas;
            }
            catch (Exception ex)
            {
                return detallexBoletas;
            }
        }
    }
}