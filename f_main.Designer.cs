namespace RegistryTools
{
    partial class f_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_CrearContenedor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.crearConteiner_Contenedor = new System.Windows.Forms.TextBox();
            this.crearConteiner_ruta = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rb_String = new System.Windows.Forms.RadioButton();
            this.rb_expString = new System.Windows.Forms.RadioButton();
            this.rb_multiString = new System.Windows.Forms.RadioButton();
            this.rb_DWORD = new System.Windows.Forms.RadioButton();
            this.rb_QWORD = new System.Windows.Forms.RadioButton();
            this.rb_binarie = new System.Windows.Forms.RadioButton();
            this.crearLlave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.createLlave_value = new System.Windows.Forms.TextBox();
            this.crearLlave_name = new System.Windows.Forms.TextBox();
            this.crearLlave_ruta = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txt_info = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Probar funcionalidades - librería v2.0";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(346, 268);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(73, 23);
            this.button6.TabIndex = 2;
            this.button6.Text = "Exit";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(24, 62);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(414, 190);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_CrearContenedor);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.crearConteiner_Contenedor);
            this.tabPage1.Controls.Add(this.crearConteiner_ruta);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(406, 164);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Crear Contenedor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_CrearContenedor
            // 
            this.btn_CrearContenedor.Location = new System.Drawing.Point(15, 116);
            this.btn_CrearContenedor.Name = "btn_CrearContenedor";
            this.btn_CrearContenedor.Size = new System.Drawing.Size(324, 23);
            this.btn_CrearContenedor.TabIndex = 3;
            this.btn_CrearContenedor.Text = "Ejecutar";
            this.btn_CrearContenedor.UseVisualStyleBackColor = true;
            this.btn_CrearContenedor.Click += new System.EventHandler(this.btnCrearContenedor);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ingrese el nombre del contenedor";
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
            // crearConteiner_Contenedor
            // 
            this.crearConteiner_Contenedor.Location = new System.Drawing.Point(15, 90);
            this.crearConteiner_Contenedor.Name = "crearConteiner_Contenedor";
            this.crearConteiner_Contenedor.Size = new System.Drawing.Size(165, 20);
            this.crearConteiner_Contenedor.TabIndex = 0;
            // 
            // crearConteiner_ruta
            // 
            this.crearConteiner_ruta.Location = new System.Drawing.Point(15, 42);
            this.crearConteiner_ruta.Name = "crearConteiner_ruta";
            this.crearConteiner_ruta.Size = new System.Drawing.Size(324, 20);
            this.crearConteiner_ruta.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rb_String);
            this.tabPage2.Controls.Add(this.rb_expString);
            this.tabPage2.Controls.Add(this.rb_multiString);
            this.tabPage2.Controls.Add(this.rb_DWORD);
            this.tabPage2.Controls.Add(this.rb_QWORD);
            this.tabPage2.Controls.Add(this.rb_binarie);
            this.tabPage2.Controls.Add(this.crearLlave);
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
            this.tabPage2.Text = "Crear Llave";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rb_String
            // 
            this.rb_String.AutoSize = true;
            this.rb_String.Checked = true;
            this.rb_String.Location = new System.Drawing.Point(200, 21);
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
            this.rb_expString.Location = new System.Drawing.Point(283, 21);
            this.rb_expString.Name = "rb_expString";
            this.rb_expString.Size = new System.Drawing.Size(108, 17);
            this.rb_expString.TabIndex = 13;
            this.rb_expString.Text = "ExpandableString";
            this.rb_expString.UseVisualStyleBackColor = true;
            // 
            // rb_multiString
            // 
            this.rb_multiString.AutoSize = true;
            this.rb_multiString.Location = new System.Drawing.Point(200, 113);
            this.rb_multiString.Name = "rb_multiString";
            this.rb_multiString.Size = new System.Drawing.Size(103, 17);
            this.rb_multiString.TabIndex = 12;
            this.rb_multiString.Text = "MultiString value";
            this.rb_multiString.UseVisualStyleBackColor = true;
            // 
            // rb_DWORD
            // 
            this.rb_DWORD.AutoSize = true;
            this.rb_DWORD.Location = new System.Drawing.Point(200, 67);
            this.rb_DWORD.Name = "rb_DWORD";
            this.rb_DWORD.Size = new System.Drawing.Size(97, 17);
            this.rb_DWORD.TabIndex = 11;
            this.rb_DWORD.Text = "DWORD value";
            this.rb_DWORD.UseVisualStyleBackColor = true;
            // 
            // rb_QWORD
            // 
            this.rb_QWORD.AutoSize = true;
            this.rb_QWORD.Location = new System.Drawing.Point(200, 90);
            this.rb_QWORD.Name = "rb_QWORD";
            this.rb_QWORD.Size = new System.Drawing.Size(97, 17);
            this.rb_QWORD.TabIndex = 10;
            this.rb_QWORD.Text = "QWORD value";
            this.rb_QWORD.UseVisualStyleBackColor = true;
            // 
            // rb_binarie
            // 
            this.rb_binarie.AutoSize = true;
            this.rb_binarie.Location = new System.Drawing.Point(200, 44);
            this.rb_binarie.Name = "rb_binarie";
            this.rb_binarie.Size = new System.Drawing.Size(86, 17);
            this.rb_binarie.TabIndex = 9;
            this.rb_binarie.Text = "Binarie value";
            this.rb_binarie.UseVisualStyleBackColor = true;
            // 
            // crearLlave
            // 
            this.crearLlave.Location = new System.Drawing.Point(200, 135);
            this.crearLlave.Name = "crearLlave";
            this.crearLlave.Size = new System.Drawing.Size(191, 23);
            this.crearLlave.TabIndex = 8;
            this.crearLlave.Text = "Ejecutar";
            this.crearLlave.UseVisualStyleBackColor = true;
            this.crearLlave.Click += new System.EventHandler(this.btncrearLlave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Valor de la llave";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ingrese el nombre de la llave";
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
            this.createLlave_value.Size = new System.Drawing.Size(165, 20);
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
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(406, 164);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Leer Llave";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(406, 164);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Eliminar Llave";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(406, 164);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Eliminar Contenedor";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // txt_info
            // 
            this.txt_info.AutoSize = true;
            this.txt_info.Location = new System.Drawing.Point(25, 278);
            this.txt_info.Name = "txt_info";
            this.txt_info.Size = new System.Drawing.Size(16, 13);
            this.txt_info.TabIndex = 2;
            this.txt_info.Text = "---";
            // 
            // f_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 318);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txt_info);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Name = "f_main";
            this.Text = "Prueba de Funcionalidades v2.0";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label txt_info;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox crearConteiner_Contenedor;
        private System.Windows.Forms.TextBox crearConteiner_ruta;
        private System.Windows.Forms.Button btn_CrearContenedor;
        private System.Windows.Forms.Button crearLlave;
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
    }
}

