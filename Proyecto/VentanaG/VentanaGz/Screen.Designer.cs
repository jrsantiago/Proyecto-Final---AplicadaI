namespace VentanaGz
{
    partial class Screen
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
            this.Mostrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridScreen = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAltura = new System.Windows.Forms.TextBox();
            this.textBancho = new System.Windows.Forms.TextBox();
            this.comboBCliente = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttoBuscarCliente = new System.Windows.Forms.Button();
            this.textBbuscar = new System.Windows.Forms.TextBox();
            this.dateTimeScreen = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // Mostrar
            // 
            this.Mostrar.Location = new System.Drawing.Point(477, 147);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Size = new System.Drawing.Size(75, 40);
            this.Mostrar.TabIndex = 50;
            this.Mostrar.Text = "Mostrar";
            this.Mostrar.UseVisualStyleBackColor = true;
            this.Mostrar.Click += new System.EventHandler(this.Mostrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Cliente";
            // 
            // dataGridScreen
            // 
            this.dataGridScreen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridScreen.Location = new System.Drawing.Point(2, 193);
            this.dataGridScreen.Name = "dataGridScreen";
            this.dataGridScreen.Size = new System.Drawing.Size(637, 158);
            this.dataGridScreen.TabIndex = 55;
            this.dataGridScreen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridScreen_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Altura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Ancho";
            // 
            // textBoxAltura
            // 
            this.textBoxAltura.Location = new System.Drawing.Point(315, 127);
            this.textBoxAltura.Name = "textBoxAltura";
            this.textBoxAltura.Size = new System.Drawing.Size(76, 20);
            this.textBoxAltura.TabIndex = 44;
            // 
            // textBancho
            // 
            this.textBancho.Location = new System.Drawing.Point(315, 97);
            this.textBancho.Name = "textBancho";
            this.textBancho.Size = new System.Drawing.Size(76, 20);
            this.textBancho.TabIndex = 43;
            // 
            // comboBCliente
            // 
            this.comboBCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBCliente.FormattingEnabled = true;
            this.comboBCliente.ItemHeight = 13;
            this.comboBCliente.Items.AddRange(new object[] {
            "Nombre",
            "Cedula",
            "Id"});
            this.comboBCliente.Location = new System.Drawing.Point(315, 16);
            this.comboBCliente.Name = "comboBCliente";
            this.comboBCliente.Size = new System.Drawing.Size(128, 21);
            this.comboBCliente.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Campo";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackgroundImage = global::VentanaGz.Properties.Resources.Misc_Delete_Database_icon;
            this.buttonEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonEliminar.Location = new System.Drawing.Point(420, 357);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 95);
            this.buttonEliminar.TabIndex = 49;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.BackgroundImage = global::VentanaGz.Properties.Resources.Text_Edit_icon;
            this.buttonActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonActualizar.Location = new System.Drawing.Point(288, 357);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(78, 95);
            this.buttonActualizar.TabIndex = 48;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Image = global::VentanaGz.Properties.Resources.Misc_New_Database_icon;
            this.buttonAgregar.Location = new System.Drawing.Point(157, 357);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(77, 95);
            this.buttonAgregar.TabIndex = 47;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttoBuscarCliente
            // 
            this.buttoBuscarCliente.Location = new System.Drawing.Point(477, 41);
            this.buttoBuscarCliente.Name = "buttoBuscarCliente";
            this.buttoBuscarCliente.Size = new System.Drawing.Size(71, 30);
            this.buttoBuscarCliente.TabIndex = 42;
            this.buttoBuscarCliente.Text = "Buscar";
            this.buttoBuscarCliente.UseVisualStyleBackColor = true;
            this.buttoBuscarCliente.Click += new System.EventHandler(this.buttoBuscarCliente_Click);
            // 
            // textBbuscar
            // 
            this.textBbuscar.Location = new System.Drawing.Point(315, 51);
            this.textBbuscar.Name = "textBbuscar";
            this.textBbuscar.Size = new System.Drawing.Size(75, 20);
            this.textBbuscar.TabIndex = 41;
            // 
            // dateTimeScreen
            // 
            this.dateTimeScreen.CustomFormat = "d/M/y";
            this.dateTimeScreen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeScreen.Location = new System.Drawing.Point(315, 167);
            this.dateTimeScreen.MinDate = new System.DateTime(2016, 7, 29, 0, 0, 0, 0);
            this.dateTimeScreen.Name = "dateTimeScreen";
            this.dateTimeScreen.Size = new System.Drawing.Size(108, 20);
            this.dateTimeScreen.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Fecha";
            // 
            // Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VentanaGz.Properties.Resources.lounge_pz_k33za000_kb_lounge_blanco_25x70_1_hd_b_b;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(644, 455);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimeScreen);
            this.Controls.Add(this.Mostrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridScreen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAltura);
            this.Controls.Add(this.textBancho);
            this.Controls.Add(this.comboBCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.buttoBuscarCliente);
            this.Controls.Add(this.textBbuscar);
            this.Name = "Screen";
            this.Text = "Screen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Mostrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridScreen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAltura;
        private System.Windows.Forms.TextBox textBancho;
        private System.Windows.Forms.ComboBox comboBCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttoBuscarCliente;
        private System.Windows.Forms.TextBox textBbuscar;
        private System.Windows.Forms.DateTimePicker dateTimeScreen;
        private System.Windows.Forms.Label label5;
    }
}