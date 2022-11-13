using Oefening_ADO.net.DB_Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_ADO.net.Repository
{
    public class RepositoryTestADO : IRepositoryTest
    {
        DBMSSQL _db;
        public RepositoryTestADO()
        {
            _db = SingletonDB.GetDB();
        }
        public List<string> GetItems()
        {

            List<string> ListValues = new List<string>();


            _db.Connect();
            System.Data.DataTable dt = _db.GetDT("SELECT * FROM tbl_test;");
            _db.Close();

            MessageBox.Show("Aantal rijen: " + dt.Rows.Count);

            foreach (DataRow dr in dt.Rows)
            {
                ListValues.Add((string)dr.ItemArray[1]);
            }
            return ListValues;

        }

        string IRepositoryTest.GetItemById(int Id)
        {
            _db.Connect();
            System.Data.DataTable dt = _db.GetDT("SELECT * FROM tbl_test WHERE Idx = " + Id + ";");
            _db.Close();
            string valueToReturn = (string)dt.Rows[0].ItemArray[1];
            return valueToReturn;
        }

        void IRepositoryTest.AddItem(DB_Models.tbl_test valueToAdd)
        {
            string sSQL = "INSERT INTO tbl_test (Col1) VALUES('" + valueToAdd.Col1 + "')";
            if (_db.Connect())
            {
                _db.ExecuteSQL(sSQL);
            }

            _db.Close();
        }

        void IRepositoryTest.DeleteItem(int Id)
        {
            string sSQL = "DELETE FROM tbl_test WHERE Idx = " + Id + ";";

            _db.Connect();
            _db.ExecuteSQL(sSQL);
            _db.Close();
        }
    }
}
