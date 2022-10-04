using Entity_Framework2.Contexts;

namespace Entity_Framework2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (var db = new TaskDataContext())
            {
                var tasks = db.Tasks.ToList();
            }
        }
    }
}