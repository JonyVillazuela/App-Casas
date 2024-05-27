    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;
using datos;

namespace negocio
{
    public class ViviendaDatos
    {
        public List<Vivienda> listar()
        {
            List<Vivienda> lista = new List<Vivienda>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;


            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATÁLOGO_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Casa_lote, Ambientes, M2, Imagen_Descriptiva, Dormitorios, Baños, Piscina, P.[Tipo de Calefaccion],V.[Tipo de ventana], C.IdCalefacción, C.IdVentanas, C.Id from Viviendas C,  Calefaccion P, Ventanas V  where V.ID = C.IdVentanas and P.Id = C.IdCalefacción ";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Vivienda aux = new Vivienda();
                    aux.Id = (int)lector["Id"];
                    aux.Casa_lote = (int)lector["Casa_lote"];
                    aux.Ambientes = (int)lector["Ambientes"];
                    aux.M2 = (int)lector["M2"];

                    //if(!(lector.IsDBNull(lector.GetOrdinal("Imagen_Descriptiva"))))
                    //aux.Imagen = (string)lector["Imagen_Descriptiva"];


                    //aux.Dormitorios = (int)lector["Dormitorios"];
                    //aux.Baños = (int)lector["Baños"];
                    //aux.Piscina = (string)lector["Piscina"];
                    aux.Tipo_de_Ventana = new Ventana();
                    aux.Tipo_de_Ventana.Id = (int)lector["Id"];
                    aux.Tipo_de_Ventana.TipoVentana = (string)lector["Tipo de Ventana"];
                    aux.Tipo_de_Calefaccion = new Calefaccion();
                    aux.Tipo_de_Calefaccion.Id = (int)lector["Id"];
                    aux.Tipo_de_Calefaccion.TipoCalefaccion = (string)lector["Tipo de Calefaccion"];

                    if (!(lector["Imagen_Descriptiva"] is DBNull))
                        aux.Imagen = (string)lector["Imagen_Descriptiva"];

                    if (!(lector["Dormitorios"] is DBNull))
                        aux.Dormitorios = (int)lector["Dormitorios"];

                    if (!(lector["Baños"] is DBNull))
                        aux.Baños = (int)lector["Baños"];

                    if (!(lector["Piscina"] is DBNull))
                        aux.Piscina = (string)lector["Piscina"];



                    lista.Add(aux);
                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void agregar(Vivienda nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into Viviendas (Casa_lote, Ambientes, M2, Imagen_Descriptiva, Dormitorios, Baños, Piscina, IdCalefacción, IdVentanas) values (@Casa_lote, @Ambientes, @M2, @Imagen_Descriptiva, @Dormitorios, @Baños, @Piscina, @IdCalefacción, @IdVentanas)");
                datos.setearParametro("@Casa_lote", nuevo.Casa_lote);
                datos.setearParametro("@Ambientes", nuevo.Ambientes);
                datos.setearParametro("@M2", nuevo.M2);
                datos.setearParametro("@Imagen_Descriptiva", nuevo.Imagen);
                datos.setearParametro("@Dormitorios", nuevo.Dormitorios);
                datos.setearParametro("@Baños", nuevo.Baños);
                datos.setearParametro("@Piscina", nuevo.Piscina);
                datos.setearParametro("@IdCalefacción", nuevo.Tipo_de_Calefaccion.Id);
                datos.setearParametro("@IdVentanas", nuevo.Tipo_de_Ventana.Id);
                datos.ejecutarAccion();

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

        public void modificar(Vivienda house)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("UPDATE Viviendas SET Casa_lote = @Casa_lote, Ambientes = @Ambientes, M2 = @M2, Imagen_Descriptiva = @Imagen_Descriptiva, Dormitorios = @Dormitorios, Baños = @Baños, Piscina = @Piscina, IdCalefacción = @IdCalefacción, IdVentanas = @IdVentanas WHERE Id = @Id");
                datos.setearParametro("@Casa_lote", house.Casa_lote);
                datos.setearParametro("@Ambientes", house.Ambientes);
                datos.setearParametro("@M2", house.M2);
                datos.setearParametro("@Imagen_Descriptiva", house.Imagen);
                datos.setearParametro("@Dormitorios", house.Dormitorios);
                datos.setearParametro("@Baños", house.Baños);
                datos.setearParametro("@Piscina", house.Piscina);
                datos.setearParametro("@IdCalefacción", house.Tipo_de_Calefaccion.Id);
                datos.setearParametro("@IdVentanas", house.Tipo_de_Ventana.Id);
                datos.setearParametro("@Id", house.Id);

                datos.ejecutarAccion();
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

        public void eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from Viviendas where id= @id");
                datos.setearParametro("id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
