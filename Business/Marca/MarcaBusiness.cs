using Dao.Implements;
using Domain.Entities;
using System;
using System.Collections.Generic;

namespace Business
{
    public class MarcaBusiness 
    {

        public List<Marca> GetMarcas()
        {
            var listMarcas = new List<Marca>();
            var marcaDao = new MarcaImp();
            try
            {
                listMarcas = marcaDao.GetMarcas();

                return listMarcas;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
