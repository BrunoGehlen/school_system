using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school_system {
    class Program {
        static void Main(string[] args) {
            Human sissy = new Human("Sissy", "Wagner");
            sissy.IntroduceMyself();


            Console.ReadKey();
            }
        }
    }
}