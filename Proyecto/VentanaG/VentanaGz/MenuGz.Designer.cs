namespace VentanaGz
{
    partial class MenuGz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuGz));
            this.PrincipalmenuStrip = new System.Windows.Forms.MenuStrip();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.screenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.materialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.screenToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.materialesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PrincipalmenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrincipalmenuStrip
            // 
            this.PrincipalmenuStrip.BackColor = System.Drawing.Color.CornflowerBlue;
            this.PrincipalmenuStrip.BackgroundImage = global::VentanaGz.Properties.Resources.Blue_Widescreen_Background_1920x1200;
            this.PrincipalmenuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PrincipalmenuStrip.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrincipalmenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.toolStripMenuItem1});
            this.PrincipalmenuStrip.Location = new System.Drawing.Point(0, 0);
            this.PrincipalmenuStrip.Name = "PrincipalmenuStrip";
            this.PrincipalmenuStrip.Size = new System.Drawing.Size(573, 28);
            this.PrincipalmenuStrip.TabIndex = 0;
            this.PrincipalmenuStrip.Text = "menuStrip1";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem,
            this.actualizarToolStripMenuItem,
            this.screenToolStripMenuItem1,
            this.nuevoUsuarioToolStripMenuItem,
            this.materialesToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.usuarioToolStripMenuItem.Text = "Registros";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // nuevoUsuarioToolStripMenuItem
            // 
            this.nuevoUsuarioToolStripMenuItem.Name = "nuevoUsuarioToolStripMenuItem";
            this.nuevoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.nuevoUsuarioToolStripMenuItem.Text = "Usuario";
            this.nuevoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.nuevoUsuarioToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.eliminarToolStripMenuItem.Text = "Cliente";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.actualizarToolStripMenuItem.Text = "Ventana";
            this.actualizarToolStripMenuItem.Click += new System.EventHandler(this.actualizarToolStripMenuItem_Click);
            // 
            // screenToolStripMenuItem1
            // 
            this.screenToolStripMenuItem1.Name = "screenToolStripMenuItem1";
            this.screenToolStripMenuItem1.Size = new System.Drawing.Size(152, 24);
            this.screenToolStripMenuItem1.Text = "Screen";
            this.screenToolStripMenuItem1.Click += new System.EventHandler(this.screenToolStripMenuItem1_Click);
            // 
            // materialesToolStripMenuItem
            // 
            this.materialesToolStripMenuItem.Name = "materialesToolStripMenuItem";
            this.materialesToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.materialesToolStripMenuItem.Text = "Materiales";
            this.materialesToolStripMenuItem.Click += new System.EventHandler(this.materialesToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem1,
            this.ventanaToolStripMenuItem,
            this.screenToolStripMenuItem2,
            this.usuariosToolStripMenuItem,
            this.materialesToolStripMenuItem1});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(152, 24);
            this.clienteToolStripMenuItem1.Text = "Cliente";
            this.clienteToolStripMenuItem1.Click += new System.EventHandler(this.clienteToolStripMenuItem1_Click);
            // 
            // ventanaToolStripMenuItem
            // 
            this.ventanaToolStripMenuItem.Name = "ventanaToolStripMenuItem";
            this.ventanaToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.ventanaToolStripMenuItem.Text = "Ventana";
            this.ventanaToolStripMenuItem.Click += new System.EventHandler(this.ventanaToolStripMenuItem_Click);
            // 
            // screenToolStripMenuItem2
            // 
            this.screenToolStripMenuItem2.Name = "screenToolStripMenuItem2";
            this.screenToolStripMenuItem2.Size = new System.Drawing.Size(152, 24);
            this.screenToolStripMenuItem2.Text = "Screen";
            this.screenToolStripMenuItem2.Click += new System.EventHandler(this.screenToolStripMenuItem2_Click);
            // 
            // materialesToolStripMenuItem1
            // 
            this.materialesToolStripMenuItem1.Name = "materialesToolStripMenuItem1";
            this.materialesToolStripMenuItem1.Size = new System.Drawing.Size(152, 24);
            this.materialesToolStripMenuItem1.Text = "Materiales";
            this.materialesToolStripMenuItem1.Click += new System.EventHandler(this.materialesToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 24);
            // 
            // MenuGz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VentanaGz.Properties.Resources.degradado_fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(573, 394);
            this.Controls.Add(this.PrincipalmenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.PrincipalmenuStrip;
            this.Name = "MenuGz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuGz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuGz_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuGz_FormClosed);
            this.Load += new System.EventHandler(this.MenuGz_Load);
            this.PrincipalmenuStrip.ResumeLayout(false);
            this.PrincipalmenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip PrincipalmenuStrip;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem screenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ventanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem screenToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem materialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materialesToolStripMenuItem1;
        //   private VentanaGz.ScreenUserControl screenUserControl1;
    }
}