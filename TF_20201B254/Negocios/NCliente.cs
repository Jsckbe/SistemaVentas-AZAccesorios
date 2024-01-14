using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NCliente
    {
        private DCliente dCliente = new DCliente();

        public String Registrar(Clientes cliente)
        {
            return dCliente.Registrar(cliente);
        }

        public String Modificar(Clientes cliente)
        {
            return dCliente.Modificar(cliente);
        }

        public String Eliminar(int id)
        {
            return dCliente.Eliminar(id);
        }

        public List<Clientes> ListarTodo()
        {
            return dCliente.ListarTodo();
        }

        public List<Clientes> ListarTodoPorDNI(int dni)
        {
            return dCliente.ListarTodoPorDNI(dni);
        }
    }
}