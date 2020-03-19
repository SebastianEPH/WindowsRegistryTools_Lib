using Microsoft.Win32;
using RegistryTools.Libs;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace RegistryTools {
    public partial class f_main: Form {

        Regedit registro = new Regedit();

        public f_main() {
            InitializeComponent();
        }
        private void btnCrearContenedor(object sender, EventArgs e) {
            //// Ruta completa del registro
            ////Ejemplo: @"HKEY_CURRENT_USER\Contenedor1"
            //string ruta = crearConteiner_ruta.Text.ToString();
            //// nombre del nuevo contenedor
            //string nombre = crearConteiner_Contenedor.Text.ToString();
            //// El mensaje de confirmación o de Falló se mostrará en la pantalla
            //txt_info.Text = registro.CreateKey(ruta, nombre);



            // Int32

           
            


        }
        private void btnCrearLlave(object sender, EventArgs e) {
            // Ruta completa del registro
            //Ejemplo: @"HKEY_CURRENT_USER\Contenedor1"
            string ruta = crearLlave_ruta.Text.ToString();

            // nombre del la llave
            string nombre = crearLlave_name.Text.ToString();
            //Valor tipos texto
            string valor = createLlave_value.Text.ToString();


            // String
            if (rb_String.Checked) {
                // El mensaje de confirmación o de Falló se mostrará en la pantalla

                txt_info.Text = registro.CreateKeyValue_String(ruta, nombre, valor);
            }
            //Binarie
            if (rb_binarie.Checked) {
                // El mensaje de confirmación o de Falló se mostrará en la pantalla
                //txt_info.Text = registro.CreateKeyValue_Binarie(ruta, nombre, valor);
                Console.WriteLine("Esta función no está terminada en modo gráfico");
            }
            //DWORD
            if (rb_DWORD.Checked) {
                // El mensaje de confirmación o de Falló se mostrará en la pantalla
                Int32 valori = Int32.Parse(createLlave_value.Text);
                txt_info.Text = registro.CreateKeyValue_DWORD(ruta, nombre, valori);
            }
            //QWORD
            if (rb_QWORD.Checked) {
                // El mensaje de confirmación o de Falló se mostrará en la pantalla
                Int64 valori = Int64.Parse(createLlave_value.Text);
                txt_info.Text = registro.CreateKeyValue_QWORD(ruta, nombre, valori);
            }
            //MultiString
            if (rb_multiString.Checked) {
                // El mensaje de confirmación o de Falló se mostrará en la pantalla
                createLlave_value.Multiline = true;
                string [] stringML = { createLlave_value.Text.ToString() };
                txt_info.Text = registro.CreateKeyValue_MultiString(ruta, nombre, stringML);
            }
            //Expandable String
            if (rb_expString.Checked) {
                // El mensaje de confirmación o de Falló se mostrará en la pantalla
                txt_info.Text = registro.CreateKeyValue_ExpandString(ruta, nombre, valor);
            }
        }
        private void btnGetDataValue(object sender, EventArgs e) {

            string ruta = btnleerLlave_ruta.Text.ToString();

            // nombre del la llave
            string nombre = btnleerLlave_name.Text.ToString();
            //Valor tipos texto
            string valor = createLlave_value.Text.ToString();

            // no lee binario 
            // NodeLabelEditEventArgs crea binarios
            // No lee DWord
            // Si lee Qword obtiene decimales                                                                                                                                                                                             





            txt_info.Text = btnleerLlave_valor.Text = registro.GetDataValues(ruta, nombre);
        }
        private void btnDeleteValues(object sender, EventArgs e) {

            string ruta = deleteLlave_ruta.Text.ToString();
            string nombre = deleteLlave_name.Text.ToString();
            txt_info.Text = registro.DeleteValue(ruta, nombre);

        }
        private void btnDeleteKey(object sender, EventArgs e) {
            string ruta = deleteAll_ruta.Text.ToString();
            txt_info.Text = registro.DeleteKey(ruta);
        }
   

        private void BtnExit(object sender, EventArgs e) {
            this.Close();
        }
    }  


}
