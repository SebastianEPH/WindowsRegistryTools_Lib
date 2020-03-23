using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistryTools;

namespace WindowsRegistryTools {
    class Program {
        static void Main(string [] args) {

            // Se instancia la ésta clase 
            Program l = new Program();
            // Instanciamos la librería
            Regedit r = new Regedit();


            // Proceso del menú y opciones

            //Llama al menú 
            l.Menu();
        }
        public void Menu() {
            // Menú Principal para probar funcionalidades
            Console.WriteLine("# Windows Registry Tools v3.1");
            Console.WriteLine("");
            Console.WriteLine(" Create Registry");
            Console.WriteLine("     (1)     = Crear nuevo Key");
            Console.WriteLine("     (2)     = Crear nuevo valor - String");
            Console.WriteLine("     (3)     = Crear nuevo valor - Binary");
            Console.WriteLine("     (4)     = Crear nuevo valor - DWORD");
            Console.WriteLine("     (5)     = Crear nuevo valor - QWORD");
            Console.WriteLine("     (6)     = Crear nuevo valor - MultiString");
            Console.WriteLine("     (7)     = Crear nuevo valor - ExpandString");
            Console.WriteLine("");
            Console.WriteLine("     (8)     = Obtener datos del valor - String");
            Console.WriteLine("     (9)     = Obtener datos del valor - Binary");
            Console.WriteLine("     (10)    = Obtener datos del valor - DWORD");
            Console.WriteLine("     (11)    = Obtener datos del valor - QWORD");
            Console.WriteLine("     (12)    = Obtener datos del valor - MultiString");
            Console.WriteLine("     (13)    = Obtener datos del valor - ExpandString");
            Console.WriteLine("");
            Console.WriteLine("     (14)    = Eliminar llave");
            Console.WriteLine("     (16)    = Eliminar valor");
            Console.WriteLine("");
            Console.WriteLine("     (99)    = Salir ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" Escribe una opción");





            Console.ReadKey();

        }
        public void CreateKey() {

        }
        public void CreateKeyValue_String() {

        }
        public void CreateKeyValue_Binary() {

        }
        public void CreateKeyValue_DWORD() {

        }
        public void CreateKeyValue_QWORD() {

        }
        public void CreateKeyValue_MultiString() {

        }
        public void CreateKeyValue_ExpandString() {

        }
        public void GetKeyValue_String() {

        }
        public void GetKeyValue_Binary() {

        }
        public void GetKeyValue_DWORD() {

        }
        public void GetKeyValue_QWORD() {

        }
        public void GetKeyValue_MultiString() {

        }
        public void GetKeyValue_ExpandString() {

        }
        public void DeleteKey() {

        }

        public void DeleteValue() {

        }

    }
}
