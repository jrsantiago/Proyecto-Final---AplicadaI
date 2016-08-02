namespace VentanaGz
{
    partial class ConsultaScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaScreen));
            this.comboBCliente = new System.Windows.Forms.ComboBox();
            this.dataGScreen = new System.Windows.Forms.DataGridView();
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.bottonBuscar = new System.Windows.Forms.Button();
            this.textBoxCampo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBCliente
            // 
            this.comboBCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBCliente.FormattingEnabled = true;
            this.comboBCliente.Items.AddRange(new object[] {
            "Id",
            "Cedula",
            "Nombre"});
            this.comboBCliente.Location = new System.Drawing.Point(144, 21);
            this.comboBCliente.Name = "comboBCliente";
            this.comboBCliente.Size = new System.Drawing.Size(127, 21);
            this.comboBCliente.TabIndex = 9;
            // 
            // dataGScreen
            // 
            this.dataGScreen.AllowUserToAddRows = false;
            this.dataGScreen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGScreen.Location = new System.Drawing.Point(-2, 95);
            this.dataGScreen.Name = "dataGScreen";
            this.dataGScreen.ReadOnly = true;
            this.dataGScreen.Size = new System.Drawing.Size(644, 214);
            this.dataGScreen.TabIndex = 8;
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.Location = new System.Drawing.Point(37, 326);
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(75, 23);
            this.buttonImprimir.TabIndex = 7;
            this.buttonImprimir.Text = "Imprimir";
            this.buttonImprimir.UseVisualStyleBackColor = true;
            this.buttonImprimir.Click += new System.EventHandler(this.buttonImprimir_Click);
            // 
            // bottonBuscar
            // 
            this.bottonBuscar.Location = new System.Drawing.Point(280, 50);
            this.bottonBuscar.Name = "bottonBuscar";
            this.bottonBuscar.Size = new System.Drawing.Size(75, 31);
            this.bottonBuscar.TabIndex = 6;
            this.bottonBuscar.Text = "Buscar";
            this.bottonBuscar.UseVisualStyleBackColor = true;
            this.bottonBuscar.Click += new System.EventHandler(this.bottonBuscar_Click);
            // 
            // textBoxCampo
            // 
            this.textBoxCampo.Location = new System.Drawing.Point(144, 56);
            this.textBoxCampo.Name = "textBoxCampo";
            this.textBoxCampo.Size = new System.Drawing.Size(100, 20);
            this.textBoxCampo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cliente";
            // 
            // ConsultaScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 362);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBCliente);
            this.Controls.Add(this.dataGScreen);
            this.Controls.Add(this.buttonImprimir);
            this.Controls.Add(this.bottonBuscar);
            this.Controls.Add(this.textBoxCampo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaScreen";
            this.Text = "ConsultaScreen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBCliente;
        private System.Windows.Forms.DataGridView dataGScreen;
        private System.Windows.Forms.Button buttonImprimir;
        private System.Windows.Forms.Button bottonBuscar;
        private System.Windows.Forms.TextBox textBoxCampo;
        private System.Windows.Forms.Label label1;
    }
}