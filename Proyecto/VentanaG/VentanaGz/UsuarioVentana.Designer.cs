namespace VentanaGz
{
    partial class UsuarioVentana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioVentana));
            this.textBbuscarUsuario = new System.Windows.Forms.TextBox();
            this.buttoBuscarUsuario = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBContra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBUserName = new System.Windows.Forms.TextBox();
            this.radioButtoFeme = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtoMascu = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioBuAdministrador = new System.Windows.Forms.RadioButton();
            this.radioButtAsociado = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBbuscarUsuario
            // 
            this.textBbuscarUsuario.Location = new System.Drawing.Point(204, 39);
            this.textBbuscarUsuario.Name = "textBbuscarUsuario";
            this.textBbuscarUsuario.Size = new System.Drawing.Size(138, 20);
            this.textBbuscarUsuario.TabIndex = 0;
            // 
            // buttoBuscarUsuario
            // 
            this.buttoBuscarUsuario.Location = new System.Drawing.Point(373, 33);
            this.buttoBuscarUsuario.Name = "buttoBuscarUsuario";
            this.buttoBuscarUsuario.Size = new System.Drawing.Size(71, 30);
            this.buttoBuscarUsuario.TabIndex = 1;
            this.buttoBuscarUsuario.Text = "Buscar";
            this.buttoBuscarUsuario.UseVisualStyleBackColor = true;
            this.buttoBuscarUsuario.Click += new System.EventHandler(this.buttoBuscarUsuario_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Image = global::VentanaGz.Properties.Resources.Misc_New_Database_icon;
            this.buttonAgregar.Location = new System.Drawing.Point(73, 258);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 94);
            this.buttonAgregar.TabIndex = 8;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Image = global::VentanaGz.Properties.Resources.Text_Edit_icon;
            this.buttonActualizar.Location = new System.Drawing.Point(204, 258);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(75, 94);
            this.buttonActualizar.TabIndex = 9;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Image = global::VentanaGz.Properties.Resources.Misc_Delete_Database_icon;
            this.buttonEliminar.Location = new System.Drawing.Point(347, 258);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 94);
            this.buttonEliminar.TabIndex = 10;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Contraseña";
            // 
            // textBContra
            // 
            this.textBContra.Location = new System.Drawing.Point(204, 194);
            this.textBContra.Name = "textBContra";
            this.textBContra.Size = new System.Drawing.Size(138, 20);
            this.textBContra.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nombre de Usuario";
            // 
            // textBUserName
            // 
            this.textBUserName.Location = new System.Drawing.Point(204, 168);
            this.textBUserName.Name = "textBUserName";
            this.textBUserName.Size = new System.Drawing.Size(138, 20);
            this.textBUserName.TabIndex = 6;
            // 
            // radioButtoFeme
            // 
            this.radioButtoFeme.AutoSize = true;
            this.radioButtoFeme.Location = new System.Drawing.Point(271, 145);
            this.radioButtoFeme.Name = "radioButtoFeme";
            this.radioButtoFeme.Size = new System.Drawing.Size(71, 17);
            this.radioButtoFeme.TabIndex = 5;
            this.radioButtoFeme.TabStop = true;
            this.radioButtoFeme.Text = "Femenin..";
            this.radioButtoFeme.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Sexo";
            // 
            // radioButtoMascu
            // 
            this.radioButtoMascu.AutoSize = true;
            this.radioButtoMascu.Location = new System.Drawing.Point(204, 145);
            this.radioButtoMascu.Name = "radioButtoMascu";
            this.radioButtoMascu.Size = new System.Drawing.Size(67, 17);
            this.radioButtoMascu.TabIndex = 4;
            this.radioButtoMascu.TabStop = true;
            this.radioButtoMascu.Text = "Masculi..";
            this.radioButtoMascu.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Apellido";
            // 
            // textBApellido
            // 
            this.textBApellido.Location = new System.Drawing.Point(204, 113);
            this.textBApellido.Name = "textBApellido";
            this.textBApellido.Size = new System.Drawing.Size(138, 20);
            this.textBApellido.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre";
            // 
            // textBNombre
            // 
            this.textBNombre.Location = new System.Drawing.Point(204, 87);
            this.textBNombre.Name = "textBNombre";
            this.textBNombre.Size = new System.Drawing.Size(138, 20);
            this.textBNombre.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Id";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // radioBuAdministrador
            // 
            this.radioBuAdministrador.AutoSize = true;
            this.radioBuAdministrador.Location = new System.Drawing.Point(204, 221);
            this.radioBuAdministrador.Name = "radioBuAdministrador";
            this.radioBuAdministrador.Size = new System.Drawing.Size(88, 17);
            this.radioBuAdministrador.TabIndex = 17;
            this.radioBuAdministrador.TabStop = true;
            this.radioBuAdministrador.Text = "Administrador";
            this.radioBuAdministrador.UseVisualStyleBackColor = true;
            // 
            // radioButtAsociado
            // 
            this.radioButtAsociado.AutoSize = true;
            this.radioButtAsociado.Location = new System.Drawing.Point(298, 220);
            this.radioButtAsociado.Name = "radioButtAsociado";
            this.radioButtAsociado.Size = new System.Drawing.Size(69, 17);
            this.radioButtAsociado.TabIndex = 18;
            this.radioButtAsociado.TabStop = true;
            this.radioButtAsociado.Text = "Asociado";
            this.radioButtAsociado.UseVisualStyleBackColor = true;
            // 
            // UsuarioVentana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VentanaGz.Properties.Resources.lounge_pz_k33za000_kb_lounge_blanco_25x70_1_hd_b_b;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(486, 375);
            this.Controls.Add(this.radioButtAsociado);
            this.Controls.Add(this.radioBuAdministrador);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBContra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.textBUserName);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.radioButtoFeme);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttoBuscarUsuario);
            this.Controls.Add(this.radioButtoMascu);
            this.Controls.Add(this.textBbuscarUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBNombre);
            this.Controls.Add(this.textBApellido);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UsuarioVentana";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.UsuarioVentana_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBbuscarUsuario;
        private System.Windows.Forms.Button buttoBuscarUsuario;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBContra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBUserName;
        private System.Windows.Forms.RadioButton radioButtoFeme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtoMascu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioBuAdministrador;
        private System.Windows.Forms.RadioButton radioButtAsociado;
    }
}