namespace VentanaGz
{
    partial class Loging
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loging));
            this.textbContrasena = new System.Windows.Forms.TextBox();
            this.textbUserName = new System.Windows.Forms.TextBox();
            this.EntrarSesinbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textbContrasena
            // 
            this.textbContrasena.Location = new System.Drawing.Point(99, 138);
            this.textbContrasena.Name = "textbContrasena";
            this.textbContrasena.PasswordChar = '*';
            this.textbContrasena.Size = new System.Drawing.Size(143, 20);
            this.textbContrasena.TabIndex = 5;
            this.textbContrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbContrasena_KeyPress);
            // 
            // textbUserName
            // 
            this.textbUserName.Location = new System.Drawing.Point(99, 100);
            this.textbUserName.Name = "textbUserName";
            this.textbUserName.Size = new System.Drawing.Size(118, 20);
            this.textbUserName.TabIndex = 4;
            // 
            // EntrarSesinbutton
            // 
            this.EntrarSesinbutton.BackgroundImage = global::VentanaGz.Properties.Resources.images__2_;
            this.EntrarSesinbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EntrarSesinbutton.Image = global::VentanaGz.Properties.Resources.Arrow_Back_icon;
            this.EntrarSesinbutton.Location = new System.Drawing.Point(259, 127);
            this.EntrarSesinbutton.Name = "EntrarSesinbutton";
            this.EntrarSesinbutton.Size = new System.Drawing.Size(47, 40);
            this.EntrarSesinbutton.TabIndex = 3;
            this.EntrarSesinbutton.UseVisualStyleBackColor = true;
            this.EntrarSesinbutton.Click += new System.EventHandler(this.EntrarSesinbutton_Click);
            // 
            // Loging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::VentanaGz.Properties.Resources._2016_06_22_19_32_04;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(316, 356);
            this.Controls.Add(this.textbContrasena);
            this.Controls.Add(this.textbUserName);
            this.Controls.Add(this.EntrarSesinbutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Loging";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loging";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbContrasena;
        private System.Windows.Forms.TextBox textbUserName;
        private System.Windows.Forms.Button EntrarSesinbutton;
    }
}