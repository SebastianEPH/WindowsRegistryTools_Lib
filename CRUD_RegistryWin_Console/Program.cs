using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program {
    static void Main(string[] args) {

        //RegistryWin hola = new RegistryWin("path");

        String path = @"dsaasdsdadassdaHKEY_CURRENT_USER\SOFTWARE\BugSplat";
        

        void verifica_ruta_valida() {
            int ixt = path.IndexOf(@"HKEY_");  // obtiene el index
            path = path.Substring(ixt,path.Length-ixt);
            Console.WriteLine(path);
        }


        verifica_ruta_valida();
        Console.ReadKey();
    }
}

