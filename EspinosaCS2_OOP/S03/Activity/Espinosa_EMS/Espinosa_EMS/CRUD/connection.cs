using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espinosa_EMS.CRUD
{
    class connection
    {
        //>>> Insert Constring here!

        static string dbPath = @"C:\LOCALDB\EMS.mdb";
        public static string conString = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={dbPath};";
        //private static string conString = " Data Source = tcp:127.2.3.4; Initial Catalog = TestDB; User ID = saa; Password= Password=P@ssw0rd;";


        public static OleDbConnection mysqldb()
        {
            return new OleDbConnection(conString);

        }
        public static OleDbConnection con = mysqldb();
    }
}
