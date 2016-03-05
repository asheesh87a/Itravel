using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ItravelDataAccess
{
   public class ConectionString
    {
        public string dataConection()
        {
            string con = @"Data Source=ASHEESHYADAV-PC;Initial Catalog=Itravel;Integrated Security=True";
            return con;
        }
    }
}
