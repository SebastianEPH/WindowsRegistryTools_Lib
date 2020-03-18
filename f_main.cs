using Microsoft.Win32;
using RegistryTools.Libs;
using System;
using System.Windows.Forms;


namespace RegistryTools {
    public partial class f_main : Form
    {
        Regedit registro = new Regedit();
        Regedito registro3 = new Regedito();
        public f_main(){
            InitializeComponent();
        }
        private void btnCrearContenedor(object sender, EventArgs e) {
            // Ruta completa del registro
            //Ejemplo: @"HKEY_CURRENT_USER\Contenedor1"
            string ruta = crearConteiner_ruta.Text.ToString();
            // nombre del nuevo contenedor
            string nombre = crearConteiner_Contenedor.Text.ToString();
            // El mensaje de confirmación o de Falló se mostrará en la pantalla
            txt_info.Text = registro.createConteiner(ruta, nombre);
        }

        private void btncrearLlave(object sender, EventArgs e) {
            // Ruta completa del registro
            //Ejemplo: @"HKEY_CURRENT_USER\Contenedor1"
            string ruta = crearLlave_ruta.Text.ToString();

            // nombre del la llave
            string nombre = crearLlave_name.Text.ToString();
            //Valor tipos texto
            string valors = createLlave_value.Text.ToString();


            // String
            if (rb_String.Checked) {
                // El mensaje de confirmación o de Falló se mostrará en la pantalla
               
                txt_info.Text = registro.createKeyValue_String(ruta, nombre, valors);
            }
            //Binarie
            if (rb_binarie.Checked) {
                // El mensaje de confirmación o de Falló se mostrará en la pantalla
                txt_info.Text = registro.createKeyValue_Binarie(ruta, nombre, valors);
            }
            //DWORD
            if (rb_DWORD.Checked) {
                // El mensaje de confirmación o de Falló se mostrará en la pantalla
                //txt_info.Text = registro.CreateKeyValue_DWORD(ruta, nombre, valori);
            }
            //QWORD
            if (rb_QWORD.Checked) {
                // El mensaje de confirmación o de Falló se mostrará en la pantalla
                //txt_info.Text = registro.CreateKeyValue_QWORD(ruta, nombre, valori);
            }
            //MultiString
            if (rb_multiString.Checked) {
                // El mensaje de confirmación o de Falló se mostrará en la pantalla
               this.createLlave_value.Multiline = true;
                txt_info.Text = registro.createKeyValue_MultiString(ruta, nombre, valors);
            }
            //Expandable String
            if (rb_expString.Checked) {
                // El mensaje de confirmación o de Falló se mostrará en la pantalla
                //txt_info.Text = registro.createKeyValue_ExpandableString(ruta, nombre, valors);
            }
        }

        private void btnleerLlave(object sender, EventArgs e) {

            string ruta = btnleerLlave_ruta.Text.ToString();

            // nombre del la llave
            string nombre = btnleerLlave_name.Text.ToString();
            //Valor tipos texto
            string valor = createLlave_value.Text.ToString();

            txt_info.Text = btnleerLlave_valor.Text = registro.readKeyValue(ruta,nombre);
        }

        private void btndeleteLlave(object sender, EventArgs e) {

            string ruta = deleteLlave_ruta.Text.ToString();
            string nombre = deleteLlave_name.Text.ToString();
            txt_info.Text = registro.deleteKeyValue(ruta,nombre);
            
        }

        private void btndeleteAll_Click(object sender, EventArgs e) {
            string ruta = deleteAll_ruta.Text.ToString();
            txt_info.Text = registro.deleteConteinerAll(ruta);
        }

