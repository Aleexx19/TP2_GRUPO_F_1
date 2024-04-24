using Dao.Implements;
using Domain.Entities;
using System.Collections.Generic;
using System;

namespace Business.Marca
{
  public class CategoriaBusiness
    {
        public List <CategoriaEntity> GetCategorias()
        {
            var listCategorias = new List<CategoriaEntity>();
            var categoriaDao = new CategoriaImp();
            try
            {
                listCategorias = categoriaDao.GetCategorias();
                return listCategorias;

            }
            catch(Exception ex) 
            {

                throw ex;
            }
        }
    }
}
