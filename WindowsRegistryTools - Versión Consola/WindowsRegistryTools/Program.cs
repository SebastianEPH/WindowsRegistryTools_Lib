using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RegistryTools;

namespace WindowsRegistryTools {
    class Program {
        static void Main(string [] args) {

            // Instanciamos la librería
            Regedit r = new Regedit();

            // Proceso del menú y opciones
            Program l = new Program();
            l.Menu();
           
        }
        public void Menu() {
            //Limpiar pantalla 
            Console.Clear();
            //Console.BackgroundColor(red);

            Console.SetCursorPosition(45, 2);

            // Menú Principal para probar funcionalidades
            Console.WriteLine("Windows Registry Tools v3.1");
            Console.WriteLine("");
            Console.WriteLine(" Create Registry");
            Console.WriteLine("");
            Console.WriteLine("     | 1 |     =   Crear nuevo Key");
            Console.WriteLine("     | 2 |     =   Crear nuevo valor - String");
            Console.WriteLine("     | 3 |     =   Crear nuevo valor - Binary");
            Console.WriteLine("     | 4 |     =   Crear nuevo valor - DWORD");
            Console.WriteLine("     | 5 |     =   Crear nuevo valor - QWORD");
            Console.WriteLine("     | 6 |     =   Crear nuevo valor - MultiString");
            Console.WriteLine("     | 7 |     =   Crear nuevo valor - ExpandString");
            Console.WriteLine("");
            Console.WriteLine("     | 8 |     =   Obtener datos del valor - String");
            Console.WriteLine("     | 9 |     =   Obtener datos del valor - Binary");
            Console.WriteLine("     | 10 |    =   Obtener datos del valor - DWORD");
            Console.WriteLine("     | 11 |    =   Obtener datos del valor - QWORD");
            Console.WriteLine("     | 12 |    =   Obtener datos del valor - MultiString");
            Console.WriteLine("     | 13 |    =   Obtener datos del valor - ExpandString");
            Console.WriteLine("");
            Console.WriteLine("     | 14 |    =   Eliminar llave");
            Console.WriteLine("     | 16 |    =   Eliminar valor");
            Console.WriteLine("");
            Console.WriteLine("     | 99 |    =   Salir ");
            Console.WriteLine("");
            Console.Write(" Escoje una opción: ");
          //  Console.WriteLine(" °°°°°°°°°°°°°°°°°°°");

            // Obtiene Opción
            string obtiene;
            bool verifica;

            //Obtiene texto
            obtiene = Console.ReadLine();

            //Verifica si el texto es un número entero
            verifica = Int16.TryParse(obtiene, out Int16 ingresado);
            
            if (verifica) {
                switch (ingresado) {
                    case 1:     CreateKey();                    break;
                    case 2:     CreateKeyValue_String();        break;
                    case 3:     CreateKeyValue_Binary();        break;
                    case 4:     CreateKeyValue_DWORD();         break;
                    case 5:     CreateKeyValue_QWORD();         break;
                    case 6:     CreateKeyValue_MultiString();   break;
                    case 7:     CreateKeyValue_ExpandString();  break;
                    case 8:     GetKeyValue_String();           break;
                    case 9:     GetKeyValue_Binary();           break;
                    case 10:    GetKeyValue_DWORD();            break;
                    case 12:    GetKeyValue_QWORD();            break;
                    case 13:    GetKeyValue_MultiString();      break;
                    case 14:    GetKeyValue_ExpandString();     break;
                    case 15:    DeleteKey();                    break;
                    case 16:    DeleteValue();                  break;
                    case 99:    Exit();                         break;  // Sale 
                    default:    Menu();                         break;  // Vuelve al menú
                }
            } else {
                Menu();
            }
           
        }
        public void CreateKey() {
            Console.SetCursorPosition(45, 2);
            // Inicio
            Console.WriteLine("Crear Nueva llave");
            Console.WriteLine("");
        }
        public void CreateKeyValue_String() {
            Console.SetCursorPosition(45, 2);
            // Inicio
            Console.WriteLine("Crear Nueva llave");
            Console.WriteLine("");
        }
        public void CreateKeyValue_Binary() {
            Console.SetCursorPosition(45, 2);
            // Inicio
            Console.WriteLine("Crear Nueva llave");
            Console.WriteLine("");
        }
        public void CreateKeyValue_DWORD() {
            Console.SetCursorPosition(45, 2);
            // Inicio
            Console.WriteLine("Crear Nueva llave");
            Console.WriteLine("");
        }
        public void CreateKeyValue_QWORD() {
            Console.SetCursorPosition(45, 2);
            // Inicio
            Console.WriteLine("Crear Nueva llave");
            Console.WriteLine("");
        }
        public void CreateKeyValue_MultiString() {
            Console.SetCursorPosition(45, 2);
            // Inicio
            Console.WriteLine("Crear Nueva llave");
            Console.WriteLine("");
        }
        public void CreateKeyValue_ExpandString() {
            Console.SetCursorPosition(45, 2);
            // Inicio
            Console.WriteLine("Crear Nueva llave");
            Console.WriteLine("");
        }
        public void GetKeyValue_String() {
            Console.SetCursorPosition(45, 2);
            // Inicio
            Console.WriteLine("Crear Nueva llave");
            Console.WriteLine("");
        }
        public void GetKeyValue_Binary() {
            Console.SetCursorPosition(45, 2);
            // Inicio
            Console.WriteLine("Crear Nueva llave");
            Console.WriteLine("");
        }
        public void GetKeyValue_DWORD() {
            Console.SetCursorPosition(45, 2);
            // Inicio
            Console.WriteLine("Crear Nueva llave");
            Console.WriteLine("");
        }
        public void GetKeyValue_QWORD() {
            Console.SetCursorPosition(45, 2);
            // Inicio
            Console.WriteLine("Crear Nueva llave");
            Console.WriteLine("");
        }
        public void GetKeyValue_MultiString() {
            Console.SetCursorPosition(45, 2);
            // Inicio
            Console.WriteLine("Crear Nueva llave");
            Console.WriteLine("");
        }
        public void GetKeyValue_ExpandString() {
            Console.SetCursorPosition(45, 2);
            // Inicio
            Console.WriteLine("Crear Nueva llave");
            Console.WriteLine("");
        }
        public void DeleteKey() {
            Console.SetCursorPosition(45, 2);
            // Inicio
            Console.WriteLine("Crear Nueva llave");
            Console.WriteLine("");
        }
        public void DeleteValue() {
            Console.SetCursorPosition(45, 2);
            // Inicio
            Console.WriteLine("Crear Nueva llave");
            Console.WriteLine("");
        }
        public void Exit() { 
        
        }

    }
}
