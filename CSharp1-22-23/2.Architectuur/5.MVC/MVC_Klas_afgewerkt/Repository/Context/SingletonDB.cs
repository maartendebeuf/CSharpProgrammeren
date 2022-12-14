using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Context
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
                _DB.ConnectionString = LocalDBContext._connectionString;
                //  _DB.ConnectionString = Connstring;
                _DB.Connect();

            }
            return _DB;
        }
    }
}
