namespace DetectaObjetos
{
    partial class FrmDeteccaoObjeto
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picImagem = new PictureBox();
            menuStrip1 = new MenuStrip();
            AbrirImagemToolStripMenuItem = new ToolStripMenuItem();
            iniciarCameraToolStripMenuItem = new ToolStripMenuItem();
            finalizarCameraToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)picImagem).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // picImagem
            // 
            picImagem.Dock = DockStyle.Fill;
            picImagem.Location = new System.Drawing.Point(0, 24);
            picImagem.Name = "picImagem";
            picImagem.Size = new System.Drawing.Size(800, 426);
            picImagem.TabIndex = 0;
            picImagem.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { AbrirImagemToolStripMenuItem, iniciarCameraToolStripMenuItem, finalizarCameraToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // AbrirImagemToolStripMenuItem
            // 
            AbrirImagemToolStripMenuItem.Name = "AbrirImagemToolStripMenuItem";
            AbrirImagemToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            AbrirImagemToolStripMenuItem.Text = "Abrir Imagem";
            AbrirImagemToolStripMenuItem.Click += AbrirImagemToolStripMenuItem_Click;
            // 
            // iniciarCameraToolStripMenuItem
            // 
            iniciarCameraToolStripMenuItem.Name = "iniciarCameraToolStripMenuItem";
            iniciarCameraToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            iniciarCameraToolStripMenuItem.Text = "Iniciar Camera";
            iniciarCameraToolStripMenuItem.Click += IniciarWebCamToolStripMenuItem_Click;
            // 
            // finalizarCameraToolStripMenuItem
            // 
            finalizarCameraToolStripMenuItem.Name = "finalizarCameraToolStripMenuItem";
            finalizarCameraToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            finalizarCameraToolStripMenuItem.Text = "Finalizar Camera";
            finalizarCameraToolStripMenuItem.Click += PararWebCamToolStripMenuItem_Click;
            // 
            // FrmDeteccaoObjeto
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(picImagem);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmDeteccaoObjeto";
            Text = "Detectar Objetos";
            ((System.ComponentModel.ISupportInitialize)picImagem).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picImagem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem AbrirImagemToolStripMenuItem;
        private ToolStripMenuItem iniciarCameraToolStripMenuItem;
        private ToolStripMenuItem finalizarCameraToolStripMenuItem;
    }
}
