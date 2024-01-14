using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DCliente
    {
        public String Registrar(Clientes cliente)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Clientes.Add(cliente);
                    context.SaveChanges();
                }
                return "Registrado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Modificar(Clientes cliente)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Clientes clienteTemp = context.Clientes.Find(cliente.id_cliente);
                    clienteTemp.dni_cliente = cliente.dni_cliente;
                    clienteTemp.nombre_cliente = cliente.nombre_cliente;
                    clienteTemp.telefono = cliente.telefono;
                    clienteTemp.direccion = cliente.direccion;
                    clienteTemp.Empleados_id_empleados = cliente.Empleados_id_empleados;
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
                    Clientes clienteTemp = context.Clientes.Find(id);
                    context.Clientes.Remove(clienteTemp);
                    context.SaveChanges();
                }
                return "Eliminado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Clientes> ListarTodo()
        {
            List<Clientes> clientes = new List<Clientes>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    clientes = context.Clientes.ToList();
                }
                return clientes;
            }
            catch (Exception ex)
            {
                return clientes;
            }
        }

        //Reporte hecho por Fabiana Paucar U201921905
        public List<Clientes> ListarTodoPorDNI(int dni)
        {
            List<Clientes> clientes = new List<Clientes>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    clientes = context.Clientes.Where(c => c.dni_cliente.Equals(dni)).ToList();
                }
                return clientes;
            }
            catch (Exception ex)
            {
                return clientes;
            }
        }
    }
}