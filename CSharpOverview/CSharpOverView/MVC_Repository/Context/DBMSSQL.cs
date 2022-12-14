using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Repository.Context
{
    public class DBMSSQL
    {
        private SqlConnection _Connection;

        public DBMSSQL()
        {
            this.ConnectionString = "";
            _Connection = new SqlConnection();
        }

        public string ConnectionString { get; set; }

        public bool Connect()
        {
            if (this.Status() != ConnState.IsOpen)
            {

                _Connection.ConnectionString = this.ConnectionString;
                _Connection.Open();

            }

            if (_Connection.State == System.Data.ConnectionState.Open)
            {
                return true;
            }
            else { return false; }

        }

        public ConnState Status()
        {

            switch (_Connection.State)
            {
                case System.Data.ConnectionState.Open:
                    return ConnState.IsOpen;
                case System.Data.ConnectionState.Fetching:
                    return ConnState.IsOpen;
                default:
                    return ConnState.IsClosed;
            }
        }

        public enum ConnState
        {
            IsOpen,
            IsClosed
        }

        public void Close()
        {
            _Connection.Close();
        }

        public void ExecuteSQL(string sql)
        {
            //  _Connection = new SqlConnection(ConnectionString);
            Microsoft.Data.SqlClient.SqlCommand cmd = _Connection.CreateCommand();
            cmd.CommandText = sql;

            cmd.ExecuteNonQuery();

        }

        public System.Data.DataTable GetDT(string sql)
        {
            //  _Connection = new SqlConnection(ConnectionString);
            System.Data.DataTable dt = new System.Data.DataTable();
            Microsoft.Data.SqlClient.SqlDataAdapter da = new SqlDataAdapter();
            Microsoft.Data.SqlClient.SqlCommand cmd = _Connection.CreateCommand();
            cmd.CommandText = sql;
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
    }
}
