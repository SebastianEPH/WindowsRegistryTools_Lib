namespace WindowsRegistryTools {
    partial class f_main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.dfgfdg = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_CreateKey = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.crearKey_key = new System.Windows.Forms.TextBox();
            this.crearKey_Path = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rb_String = new System.Windows.Forms.RadioButton();
            this.rb_expString = new System.Windows.Forms.RadioButton();
            this.rb_multiString = new System.Windows.Forms.RadioButton();
            this.rb_DWORD = new System.Windows.Forms.RadioButton();
            this.rb_QWORD = new System.Windows.Forms.RadioButton();
            this.rb_binarie = new System.Windows.Forms.RadioButton();
            this.btnCreateValues = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.createLlave_value = new System.Windows.Forms.TextBox();
            this.crearLlave_name = new System.Windows.Forms.TextBox();
            this.crearLlave_ruta = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.GetValues_Combo = new System.Windows.Forms.ComboBox();
            this.getValue_Salida = new System.Windows.Forms.TextBox();
            this.btnGetValues = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.getValues_NameValue = new System.Windows.Forms.TextBox();
            this.getValues_path = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btn_keyDelete = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.deleteAll_ruta = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnValueDelete = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.deleteLlave_name = new System.Windows.Forms.TextBox();
            this.deleteLlave_ruta = new System.Windows.Forms.TextBox();
            this.txt_info = new System.Windows.Forms.Label();
            this.dfgfdg.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Probar funcionalidades - librería v3.1";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(361, 263);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(73, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit);
            // 
            // dfgfdg
            // 
            this.dfgfdg.Controls.Add(this.tabPage1);
            this.dfgfdg.Controls.Add(this.tabPage2);
            this.dfgfdg.Controls.Add(this.tabPage3);
            this.dfgfdg.Controls.Add(this.tabPage5);
            this.dfgfdg.Controls.Add(this.tabPage4);
            this.dfgfdg.Location = new System.Drawing.Point(20, 67);
            this.dfgfdg.Name = "dfgfdg";
            this.dfgfdg.SelectedIndex = 0;
            this.dfgfdg.Size = new System.Drawing.Size(414, 190);
            this.dfgfdg.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_CreateKey);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.crearKey_key);
            this.tabPage1.Controls.Add(this.crearKey_Path);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(406, 164);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Crear Llave";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_CreateKey
            // 
            this.btn_CreateKey.Location = new System.Drawing.Point(15, 116);
            this.btn_CreateKey.Name = "btn_CreateKey";
            this.btn_CreateKey.Size = new System.Drawing.Size(370, 23);
            this.btn_CreateKey.TabIndex = 3;
            this.btn_CreateKey.Text = "Crear Llave";
            this.btn_CreateKey.UseVisualStyleBackColor = true;
            this.btn_CreateKey.Click += new System.EventHandler(this.btnCrearKey);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ingrese el nombre de la llave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese la ruta:";
            // 
            // crearKey_key
            // 
            this.crearKey_key.Location = new System.Drawing.Point(15, 90);
            this.crearKey_key.Name = "crearKey_key";
            this.crearKey_key.Size = new System.Drawing.Size(165, 20);
            this.crearKey_key.TabIndex = 0;
            // 
            // crearKey_Path
            // 
            this.crearKey_Path.Location = new System.Drawing.Point(15, 42);
            this.crearKey_Path.Name = "crearKey_Path";
            this.crearKey_Path.Size = new System.Drawing.Size(370, 20);
            this.crearKey_Path.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rb_String);
            this.tabPage2.Controls.Add(this.rb_expString);
            this.tabPage2.Controls.Add(this.rb_multiString);
            this.tabPage2.Controls.Add(this.rb_DWORD);
            this.tabPage2.Controls.Add(this.rb_QWORD);
            this.tabPage2.Controls.Add(this.rb_binarie);
            this.tabPage2.Controls.Add(this.btnCreateValues);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.createLlave_value);
            this.tabPage2.Controls.Add(this.crearLlave_name);
            this.tabPage2.Controls.Add(this.crearLlave_ruta);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(406, 164);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Crear Valores";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rb_String
            // 
            this.rb_String.AutoSize = true;
            this.rb_String.Checked = true;
            this.rb_String.Location = new System.Drawing.Point(189, 21);
            this.rb_String.Name = "rb_String";
            this.rb_String.Size = new System.Drawing.Size(81, 17);
            this.rb_String.TabIndex = 14;
            this.rb_String.TabStop = true;
            this.rb_String.Text = "String value";
            this.rb_String.UseVisualStyleBackColor = true;
            // 
            // rb_expString
            // 
            this.rb_expString.AutoSize = true;
            this.rb_expString.Location = new System.Drawing.Point(292, 21);
            this.rb_expString.Name = "rb_expString";
            this.rb_expString.Size = new System.Drawing.Size(108, 17);
            this.rb_expString.TabIndex = 13;
            this.rb_expString.Text = "ExpandableString";
            this.rb_expString.UseVisualStyleBackColor = true;
            // 
            // rb_multiString
            // 
            this.rb_multiString.AutoSize = true;
            this.rb_multiString.Location = new System.Drawing.Point(292, 44);
            this.rb_multiString.Name = "rb_multiString";
            this.rb_multiString.Size = new System.Drawing.Size(103, 17);
            this.rb_multiString.TabIndex = 12;
            this.rb_multiString.Text = "MultiString value";
            this.rb_multiString.UseVisualStyleBackColor = true;
            this.rb_multiString.CheckedChanged += new System.EventHandler(this.rb_multiString_CheckedChanged);
            // 
            // rb_DWORD
            // 
            this.rb_DWORD.AutoSize = true;
            this.rb_DWORD.Location = new System.Drawing.Point(189, 67);
            this.rb_DWORD.Name = "rb_DWORD";
            this.rb_DWORD.Size = new System.Drawing.Size(97, 17);
            this.rb_DWORD.TabIndex = 11;
            this.rb_DWORD.Text = "DWORD value";
            this.rb_DWORD.UseVisualStyleBackColor = true;
            // 
            // rb_QWORD
            // 
            this.rb_QWORD.AutoSize = true;
            this.rb_QWORD.Location = new System.Drawing.Point(292, 67);
            this.rb_QWORD.Name = "rb_QWORD";
            this.rb_QWORD.Size = new System.Drawing.Size(97, 17);
            this.rb_QWORD.TabIndex = 10;
            this.rb_QWORD.Text = "QWORD value";
            this.rb_QWORD.UseVisualStyleBackColor = true;
            // 
            // rb_binarie
            // 
            this.rb_binarie.AutoSize = true;
            this.rb_binarie.Location = new System.Drawing.Point(189, 44);
            this.rb_binarie.Name = "rb_binarie";
            this.rb_binarie.Size = new System.Drawing.Size(86, 17);
            this.rb_binarie.TabIndex = 9;
            this.rb_binarie.Text = "Binarie value";
            this.rb_binarie.UseVisualStyleBackColor = true;
            // 
            // btnCreateValues
            // 
            this.btnCreateValues.Location = new System.Drawing.Point(189, 99);
            this.btnCreateValues.Name = "btnCreateValues";
            this.btnCreateValues.Size = new System.Drawing.Size(196, 23);
            this.btnCreateValues.TabIndex = 8;
            this.btnCreateValues.Text = "Crear Valores";
            this.btnCreateValues.UseVisualStyleBackColor = true;
            this.btnCreateValues.Click += new System.EventHandler(this.btnCrearValues);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Datos del valor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre del Valor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ingrese la ruta:";
            // 
            // createLlave_value
            // 
            this.createLlave_value.Location = new System.Drawing.Point(18, 128);
            this.createLlave_value.Name = "createLlave_value";
            this.createLlave_value.Size = new System.Drawing.Size(367, 20);
            this.createLlave_value.TabIndex = 4;
            // 
            // crearLlave_name
            // 
            this.crearLlave_name.Location = new System.Drawing.Point(18, 77);
            this.crearLlave_name.Name = "crearLlave_name";
            this.crearLlave_name.Size = new System.Drawing.Size(165, 20);
            this.crearLlave_name.TabIndex = 4;
            // 
            // crearLlave_ruta
            // 
            this.crearLlave_ruta.Location = new System.Drawing.Point(18, 29);
            this.crearLlave_ruta.Name = "crearLlave_ruta";
            this.crearLlave_ruta.Size = new System.Drawing.Size(165, 20);
            this.crearLlave_ruta.TabIndex = 5;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.GetValues_Combo);
            this.tabPage3.Controls.Add(this.getValue_Salida);
            this.tabPage3.Controls.Add(this.btnGetValues);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.getValues_NameValue);
            this.tabPage3.Controls.Add(this.getValues_path);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(406, 164);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Leer Valores";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // GetValues_Combo
            // 
            this.GetValues_Combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.GetValues_Combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.GetValues_Combo.FormattingEnabled = true;
            this.GetValues_Combo.Items.AddRange(new object[] {
            "String Value",
            "Binary Value Byte",
            "Binary Value Hex",
            "DWORD (32 Bits) Value",
            "QWORD (64 Bits) Value",
            "Multi-String Value",
            "Expandable String Value"});
            this.GetValues_Combo.Location = new System.Drawing.Point(188, 20);
            this.GetValues_Combo.Name = "GetValues_Combo";
            this.GetValues_Combo.Size = new System.Drawing.Size(203, 21);
            this.GetValues_Combo.TabIndex = 22;
            this.GetValues_Combo.Text = "String Value";
            // 
            // getValue_Salida
            // 
            this.getValue_Salida.Location = new System.Drawing.Point(188, 69);
            this.getValue_Salida.Multiline = true;
            this.getValue_Salida.Name = "getValue_Salida";
            this.getValue_Salida.Size = new System.Drawing.Size(203, 92);
            this.getValue_Salida.TabIndex = 7;
            // 
            // btnGetValues
            // 
            this.btnGetValues.Location = new System.Drawing.Point(15, 117);
            this.btnGetValues.Name = "btnGetValues";
            this.btnGetValues.Size = new System.Drawing.Size(165, 23);
            this.btnGetValues.TabIndex = 21;
            this.btnGetValues.Text = "Obtener Valores";
            this.btnGetValues.UseVisualStyleBackColor = true;
            this.btnGetValues.Click += new System.EventHandler(this.btnGetDataValue);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Se obtuvo el valor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Ingrese el nombre del valor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Ingrese la ruta:";
            // 
            // getValues_NameValue
            // 
            this.getValues_NameValue.Location = new System.Drawing.Point(15, 91);
            this.getValues_NameValue.Name = "getValues_NameValue";
            this.getValues_NameValue.Size = new System.Drawing.Size(165, 20);
            this.getValues_NameValue.TabIndex = 16;
            // 
            // getValues_path
            // 
            this.getValues_path.Location = new System.Drawing.Point(12, 30);
            this.getValues_path.Name = "getValues_path";
            this.getValues_path.Size = new System.Drawing.Size(168, 20);
            this.getValues_path.TabIndex = 17;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btn_keyDelete);
            this.tabPage5.Controls.Add(this.label13);
            this.tabPage5.Controls.Add(this.deleteAll_ruta);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(406, 164);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Eliminar Llave";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btn_keyDelete
            // 
            this.btn_keyDelete.Location = new System.Drawing.Point(12, 104);
            this.btn_keyDelete.Name = "btn_keyDelete";
            this.btn_keyDelete.Size = new System.Drawing.Size(373, 23);
            this.btn_keyDelete.TabIndex = 13;
            this.btn_keyDelete.Text = "Eliminar Llave";
            this.btn_keyDelete.UseVisualStyleBackColor = true;
            this.btn_keyDelete.Click += new System.EventHandler(this.btnDeleteKey);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Ingrese la ruta:";
            // 
            // deleteAll_ruta
            // 
            this.deleteAll_ruta.Location = new System.Drawing.Point(12, 44);
            this.deleteAll_ruta.Name = "deleteAll_ruta";
            this.deleteAll_ruta.Size = new System.Drawing.Size(373, 20);
            this.deleteAll_ruta.TabIndex = 10;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnValueDelete);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.deleteLlave_name);
            this.tabPage4.Controls.Add(this.deleteLlave_ruta);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(406, 164);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Eliminar Valor";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnValueDelete
            // 
            this.btnValueDelete.Location = new System.Drawing.Point(12, 117);
            this.btnValueDelete.Name = "btnValueDelete";
            this.btnValueDelete.Size = new System.Drawing.Size(373, 23);
            this.btnValueDelete.TabIndex = 8;
            this.btnValueDelete.Text = "Eliminar Valor";
            this.btnValueDelete.UseVisualStyleBackColor = true;
            this.btnValueDelete.Click += new System.EventHandler(this.btnDeleteValues);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Ingrese el nombre del Valor";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Ingrese la ruta:";
            // 
            // deleteLlave_name
            // 
            this.deleteLlave_name.Location = new System.Drawing.Point(12, 91);
            this.deleteLlave_name.Name = "deleteLlave_name";
            this.deleteLlave_name.Size = new System.Drawing.Size(373, 20);
            this.deleteLlave_name.TabIndex = 4;
            // 
            // deleteLlave_ruta
            // 
            this.deleteLlave_ruta.Location = new System.Drawing.Point(12, 43);
            this.deleteLlave_ruta.Name = "deleteLlave_ruta";
            this.deleteLlave_ruta.Size = new System.Drawing.Size(373, 20);
            this.deleteLlave_ruta.TabIndex = 5;
            // 
            // txt_info
            // 
            this.txt_info.AutoSize = true;
            this.txt_info.Location = new System.Drawing.Point(33, 268);
            this.txt_info.Name = "txt_info";
            this.txt_info.Size = new System.Drawing.Size(16, 13);
            this.txt_info.TabIndex = 2;
            this.txt_info.Text = "---";
            // 
            // f_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 298);
            this.Controls.Add(this.dfgfdg);
            this.Controls.Add(this.txt_info);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Name = "f_main";
            this.Text = "Probar funcionalidades - librería v3.1";
            this.dfgfdg.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TabControl dfgfdg;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label txt_info;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox crearKey_key;
        private System.Windows.Forms.TextBox crearKey_Path;
        private System.Windows.Forms.Button btn_CreateKey;
        private System.Windows.Forms.Button btnCreateValues;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox crearLlave_name;
        private System.Windows.Forms.TextBox crearLlave_ruta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox createLlave_value;
        private System.Windows.Forms.RadioButton rb_String;
        private System.Windows.Forms.RadioButton rb_expString;
        private System.Windows.Forms.RadioButton rb_multiString;
        private System.Windows.Forms.RadioButton rb_DWORD;
        private System.Windows.Forms.RadioButton rb_QWORD;
        private System.Windows.Forms.RadioButton rb_binarie;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnGetValues;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox getValues_NameValue;
        private System.Windows.Forms.TextBox getValues_path;
        private System.Windows.Forms.Button btnValueDelete;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox deleteLlave_name;
        private System.Windows.Forms.TextBox deleteLlave_ruta;
        private System.Windows.Forms.Button btn_keyDelete;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox deleteAll_ruta;
        private System.Windows.Forms.TextBox getValue_Salida;
        private System.Windows.Forms.ComboBox GetValues_Combo;
    }
}

