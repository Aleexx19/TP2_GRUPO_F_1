using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ArticuloEntity
    {
        public int CodArticulo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public SqlMoney precio { get; set; }

    }
}
