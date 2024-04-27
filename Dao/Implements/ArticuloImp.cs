﻿using Dao.DataAccessObject;
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
              
                datos.setearConsulta("SELECT  A.ID, A.CODIGO, A.NOMBRE, A.DESCRIPCION, A.IdMarca, M.Descripcion AS DSM," +
                    " A.IdCategoria, C.Descripcion AS DSC, A.Precio  FROM ARTICULOS A INNER JOIN MARCAS M ON (A.IdMarca=M.Id)" +
                    " INNER JOIN CATEGORIAS C ON (A.IdCategoria=C.Id)");

                datos.ejecutarLectura();
                
                while (datos.Reader.Read())
                {
                    var articulo = new ArticuloEntity(); 
                    articulo.Id = (int)datos.Reader["id"];
                    articulo.CodArticulo = (string)datos.Reader["Codigo"];
                    articulo.nombre = (string)datos.Reader["Nombre"];
                    articulo.descripcion = (string)datos.Reader["Descripcion"];

                    articulo.Marca = new MarcaEntity();
                    articulo.Categoria = new CategoriaEntity();

                    articulo.Marca.Id = (int)datos.Reader["IdMarca"];
                    articulo.Marca.Descripcion = (string)datos.Reader["DSM"];
                    articulo.Categoria.Id = (int)datos.Reader["IdCategoria"];
                    articulo.Categoria.Descripcion = (string)datos.Reader["DSC"];
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

        public int AgregarArticulo(ArticuloEntity art)
        {
            DataAccess datos = new DataAccess(); //La proxima linea necesita agregar Categoria y Marca !
            string consulta = string.Format("insert into ARTICULOS (Codigo, Nombre, Descripcion, Precio) values ('" + art.CodArticulo + "', '" + art.nombre + "', '" + art.descripcion + "', " + art.precio + ")");

            try
            {
                datos.setearConsulta(consulta); 
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
