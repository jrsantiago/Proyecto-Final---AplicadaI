namespace VentanaGz
{
    partial class ConsultaCiente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaCiente));
            this.textBCampos = new System.Windows.Forms.TextBox();
            this.dataGridCliente = new System.Windows.Forms.DataGridView();
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBCampo = new System.Windows.Forms.ComboBox();
            this.buttonEntrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // textBCampos
            // 
            this.textBCampos.Location = new System.Drawing.Point(211, 38);
            this.textBCampos.Name = "textBCampos";
            this.textBCampos.Size = new System.Drawing.Size(128, 20);
            this.textBCampos.TabIndex = 1;
            // 
            // dataGridCliente
            // 
            this.dataGridCliente.AllowUserToAddRows = false;
            this.dataGridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCliente.Location = new System.Drawing.Point(32, 87);
            this.dataGridCliente.Name = "dataGridCliente";
            this.dataGridCliente.ReadOnly = true;
            this.dataGridCliente.Size = new System.Drawing.Size(493, 214);
            this.dataGridCliente.TabIndex = 4;
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.Location = new System.Drawing.Point(32, 316);
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(75, 23);
            this.buttonImprimir.TabIndex = 5;
            this.buttonImprimir.Text = "Imprimir";
            this.buttonImprimir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Campo";
            // 
            // comboBCampo
            // 
            this.comboBCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBCampo.FormattingEnabled = true;
            this.comboBCampo.Items.AddRange(new object[] {
            "Id",
            "Nombre",
            "Cedula"});
            this.comboBCampo.Location = new System.Drawing.Point(211, 9);
            this.comboBCampo.Name = "comboBCampo";
            this.comboBCampo.Size = new System.Drawing.Size(128, 21);
            this.comboBCampo.TabIndex = 0;
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.Location = new System.Drawing.Point(359, 36);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(75, 23);
            this.buttonEntrar.TabIndex = 3;
            this.buttonEntrar.Text = "Entrar";
            this.buttonEntrar.UseVisualStyleBackColor = true;
            this.buttonEntrar.Click += new System.EventHandler(this.buttonEntrar_Click);
            // 
            // ConsultaCiente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 351);
            this.Controls.Add(this.comboBCampo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonImprimir);
            this.Controls.Add(this.dataGridCliente);
            this.Controls.Add(this.buttonEntrar);
            this.Controls.Add(this.textBCampos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaCiente";
            this.Text = "Consulta Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBCampos;
        private System.Windows.Forms.DataGridView dataGridCliente;
        private System.Windows.Forms.Button buttonImprimir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBCampo;
        private System.Windows.Forms.Button buttonEntrar;
    }
}