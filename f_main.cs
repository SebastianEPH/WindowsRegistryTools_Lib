using Microsoft.Win32;
using RegistryTools.Libs;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace RegistryTools {
    public partial class f_main: Form {
        Regedit registro = new Regedit();
        Regedito registro3 = new Regedito();


        List<string> listaNombres = new List<string>();
        int cantidad = 0;




        public f_main() {
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

            txt_info.Text = btnleerLlave_valor.Text = registro.readKeyValue(ruta, nombre);
        }
        private void btndeleteLlave(object sender, EventArgs e) {

            string ruta = deleteLlave_ruta.Text.ToString();
            string nombre = deleteLlave_name.Text.ToString();
            txt_info.Text = registro.deleteKeyValue(ruta, nombre);

        }
        private void btndeleteAll_Click(object sender, EventArgs e) {
            string ruta = deleteAll_ruta.Text.ToString();
            txt_info.Text = registro.deleteConteinerAll(ruta);
        }
        private void button1_Click(object sender, EventArgs e) {

            string path = crearConteiner_ruta.Text;
            string nameValue = crearConteiner_Contenedor.Text;
            string dataValue = txtValueData.Text;



            //string [] arrayNombres = new string [20];
            //int index = 0;



            //string hexValues = "48,65,6C,6C,6F,20,57,6F,72,6C,64,21";
            //string [] hexValuesSplit = hexValues.Split(',');

                listaNombres.Add(dataValue);

                cantidad++;

            Console.WriteLine(listaNombres);

        }   
    }  


}
