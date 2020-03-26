using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;


namespace WindowsRegistryTools {
    public partial class f_main: Form {

        RegistryTools_ registro = new RegistryTools_();

        public f_main() {
            InitializeComponent();
        }
        private void btnCrearKey(object sender, EventArgs e) {
          //  Ruta completa del registro
          //Ejemplo: @"HKEY_CURRENT_USER\Contenedor1"
            string ruta = crearKey_Path.Text.ToString();
           // valueName del nuevo contenedor
            string nombre = crearKey_key.Text.ToString();
           // El mensaje de confirmación o de Falló se mostrará en la pantalla
            txt_info.Text = registro.CreateKey(ruta, nombre);





        }
        private void btnCrearValues(object sender, EventArgs e) {
            // Ruta completa del registro
            //Ejemplo: @"HKEY_CURRENT_USER\Contenedor1"
            string ruta = crearLlave_ruta.Text.ToString();

            // valueName del la llave
            string valueName = crearLlave_name.Text.ToString();
            //Valor tipos texto
            string valueData = createLlave_value.Text.ToString();


            // String
            if (rb_String.Checked) {
                // El mensaje de confirmación o de Falló se mostrará en la pantalla

                txt_info.Text = registro.CreateKeyValue_String(ruta, valueName, valueData);
            }
            //Binarie
            if (rb_binarie.Checked) {
                bool hola;
                    //Palabras claves para saltar 
                    Char [] caractersalto = { ' ', ',' };
                    // Nuevo array con saltos de linea
                    String [] valueDataSaltos = valueData.Split(caractersalto);
                    // Nuevo array de valores tipo binario
                    byte [] valueDataB = new byte [valueDataSaltos.Length];
                try {
                    // Verificar parse dato por dato 
                    for (int i = 0; i < valueDataSaltos.Length; i++) {
                        // Inserta datos en binario
                        valueDataB [i] = byte.Parse(valueDataSaltos [i]);
                    }
                    hola = true;
                } catch {
                    hola = false;
                    txt_info.Text = "Ingrese los datos correctamente";
                }
                if (hola) {
                    // Proceso de Insertar Datos a los registros (Regedit
                   txt_info.Text = registro.CreateKeyValue_Binary(ruta, valueName, valueDataB);
                } else {
                    txt_info.Text = "Ingrese los datos correctamente";
                }
            }
            //DWORD
            if (rb_DWORD.Checked) {
                // El mensaje de confirmación o de Falló se mostrará en la pantalla
                Int32 valori = Int32.Parse(createLlave_value.Text);
                txt_info.Text = registro.CreateKeyValue_DWORD(ruta, valueName, valori);
            }
            //QWORD
            if (rb_QWORD.Checked) {
                // El mensaje de confirmación o de Falló se mostrará en la pantalla
                Int64 valori = Int64.Parse(createLlave_value.Text);
                txt_info.Text = registro.CreateKeyValue_QWORD(ruta, valueName, valori);
            }
            //MultiString
            if (rb_multiString.Checked) {
                // El mensaje de confirmación o de Falló se mostrará en la pantalla
                createLlave_value.Multiline = true;
                string [] stringML = { createLlave_value.Text.ToString() };
                txt_info.Text = registro.CreateKeyValue_MultiString(ruta, valueName, stringML);
            }
            //Expandable String
            if (rb_expString.Checked) {
                // El mensaje de confirmación o de Falló se mostrará en la pantalla
                txt_info.Text = registro.CreateKeyValue_ExpandString(ruta, valueName, valueData);
            }
        }
        private void btnGetDataValue(object sender, EventArgs e) {

            string ruta = getValues_path.Text.ToString();

            // valueName del la llave
            string nombre = getValues_NameValue.Text.ToString();
            //Valor tipos texto





            //try {   // Obtiene Multilinea
            //    string [] tArray = (string []) Registry.GetValue(ruta,
            //                      valueName, new string [] { "No se encontró el valueData multistring" });
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


            // no lee binario 
                                                                                                                                                                                       
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
