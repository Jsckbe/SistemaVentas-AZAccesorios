using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DProveedor
    {
        public String Registrar(Proveedores proveedor)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Proveedores.Add(proveedor);
                    context.SaveChanges();
                }
                return "Registrado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Modificar(Proveedores proveedor)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Proveedores proveedorTemp = context.Proveedores.Find(proveedor.id_proveedor);
                    proveedorTemp.nombre_proveedor = proveedor.nombre_proveedor;
                    proveedorTemp.productos_vender = proveedor.productos_vender;
                    proveedorTemp.direccion_proveedor = proveedor.direccion_proveedor;
                    proveedorTemp.telefono_proveedor = proveedor.telefono_proveedor;
                    proveedorTemp.ruc_proveedor = proveedor.ruc_proveedor;
                    proveedorTemp.Empleados_id_empleados = proveedor.Empleados_id_empleados;
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
                    Proveedores proveedorTemp = context.Proveedores.Find(id);
                    context.Proveedores.Remove(proveedorTemp);
                    context.SaveChanges();
                }
                return "Eliminado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Proveedores> ListarTodo()
        {
            List<Proveedores> proveedores = new List<Proveedores>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    proveedores = context.Proveedores.ToList();
                }
                return proveedores;
            }
            catch (Exception ex)
            {
                return proveedores;
            }
        }
    }
}