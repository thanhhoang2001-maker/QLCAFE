using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLCAFE
{
    public class DBConnect
    {
        protected SqlConnection _conn = new SqlConnection(@"Data Source=VANDUC\SQLEXPRESS;Initial Catalog=QLQuanCaFe;Integrated Security=True");
    }
}
