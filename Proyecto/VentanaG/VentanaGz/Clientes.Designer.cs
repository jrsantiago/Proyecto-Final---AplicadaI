namespace VentanaGz
{
    partial class Clientes
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBTelefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBNombre = new System.Windows.Forms.TextBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttoBuscarUsuario = new System.Windows.Forms.Button();
            this.textBbuscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maskeBcedula = new System.Windows.Forms.MaskedTextBox();
            this.textBDireccion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cedula";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Telefono";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBTelefono
            // 
            this.textBTelefono.Location = new System.Drawing.Point(167, 114);
            this.textBTelefono.Name = "textBTelefono";
            this.textBTelefono.Size = new System.Drawing.Size(138, 20);
            this.textBTelefono.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre";
            // 
            // textBNombre
            // 
            this.textBNombre.Location = new System.Drawing.Point(167, 88);
            this.textBNombre.Name = "textBNombre";
            this.textBNombre.Size = new System.Drawing.Size(138, 20);
            this.textBNombre.TabIndex = 3;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Image = global::VentanaGz.Properties.Resources.Misc_Delete_Database_icon;
            this.buttonEliminar.Location = new System.Drawing.Point(299, 262);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(77, 92);
            this.buttonEliminar.TabIndex = 10;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Image = global::VentanaGz.Properties.Resources.Text_Edit_icon;
            this.buttonActualizar.Location = new System.Drawing.Point(167, 262);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(81, 92);
            this.buttonActualizar.TabIndex = 9;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Image = global::VentanaGz.Properties.Resources.Misc_New_Database_icon;
            this.buttonAgregar.Location = new System.Drawing.Point(36, 262);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(80, 92);
            this.buttonAgregar.TabIndex = 8;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttoBuscarUsuario
            // 
            this.buttoBuscarUsuario.Location = new System.Drawing.Point(272, 41);
            this.buttoBuscarUsuario.Name = "buttoBuscarUsuario";
            this.buttoBuscarUsuario.Size = new System.Drawing.Size(71, 30);
            this.buttoBuscarUsuario.TabIndex = 2;
            this.buttoBuscarUsuario.Text = "Buscar";
            this.buttoBuscarUsuario.UseVisualStyleBackColor = true;
            this.buttoBuscarUsuario.Click += new System.EventHandler(this.buttoBuscarUsuario_Click);
            // 
            // textBbuscar
            // 
            this.textBbuscar.Location = new System.Drawing.Point(167, 47);
            this.textBbuscar.Name = "textBbuscar";
            this.textBbuscar.Size = new System.Drawing.Size(73, 20);
            this.textBbuscar.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(167, 204);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(138, 20);
            this.textBoxEmail.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Id";
            // 
            // maskeBcedula
            // 
            this.maskeBcedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskeBcedula.Location = new System.Drawing.Point(167, 147);
            this.maskeBcedula.Mask = "999-9999999-9";
            this.maskeBcedula.Name = "maskeBcedula";
            this.maskeBcedula.Size = new System.Drawing.Size(94, 22);
            this.maskeBcedula.TabIndex = 5;
            // 
            // textBDireccion
            // 
            this.textBDireccion.Location = new System.Drawing.Point(167, 175);
            this.textBDireccion.Name = "textBDireccion";
            this.textBDireccion.Size = new System.Drawing.Size(138, 20);
            this.textBDireccion.TabIndex = 6;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VentanaGz.Properties.Resources.lounge_pz_k33za000_kb_lounge_blanco_25x70_1_hd_b_b;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(428, 381);
            this.Controls.Add(this.textBDireccion);
            this.Controls.Add(this.maskeBcedula);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttoBuscarUsuario);
            this.Controls.Add(this.textBbuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBTelefono);
            this.Controls.Add(this.textBNombre);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBTelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBNombre;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttoBuscarUsuario;
        private System.Windows.Forms.TextBox textBbuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskeBcedula;
        private System.Windows.Forms.TextBox textBDireccion;
    }
}