using Microsoft.Win32;
using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistryTools.Libs {

    /// <summary>
    /// WindowsRegistryTools 2.0
    /// </summary>
    /// <remarks>
    /// <para>esto da formato a un remark.</para>
    /// </remarks>     
    /// <returns>
    /// Ésto es retorno
    /// </returns>
    /// <example>
    /// <code>
    /// int c = Math.Add(4, 5);
    /// if (c > 10)
    /// {
    ///     Console.WriteLine(c);
    /// }
    /// </code>
    /// </example>
    /// <param name="a">paremtros info .</param>
    /// <param name="b">A double precision number.</param>
    /// <exception cref="System.DivideByZeroException">Marcará error si tu no ingresas o ingrasas tal cosa</exception>
    class Regedit {
        private string message = "";

        /// <summary>
        /// Creará una llave de Registro tipo String
        /// </summary>
        public string createKeyValue_String(string key_ruta, string key_name, string key_values) {
            /// key_ruta     = Ruta de Regedit de Windows
            /// key_name     = Es el nombre que tendrá llave
            /// key_values   = Son los valores que almacenará la llave - String
            return message = createOrWriteRegistry_conteinerAndValue(key_ruta, key_name,"",key_values,1);
        }

        /// <summary>
        /// Creará una llave de Registro tipo Binario
        /// </summary>
        public void createKeyValue_Binarie() {

        }

        /// <summary>
        /// Creará una llave de Registro tipo DWORD (32 Bits)
        /// </summary>
        public void createKeyValue_DWORD() { 

        }

        /// <summary>
        /// Creará una llave de Registro tipo QWORD (64 Bits)
        /// </summary>
        public void createKeyValue_QWORD() {        

        }

        /// <summary>
        /// Creará una llave de Registro tipo MultiString
        /// Permite guardar una llave con saltos de linea
        /// </summary>
        public void createKeyValue_MultiString() {

        }

        /// <summary>
        /// Creará una llave de Registro tipo ExpandableString
        /// Permite guardar llave con una gran cantidad de caracteres.
        /// </summary>
        public void createKeyValue_ExpandableString() {        //Función crear llave de Registro en formato ExpandableString

        }

        /// <summary>
        /// Creará la Carpeta en la cuál se se podrán almacenar llaves 
        /// </summary>
        public string createConteiner(string key_ruta, string key_name, string key_conteiner) { 
            // key_ruta     = Ruta de Regedit de Windows
            // key_name     = Es el nombre que tendrá llave
            // key_values   = Son los valores que almacenará la llave - String
            return message = createOrWriteRegistry_conteinerAndValue(key_ruta, "",key_conteiner, "",0);
        }

        /// <summary>
        /// Eliminará la carpeta y todas las llaves de dicha carpeta contenedora.
        /// </summary>
        public string deleteConteinerAll(string key_ruta) {
            message = deleteRegistry_conteinerAndValue(false,key_ruta,"");
            return message;
        }

        /// <summary>
        /// Eliminará una llave del registro de Windows
        /// </summary>
        public string deleteKeyValue(string key_ruta,string key_name) {     //Función Elimina, solo la Llave eleccionad dentro del contenedor
            message = deleteRegistry_conteinerAndValue(true, key_ruta,key_name);
            return message;
        }

        private string readRegistry_valueString(string key_ruta /*Ruta completa del key*/, string key_name /*Nombre del Key*/){

            try {

                if (key_ruta == "" ) {
                    //Verifica si La Ruta ingresada no esté vacío
                    return message = "La ruta ingresada está vacía";
                }
                if (key_name == "") {
                    //Verifica si el nombre del Key no esté vacío
                    return message = "El nombre ingresado está vacío";
                }

                message = (string)Registry.GetValue(key_ruta, key_name, "¡No se encontró el Key!");

                // Retorna el valor de la llave
                // ó
                // Retorna el mensaje por defecto, si no existe la llave
            } catch (Exception e) {
                //Mensaje de error +  su Codigo de error
                message = "Hubo un error al leer la llave: " + e;
            }
  
            return message; 
        }
        private string createOrWriteRegistry_conteinerAndValue(string key_ruta /*Ruta completa del key*/, string key_name /*Nombre del Key*/,string key_conteiner/*Nombre del contenedor*/,string key_values/*valores de la llave*/, byte key_value_type) {


            //Si el nombre de la llave *Key_name* está vacía, entonces 
            //no se creará la llave, solo las carpetas contendoras
            if (key_ruta == "") {
                return message = "La ruta ingresada está vacía";
            }
            if (key_name == "") {
                // Por si El nombre de la llave *key_name* está vacía , pero los valores no.  
                // Para evitar posibles errores está ésta condicional, la cual
                // convertirá el *key_value* a vacío
                key_values = "";
            }


            //Crea o Escribe una llave del registro
            try {

                switch (key_value_type) {

                    /*          0   =       °Se crea un conteiner no una llave°
                     *          1   =       String Value
                     *          2   =       Binarie Value
                     *          3   =       DWORD (32bits) Value
                     *          4   =       QWORD (64bits) Value
                     *          5   =       Multi-String Value
                     *          6   =       Expandable String                                                           */
                    case 0:
                        //Solo se crea el conteiner, y no una llave
                        Registry.SetValue(key_ruta+@"\"+key_conteiner, key_name, key_values);  
                    break;

                    case 1:
                        //String Value
                        Registry.SetValue(key_ruta, key_name, key_values,RegistryValueKind.String);   // Se crea la llave en el registro
                    break;

                    case 2:
                        Registry.SetValue(key_ruta, key_name, key_values,RegistryValueKind.Binary);   // Se crea la llave en el registro
                    break;

                    case 3:
                        Registry.SetValue(key_ruta, key_name, key_values, RegistryValueKind.DWord);   // Se crea la llave en el registro
                    break;

                    case 4:
                        Registry.SetValue(key_ruta, key_name, key_values, RegistryValueKind.QWord);   // Se crea la llave en el registro
                    break;

                    case 5:
                        Registry.SetValue(key_ruta, key_name, key_values, RegistryValueKind.MultiString);   // Se crea la llave en el registro
                    break;

                    case 6:
                        Registry.SetValue(key_ruta, key_name, key_values, RegistryValueKind.ExpandString);   // Se crea la llave en el registro
                    break;

                    default:
                    message = "Especifique el tipo de valor del key";
                    break;
                }

                //Condición para fines de personalización del mensaje
                if (key_name == "") {
                    message = "Se creo el contenedor";
                } else {
                    message = "La nueva llave se guardó con exito";
                }

            } catch (Exception e) {
                message = "Hubo un error al guardar la llave " + e;
            }

            //Retorna el mensaje
            return message;
        }
        private string deleteRegistry_conteinerAndValue(bool value/*Verifica si se usara valores*/, string key_ruta /*Ruta completa del key*/, string key_name /*Nombre del Key*/) {
                    
            //Se verificará que la ruta del registro no esté vacía
            if (key_ruta == "") {
                return message = "Usted no ingresó la ruta ";
            }


            string key_conteiner = getConteinerRegistry(key_ruta);
            string key_ruta_sin_conteiner = getKeyRutaSingetConteinerRegistry(key_ruta);
            string key_ruta_sin_Type = getKeyRutaSingetTypeRegistry(key_ruta);

           /* Se eliminarán los siguientes textos de °key_name°
            * que se obtendrán de la función °getTypeRegistry°: 
            *         "HKEY_CLASSES_ROOT\"  "HKEY_CURRENT_USER\"    "HKEY_USERS\"
            *         "HKEY_LOCAL_MACHINE\" "HKEY_CURRENT_CONFIG\"
            * Dando como resultado solo la sub ruta.
            * 
            * Ejemplo:
            * [Antes]    key_ruta = @"HKEY_CURRENT_USER\Contenedor1\Contenedor2\Contenedor3"
            * [Despues]  key_ruta = @"Contenedor1\Contenedor2\Contenedor3"
            */
            key_ruta = getTypeRegistry(key_ruta);   //Ruta Modificada
            
            //Verifica si se borrará la llave o un contenedor
            if (value) {        //Se borrará la llave
                        //Se verifica que la llave no esté vacía
                        if (key_name == "") {
                        return message = "Usted no ingreso el nombre de la llave que desea eliminar ";
                        }

                    try {
                        RegistryKey k;
                    
                        switch (key_ruta) {
                            case "HKEY_CLASSES_ROOT":
                                k = Registry.ClassesRoot.OpenSubKey(key_ruta_sin_Type, true);
                                k.DeleteValue(key_name);
                                k.Close();
                                break;
                            case "HKEY_CURRENT_USER":
                                k = Registry.CurrentUser.OpenSubKey(key_ruta_sin_Type, true);
                                k.DeleteValue(key_name);
                                k.Close();
                                break;
                            case "HKEY_LOCAL_MACHINE":
                                k = Registry.LocalMachine.OpenSubKey(key_ruta_sin_Type, true);
                                k.DeleteValue(key_name);
                                k.Close();
                                break;
                            case "HKEY_USERS":
                                k = Registry.Users.OpenSubKey(key_ruta_sin_Type, true);
                                k.DeleteValue(key_name);
                                k.Close();
                                break;
                            case "HKEY_CURRENT_CONFIG":
                                k = Registry.CurrentConfig.OpenSubKey(key_ruta_sin_Type, true);
                                k.DeleteValue(key_name);
                                k.Close();
                                break;

                            default:
                                message = "Hubo un problema con la ruta ingresada";
                                break;
                        }


                    message = "Se Eliminó la Llave Correctamente";
                    } catch (Exception ex) {
                        message = "Hubo un error al eliminar el Key: " + ex;
                    }
            }
            else{               //Se borrara solo el contenedor
                key_name = "";

                
                try {
                    RegistryKey k;

                    switch (key_ruta) {
                        case "HKEY_CLASSES_ROOT":
                            k = Registry.ClassesRoot.OpenSubKey(key_ruta_sin_conteiner, true);
                            k.DeleteSubKeyTree(key_conteiner);
                            k.Close();
                            break;
                        case "HKEY_CURRENT_USER":
                            k = Registry.CurrentUser.OpenSubKey(key_ruta_sin_conteiner, true);
                            k.DeleteSubKeyTree(key_conteiner);
                            k.Close();
                            break;
                        case "HKEY_LOCAL_MACHINE":
                            k = Registry.LocalMachine.OpenSubKey(key_ruta_sin_conteiner, true);
                            k.DeleteSubKeyTree(key_conteiner);
                            k.Close();
                            break;
                        case "HKEY_USERS":
                            k = Registry.Users.OpenSubKey(key_ruta_sin_conteiner, true);
                            k.DeleteSubKeyTree(key_conteiner);
                            k.Close();
                            break;
                        case "HKEY_CURRENT_CONFIG":
                            k = Registry.CurrentConfig.OpenSubKey(key_ruta_sin_conteiner, true);
                            k.DeleteSubKeyTree(key_conteiner);
                            k.Close();
                            break;
                        default:
                            message = "Error en If (value)= false, el key_ruta no es correcta";
                            break;
                    }

                    message = "Se Eliminó la carpeta contenedor Correctamente";
                } catch (Exception ex) {
                    message = "Hubo un error al eliminar el contenedor " + ex;
                }
            }
            return message;
        }



        //Éstas son funciones, propias de la librería, no modificar..
        private string getTypeRegistry(string key_ruta){
            /* 
             * Ésta función recorrerá toda la variable °key_ruta°
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

            if (key_ruta == "") {
                //Verifica si La Ruta ingresada no esté vacío
                return message = "La ruta ingresada está vacía";
            }
            try {
                // Desde ésta palabra clave se empieza a obtener el texto
                string palabraInicio = "";
                // Desde ésta palabra clave se termina de obtener el texto
                string palabraFin = @"\";

                //Obtiene el número de posición en la cual se encuentra la °palabra_inicio°
                int inicio  = key_ruta.IndexOf(palabraInicio) + palabraInicio.Length + 1;

                if (inicio > palabraInicio.Length) {
                    int fin = 0;
                    string final = key_ruta.Substring(inicio, key_ruta.Length - inicio);

                    fin = final.IndexOf(palabraFin);

                    message =  key_ruta.Substring(inicio-1, fin+1);
                }
            } catch (Exception) {
                message = "Hubo un problema con la variable key_ruta";
            }
            return message;
        }   
        private string getKeyRutaSingetTypeRegistry(string key_ruta){
            /* Ésta función leerá la variable *key_ruta* 
             * buscando y eliminando los siguientes textos
             * que se obtendrán de la función °getTypeRegistry°: 
             *         "HKEY_CLASSES_ROOT\"  
             *         "HKEY_CURRENT_USER\"   
             *         "HKEY_USERS\"
             *         "HKEY_LOCAL_MACHINE\" 
             *         "HKEY_CURRENT_CONFIG\"
             * Dando como resultado solo la sub ruta.
             * 
             * =Ejemplo:
             * [Antes]    key_ruta = @"HKEY_CURRENT_USER\Contenedor1\Contenedor2\Contenedor3"
             * [Despues]  key_ruta = @"Contenedor1\Contenedor2\Contenedor3"
             * 
             * =Variables
             *            - String: palabra_inicial     // Desde esta palabra Clave se empieza a obtener el texto
             *            - String: palabra_fin         // Desde esta palabra Clave se termina de obtener el texto
             */

            if (key_ruta == "") {
                //Verifica si La Ruta ingresada no esté vacío
                return message = "La ruta ingresada está vacía";        //Mandar Código de cuadro de texto vacío
            }




            try {
                // Desde ésta palabra clave se empieza a obtener el texto
                string palabraInicio = getTypeRegistry(key_ruta);
                message =  key_ruta.Substring(palabraInicio.Length + 1);

            } catch (Exception) {
                message = "error en la función getKeyRutaSingetTypeRegistry";   
            }

            return message;

        }
        private string getConteinerRegistry(string key_ruta) {
            
            /* Ésta función busca retornar el "CONTENEDOR" de la variable °key_ruta°
             * 
             * =Ejemplo:
             * [Antes]    key_ruta = @"HKEY_CURRENT_USER\Contenedor1\Contenedor2\Contenedor3"
             * [Despues]  key_ruta =  "Contenedor3"
             * 
             */
            if (key_ruta == "") {
                //Verifica si La Ruta ingresada no esté vacío
                return message = "La ruta ingresada está vacía";
            }

            try {
                /* Obtiene el último número de posición donde encuentre @"\"                    */
                key_ruta = getKeyRutaSingetTypeRegistry(key_ruta);

                /* Utiliza la variable para obtener el ultimo contendor 
                 * =Ejemplo:
                 * [Antes]    key_ruta = @"Contenedor1\Contenedor2\Contenedor3" 
                 * [Despues]  key_ruta =  "Contenedor3"                                                     */
                int palabraClave = key_ruta.LastIndexOf(@"\");

                message = key_ruta.Substring(palabraClave+1);
            } catch (Exception) {
                message = "Error al obtener el contendor";
            }

            return message;
        }
        private string getKeyRutaSingetConteinerRegistry(string key_ruta) {
            /* Ésta función busca eliminar el "TIPO DE REGISTRO" y el "CONTENEDOR" 
             * de la variable °key_ruta°
             * 
             * =Ejemplo:
             * [Antes]    key_ruta = @"HKEY_CURRENT_USER\Contenedor1\Contenedor2\Contenedor3"
             * [Despues]  key_ruta = @"Contenedor1\Contenedor2"
             * 
             */
            key_ruta = getKeyRutaSingetTypeRegistry(key_ruta);
            string key_conteiner = getConteinerRegistry(key_ruta);

            // Desde ésta palabra clave se empieza a obtener el texto
            string palabraInicio = "";
            // Desde ésta palabra clave se termina de obtener el texto
            string palabraFin = key_conteiner;                      //Solucionar bug, de cuando en la ruta hay dos carpetas con el mismo nombre

            //Obtiene el número de posición en la cual se encuentra la °palabra_inicio°
            int inicio = key_ruta.IndexOf(palabraInicio) + palabraInicio.Length + 1;


            if (inicio > palabraInicio.Length) {
                int fin = 0;
                string final = key_ruta.Substring(inicio, key_ruta.Length - inicio);

                fin = final.IndexOf(palabraFin);

                message =  key_ruta.Substring(0,fin);
            }


            return message;
        }
    
    }

}
