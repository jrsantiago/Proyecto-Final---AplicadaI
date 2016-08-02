namespace VentanaGz
{
    partial class ConsultaMateriales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaMateriales));
            this.dataGriMateriales = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGriMateriales)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGriMateriales
            // 
            this.dataGriMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGriMateriales.Location = new System.Drawing.Point(12, 80);
            this.dataGriMateriales.Name = "dataGriMateriales";
            this.dataGriMateriales.Size = new System.Drawing.Size(512, 210);
            this.dataGriMateriales.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "Imprimir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ConsultaMateriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 325);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGriMateriales);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaMateriales";
            this.Text = "ConsultaMateriales";
            this.Load += new System.EventHandler(this.ConsultaMateriales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGriMateriales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGriMateriales;
        private System.Windows.Forms.Button button2;
    }
}