        private void button1_Click(object sender, EventArgs e) {

            //byte[] bytesValues = { 0,2,1,4};
            //    if (BitConverter.IsLittleEndian) 
            //        Array.Reverse(bytesValues);

            // int x = BitConverter.ToInt32(bytesValues, 0);
            // Console.WriteLine($"int: {x}");

            // Console.WriteLine("convertir atras byte ");
            // byte[] bts = BitConverter.GetBytes(x);
            // Console.WriteLine($"Byte Array: {BitConverter.ToString(bts)}\n\n\n\n");




            //    byte[] bytes = { 01, 2, 02, 30 };

            //    // If the system architecture is little-endian (that is, little end first),
            //    // reverse the byte array.
            //    if (BitConverter.IsLittleEndian)
            //        Array.Reverse(bytes);

            //    int i = BitConverter.ToInt32(bytes, 0);
            //    Console.WriteLine("NEW NEW int: {0}", i);


            string path = crearConteiner_ruta.Text;
            string nameValue = crearConteiner_Contenedor.Text;

            //path = registro3.RoutePath(path);

;
            ////byte[] bytesValues = { };

            //path = registro3.GetSubFiles(path);

            ////              Quieres separar por coma? Usa
            ////              string[] arValores = tuTextBox.Text.Split(",");
            ////              Con eso tienes los números en un arreglo de strings. Luego usa un for each y parsea cada ítem con TryParse

            //int value = Int32.Parse(txtValueData.Text);
            //Byte[] bytes = BitConverter.GetBytes(value);

            ////int intValue = BitConverter.ToInt32(bytes,0);

            //byte[] byteValues =  bytes ;

            ////////////////////RegistryKey k;

            ////////////////////Byte [] dataValue = {Byte.Parse(txtValueData.Text)};

            ////////////////////try {

            ////////////////////    k = Registry.CurrentUser.OpenSubKey(registro3.GetSubFiles(path), true);
            ////////////////////    k.SetValue(nameValue, dataValue, RegistryValueKind.Binary);
            ////////////////////    k.Close();
            ////////////////////    Console.WriteLine("Exito");
            ////////////////////} catch (Exception er) {
            ////////////////////    Console.WriteLine("falló" +er);

            ////////////////////}

















            ////Byte [] dataValue = { Byte.Parse(txtValueData.Text) };
            //int value = int.Parse(txtValueData.Text);
            //byte [] bytes = BitConverter.GetBytes(value);
            //Console.WriteLine(BitConverter.ToString(bytes));

            //if (BitConverter.IsLittleEndian)
            //    Array.Reverse(bytes);

            //Console.WriteLine(BitConverter.ToString(bytes));
            //// Call method to send byte stream across machine boundaries.

            //// Receive byte stream from beyond machine boundaries.
            //Console.WriteLine(BitConverter.ToString(bytes));
            //if (BitConverter.IsLittleEndian)
            //    Array.Reverse(bytes);

            //Console.WriteLine(BitConverter.ToString(bytes));
            //int result = BitConverter.ToInt32(bytes, 0);
            //Console.WriteLine("Original value: {0}", value);
            //Console.WriteLine("Returned value: {0}", result);





            Int32 dataValue = Int32.Parse(txtValueData.Text);
            Console.WriteLine("Create string"+registro3.CreateKeyValue_DWORD(path,nameValue,dataValue));










            ////////////string[] arValores = crearConteiner_Contenedor.Text.Split();

            ////////////byte[] bytesValues = { };

            //////////path = registro3.GetSubFiles(path);


            ////////////              Quieres separar por coma? Usa
            ////////////              string[] arValores = tuTextBox.Text.Split(",");
            ////////////              Con eso tienes los números en un arreglo de strings. Luego usa un for each y parsea cada ítem con TryParse

            //////////int value = Int32.Parse(txtValueData.Text);
            //////////Byte[] bytes = BitConverter.GetBytes(value);

            ////////////int intValue = BitConverter.ToInt32(bytes,0);

            //////////byte[] byteValues = bytes;


            //////////try {
            //////////    RegistryKey k;
            //////////    // Ruta // Nombre del valor // Datos del valor 
            //////////    k = Registry.CurrentUser.OpenSubKey(path, true);

            //////////    k.SetValue(nameValue, byteValues, RegistryValueKind.Binary);

            //////////    Console.WriteLine("Se gurado corerectamente ");
            //////////} catch (Exception) {
            //////////    Console.WriteLine("No se puedo guarsdar ");    // No se puedo crear el valor de la llave
            //////////}






            ////Console.WriteLine("getType_Registry                  = " + registro.GetTypeRegistry(path));
            ////Console.WriteLine("getKeyRutaSingetTypeRegistry      = " + registro.getKeyRutaSingetTypeRegistry(path));
            ////Console.WriteLine("ggetConteinerRegistry             = " + registro.getConteinerRegistry(path));
            //////Console.WriteLine("getKeyRutaSingetConteinerRegistry = " + registro.getKeyRutaSingetConteinerRegistry(path));


            ////Console.WriteLine("gettypeRegistry = " + registro3.GetTypeRegistry(path));
            ////Console.WriteLine("reoutePath      = " + registro3.RoutePath(path));
            ////Console.WriteLine("getNameKey      = " + registro3.GetkeyName(path));
            ////Console.WriteLine("Ruta sin key    = " + registro3.GetSubFilesSinKeyName(path));
            ////Console.WriteLine("GetSubFiles     = " + registro3.GetSubFiles(path) + "\n\n\n\n");
            //Console.WriteLine("Eliminar"+ registro3.createKeyValue_string(path,nameValue,"este es un dato"));




            //Console.WriteLine(nameValue);
            //Console.WriteLine("DeleteValues     = " + registro3.DeleteValues(path, nameValue) + "\n\n\n\n");

            //  Console.WriteLine("eliminar Key y sus datos= "+registro3.DeleteKey(path));


            /* Ésta función busca eliminar el "TIPO DE REGISTRO" y el "CONTENEDOR" 
             * de la variable °path°
             * 
             * =Ejemplo:
             * [Antes]    path = @"HKEY_CURRENT_USER\Contenedor1\Contenedor2\Contenedor3"
             * [Despues]  path = @"Contenedor1\Contenedor2"
             * 
             */


            //// Se obtiene la ruta limpia , sin gettypeKey
            //int  total = registro3.GetSubFiles(path).Length - registro3.GetkeyName(path).Length;
            ////string nameKey = registro3.GetSubFiles(path);
            //path = registro3.GetSubFiles(path);

            //// Desde ésta palabra clave se termina de obtener el texto
            //// string palabraFin = nameKey;                      //Solucionar bug, de cuando en la ruta hay dos carpetas con el mismo nombre

            ////Obtiene el número de posición en la cual se encuentra la °palabra_inicio°
            //int inicio = 0;// obtiene el numero de posición de esta palabra pero de atras hacia delante




            ////int newnumber = 
            ////if (inicio > palabraInicio.Length) {

            //int fin = path.Length - inicio;


            //int fin2 = path.Length - fin;
            ////Console.WriteLine("fin             " + fin);

            //Console.WriteLine("Esto es el resultado         ********    " + path.Substring(0,total));
            ////}


            //Console.WriteLine("path             " + path);
            //// Console.WriteLine("nameKey          " + nameKey);
            ////Console.WriteLine("Fin 2            " + fin2);
            ////Console.WriteLine("Palabra fin      " +newnumber);
            ////Console.WriteLine("inicio           " + inicio);










            ////Ruta limpia
            //string path = registro3.RoutePath(path);
            ////string gettype = ;

            ////    // Tipo de R





            ////Verifica si encontró typeRegistry
            //int ver = path.LastIndexOf(registro3.GetTypeRegistry(path)); //Ingles UK


            ////int inin = path.IndexOf(registro3.GetTypeRegistry(path));
            //if (ver == 0) {
            //    try {
            //        int inin = registro3.GetTypeRegistry(path).Length +1;
            //        int ifin = path.Length - inin;
            //        path = path.Substring(inin, ifin);
            //    } catch (Exception ess) {
            //        int inin = registro3.GetTypeRegistry(path).Length;
            //        int ifin = path.Length - inin;
            //        path = path.Substring(inin, ifin);
            //    }

            //} else {
            //    path = "E#R002"; // Ruta invalida
            //}


            ////Console.WriteLine("Inin      = " + inin);
            ////Console.WriteLine("Ifin      = " + ifin);
            //Console.WriteLine("Verificar = " + ver);
            //Console.WriteLine("Path      = " + path + "\n\n\n");



















            //string path;

            //path = registro3.RoutePath(path);

            //int ifin = 0;
            //int inin;


            //inin = path.IndexOf("HKEY_");



            //int root = path.IndexOf(@"HKEY_CLASSES_ROOT"); //Ingles UK
            //if (root != -1) {
            //    // Significa que si se encontró ésta palabra
            //    ifin = @"HKEY_CLASSES_ROOT".Length;

            //    path = path.Substring(inin, ifin);
            //}
            //int user = path.IndexOf(@"HKEY_CURRENT_USER"); //Ingles UK
            //user = user - inin;
            //if (user != -1) {
            //    // Significa que si se encontró ésta palabra
            //    ifin = @"HKEY_CURRENT_USER".Length;

            //    path = path.Substring(inin, ifin);
            //}









            //int machine = path.IndexOf(@"HKEY_LOCAL_MACHINE"); //Ingles UK
            //if (machine != -1) {
            //    // Significa que si se encontró ésta palabra
            //    ifin = @"HKEY_LOCAL_MACHINE".Length;
            //    ifin = ifin + inin;
            //     path = path.Substring(inin, ifin);
            //}
            //int users = path.IndexOf(@"HKEY_USERS"); //Ingles UK
            //if (users != -1) {
            //    // Significa que si se encontró ésta palabra
            //    ifin = @"HKEY_USERS".Length;
            //    ifin = ifin - inin;
            //    path = path.Substring(inin, ifin);
            //}
            //int config = path.IndexOf(@"HKEY_CURRENT_CONFIG"); //Ingles UK
            //if (config != -1) {
            //    // Significa que si se encontró ésta palabra
            //    ifin = @"HKEY_CURRENT_CONFIG".Length;
            //    ifin = ifin - inin;
            //    path = path.Substring(inin, ifin);
            //}
            //if (root == -1 && user == -1 && machine == -1 && users == -1 && config == -1) {
            //    Console.WriteLine( "E#R002");   // Manda mensaje de error de ruta no valida
            //}


            //Console.WriteLine("Esto es el ifin : " + ifin);
            //Console.WriteLine("Esto es el inin : " + inin);
            //Console.WriteLine("Esto es el USER : " + user);
            //Console.WriteLine("Esto es el PATH : " + path + "\n\n\n\n\n");






        }
    }  

}
