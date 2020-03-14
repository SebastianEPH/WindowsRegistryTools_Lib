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
                //txt_info.Text = registro.createKeyValue_DWORD(ruta, nombre, valori);
            }
            //QWORD
            if (rb_QWORD.Checked) {
                // El mensaje de confirmación o de Falló se mostrará en la pantalla
                //txt_info.Text = registro.createKeyValue_QWORD(ruta, nombre, valori);
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
            string key_ruta = crearConteiner_ruta.Text;


            //Console.WriteLine("getType_Registry                  = " + registro.getTypeRegistry(key_ruta));
            //Console.WriteLine("getKeyRutaSingetTypeRegistry      = " + registro.getKeyRutaSingetTypeRegistry(key_ruta));
            //Console.WriteLine("ggetConteinerRegistry             = " + registro.getConteinerRegistry(key_ruta));
            //Console.WriteLine("getKeyRutaSingetConteinerRegistry = " + registro.getKeyRutaSingetConteinerRegistry(key_ruta));


            Console.WriteLine("gettypeRegistry = "+registro3.getTypeRegistry(key_ruta));
            Console.WriteLine("reoutePath      = "+registro3.routePath(key_ruta));
           // Console.WriteLine("getSubFiles     = " + registro3.getSubFiles(key_ruta)+"-\n\n\n\n");


            string path = registro3.routePath(key_ruta);
            //string gettype = ;


            int inin = registro3.getTypeRegistry(path).Length;
            
            int ifin = path.Length;
            
            //Verifica si encontró typeRegistry
            int ver = path.IndexOf(registro3.getTypeRegistry(path)); //Ingles UK

            if (ver != -1) {
                // Significa que si se encontró ésta palabra
              ifin = ifin - inin;
                path.Substring(inin, ifin);
            }

        Console.WriteLine("Inin      = " + inin);
            Console.WriteLine("Ifin      = " + ifin);
            Console.WriteLine("Verificar = " + ver);
            Console.WriteLine("Path      = " + path+"\n\n\n");

            //string path;

            //path = registro3.routePath(key_ruta);

            //int ifin = 0;
            //int inin;


            //inin = path.IndexOf("HKEY_");



            //int root = path.IndexOf(@"HKEY_CLASSES_ROOT"); //Ingles UK
            //if (root != -1) {
            //    // Significa que si se encontró ésta palabra
            //    ifin = @"HKEY_CLASSES_ROOT".Length;

            //     path = path.Substring(inin, ifin);
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
            //Console.WriteLine("Esto es el PATH : " + path+"\n\n\n\n\n");






        }
    }  

}
