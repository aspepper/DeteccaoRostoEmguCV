namespace DeteccaoRostoEmguCV
{
    partial class FrmDeteccaoRosto
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abrirImagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarWebCamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pararWebCamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pararVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirImagemToolStripMenuItem,
            this.iniciarWebCamToolStripMenuItem,
            this.pararWebCamToolStripMenuItem,
            this.abrirVideoToolStripMenuItem,
            this.pararVideoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // abrirImagemToolStripMenuItem
            // 
            this.abrirImagemToolStripMenuItem.Name = "abrirImagemToolStripMenuItem";
            this.abrirImagemToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.abrirImagemToolStripMenuItem.Text = "Abrir Imagem";
            this.abrirImagemToolStripMenuItem.Click += new System.EventHandler(this.AbrirImagemToolStripMenuItem_Click);
            // 
            // iniciarWebCamToolStripMenuItem
            // 
            this.iniciarWebCamToolStripMenuItem.Name = "iniciarWebCamToolStripMenuItem";
            this.iniciarWebCamToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.iniciarWebCamToolStripMenuItem.Text = "Iniciar WebCam";
            this.iniciarWebCamToolStripMenuItem.Click += new System.EventHandler(this.IniciarWebCamToolStripMenuItem_Click);
            // 
            // pararWebCamToolStripMenuItem
            // 
            this.pararWebCamToolStripMenuItem.Name = "pararWebCamToolStripMenuItem";
            this.pararWebCamToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.pararWebCamToolStripMenuItem.Text = "Parar WebCam";
            this.pararWebCamToolStripMenuItem.Click += new System.EventHandler(this.PararWebCamToolStripMenuItem_Click);
            // 
            // abrirVideoToolStripMenuItem
            // 
            this.abrirVideoToolStripMenuItem.Name = "abrirVideoToolStripMenuItem";
            this.abrirVideoToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.abrirVideoToolStripMenuItem.Text = "Abrir Video";
            this.abrirVideoToolStripMenuItem.Click += new System.EventHandler(this.AbrirVideoToolStripMenuItem_Click);
            // 
            // pararVideoToolStripMenuItem
            // 
            this.pararVideoToolStripMenuItem.Name = "pararVideoToolStripMenuItem";
            this.pararVideoToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.pararVideoToolStripMenuItem.Text = "Parar Video";
            this.pararVideoToolStripMenuItem.Click += new System.EventHandler(this.PararVideoToolStripMenuItem_Click);
            // 
            // picImagem
            // 
            this.picImagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImagem.Location = new System.Drawing.Point(0, 24);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(800, 545);
            this.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagem.TabIndex = 1;
            this.picImagem.TabStop = false;
            // 
            // FrmDeteccaoRosto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 569);
            this.Controls.Add(this.picImagem);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmDeteccaoRosto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detecção de Rosto";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirImagemToolStripMenuItem;
        private System.Windows.Forms.PictureBox picImagem;
        private System.Windows.Forms.ToolStripMenuItem iniciarWebCamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pararWebCamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pararVideoToolStripMenuItem;
    }
}

