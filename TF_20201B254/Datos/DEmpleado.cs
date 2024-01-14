using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DEmpleado
    {
        public String Registrar(Empleados empleado)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Empleados.Add(empleado);
                    context.SaveChanges();
                }
                return "Registrado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Modificar(Empleados empleado)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Empleados empleadoTemp = context.Empleados.Find(empleado.id_empleados);
                    empleadoTemp.nombre_empleado = empleado.nombre_empleado;
                    empleadoTemp.dni_empleado = empleado.dni_empleado;
                    empleadoTemp.cargo = empleado.cargo;
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
                    Empleados empleadoTemp = context.Empleados.Find(id);
                    context.Empleados.Remove(empleadoTemp);
                    context.SaveChanges();
                }
                return "Eliminado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Empleados> ListarTodo()
        {
            List<Empleados> empleados = new List<Empleados>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    empleados = context.Empleados.ToList();
                }
                return empleados;
            }
            catch (Exception ex)
            {
                return empleados;
            }
        }

        //Reporte hecho por Jack Bonzano U20201b254
        public List<Empleados> ListarTodoPorDNI(int dni_empleado)
        {
            List<Empleados> boletas = new List<Empleados>();
            try
            {
                using (var context = new BDEFEntities())
                {

                    boletas = context.Empleados.Where(c => c.dni_empleado.Equals(dni_empleado)).ToList();

                }
                return boletas;
            }
            catch (Exception ex)
            {
                return boletas;
            }
        }
    }
}