using MVVM_klassikaal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_klassikaal.ViewModels
{
    public class DetailVM : BasisVM
    {
        public DetailVM() { }
        public DetailVM(Gebruiker u) {
            this.user = u;
        }
        public Gebruiker user { get; set; }
    }
}
