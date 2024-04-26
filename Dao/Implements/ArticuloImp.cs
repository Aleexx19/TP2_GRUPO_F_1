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
                datos.setearConsulta("select Codigo,Nombre,Descripcion,Precio from ARTICULOS"); 
                datos.ejecutarLectura();

                while (datos.Reader.Read())
                {
                    var articulo = new ArticuloEntity(); //completar los campos con marcas y cat
                    articulo.CodArticulo = (string)datos.Reader["Codigo"];
                    articulo.nombre = (string)datos.Reader["Nombre"];
                    articulo.descripcion = (string)datos.Reader["Descripcion"];
                    articulo.precio = (decimal)datos.Reader["Precio"];

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
