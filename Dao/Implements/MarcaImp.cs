using Dao.DataAccessObject;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

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

       public int AgregarMarca(MarcaEntity marca)
        {
            DataAccess datos = new DataAccess();
            string consulta = string.Format("insert marcas (Descripcion) values ('{0}')", marca.Descripcion); //Acá armo la consulta

            try
            {
                datos.setearConsulta(consulta); //Acá ya la preparo 
                return datos.ejecutarAccion(); //Acá lo ejecuto
                
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

        //Modificar (update).

    }
}
