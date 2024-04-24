using Dao.Implements;
using Domain.Entities;
using System;
using System.Collections.Generic;

namespace Business
{
    public class MarcaBusiness 
    {

        public List<MarcaEntity> GetMarcas()
        {
            var listMarcas = new List<MarcaEntity>();
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
