using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_ADO.net
{
    internal class SingletonDB
    {
        internal static DBMSSQL _DB;
        // internal static string Connstring { get; set; }

        public static DBMSSQL GetDB()
        {
            if (_DB == null)
            {
                _DB = new DBMSSQL();
                _DB.ConnectionString = "Server=MSI-MAARTEN; Database=testdb;Trusted_Connection=True; User Id=Tester;Password=Test; TrustServerCertificate=True";
                //  _DB.ConnectionString = Connstring;
                _DB.Connect();

            }
            return _DB;
        }
    }
}
