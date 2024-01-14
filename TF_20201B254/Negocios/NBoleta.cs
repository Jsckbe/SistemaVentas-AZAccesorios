using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NBoleta
    {
        private DBoleta dBoleta = new DBoleta();

        public String Registrar(Boleta boleta)
        {
            return dBoleta.Registrar(boleta);
        }

        public String Modificar(Boleta boleta)
        {
            return dBoleta.Modificar(boleta);
        }

        public String Eliminar(int id)
        {
            return dBoleta.Eliminar(id);
        }

        public List<Boleta> ListarTodo()
        {
            return dBoleta.ListarTodo();
        }

        public List<Boleta> ListarTodoPorCliente(String cuerpo_nombre)
        {
            return dBoleta.ListarTodoPorCliente(cuerpo_nombre);
        }

        public List<Boleta> ListarTodoPorNumero(string numero_boleta)
        {
            return dBoleta.ListarTodoPorNumero(numero_boleta);
        }
    }
}