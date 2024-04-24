using Dao.DataAccessObject;
using Domain.Entities;
using System;
using System.Collections.Generic;

namespace Dao.Implements
{
    public class MarcaImp 
    {

        public List<MarcaEntity> GetMarcas()
        {
            var listMarcas = new List<MarcaEntity>();
            DataAccess datos = new DataAccess();

            try
            {
                datos.setearConsulta("SELECT Id, Descripcion FROM MARCAS");
                datos.ejecutarLectura();

                while (datos.Reader.Read())
                {
                    var marca = new MarcaEntity();
                    marca.Id = (int)datos.Reader["Id"];
                    marca.Descripcion = (string)datos.Reader["Descripcion"];

                    listMarcas.Add(marca);
                }

                return listMarcas;
            }catch(Exception ex)
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
