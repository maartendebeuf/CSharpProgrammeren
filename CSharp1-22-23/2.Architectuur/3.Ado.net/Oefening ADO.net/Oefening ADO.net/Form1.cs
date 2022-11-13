using Microsoft.Data.SqlClient;
using Oefening_ADO.net.Repository;
using System.Data;
using System.Media;

namespace Oefening_ADO.net
{
    public partial class Form1 : Form
    {
        private RepositoryTestADO _repo;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _repo = new RepositoryTestADO();

            SqlConnection con = new SqlConnection();
            con.ConnectionString = SingletonDB.GetDB().ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [tbl_test]", con);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);   
           
            da.Fill(ds);

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = ds.Tables[0].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> items = _repo.GetItems();
            MessageBox.Show(items.Count.ToString());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}