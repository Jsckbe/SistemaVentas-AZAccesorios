using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DFactura
    {
        public String Registrar(Factura factura)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Factura.Add(factura);
                    context.SaveChanges();
                }
                return "Registrado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Modificar(Factura factura)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Factura facturaTemp = context.Factura.Find(factura.id_factura);
                    facturaTemp.numero_factura = factura.numero_factura;
                    facturaTemp.fecha = factura.fecha;
                    facturaTemp.Proveedores_id_proveedor = factura.Proveedores_id_proveedor;
                    context.SaveChanges();
                }
                return "Modificado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Eliminar(int id)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Factura facturaTemp = context.Factura.Find(id);
                    context.Factura.Remove(facturaTemp);
                    context.SaveChanges();
                }
                return "Eliminado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Factura> ListarTodo()
        {
            List<Factura> facturas = new List<Factura>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    facturas = context.Factura.ToList();
                }
                return facturas;
            }
            catch (Exception ex)
            {
                return facturas;
            }
        }
    }
}