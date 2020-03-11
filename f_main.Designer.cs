﻿namespace RegistryTools
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
            this.l_name = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupReadRegistryValue = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbReadKeyName = new System.Windows.Forms.TextBox();
            this.tbReadResultValue = new System.Windows.Forms.TextBox();
            this.tbReadRegistryPath = new System.Windows.Forms.TextBox();
            this.btnReadRegistry = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.group_create_registry = new System.Windows.Forms.GroupBox();
            this.cbTypeKeyValue = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.Label();
            this.txtKeyName = new System.Windows.Forms.Label();
            this.tbCreateValue = new System.Windows.Forms.TextBox();
            this.tbKeyName = new System.Windows.Forms.TextBox();
            this.tbCreateOrDelete = new System.Windows.Forms.TextBox();
            this.rbCreateValue = new System.Windows.Forms.RadioButton();
            this.rbCreateConteiner = new System.Windows.Forms.RadioButton();
            this.btnDeleteRegistry = new System.Windows.Forms.Button();
            this.btnCreateRegistry = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.EliminaresteBotton = new System.Windows.Forms.Button();
            this.tabPage5.SuspendLayout();
            this.groupReadRegistryValue.SuspendLayout();
            this.group_create_registry.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // l_name
            // 
            this.l_name.AutoSize = true;
            this.l_name.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_name.Location = new System.Drawing.Point(51, 100);
            this.l_name.Name = "l_name";
            this.l_name.Size = new System.Drawing.Size(549, 27);
            this.l_name.TabIndex = 0;
            this.l_name.Text = "No usar, hasta que vuelva a estar en una versión stable";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(617, 464);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(703, 393);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Backup Registros";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupReadRegistryValue);
            this.tabPage5.Controls.Add(this.group_create_registry);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(703, 393);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Regedit";
            this.tabPage5.UseVisualStyleBackColor = true;
            this.tabPage5.Click += new System.EventHandler(this.registryStartEvent);
            // 
            // groupReadRegistryValue
            // 
            this.groupReadRegistryValue.Controls.Add(this.label3);
            this.groupReadRegistryValue.Controls.Add(this.label2);
            this.groupReadRegistryValue.Controls.Add(this.tbReadKeyName);
            this.groupReadRegistryValue.Controls.Add(this.tbReadResultValue);
            this.groupReadRegistryValue.Controls.Add(this.tbReadRegistryPath);
            this.groupReadRegistryValue.Controls.Add(this.btnReadRegistry);
            this.groupReadRegistryValue.Controls.Add(this.label1);
            this.groupReadRegistryValue.Location = new System.Drawing.Point(27, 185);
            this.groupReadRegistryValue.Name = "groupReadRegistryValue";
            this.groupReadRegistryValue.Size = new System.Drawing.Size(653, 181);
            this.groupReadRegistryValue.TabIndex = 8;
            this.groupReadRegistryValue.TabStop = false;
            this.groupReadRegistryValue.Text = "Read Registry Value";
            this.groupReadRegistryValue.Enter += new System.EventHandler(this.groupReadRegistryValue_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Key Path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Key Name:";
            // 
            // tbReadKeyName
            // 
            this.tbReadKeyName.Location = new System.Drawing.Point(15, 96);
            this.tbReadKeyName.Name = "tbReadKeyName";
            this.tbReadKeyName.Size = new System.Drawing.Size(228, 20);
            this.tbReadKeyName.TabIndex = 8;
            // 
            // tbReadResultValue
            // 
            this.tbReadResultValue.Location = new System.Drawing.Point(276, 96);
            this.tbReadResultValue.Multiline = true;
            this.tbReadResultValue.Name = "tbReadResultValue";
            this.tbReadResultValue.Size = new System.Drawing.Size(368, 73);
            this.tbReadResultValue.TabIndex = 7;
            // 
            // tbReadRegistryPath
            // 
            this.tbReadRegistryPath.Location = new System.Drawing.Point(15, 42);
            this.tbReadRegistryPath.Name = "tbReadRegistryPath";
            this.tbReadRegistryPath.Size = new System.Drawing.Size(629, 20);
            this.tbReadRegistryPath.TabIndex = 6;
            // 
            // btnReadRegistry
            // 
            this.btnReadRegistry.Location = new System.Drawing.Point(89, 134);
            this.btnReadRegistry.Name = "btnReadRegistry";
            this.btnReadRegistry.Size = new System.Drawing.Size(75, 23);
            this.btnReadRegistry.TabIndex = 1;
            this.btnReadRegistry.Text = "Read";
            this.btnReadRegistry.UseVisualStyleBackColor = true;
            this.btnReadRegistry.Click += new System.EventHandler(this.btnReadRegistry_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Result:";
            // 
            // group_create_registry
            // 
            this.group_create_registry.Controls.Add(this.cbTypeKeyValue);
            this.group_create_registry.Controls.Add(this.label4);
            this.group_create_registry.Controls.Add(this.label5);
            this.group_create_registry.Controls.Add(this.l_name);
            this.group_create_registry.Controls.Add(this.txtValue);
            this.group_create_registry.Controls.Add(this.txtKeyName);
            this.group_create_registry.Controls.Add(this.tbCreateValue);
            this.group_create_registry.Controls.Add(this.tbKeyName);
            this.group_create_registry.Controls.Add(this.tbCreateOrDelete);
            this.group_create_registry.Controls.Add(this.rbCreateValue);
            this.group_create_registry.Controls.Add(this.rbCreateConteiner);
            this.group_create_registry.Controls.Add(this.btnDeleteRegistry);
            this.group_create_registry.Controls.Add(this.btnCreateRegistry);
            this.group_create_registry.Location = new System.Drawing.Point(27, 21);
            this.group_create_registry.Name = "group_create_registry";
            this.group_create_registry.Size = new System.Drawing.Size(653, 158);
            this.group_create_registry.TabIndex = 4;
            this.group_create_registry.TabStop = false;
            this.group_create_registry.Text = "Create  or delete Registry";
            // 
            // cbTypeKeyValue
            // 
            this.cbTypeKeyValue.DisplayMember = "1";
            this.cbTypeKeyValue.Items.AddRange(new object[] {
            "String Value",
            "Binarie Value",
            "DWORD (32bits) Value",
            "QWORD (64bits) Value",
            "Multi-String Value",
            "Expandable String"});
            this.cbTypeKeyValue.Location = new System.Drawing.Point(376, 75);
            this.cbTypeKeyValue.Name = "cbTypeKeyValue";
            this.cbTypeKeyValue.Size = new System.Drawing.Size(145, 21);
            this.cbTypeKeyValue.TabIndex = 9;
            this.cbTypeKeyValue.Text = "String Value";
            this.cbTypeKeyValue.Visible = false;
            this.cbTypeKeyValue.SelectedIndexChanged += new System.EventHandler(this.cbTypeKeyValue_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Key Path:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-5, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(661, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "Lea la documentación que se encuentra en el archivo README.md";
            // 
            // txtValue
            // 
            this.txtValue.AutoSize = true;
            this.txtValue.Location = new System.Drawing.Point(136, 103);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(37, 13);
            this.txtValue.TabIndex = 7;
            this.txtValue.Text = "Value:";
            this.txtValue.Visible = false;
            // 
            // txtKeyName
            // 
            this.txtKeyName.AutoSize = true;
            this.txtKeyName.Location = new System.Drawing.Point(114, 80);
            this.txtKeyName.Name = "txtKeyName";
            this.txtKeyName.Size = new System.Drawing.Size(59, 13);
            this.txtKeyName.TabIndex = 6;
            this.txtKeyName.Text = "Key Name:";
            // 
            // tbCreateValue
            // 
            this.tbCreateValue.Location = new System.Drawing.Point(179, 100);
            this.tbCreateValue.Multiline = true;
            this.tbCreateValue.Name = "tbCreateValue";
            this.tbCreateValue.Size = new System.Drawing.Size(342, 40);
            this.tbCreateValue.TabIndex = 5;
            // 
            // tbKeyName
            // 
            this.tbKeyName.Location = new System.Drawing.Point(179, 76);
            this.tbKeyName.Name = "tbKeyName";
            this.tbKeyName.Size = new System.Drawing.Size(191, 20);
            this.tbKeyName.TabIndex = 4;
            // 
            // tbCreateOrDelete
            // 
            this.tbCreateOrDelete.Location = new System.Drawing.Point(15, 43);
            this.tbCreateOrDelete.Name = "tbCreateOrDelete";
            this.tbCreateOrDelete.Size = new System.Drawing.Size(629, 20);
            this.tbCreateOrDelete.TabIndex = 3;
            // 
            // rbCreateValue
            // 
            this.rbCreateValue.AutoSize = true;
            this.rbCreateValue.Location = new System.Drawing.Point(15, 106);
            this.rbCreateValue.Name = "rbCreateValue";
            this.rbCreateValue.Size = new System.Drawing.Size(52, 17);
            this.rbCreateValue.TabIndex = 2;
            this.rbCreateValue.Text = "Value";
            this.rbCreateValue.UseVisualStyleBackColor = true;
            this.rbCreateValue.CheckedChanged += new System.EventHandler(this.rbCreateValue_CheckedChanged);
            // 
            // rbCreateConteiner
            // 
            this.rbCreateConteiner.AutoSize = true;
            this.rbCreateConteiner.Checked = true;
            this.rbCreateConteiner.Location = new System.Drawing.Point(15, 79);
            this.rbCreateConteiner.Name = "rbCreateConteiner";
            this.rbCreateConteiner.Size = new System.Drawing.Size(70, 17);
            this.rbCreateConteiner.TabIndex = 1;
            this.rbCreateConteiner.TabStop = true;
            this.rbCreateConteiner.Text = "Conteiner";
            this.rbCreateConteiner.UseVisualStyleBackColor = true;
            this.rbCreateConteiner.CheckedChanged += new System.EventHandler(this.rbCreateConteiner_CheckedChanged);
            // 
            // btnDeleteRegistry
            // 
            this.btnDeleteRegistry.Location = new System.Drawing.Point(552, 75);
            this.btnDeleteRegistry.Name = "btnDeleteRegistry";
            this.btnDeleteRegistry.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteRegistry.TabIndex = 2;
            this.btnDeleteRegistry.Text = "Delete";
            this.btnDeleteRegistry.UseVisualStyleBackColor = true;
            this.btnDeleteRegistry.Click += new System.EventHandler(this.btnDeleteRegistry_Click);
            // 
            // btnCreateRegistry
            // 
            this.btnCreateRegistry.Location = new System.Drawing.Point(552, 104);
            this.btnCreateRegistry.Name = "btnCreateRegistry";
            this.btnCreateRegistry.Size = new System.Drawing.Size(75, 23);
            this.btnCreateRegistry.TabIndex = 0;
            this.btnCreateRegistry.Text = "Create";
            this.btnCreateRegistry.UseVisualStyleBackColor = true;
            this.btnCreateRegistry.Click += new System.EventHandler(this.btnCreateRegistry_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(711, 419);
            this.tabControl1.TabIndex = 1;
            // 
            // EliminaresteBotton
            // 
            this.EliminaresteBotton.Location = new System.Drawing.Point(304, 10);
            this.EliminaresteBotton.Name = "EliminaresteBotton";
            this.EliminaresteBotton.Size = new System.Drawing.Size(75, 23);
            this.EliminaresteBotton.TabIndex = 3;
            this.EliminaresteBotton.Text = "boton debugeo";
            this.EliminaresteBotton.UseVisualStyleBackColor = true;
            this.EliminaresteBotton.Click += new System.EventHandler(this.EliminaresteBotton_Click);
            // 
            // f_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 498);
            this.Controls.Add(this.EliminaresteBotton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnExit);
            this.Name = "f_main";
            this.Text = "Form1";
            this.tabPage5.ResumeLayout(false);
            this.groupReadRegistryValue.ResumeLayout(false);
            this.groupReadRegistryValue.PerformLayout();
            this.group_create_registry.ResumeLayout(false);
            this.group_create_registry.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label l_name;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupReadRegistryValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbReadKeyName;
        private System.Windows.Forms.TextBox tbReadResultValue;
        private System.Windows.Forms.TextBox tbReadRegistryPath;
        private System.Windows.Forms.Button btnReadRegistry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox group_create_registry;
        private System.Windows.Forms.ComboBox cbTypeKeyValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtValue;
        private System.Windows.Forms.Label txtKeyName;
        private System.Windows.Forms.TextBox tbCreateValue;
        private System.Windows.Forms.TextBox tbKeyName;
        private System.Windows.Forms.TextBox tbCreateOrDelete;
        private System.Windows.Forms.RadioButton rbCreateValue;
        private System.Windows.Forms.RadioButton rbCreateConteiner;
        private System.Windows.Forms.Button btnDeleteRegistry;
        private System.Windows.Forms.Button btnCreateRegistry;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button EliminaresteBotton;
    }
}

