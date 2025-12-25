using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_phong_lab.DAL
{
    public class Connection
    {
        private static string connectionString = @"Data Source=NEYUHTLAP\SQLEXPRESS;Initial Catalog=QL_lichphongthuchanh;Integrated Security=True;TrustServerCertificate=True";
        public static string GetConnectionString()
        {
            return connectionString;
        }
    }
}
