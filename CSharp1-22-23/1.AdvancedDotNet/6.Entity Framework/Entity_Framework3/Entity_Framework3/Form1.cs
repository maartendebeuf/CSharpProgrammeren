using Entity_Framework3.Contexts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_Framework3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (var db = new TaskDataContext())
            {
                var tasks = db.Tasks2.ToList();
            }
        }
    }
}
