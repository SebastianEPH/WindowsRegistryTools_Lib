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
        byte key_value_type = 0;    /* Tipo de key: *String Value* 
                                                    *Binary Value* 
                                                    *DWord* 
                                                    *QWord*
                                                    *Multi-String*
                                                    *Expanz-String*                     */


        bool value =  false;

        public f_main(){
            InitializeComponent();
            disableValue();

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e){

        }
        private void btn_uninstall_checked_Click(object sender, EventArgs e)  {
            

        }
        private void btn_edge_deactivate_click(object sender, EventArgs e){


          //  Console.WriteLine(registro.deleteRegistry_conteinerAndValue(key_n,key_ruta,key_name,key_value));

           

        }
        private void pruebakey(object sender, EventArgs e){
            key_ruta = tbCreateOrDelete.Text;
            key_name = tbKeyName.Text;
            key_value = tbCreateValue.Text;

           
           //Console.WriteLine("Key ruta, solo:                                              " +key_ruta);
           // Console.WriteLine("Key ruta, Utilizando getKeyRutaSingetTypeRegistry(key_ruta): " + registro.getKeyRutaSingetTypeRegistry(key_ruta));
           // Console.WriteLine("Key ruta, getTypeRegistry:                                   " + registro.getTypeRegistry(key_ruta));
           // Console.WriteLine("Key ruta, getConteinerRegistry:                              " + registro.getConteinerRegistry(key_ruta));
           // Console.WriteLine("Key ruta, Ruta sin tipo y sin conteiner                      " + registro.getKeyRutaSingetConteinerRegistry(key_ruta));




        }
        private void btn_edge_activate_Click(object sender, EventArgs e) {
            

        }
        private void btnCreateRegistry_Click(object sender, EventArgs e) {
            key_ruta = tbCreateOrDelete.Text;
            key_name = tbKeyName.Text;
            key_value = tbCreateValue.Text;
           // Console.WriteLine(registro.createOrWriteRegistry_conteinerAndValue(key_ruta, key_name, key_value));
            cleanRegedit();
        }
        private void btnDeleteRegistry_Click(object sender, EventArgs e) {
            //key_ruta = tbCreateOrDelete.Text;
            //key_name = tbKeyName.Text;
            //key_value = "";

            //Console.WriteLine(registro.deleteRegistry_conteinerAndValue(value,key_ruta,key_name,key_value));
            ////cleanRegedit();

        }
        private void rbCreateConteiner_CheckedChanged(object sender, EventArgs e) {
            /* *************************** Deshabilita ********************************
            *                      Label:   txtKeyName
            *                      Label:   txtValue
            *                      TextBox: tbKeyName
            *                      TextBox: tbValue
            */
            disableValue();

            value = false;      //Si es Falso , significa que No se trabajarán con Llaves y/o Valores
        
        }
        private void disableValue(){
            /* *************************** Deshabilita ********************************
            *                      Label:   txtKeyName
            *                      Label:   txtValue
            *                      TextBox: tbKeyName
            *                      TextBox: tbValue
            */
            txtKeyName.Visible = false;
            txtValue.Visible = false;
            tbKeyName.Visible = false;
            tbCreateValue.Visible = false;
            cbTypeKeyValue.Visible = false;
            //Bool
            value = false;
        }
        private void enableValue(){
            /* *************************** Habilita ********************************
            *                      Label:   txtKeyName
            *                      Label:   txtValue
            *                      TextBox: tbKeyName
            *                      TextBox: tbValue
            */
            txtKeyName.Visible = true;
            txtValue.Visible = true;
            tbKeyName.Visible = true;
            tbCreateValue.Visible = true;
            cbTypeKeyValue.Visible = true;

            //Bool
            value = true;
        }
        private void rbCreateValue_CheckedChanged(object sender, EventArgs e) {
            /* *************************** Habilita ********************************
            *                      Label:   txtKeyName
            *                      Label:   txtValue
            *                      TextBox: tbKeyName
            *                      TextBox: tbValue
            */
            enableValue();

            value = true;   //Si es verdadero , significa que se trabajarán con Llaves y/o Valores
        }
        private void registryStartEvent(object sender, EventArgs e) {
           
        }
        private void btnReadRegistry_Click(object sender, EventArgs e) {
            key_ruta = tbReadRegistryPath.Text;
            key_name = tbReadKeyName.Text;

            //try {

            //    tbReadResultValue.Text = (registro.readRegistry_valueString(key_ruta, key_name));
            //    cleanRegedit();
            //} catch (Exception ex) {
                
            //     Console.WriteLine("Hubo un error al leer la llave" + ex);
            //}


        }
        private void cleanRegedit() {
            
            tbCreateOrDelete.Text = "";
            tbKeyName.Text = "";
            tbCreateValue.Text = "";
        }
        private void groupReadRegistryValue_Enter(object sender, EventArgs e) {

        }



        private void cbTypeKeyValue_SelectedIndexChanged(object sender, EventArgs e) {
            // Realiza el cambio de la varibale Key_Value_Type
            // Ésta se encarga de almacenar 
            switch (cbTypeKeyValue.Text) {
                case "String Value": 
                    key_value_type = 1;
                
                break;
                case "Binarie Value": 
                    key_value_type = 2;
                
                break;
                case "DWORD (32bits) Value": 
                    key_value_type = 3;
                
                break;
                case "QWORD (64bits) Value": 
                    key_value_type = 4;
                
                break;
                case "Multi-String Value": 
                    key_value_type = 5;
                
                break;
                case "Expandable String": 
                    key_value_type = 6;
                
                break;
                default:
                    key_value_type = 0;
                break;


            }

        }
    }
    
}
