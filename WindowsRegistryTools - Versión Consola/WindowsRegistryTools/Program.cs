using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace WindowsRegistryTools {
    class Program {

        // Instanciamos la librería
        RegistryTools registro = new RegistryTools();


        static void Main(string [] args) {
            
            // Proceso del menú y opciones
            Program l = new Program();
            l.Menu();
        }
        
       // public RegistryTools dfgd = new Regedit();
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
            String obtiene;
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
            Console.Clear();
            Console.SetCursorPosition(45, 2);
            // Inicio
            Console.WriteLine("Crear Nueva llave");
            Console.WriteLine("");
            String path = SetPath();
            String keyName = SetKeyName();

            Console.Clear();
            Console.WriteLine(registro.CreateKey(path, keyName));
            Console.ReadKey();

        }
        public void CreateKeyValue_String() {
            Console.Clear();
            Console.SetCursorPosition(45, 2);
            // Inicio
            Console.WriteLine("Crear valores de llave- Tipo String");
            Console.WriteLine("");
            String path = SetPath();
            String valueName = SetValueName();
            Console.WriteLine("Ingrese el Dato del Valor: ");
            String valueData = Console.ReadLine();

            Console.Clear();
            Console.WriteLine(registro.CreateKeyValue_String(path,valueName,valueData));
            Console.ReadKey();
        }
        public void CreateKeyValue_Binary() {       // En proceso.. 
        }   //En proceso
        public void CreateKeyValue_DWORD() {
            Console.Clear();
            Console.SetCursorPosition(45, 2);
            // Inicio
            Console.WriteLine("Crear valores de llave - Tipo DWORD");
            Console.WriteLine("");
            String path = SetPath();
            String valueName = SetValueName();
            Int32 valueData = ParseInt32();

            Console.WriteLine(registro.CreateKeyValue_DWORD(path,valueName,valueData));
            Console.ReadKey();

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





        //Funciones de funciones

        private String SetPath() {
            Console.Clear();
            string path;
            //Función para obtener la ruta del key
            Console.Write("Inserte la ruta: ");
            path = Console.ReadLine();

            if (path.Length <= 10) {
                SetPath();
                return "";
            } else {
                return path;
            }
        }
        private String SetKeyName() {
            Console.Clear();
            string keyName;
            //Función para obtener la ruta del key
            Console.Write("Ingrese el nombre de la llave: ");
            keyName = Console.ReadLine();
            if (keyName.Length <= 1) {
                SetKeyName();
                return "";
            } else {
                return keyName;
            }
        }
        private String SetValueName() {
            Console.Clear();
            string valueName;
            //Función para obtener la ruta del key
            Console.Write("Ingrese el nombre del Valor: ");
            valueName = Console.ReadLine();
            if (valueName.Length <= 1) {
                SetValueName();
                return "";
            } else {
                return valueName;
            }
        }
        private Int32 ParseInt32() {
            Console.Clear();
            Console.Write("Ingrese el Dato del Valor: ");
            String valueData = Console.ReadLine();

            // Verifica si es un valor Int32
            bool verifica = Int32.TryParse(valueData, out Int32 salida);
            if (verifica) {
                Console.Clear();
                return salida;
            } else {
                //Si cadena de texto no es Int32, entonces volver a llamar a ésta función
                ParseInt32();
                return -0;
            }
        }
    }
}
