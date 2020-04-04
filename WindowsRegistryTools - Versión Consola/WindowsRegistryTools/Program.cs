using Microsoft.Win32;
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
            Console.WriteLine("     | 15 |    =   Eliminar valor");
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
                    case 1: CreateKey(); break;
                    case 2: CreateKeyValue_String(); break;
                    case 3: CreateKeyValue_Binary(); break;
                    case 4: CreateKeyValue_DWORD(); break;
                    case 5: CreateKeyValue_QWORD(); break;
                    case 6: CreateKeyValue_MultiString(); break;
                    case 7: CreateKeyValue_ExpandString(); break;
                    case 8: GetKeyValue_String(); break;
                    case 9: GetKeyValue_Binary(); break;
                    case 10: GetKeyValue_DWORD(); break;
                    case 11: GetKeyValue_QWORD(); break;
                    case 12: GetKeyValue_MultiString(); break;
                    case 13: GetKeyValue_ExpandString(); break;
                    case 14: DeleteKey(); break;
                    case 15: DeleteValue(); break;
                    case 99: Exit(); break;  // Sale 
                    default: Menu(); break;  // Vuelve al menú
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

        }                  //Finish
        public void CreateKeyValue_String() {
            Console.Clear();
            Console.SetCursorPosition(45, 2);
            // Inicio
            Console.WriteLine("Crear valores de llave- Tipo String");
            Console.WriteLine("");
            String path = SetPath();
            String valueName = SetValueName();
            Console.Clear();
            Console.WriteLine("Ingrese el Dato del Valor: ");
            String valueData = Console.ReadLine();

            Console.Clear();
            Console.WriteLine(registro.CreateKeyValue_String(path, valueName, valueData));
            Console.ReadKey();
        }      //Finish
        public void CreateKeyValue_Binary() {
            Console.Clear();
            Console.SetCursorPosition(45, 2);
            // Inicio
            Console.WriteLine("Crear valores de llave - Tipo Binary");
            Console.WriteLine("");
            String path = SetPath();
            String valueName = SetValueName();
            byte [] valueData = Parsebinary();
            Console.WriteLine(registro.CreateKeyValue_Binary(path,valueName,valueData));
            Console.ReadKey();
        }      //Finish
        public void CreateKeyValue_DWORD() {
            Console.Clear();
            Console.SetCursorPosition(45, 2);
            // Inicio
            Console.WriteLine("Crear valores de llave - Tipo DWORD");
            Console.WriteLine("");
            String path = SetPath();
            String valueName = SetValueName();
            Int32 valueData = ParseInt32();

            Console.WriteLine(registro.CreateKeyValue_DWORD(path, valueName, valueData));
            Console.ReadKey();

        }       //Finish
        public void CreateKeyValue_QWORD() {
            Console.Clear();
            Console.SetCursorPosition(45, 2);
            // Inicio
            Console.WriteLine("Crear valores de llave - Tipo QWORD");
            Console.WriteLine("");
            String path = SetPath();
            String valueName = SetValueName();
            Int64 valueData = ParseInt64();

            Console.WriteLine(registro.CreateKeyValue_QWORD(path, valueName, valueData));
            Console.ReadKey();
        }       //Finish
        public void CreateKeyValue_MultiString() {
            Console.Clear();
            Console.SetCursorPosition(45, 2);
            // Inicio
            Console.WriteLine("Crear valores de llave - Tipo multiString");
            Console.WriteLine("");
            String path = SetPath();
            String valueName = SetValueName();
            String [] valueData = ParseMultiString();

            Console.WriteLine(registro.CreateKeyValue_MultiString(path, valueName, valueData));
            Console.ReadKey();
        } //Finish
        public void CreateKeyValue_ExpandString() {
            Console.SetCursorPosition(45, 2);
            // Inicio
            Console.WriteLine("Crear Nueva llave");
            Console.WriteLine("");


        }//Finish
        public void GetKeyValue_String() {
            Console.Clear();
            Console.SetCursorPosition(45, 2);
            // Inicio
            Console.WriteLine("Obtener datos de un valor - Tipo String");
            Console.WriteLine("");
            String path = SetPath();
            String valueName = SetValueName();
            

            Console.Clear();

            Console.SetCursorPosition(45, 2);
            Console.WriteLine("Obtención de datos - String");
            Console.WriteLine("");
            Console.WriteLine(registro.getDataValue_String(path,valueName));
            Console.ReadKey();
        }         //Finish
        public void GetKeyValue_Binary() {          // finish
            Console.Clear();
            Console.SetCursorPosition(45, 2);
            // Inicio
            Console.WriteLine("Obtener datos de un valor - Tipo Binary");
            Console.WriteLine("");
            String path = SetPath();
            String valueName = SetValueName();

            Console.Clear();
            Console.SetCursorPosition(45, 2);
            Console.WriteLine("Obtención de datos - Binary");
            Console.WriteLine("");

            //byte[] writeA = registro.getDataValue_bin(path, valueName);
            //Console.WriteLine("");
            //for (int i = 0; i < writeA.Length; i++) {
            //    Console.WriteLine(writeA [i]);
            //}
            //Console.ReadKey();

            byte [] writeA = registro.getDataValue_Binary(path, valueName);

            repetir();

            void repetir() {

                Console.Clear();
                Console.WriteLine("¿Mostrar los datos en formato ? ");
                Console.WriteLine("");
                Console.WriteLine("  1 = Mostrar tipo Entero ");
                Console.WriteLine("");
                Console.WriteLine("  2 = Mostrar tipo Hex");
                Console.WriteLine("");
                Console.Write("Ingrese una opción: ");
                string des = Console.ReadLine();
                switch (des) {
                    case "1": caso1(); break;
                    case "2": caso2(); break;
                    default: repetir(); break;
                }
            }
            void caso1() {

                Console.WriteLine("");
                for (int i = 0; i < writeA.Length; i++) {
                    Console.WriteLine(writeA [i]);
                }
                Console.ReadKey();
            }
            void caso2() {
                string hex = BitConverter.ToString(writeA).Replace("-", " ");//  string.Empty);
                Console.WriteLine("");
                //for (int i = 0; i < writeA.Length; i++) {
                Console.WriteLine(hex);
                //}
                Console.ReadKey();
            }


        }
        public void GetKeyValue_DWORD() {
            Console.Clear();
            Console.SetCursorPosition(45, 2);
            // Inicio
            Console.WriteLine("Obtener datos de un valor - Tipo DWORD");
            Console.WriteLine("");
            String path = SetPath();
            String valueName = SetValueName();


            Console.Clear();

            Console.SetCursorPosition(45, 2);
            Console.WriteLine("Obtención de datos - DWORD");
            Console.WriteLine("");
            Console.WriteLine(registro.getDataValue_DWORD(path, valueName));
            Console.ReadKey();
        }          //Finsh
        public void GetKeyValue_QWORD() {
            Console.Clear();
            Console.SetCursorPosition(45, 2);
            // Inicio
            Console.WriteLine("Obtener datos de un valor - Tipo QWORD");
            Console.WriteLine("");
            String path = SetPath();
            String valueName = SetValueName();


            Console.Clear();

            Console.SetCursorPosition(45, 2);
            Console.WriteLine("Obtención de datos - QWORD");
            Console.WriteLine("");
            Console.WriteLine(registro.getDataValue_QWORD(path, valueName));
            Console.ReadKey();
        }          //Finish
        public void GetKeyValue_MultiString() {
            Console.Clear();
            Console.SetCursorPosition(45, 2);
            // Inicio
            Console.WriteLine("Obtener datos de un valor - Tipo MultiString");
            Console.WriteLine("");
            String path = SetPath();
            String valueName = SetValueName();

            Console.Clear();
            Console.SetCursorPosition(45, 2);
            Console.WriteLine("Obtención de datos - MultiString");
            Console.WriteLine("");
           
           

            String [] writeA = registro.getDataValue_MultiString(path, valueName);
                Console.WriteLine("");
            for (int i = 0; i < writeA.Length; i++) {
                Console.WriteLine(writeA[i]);
            }
            Console.ReadKey();
        }    //Finish
        public void GetKeyValue_ExpandString() {
            Console.Clear();
            Console.SetCursorPosition(45, 2);
            // Inicio
            Console.WriteLine("Obtener datos de un valor - ExpandString");
            Console.WriteLine("");
            String path = SetPath();
            String valueName = SetValueName();


            Console.Clear();

            Console.SetCursorPosition(45, 2);
            Console.WriteLine("Obtención de datos - Expand");
            Console.WriteLine("");
            Console.Clear();
            Console.WriteLine(registro.getDataValue_ExpandString(path, valueName));
            Console.ReadKey();
        }     
        public void DeleteKey() {
            Console.SetCursorPosition(45, 2);
            // Inicio
            Console.WriteLine("Eliminar una Llave y los valores que almacena");
            Console.WriteLine("");
            string path = SetPath();
            Console.WriteLine(registro.DeleteKey(path));

        }                  //Finish
        public void DeleteValue() {
            Console.SetCursorPosition(45, 2);
            // Inicio
            Console.WriteLine("Eliminar una Llave y los valores que almacena");
            Console.WriteLine("");
            string path = SetPath();
            string valueName = SetValueName();
            Console.WriteLine(registro.DeleteValue(path,valueName));

        }                //Finish
        public void Exit() {                         //Finish
            
        }





        //Funciones de funciones :'v 

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
            if (valueName.Length <= 0) {
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
        private Int64 ParseInt64() {
            Console.Clear();
            Console.Write("Ingrese el Dato del Valor: ");
            String valueData = Console.ReadLine();

            // Verifica si es un valor Int32
            bool verifica = Int64.TryParse(valueData, out Int64 salida);
            if (verifica) {
                Console.Clear();
                return salida;
            } else {
                //Si cadena de texto no es Int32, entonces volver a llamar a ésta función
                ParseInt64();
                return -0;
            }
        }
        private String [] ParseMultiString() {
            Console.Clear();

            //Hacer un menú para esocjer cual es el tipo de separador deseado
            //Console.WriteLine("Escoja un signo o palabra para separar los los saltos de linea ");
            //string separar = Console.ReadLine();
            Console.Write("Ingrese los datos separandolos con una , : ");

            String valueData = Console.ReadLine();  // Obtiene datos del consola
            try {

                string [] salida;
                return salida = valueData.Split(',');   // Separa las palabras por , obtenidas del la consola

            } catch {
                //Si hay un error vuelve a la función 
                ParseMultiString();
                return new String [] { "" };
            }
        }
        private byte [] Parsebinary() {
            Console.Clear();

            //Hacer un menú para esocjer cual es el tipo de separador deseado
            //Console.WriteLine("Escoja un signo o palabra para separar los los saltos de linea ");
            //string separar = Console.ReadLine();
            Console.Write("Ingrese los datos separandolos con una , : ");

            // Obtiene datos de consola - String
            String data = Console.ReadLine();  // Obtiene datos del consola

            //Palabras especiales
            char [] delimiterChars = { ' ', ',', '.', ':' };

            // Separa los datos mediante , "Comas"
            string [] valueDataString = data.Split(delimiterChars);

            // tiene el tope maximo, según cuantos saltos de linea tenga
            byte [] valueData = new byte [valueDataString.Length];

            // Convierte String a byte 
            // Pasa por un parse
            try {
                Console.WriteLine("Se obtuvieron éstos datos: ");
                Console.WriteLine("");
                for (int i = 0; i < valueDataString.Length; i++) {
                    valueData [i] = byte.Parse(valueDataString [i]);
                    Console.WriteLine("Valor: " + i + ": " + valueData [i]);
                }
                return valueData;

            } catch  {
                Console.WriteLine("Hubo un Error al Colocar los Datos , recuerde separarlos por , : . o espacios");
                Console.ReadKey();
                //Vuelve a llamar a la función
                Parsebinary();
            }

            return new byte [] {0};
        }

    }
}
