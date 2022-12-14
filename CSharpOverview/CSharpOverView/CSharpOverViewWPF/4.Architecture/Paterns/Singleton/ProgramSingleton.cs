using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpOverView._4.Architecture.Singleton
{
    internal class ProgramSingleton
    {
        private void Start()
        {   
            MijnUniekeClass uniek = MijnUniekeClass.GetInstance;

            Console.WriteLine(uniek.Tijd());
            Thread.Sleep(1000);
            MijnUniekeClass uniek2 = MijnUniekeClass.GetInstance;
            Console.WriteLine(uniek2.Tijd());
            Console.ReadKey();
        }
    }
}
