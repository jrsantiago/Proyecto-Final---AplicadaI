namespace VentanaGz
{
    partial class VentanaGz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaGz));
            this.EntrarSesinbutton = new System.Windows.Forms.Button();
            this.textbUserName = new System.Windows.Forms.TextBox();
            this.textbContrasena = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EntrarSesinbutton
            // 
            this.EntrarSesinbutton.BackgroundImage = global::VentanaGz.Properties.Resources.images__2_;
            this.EntrarSesinbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EntrarSesinbutton.Image = global::VentanaGz.Properties.Resources.Arrow_Back_icon;
            this.EntrarSesinbutton.Location = new System.Drawing.Point(258, 140);
            this.EntrarSesinbutton.Name = "EntrarSesinbutton";
            this.EntrarSesinbutton.Size = new System.Drawing.Size(47, 40);
            this.EntrarSesinbutton.TabIndex = 0;
            this.EntrarSesinbutton.UseVisualStyleBackColor = true;
            this.EntrarSesinbutton.Click += new System.EventHandler(this.EntrarSesinbutton_Click);
            // 
            // textbUserName
            // 
            this.textbUserName.Location = new System.Drawing.Point(98, 113);
            this.textbUserName.Name = "textbUserName";
            this.textbUserName.Size = new System.Drawing.Size(118, 20);
            this.textbUserName.TabIndex = 1;
            // 
            // textbContrasena
            // 
            this.textbContrasena.Location = new System.Drawing.Point(98, 151);
            this.textbContrasena.Name = "textbContrasena";
            this.textbContrasena.PasswordChar = '*';
            this.textbContrasena.Size = new System.Drawing.Size(143, 20);
            this.textbContrasena.TabIndex = 2;
            this.textbContrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbContrasena_KeyPress);
            // 
            // VentanaGz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VentanaGz.Properties.Resources._2016_06_22_19_32_04;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(317, 379);
            this.Controls.Add(this.textbContrasena);
            this.Controls.Add(this.textbUserName);
            this.Controls.Add(this.EntrarSesinbutton);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VentanaGz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaGz";
            this.Load += new System.EventHandler(this.VentanaGz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EntrarSesinbutton;
        private System.Windows.Forms.TextBox textbUserName;
        private System.Windows.Forms.TextBox textbContrasena;
    }
}

