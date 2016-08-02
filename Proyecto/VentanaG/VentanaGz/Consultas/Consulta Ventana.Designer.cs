namespace VentanaGz
{
    partial class Consulta_Ventana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_Ventana));
            this.textBoxCampo = new System.Windows.Forms.TextBox();
            this.bottonBuscar = new System.Windows.Forms.Button();
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.dataGVentana = new System.Windows.Forms.DataGridView();
            this.comboBCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVentana)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCampo
            // 
            this.textBoxCampo.Location = new System.Drawing.Point(136, 47);
            this.textBoxCampo.Name = "textBoxCampo";
            this.textBoxCampo.Size = new System.Drawing.Size(100, 20);
            this.textBoxCampo.TabIndex = 0;
            // 
            // bottonBuscar
            // 
            this.bottonBuscar.Location = new System.Drawing.Point(280, 45);
            this.bottonBuscar.Name = "bottonBuscar";
            this.bottonBuscar.Size = new System.Drawing.Size(75, 23);
            this.bottonBuscar.TabIndex = 1;
            this.bottonBuscar.Text = "Buscar";
            this.bottonBuscar.UseVisualStyleBackColor = true;
            this.bottonBuscar.Click += new System.EventHandler(this.bottonBuscar_Click);
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.Location = new System.Drawing.Point(29, 317);
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(75, 23);
            this.buttonImprimir.TabIndex = 2;
            this.buttonImprimir.Text = "Imprimir";
            this.buttonImprimir.UseVisualStyleBackColor = true;
            this.buttonImprimir.Click += new System.EventHandler(this.buttonImprimir_Click);
            // 
            // dataGVentana
            // 
            this.dataGVentana.AllowUserToAddRows = false;
            this.dataGVentana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVentana.Location = new System.Drawing.Point(-4, 86);
            this.dataGVentana.Name = "dataGVentana";
            this.dataGVentana.ReadOnly = true;
            this.dataGVentana.Size = new System.Drawing.Size(659, 199);
            this.dataGVentana.TabIndex = 3;
            // 
            // comboBCliente
            // 
            this.comboBCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBCliente.FormattingEnabled = true;
            this.comboBCliente.Items.AddRange(new object[] {
            "Id",
            "Cedula",
            "Nombre"});
            this.comboBCliente.Location = new System.Drawing.Point(136, 12);
            this.comboBCliente.Name = "comboBCliente";
            this.comboBCliente.Size = new System.Drawing.Size(127, 21);
            this.comboBCliente.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cliente";
            // 
            // Consulta_Ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 374);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBCliente);
            this.Controls.Add(this.dataGVentana);
            this.Controls.Add(this.buttonImprimir);
            this.Controls.Add(this.bottonBuscar);
            this.Controls.Add(this.textBoxCampo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Consulta_Ventana";
            this.Text = "Consulta_Ventana";
            ((System.ComponentModel.ISupportInitialize)(this.dataGVentana)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCampo;
        private System.Windows.Forms.Button bottonBuscar;
        private System.Windows.Forms.Button buttonImprimir;
        private System.Windows.Forms.DataGridView dataGVentana;
        private System.Windows.Forms.ComboBox comboBCliente;
        private System.Windows.Forms.Label label1;
    }
}