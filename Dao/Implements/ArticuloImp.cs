using Dao.DataAccessObject;
using Domain.Entities;
using System;
using System.Collections.Generic;

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
                datos.setearConsulta("SELECT  A.ID, A.CODIGO, A.NOMBRE, A.DESCRIPCION, A.IdMarca, M.Descripcion AS DSM," +
                    " A.IdCategoria, C.Descripcion AS DSC, A.Precio  FROM ARTICULOS A INNER JOIN MARCAS M ON (A.IdMarca=M.Id)" +
                    " INNER JOIN CATEGORIAS C ON (A.IdCategoria=C.Id)");

                datos.ejecutarLectura();
                
                while (datos.Reader.Read())
                {
                    var articulo = new ArticuloEntity(); 
                    articulo.Id = (int)datos.Reader["id"];
                    articulo.CodArticulo = (string)datos.Reader["Codigo"];
                    articulo.Nombre = (string)datos.Reader["Nombre"];
                    articulo.Descripcion = (string)datos.Reader["Descripcion"];

                    articulo.Marca = new MarcaEntity();
                    articulo.Categoria = new CategoriaEntity();

                    articulo.Marca.Id = (int)datos.Reader["IdMarca"];
                    articulo.Marca.Descripcion = (string)datos.Reader["DSM"];
                    articulo.Categoria.Id = (int)datos.Reader["IdCategoria"];
                    articulo.Categoria.Descripcion = (string)datos.Reader["DSC"];
                    articulo.Precio = (decimal)datos.Reader["Precio"];

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

        public int AgregarArticulo(ArticuloEntity art)
        {
            DataAccess datos = new DataAccess(); //La proxima linea necesita agregar Categoria y Marca !
            string consulta = "INSERT ARTICULOS " +
                              "VALUES(@codigo,@nombre,@descripcion,@idMarca,@idCategoria,@precio)";

            try
            {
                datos.setearConsulta(consulta);
                datos.setearParametro("@codigo", art.CodArticulo);
                datos.setearParametro("@nombre", art.Nombre);
                datos.setearParametro("@descripcion", art.Descripcion);
                datos.setearParametro("@idMarca", art.Marca.Id);
                datos.setearParametro("@idCategoria", art.Categoria.Id);
                datos.setearParametro("@precio", art.Precio);
                return datos.ejecutarAccion(); 
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

        public int ModificarArticulo(ArticuloEntity art)
        {
            DataAccess datos = new DataAccess(); 
            string consulta = "UPDATE ARTICULOS " +
                "SET Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, " +
                "IdMarca = @idMarca, IdCategoria = @idCategoria, Precio = @precio " +
                "WHERE ID = @id";

            try
            {
                datos.setearConsulta(consulta);
                datos.setearParametro("@codigo",art.CodArticulo);
                datos.setearParametro("@nombre", art.Nombre);
                datos.setearParametro("@descripcion", art.Descripcion);
                datos.setearParametro("@idMarca", art.Marca.Id);
                datos.setearParametro("@idCategoria", art.Categoria.Id);
                datos.setearParametro("@precio", art.Precio);
                datos.setearParametro("@id", art.Id);
                return datos.ejecutarAccion();
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

        public void Eliminar(int id)
        {
            try
            {
                DataAccess datos = new DataAccess();
                datos.setearConsulta("delete from ARTICULOS where Id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
