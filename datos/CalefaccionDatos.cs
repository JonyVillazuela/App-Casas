using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace datos
{
    public class CalefaccionDatos
    {
        public List<Calefaccion> listar()
        {
            List<Calefaccion> lista = new List<Calefaccion>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select Id, [Tipo de Calefaccion] from Calefaccion");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Calefaccion aux = new Calefaccion();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.TipoCalefaccion = (string)datos.Lector["Tipo de Calefaccion"];

                    lista.Add(aux);
                }
                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }


    }
}
