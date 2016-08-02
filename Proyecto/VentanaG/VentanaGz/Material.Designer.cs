namespace VentanaGz
{
    partial class Material
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
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridMateriales = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBdescripcion = new System.Windows.Forms.ComboBox();
            this.textBoxUnidad = new System.Windows.Forms.TextBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.textBCantiPie = new System.Windows.Forms.TextBox();
            this.textBPrecio = new System.Windows.Forms.TextBox();
            this.textBbuscar = new System.Windows.Forms.TextBox();
            this.buttoBuscarMaterial = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMateriales)).BeginInit();
            this.SuspendLayout();
            // 
            // Mostrar
            // 
            this.Mostrar.Location = new System.Drawing.Point(293, 126);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Size = new System.Drawing.Size(102, 40);
            this.Mostrar.TabIndex = 50;
            this.Mostrar.Text = "Mostrar";
            this.Mostrar.UseVisualStyleBackColor = true;
            this.Mostrar.Click += new System.EventHandler(this.Mostrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Precio";
            // 
            // dataGridMateriales
            // 
            this.dataGridMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMateriales.Location = new System.Drawing.Point(12, 172);
            this.dataGridMateriales.Name = "dataGridMateriales";
            this.dataGridMateriales.Size = new System.Drawing.Size(543, 124);
            this.dataGridMateriales.TabIndex = 55;
            this.dataGridMateriales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMateriales_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Cantidad Pie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Unidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Descripcion";
            // 
            // comboBdescripcion
            // 
            this.comboBdescripcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBdescripcion.Items.AddRange(new object[] {
            "Cabezal",
            "Alfecia",
            "Jamba",
            "Celocia",
            "Mordura Screen",
            "Tela Screen",
            "Sogra Screen"});
            this.comboBdescripcion.Location = new System.Drawing.Point(148, 44);
            this.comboBdescripcion.Name = "comboBdescripcion";
            this.comboBdescripcion.Size = new System.Drawing.Size(128, 21);
            this.comboBdescripcion.TabIndex = 45;
            // 
            // textBoxUnidad
            // 
            this.textBoxUnidad.Location = new System.Drawing.Point(148, 72);
            this.textBoxUnidad.Name = "textBoxUnidad";
            this.textBoxUnidad.Size = new System.Drawing.Size(48, 20);
            this.textBoxUnidad.TabIndex = 44;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Image = global::VentanaGz.Properties.Resources.Misc_Delete_Database_icon;
            this.buttonEliminar.Location = new System.Drawing.Point(355, 302);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(78, 93);
            this.buttonEliminar.TabIndex = 49;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Image = global::VentanaGz.Properties.Resources.Text_Edit_icon;
            this.buttonActualizar.Location = new System.Drawing.Point(223, 302);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(75, 93);
            this.buttonActualizar.TabIndex = 48;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Image = global::VentanaGz.Properties.Resources.Misc_New_Database_icon;
            this.buttonAgregar.Location = new System.Drawing.Point(92, 302);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(76, 93);
            this.buttonAgregar.TabIndex = 47;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // textBCantiPie
            // 
            this.textBCantiPie.Location = new System.Drawing.Point(148, 103);
            this.textBCantiPie.Name = "textBCantiPie";
            this.textBCantiPie.Size = new System.Drawing.Size(89, 20);
            this.textBCantiPie.TabIndex = 58;
            // 
            // textBPrecio
            // 
            this.textBPrecio.Location = new System.Drawing.Point(147, 132);
            this.textBPrecio.Name = "textBPrecio";
            this.textBPrecio.Size = new System.Drawing.Size(90, 20);
            this.textBPrecio.TabIndex = 59;
            // 
            // textBbuscar
            // 
            this.textBbuscar.Location = new System.Drawing.Point(148, 12);
            this.textBbuscar.Name = "textBbuscar";
            this.textBbuscar.Size = new System.Drawing.Size(75, 20);
            this.textBbuscar.TabIndex = 41;
            this.textBbuscar.Visible = false;
            // 
            // buttoBuscarMaterial
            // 
            this.buttoBuscarMaterial.Location = new System.Drawing.Point(293, 6);
            this.buttoBuscarMaterial.Name = "buttoBuscarMaterial";
            this.buttoBuscarMaterial.Size = new System.Drawing.Size(71, 30);
            this.buttoBuscarMaterial.TabIndex = 42;
            this.buttoBuscarMaterial.Text = "Buscar";
            this.buttoBuscarMaterial.UseVisualStyleBackColor = true;
            this.buttoBuscarMaterial.Visible = false;
            this.buttoBuscarMaterial.Click += new System.EventHandler(this.buttoBuscarMaterial_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Id";
            this.label6.Visible = false;
            // 
            // Material
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 402);
            this.Controls.Add(this.textBPrecio);
            this.Controls.Add(this.textBCantiPie);
            this.Controls.Add(this.Mostrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridMateriales);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBdescripcion);
            this.Controls.Add(this.textBoxUnidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.buttoBuscarMaterial);
            this.Controls.Add(this.textBbuscar);
            this.Name = "Material";
            this.Text = "Materiales";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMateriales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Mostrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridMateriales;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBdescripcion;
        private System.Windows.Forms.TextBox textBoxUnidad;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.TextBox textBCantiPie;
        private System.Windows.Forms.TextBox textBPrecio;
        private System.Windows.Forms.TextBox textBbuscar;
        private System.Windows.Forms.Button buttoBuscarMaterial;
        private System.Windows.Forms.Label label6;
    }
}