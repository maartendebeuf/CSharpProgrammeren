using EntityFrameworkCore.Contexts;

namespace EntityFrameworkCore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (var db = new TaskDataContext())
            {
                var tasks = db.Courses.ToList();


            }
        }
    }
}