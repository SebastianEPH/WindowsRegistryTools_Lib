using RegistryTools.Libs;
using System;
using System.Windows.Forms;


namespace RegistryTools {
    public partial class f_main : Form
    {

        Regedit registro = new Regedit();
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
            //Valor tipo Entero
            int valori = 0;

            // String
            if (rb_String.Checked) {
                // El mensaje de confirmación o de Falló se mostrará en la pantalla
                txt_info.Text = registro.createKeyValue_String(ruta, nombre, valors);
            }
            //Binarie
            if (rb_binarie.Checked) {
                // El mensaje de confirmación o de Falló se mostrará en la pantalla
              //  txt_info.Text = registro.createKeyValue_Binarie(ruta, nombre, valori);
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
                txt_info.Text = registro.createKeyValue_String(ruta, nombre, valors);
            }
            //Expandable String
            if (rb_expString.Checked) {
                // El mensaje de confirmación o de Falló se mostrará en la pantalla
                //txt_info.Text = registro.createKeyValue_ExpandableString(ruta, nombre, valors);
            }
        }

     
    }
    
}
