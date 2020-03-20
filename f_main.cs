using Microsoft.Win32;
using RegistryTools.Libs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;


namespace RegistryTools {
    public partial class f_main: Form {

        Regedit registro = new Regedit();

        public f_main() {
            InitializeComponent();
        }
        private void btnCrearContenedor(object sender, EventArgs e) {
          //  Ruta completa del registro
          //Ejemplo: @"HKEY_CURRENT_USER\Contenedor1"
            string ruta = crearKey_Path.Text.ToString();
           // nombre del nuevo contenedor
            string nombre = crearKey_key.Text.ToString();
           // El mensaje de confirmación o de Falló se mostrará en la pantalla
            txt_info.Text = registro.CreateKey(ruta, nombre);





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

            string ruta = getValues_path.Text.ToString();

            // nombre del la llave
            string nombre = getValues_NameValue.Text.ToString();
            //Valor tipos texto





            //try {   // Obtiene Multilinea
            //    string [] tArray = (string []) Registry.GetValue(ruta,
            //                      nombre, new string [] { "No se encontró el valor multistring" });
            //    // Leer Array 
            //    ArrayList vector1;

            //    vector1 = new ArrayList();
            //    string salida = "";
            //    string salida2 = "";

            //    for (int i = 0; i < tArray.Length; i++) {
            //        Console.WriteLine("TestArray({0}): {1}", i, tArray [i]);
            //        vector1.Add(tArray [i]);

            //        btnGetValues_Values.Items.Add(vector1 [i]);

            //        salida = string.Join(" ", vector1 [i]);
            //        //salida = salida + "|salto de linea|";
            //        salida2 = salida2 + "" + salida;

            //    }

            //    Console.WriteLine("dentro del for " + salida2);

            final.Text = (registro.GetDataValues(ruta, nombre));
            Console.WriteLine(registro.GetDataValues(ruta, nombre));




        //} catch {


        //    }



            // no lee binario 
            // NodeLabelEditEventArgs crea binarios
            // No lee DWord
            // Si lee Qword obtiene decimales                                                                                                                                                                                             
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
