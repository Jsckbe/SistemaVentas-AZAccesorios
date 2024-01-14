using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DProducto
    {
        public String Registrar(Productos producto)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Productos.Add(producto);
                    context.SaveChanges();
                }
                return "Registrado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Modificar(Productos producto)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Productos productoTemp = context.Productos.Find(producto.id_producto);
                    productoTemp.codigo_producto = producto.codigo_producto;
                    productoTemp.nombre_producto = producto.nombre_producto;
                    productoTemp.precio = producto.precio;
                    productoTemp.Proveedores_id_proveedor = producto.Proveedores_id_proveedor;
                    productoTemp.Empleados_id_empleados = producto.Empleados_id_empleados;
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
                    Productos productoTemp = context.Productos.Find(id);
                    context.Productos.Remove(productoTemp);
                    context.SaveChanges();
                }
                return "Eliminado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Productos> ListarTodo()
        {
            List<Productos> productos = new List<Productos>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    productos = context.Productos.ToList();
                }
                return productos;
            }
            catch (Exception ex)
            {
                return productos;
            }
        }

        //Reporte hecho por Janne Bazan U202122301
        public List<Productos> ListarProductoxCod(int producCod)
        {
            {
                List<Productos> productos = new List<Productos>();
                try
                {
                    using (var context = new BDEFEntities())
                    {
                        productos = context.Productos.Where(p => p.codigo_producto.Equals(producCod)).ToList();
                    }
                    return productos;
                }
                catch (Exception ex)
                {
                    return productos;
                }
            }
        }
    }
}