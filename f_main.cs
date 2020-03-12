using RegistryTools.Libs;
using System;
using System.Windows.Forms;


namespace RegistryTools {
    public partial class f_main : Form
    {

        Regedit registro = new Regedit();
        string key_ruta     = @"";  // La ruta del Registro
        string key_name     = "";   // Nombre del Nuevo registro
        string key_value    = "";   // Valor del Registro

        public f_main(){
            InitializeComponent();
           

        }
       
    }
    
}
