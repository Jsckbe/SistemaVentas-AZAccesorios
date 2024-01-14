using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NEmpleado
    {
        private DEmpleado dEmpleado = new DEmpleado();

        public String Registrar(Empleados empleado)
        {
            return dEmpleado.Registrar(empleado);
        }

        public String Modificar(Empleados empleado)
        {
            return dEmpleado.Modificar(empleado);
        }

        public String Eliminar(int id)
        {
            return dEmpleado.Eliminar(id);
        }

        public List<Empleados> ListarTodo()
        {
            return dEmpleado.ListarTodo();
        }

        public List<Empleados> ListarTodoPorDNI(int dni_empleado)
        {
            return dEmpleado.ListarTodoPorDNI(dni_empleado);
        }
    }
}