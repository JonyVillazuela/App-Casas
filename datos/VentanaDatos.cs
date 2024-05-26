using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace datos
{
    public class VentanaDatos
    {
        public List<Ventana> listar()
        {
			List<Ventana> lista =new List<Ventana>();
			AccesoDatos datos = new AccesoDatos();

			try
			{
				datos.setearConsulta("Select Id, [Tipo de Ventana] from Ventanas");
				datos.ejecutarLectura();

				while(datos.Lector.Read())
				{
					Ventana aux = new Ventana();
					aux.Id = (int)datos.Lector["Id"];
					aux.TipoVentana = (string)datos.Lector["Tipo de Ventana"];

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
