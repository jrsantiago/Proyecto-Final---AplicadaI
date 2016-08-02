namespace VentanaGz
{
    partial class Ventana
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
            this.label6 = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.textBbuscar = new System.Windows.Forms.TextBox();
            this.comboBCliente = new System.Windows.Forms.ComboBox();
            this.textBancho = new System.Windows.Forms.TextBox();
            this.textBoxAltura = new System.Windows.Forms.TextBox();
            this.comboBcolor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridVentana = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBTipoMaterial = new System.Windows.Forms.ComboBox();
            this.Mostrar = new System.Windows.Forms.Button();
            this.buttoBuscarCliente = new System.Windows.Forms.Button();
            this.dateTimeVentana = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVentana)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Campo";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEliminar.BackgroundImage = global::VentanaGz.Properties.Resources.Misc_Delete_Database_icon;
            this.buttonEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonEliminar.Location = new System.Drawing.Point(534, 427);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 96);
            this.buttonEliminar.TabIndex = 10;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonActualizar.BackgroundImage = global::VentanaGz.Properties.Resources.Text_Edit_icon;
            this.buttonActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonActualizar.Location = new System.Drawing.Point(402, 427);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(75, 96);
            this.buttonActualizar.TabIndex = 9;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAgregar.BackgroundImage = global::VentanaGz.Properties.Resources.Misc_New_Database_icon;
            this.buttonAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAgregar.Location = new System.Drawing.Point(271, 427);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 96);
            this.buttonAgregar.TabIndex = 8;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // textBbuscar
            // 
            this.textBbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBbuscar.Location = new System.Drawing.Point(348, 41);
            this.textBbuscar.Name = "textBbuscar";
            this.textBbuscar.Size = new System.Drawing.Size(75, 20);
            this.textBbuscar.TabIndex = 2;
            this.textBbuscar.TextChanged += new System.EventHandler(this.textBbuscar_TextChanged);
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
            this.comboBCliente.Location = new System.Drawing.Point(321, 6);
            this.comboBCliente.Name = "comboBCliente";
            this.comboBCliente.Size = new System.Drawing.Size(128, 21);
            this.comboBCliente.TabIndex = 1;
            // 
            // textBancho
            // 
            this.textBancho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBancho.Location = new System.Drawing.Point(347, 90);
            this.textBancho.Name = "textBancho";
            this.textBancho.Size = new System.Drawing.Size(76, 20);
            this.textBancho.TabIndex = 4;
            // 
            // textBoxAltura
            // 
            this.textBoxAltura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAltura.Location = new System.Drawing.Point(347, 120);
            this.textBoxAltura.Name = "textBoxAltura";
            this.textBoxAltura.Size = new System.Drawing.Size(76, 20);
            this.textBoxAltura.TabIndex = 5;
            // 
            // comboBcolor
            // 
            this.comboBcolor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBcolor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBcolor.FormattingEnabled = true;
            this.comboBcolor.Items.AddRange(new object[] {
            "Blanco",
            "Negro"});
            this.comboBcolor.Location = new System.Drawing.Point(347, 146);
            this.comboBcolor.Name = "comboBcolor";
            this.comboBcolor.Size = new System.Drawing.Size(102, 21);
            this.comboBcolor.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Ancho";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Altura";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Color";
            // 
            // dataGridVentana
            // 
            this.dataGridVentana.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridVentana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVentana.Location = new System.Drawing.Point(3, 239);
            this.dataGridVentana.Name = "dataGridVentana";
            this.dataGridVentana.Size = new System.Drawing.Size(823, 171);
            this.dataGridVentana.TabIndex = 35;
            this.dataGridVentana.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVentana_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Campo Cliente";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "TipoMaterial";
            // 
            // comboBTipoMaterial
            // 
            this.comboBTipoMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBTipoMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBTipoMaterial.FormattingEnabled = true;
            this.comboBTipoMaterial.Items.AddRange(new object[] {
            "Doble A",
            "Doble A Superior"});
            this.comboBTipoMaterial.Location = new System.Drawing.Point(347, 173);
            this.comboBTipoMaterial.Name = "comboBTipoMaterial";
            this.comboBTipoMaterial.Size = new System.Drawing.Size(145, 21);
            this.comboBTipoMaterial.TabIndex = 7;
            // 
            // Mostrar
            // 
            this.Mostrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Mostrar.Location = new System.Drawing.Point(608, 198);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Size = new System.Drawing.Size(81, 34);
            this.Mostrar.TabIndex = 11;
            this.Mostrar.Text = "Refrescar";
            this.Mostrar.UseVisualStyleBackColor = true;
            this.Mostrar.Click += new System.EventHandler(this.Mostrar_Click);
            // 
            // buttoBuscarCliente
            // 
            this.buttoBuscarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttoBuscarCliente.Location = new System.Drawing.Point(510, 31);
            this.buttoBuscarCliente.Name = "buttoBuscarCliente";
            this.buttoBuscarCliente.Size = new System.Drawing.Size(71, 30);
            this.buttoBuscarCliente.TabIndex = 3;
            this.buttoBuscarCliente.Text = "Buscar";
            this.buttoBuscarCliente.UseVisualStyleBackColor = true;
            this.buttoBuscarCliente.Click += new System.EventHandler(this.buttoBuscarCliente_Click);
            // 
            // dateTimeVentana
            // 
            this.dateTimeVentana.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeVentana.Location = new System.Drawing.Point(347, 209);
            this.dateTimeVentana.Name = "dateTimeVentana";
            this.dateTimeVentana.Size = new System.Drawing.Size(197, 20);
            this.dateTimeVentana.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(251, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Fecha";
            // 
            // Ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VentanaGz.Properties.Resources.lounge_pz_k33za000_kb_lounge_blanco_25x70_1_hd_b_b;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(830, 535);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimeVentana);
            this.Controls.Add(this.Mostrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBTipoMaterial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridVentana);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBcolor);
            this.Controls.Add(this.textBoxAltura);
            this.Controls.Add(this.textBancho);
            this.Controls.Add(this.comboBCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.buttoBuscarCliente);
            this.Controls.Add(this.textBbuscar);
            this.Name = "Ventana";
            this.Text = "Ventana";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVentana)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.TextBox textBbuscar;
        private System.Windows.Forms.ComboBox comboBCliente;
        private System.Windows.Forms.TextBox textBancho;
        private System.Windows.Forms.TextBox textBoxAltura;
        private System.Windows.Forms.ComboBox comboBcolor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridVentana;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBTipoMaterial;
        private System.Windows.Forms.Button Mostrar;
        private System.Windows.Forms.Button buttoBuscarCliente;
        private System.Windows.Forms.DateTimePicker dateTimeVentana;
        private System.Windows.Forms.Label label7;
    }
}