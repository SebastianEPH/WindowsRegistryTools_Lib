using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program {

    
    static void Main(string[] args) {

       RegistryWin hola = new RegistryWin(@"Computer\HKEYd_CURRENT_USER\AppEvents");

        Console.WriteLine(hola.check_path());
        hola.clear_path();
        Console.WriteLine(hola.PATH);





        Console.ReadKey();
    }
}

