using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
                    Char [] caractersalto = { ' ', ',', '-'};
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
            String path =getValues_path.Text;
            String valueName = getValues_NameValue.Text;
            try {
                switch (GetValues_Combo.Text) {
                    case "String Value": getValue_Salida.Text = registro.getDataValue_String(path, valueName); txt_info.Text = ""; break;
                    case "Binary Value Byte":
                    byte [] binary = registro.getDataValue_Binary(path, valueName); txt_info.Text = "";
                    string textofinal = "";

                    //byte.getDecoder().decode(binarys);
                    int sumador = 7;
                    for (int i = 0; i < binary.Length; i++) {
                        textofinal = textofinal + binary [i] + " ";
                        //binarys [i] = new string(binary [i]);
                        if (i == sumador) {
                            textofinal = textofinal + "\r\n";
                            sumador = sumador + 8;
                        }
                    }

                    getValue_Salida.Text = textofinal;
                    break;

                    case "Binary Value Hex":
                    byte [] binary2 = registro.getDataValue_Binary(path, valueName); txt_info.Text = "";
                    string textofinal2 = "";

                    //byte.getDecoder().decode(binarys);
                    int sumador2 = 7;

                    //string hexValue = intValue.ToString("X");


                    //byte [] data = new byte [] { 1, 2, 3, 4, 5, 128, 255 };
                    string hex = String.Join(" ", binary2.Select(b => b.ToString("x2")).ToArray());
                    //Console.WriteLine(hex);


                    //for (int i = 0; i < binary2.Length; i++) {
                    //    textofinal2 = textofinal2 + binary2[i];
                    //    //binarys [i] = new string(binary [i]);

                    //    if (i == sumador2) {
                    //        textofinal2 = textofinal2 + "\r\n";
                    //        sumador2 = sumador2 + 8;
                    //    }
                    //}

                    getValue_Salida.Text = hex;
                    break;
                    case "DWORD(32 Bits) Value": txt_info.Text = ""; getValue_Salida.Text = registro.getDataValue_DWORD(path, valueName) + ""; break;
                    case "QWORD(64 Bits) Value": txt_info.Text = ""; getValue_Salida.Text = registro.getDataValue_QWORD(path, valueName) + ""; break;
                    case "Multi-String Value": txt_info.Text = ""; 
                            string [] obtiene = registro.getDataValue_MultiString(path, valueName);
                                string mostrar = "";

                            for (int i = 0; i < obtiene.Length; i++) {
                                mostrar = mostrar + obtiene [i]+"\r\n";
                            }
                            getValue_Salida.Text = mostrar;
                    break;
                    case "Expandable String Value": txt_info.Text = ""; getValue_Salida.Text = registro.getDataValue_ExpandString(path, valueName); break;
                    default: getValue_Salida.Text = ""; txt_info.Text = "Error, escoja correctamente"; break;
                }
            } catch  {
                getValue_Salida.Text = ""; 
                txt_info.Text = "Error, escoja correctamente";
            }
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

        private void rb_multiString_CheckedChanged(object sender, EventArgs e) {
            if (rb_multiString.Checked) {
                createLlave_value.Multiline = true;
            } else {
                createLlave_value.Multiline = false;


            }
        }
    }  


}
