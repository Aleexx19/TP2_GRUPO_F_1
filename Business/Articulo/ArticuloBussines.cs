using Dao.Implements;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace Business.Articulo
{
    public class ArticuloBussines
    {
        public List<ArticuloEntity> GetArticulo()
        {
            var listArticulos = new List<ArticuloEntity>();
            var ArticuloDao = new ArticuloImp();
            try
            {
                listArticulos = ArticuloDao.GetArticulo();

                return listArticulos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
         
        public int agregarArticulo(ArticuloEntity nuevo)
        {
            ArticuloImp artImp = new ArticuloImp();
            try
            {
                return artImp.AgregarArticulo(nuevo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Eliminar(int id)
        {
            ArticuloImp articuloImp = new ArticuloImp();
            try
            {
                articuloImp.Eliminar(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

    }
   

    }
