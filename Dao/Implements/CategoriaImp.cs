using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dao.DataAccessObject;


namespace Dao.Implements
{
    public class CategoriaImp
    {
       public List<CategoriaEntity>GetCategorias()
        {
            var listaCategorias = new List<CategoriaEntity>();
           DataAccess datos = new DataAccess();
            try
            {
                datos.setearConsulta("SELECT Id, Descripcion FROM CATEGORIAS");
                datos.ejecutarLectura();

                while (datos.Reader.Read())
                {
                    var categoria = new CategoriaEntity();
                   categoria.Id = (int)datos.Reader["Id"];
                   categoria.Descripcion = (string)datos.Reader["Descripcion"];
                        listaCategorias.Add(categoria);

                }
                return listaCategorias;
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
