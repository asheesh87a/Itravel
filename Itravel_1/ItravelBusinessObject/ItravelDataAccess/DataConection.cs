using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ItravelDataAccess
{
    public class DataConection
    {
        public DataSet DataAccess(string query)
        {
            ConectionString cs = new ConectionString();
            string con = cs.dataConection();
            SqlConnection sqlcon = new SqlConnection(con);
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }
    }
}
