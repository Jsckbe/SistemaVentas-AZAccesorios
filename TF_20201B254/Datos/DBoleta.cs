using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DBoleta
    {
        public String Registrar(Boleta boleta)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Boleta.Add(boleta);
                    context.SaveChanges();
                }
                return "Registrado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Modificar(Boleta boleta)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Boleta boletaTemp = context.Boleta.Find(boleta.id_boleta);
                    boletaTemp.numero_boleta = boleta.numero_boleta;
                    boletaTemp.fecha = boleta.fecha;
                    boletaTemp.Clientes_id_cliente = boleta.Clientes_id_cliente;
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
                    Boleta boletaTemp = context.Boleta.Find(id);
                    context.Boleta.Remove(boletaTemp);
                    context.SaveChanges();
                }
                return "Eliminado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Boleta> ListarTodo()
        {
            List<Boleta> boletas = new List<Boleta>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    boletas = context.Boleta.ToList();
                }
                return boletas;
            }
            catch (Exception ex)
            {
                return boletas;
            }
        }

        //Reporte hecho por Norel Vidaurre U202114246

        public List<Boleta> ListarTodoPorCliente(String nombrecliente)
        {
            List<Boleta> boletas = new List<Boleta>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    boletas = context.Boleta.Where(c => c.Clientes.nombre_cliente.Equals(nombrecliente)).ToList();
                }
                return boletas;
            }
            catch (Exception ex)
            {
                return boletas;
            }
        }

        //Reporte hecho por Yerly Becerra U20211E436
        public List<Boleta> ListarTodoPorNumero(string numero_boleta)
        {
            List<Boleta> boletas = new List<Boleta>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    //boletas = context.Boleta.Where(c => c.Boleta.fecha.Contains(fecha)).ToList();
                    //boletas = context.Boleta.Where(c => c.Clientes.Boleta.Equals(numero_boleta)).ToList();
                    boletas = context.Boleta.Where(c => c.numero_boleta.Equals(numero_boleta)).ToList();

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