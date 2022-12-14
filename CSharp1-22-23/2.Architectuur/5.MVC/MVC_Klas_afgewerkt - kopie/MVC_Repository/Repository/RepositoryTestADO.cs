using MVC_Repository.Context;
//using Repository.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Repository.Repository
{
    public class RepositoryTestADO : IRepositoryTest
    {
        DBMSSQL _db;
        public RepositoryTestADO()
        {
            //   _db = new DBMSSQL();
            //   _db.ConnectionString = "Server=localhost\\sqlexpress; Database=testdb;Trusted_Connection=True; User Id=tester;Password=test; TrustServerCertificate=True";
            _db = SingletonDB.GetDB();
        }
        public List<Models.tbl_test> GetItems()
        {

            List<Models.tbl_test > ListValues = new List<Models.tbl_test>();


            _db.Connect();
            System.Data.DataTable dt = _db.GetDT("SELECT * FROM tbl_test;");
            _db.Close();

            //System.Data.DataTable dt = SingletonDB.GetDB().GetDT("SELECT * FROM tbl_test;");

            // MessageBox.Show("Aantal rijen: " + dt.Rows.Count);
            foreach (DataRow dr in dt.Rows)
            {

                Models.tbl_test newTbl_Test = new Models.tbl_test();
                newTbl_Test.Idx = (int)dr.ItemArray[0];
                newTbl_Test.Col1 = (string)dr.ItemArray[1];

                ListValues.Add(newTbl_Test);
            }
            return ListValues;

        }

        public string GetItemById(int Id)
        {


            _db.Connect();
            // System.Data.DataTable dt  = SingletonDB.GetDB().GetDT("SELECT * FROM tbl_test WHERE Idx = " + Id + ";");
            System.Data.DataTable dt = _db.GetDT("SELECT * FROM tbl_test WHERE Idx = " + Id + ";");
            // MessageBox.Show("Aantal rijen: " + dt.Rows.Count);
            _db.Close();
            string valueToReturn = (string)dt.Rows[0].ItemArray[1];
            return valueToReturn;
        }

        public void AddItem(Models.tbl_test valueToAdd)
        {
            string sSQL = "INSERT INTO tbl_test (Col1) VALUES('" + valueToAdd.Col1 + "')";
            if (_db.Connect())
            {
                _db.ExecuteSQL(sSQL);
            }

            _db.Close();
        }

        public void DeleteItem(int Id)
        {
            string sSQL = "DELETE FROM tbl_test WHERE Idx = " + Id + ";";

            _db.Connect();
            _db.ExecuteSQL(sSQL);
            _db.Close();
        }
    }
}