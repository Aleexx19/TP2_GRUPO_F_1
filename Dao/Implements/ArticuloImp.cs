using Dao.DataAccessObject;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.Implements
{
    public class ArticuloImp
    {
        public List<ArticuloEntity> GetArticulo()
        {
            var listArticulos = new List<ArticuloEntity>();
            DataAccess datos = new DataAccess();

            try
            {
                datos.setearConsulta(""); //completar consulta
                datos.ejecutarLectura();

                while (datos.Reader.Read())
                {
                    var articulo = new ArticuloEntity(); //completar los campos con marcas y cat
                    articulo.CodArticulo = (int)datos.Reader["codArticulo"];
                    articulo.nombre = (string)datos.Reader["Nombre"];
                    articulo.descripcion = (string)datos.Reader["Descripcion"];
                    articulo.precio = (SqlMoney)datos.Reader["Precio"];

                    listArticulos.Add(articulo);
                }

                return listArticulos;
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
