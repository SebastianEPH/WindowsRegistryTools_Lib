using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistryTools.Libs {
    class Regedito {
        string message = "";












        /// Funcionalidades pertenecientes solo a ésta librería, no modificar
        public string getPathFiles(string path) {
            //Obtenemos el dato
            path = routePath(path);

            //Verifica algún codigo de Error
            if (path == "E#R001" || path == "E#R002") {
                return path; //Devuelve el mensaje de error obtenido
            }

            int nini;
            int nfin = path.Length;

            int ver1 = path.IndexOf(getTypeRegistry(path)); //Ingles UK
            if (ver1 != -1) {
                // Significa que si se encontró ésta palabra
                nini = getTypeRegistry(path).Length;
                nfin = nfin - nini;
                return path = path.Substring(nini, nfin);
            }



                return "";
        }
        public string getTypeRegistry(string path) {
            /* 
             * Ésta función recorrerá toda la variable °path°
             * y retornará solo uno de los siguientes textos:
             *                                        =>        HKEY_CLASSES_ROOT
             *                                        =>        HKEY_CURRENT_USER
             *                                        =>        HKEY_LOCAL_MACHINE
             *                                        =>        HKEY_USERS
             *                                        =>        HKEY_CURRENT_CONFIG                                            
             * VARIABLES:
             *            - String: palabra_inicial     // Desde esta palabra Clave se empieza a obtener el texto
             *            - String: palabra_fin         // Desde esta palabra Clave se termina de obtener el texto
             */
            

            // Verifica si el camino de ruta lleva Computer\ o computadora
            // bool containsSearchResult = factMessage.Contains("Extension");
            // Console.WriteLine($"Starts with \"extension\"? {containsSearchResult}");

            // verifica si camino lleva computer , pero esta devuelve un valor contrario que el de arriba
            //bool ignoreCaseSearchResult = factMessage.StartsWith("extension", System.StringComparison.CurrentCultureIgnoreCase);
            //Console.WriteLine($"Starts with \"extension\"? {ignoreCaseSearchResult} (ignoring case)");
            

            // Obtiene la Ruta Limpia
             path =  routePath(path);
            // Verifica si la ruta está vacía
            if (path == "E#R001") {
                return path;    //Se termina el proceso y Retorna mensaje de Error
            }

            // Proceso de Obtención de  del tipo de registro

            int nini;
            int nfin = path.Length;

            int root = path.IndexOf(@"HKEY_CLASSES_ROOT"); //Ingles UK
            if (root != -1) {
                // Significa que si se encontró ésta palabra
                nini = @"HKEY_CLASSES_ROOT".Length;
                //nfin = nfin - nini;
                return path = path.Substring(0, nini);
            }
            int user = path.IndexOf(@"HKEY_CURRENT_USER"); //Ingles UK
            if (user != -1) {
                // Significa que si se encontró ésta palabra
                nini = @"HKEY_CURRENT_USER".Length;
                //nfin = nfin - nini;
                return path = path.Substring(0,nini);
            }
            int machine = path.IndexOf(@"HKEY_LOCAL_MACHINE"); //Ingles UK
            if (machine != -1) {
                // Significa que si se encontró ésta palabra
                nini = @"HKEY_LOCAL_MACHINE".Length;
                //nfin = nfin - nini;
                return path = path.Substring(0, nini);
            }
            int users = path.IndexOf(@"HKEY_USERS"); //Ingles UK
            if (users != -1) {
                // Significa que si se encontró ésta palabra
                nini = @"HKEY_USERS".Length;
                //nfin = nfin - nini;
                return path = path.Substring(0, nini);
            }
            int config = path.IndexOf(@"HKEY_CURRENT_CONFIG"); //Ingles UK
            if (config != -1) {
                // Significa que si se encontró ésta palabra
                nini = @"HKEY_CURRENT_CONFIG".Length;
                // nfin = nfin - nini;
                return path = path.Substring(0, nini);
            }

            return "E#R002 ";   // Manda mensaje de error de ruta no valida
           
        }

        private string routePath (string path) {
            // Éste es la primera funcionalidad, Verifica si la ruta ingresada lleva 
            // las palabras: "Computer\" ,"Computadora\", "Equipo\"

            if (path == "") {
                //Verifica si La Ruta ingresada no esté vacío
                return message = "E#R001";  // Error la ruta ingresada está vacía
            }


            int nini ;
            int nfin = path.Length;
            
            int ver1 = path.IndexOf(@"Computer\"); //Ingles UK
            if (ver1 != -1) {
                // Significa que si se encontró ésta palabra
                nini = @"Computer\".Length;
                nfin = nfin - nini;
                path = path.Substring(nini, nfin);
            }
            int ver2 = path.IndexOf(@"Computadora\");  // Other
            if (ver2 != -1) {
                // Significa que si se encontró ésta palabra
                nini = @"Computadora\".Length;
                nfin = nfin - nini;
                path = path.Substring(nini, nfin);
            }
            int ver3 = path.IndexOf(@"Equipo\");   //Español
            if (ver3 != -1) {
                // Significa que si se encontró ésta palabra
                nini = @"Equipo\".Length;
                nfin = nfin - nini;
                path = path.Substring(nini, nfin);
            }

            if (ver1 == -1 && ver2 == -1 && ver3 == -1) {
                return path;
            }


            return path;

        }

    }
}
