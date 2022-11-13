using Entity_Framework6.Contexts;

namespace Entity_Framework6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            using (var db = new TaskDataContext())
            {
                var tasks = db.Tasks.ToList();
            }
            InitializeComponent();
        }
    }
}