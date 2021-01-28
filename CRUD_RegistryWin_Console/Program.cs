using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program {

    
    static void Main(string[] args) {

       RegistryWin hola = new RegistryWin(@"Computer\HKEY_CURRENT_USER\");


        Console.WriteLine("DATA: ");
        Console.WriteLine("PATH: "+ hola.PATH);
        Console.WriteLine("Type registry " + hola.TYPE_REGISTRY);
        //Console.WriteLine("Type registry num " + hola.TYPE);
        Console.WriteLine("Parametros :? " + hola.PARAMETER);
        Console.WriteLine("tiene parametros :? " + hola.HAS_PARAMETER);
        //Console.WriteLine(hola.PATH);
        hola.SetValue_String("asda&&&&&","45398034906");





        Console.ReadKey();
    }
}

