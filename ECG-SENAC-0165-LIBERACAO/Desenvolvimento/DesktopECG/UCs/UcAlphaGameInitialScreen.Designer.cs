namespace DesktopECG.UCs
{
    partial class UcAlphaGameInitialScreen
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcAlphaGameInitialScreen));
            this.labelPlay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSair = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPlay
            // 
            this.labelPlay.AutoSize = true;
            this.labelPlay.BackColor = System.Drawing.Color.Transparent;
            this.labelPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelPlay.Font = new System.Drawing.Font("Athiti SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPlay.Location = new System.Drawing.Point(416, 158);
            this.labelPlay.Name = "labelPlay";
            this.labelPlay.Size = new System.Drawing.Size(92, 51);
            this.labelPlay.TabIndex = 0;
            this.labelPlay.Text = "PLAY";
            this.labelPlay.Click += new System.EventHandler(this.labelPlay_Click);
            this.labelPlay.MouseEnter += new System.EventHandler(this.Enter_Animation);
            this.labelPlay.MouseLeave += new System.EventHandler(this.Leave_Animation);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Athiti SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(403, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "PLAY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Athiti SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(403, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "SCORE";
            this.label2.MouseEnter += new System.EventHandler(this.Enter_Animation);
            this.label2.MouseLeave += new System.EventHandler(this.Leave_Animation);
            // 
            // labelSair
            // 
            this.labelSair.AutoSize = true;
            this.labelSair.BackColor = System.Drawing.Color.Transparent;
            this.labelSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSair.Font = new System.Drawing.Font("Athiti SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSair.Location = new System.Drawing.Point(416, 303);
            this.labelSair.Name = "labelSair";
            this.labelSair.Size = new System.Drawing.Size(86, 51);
            this.labelSair.TabIndex = 2;
            this.labelSair.Text = "SAIR";
            this.labelSair.Click += new System.EventHandler(this.label3_Click);
            this.labelSair.MouseEnter += new System.EventHandler(this.Enter_Animation);
            this.labelSair.MouseLeave += new System.EventHandler(this.Leave_Animation);
            // 
            // UcAlphaGameInitialScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.labelSair);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPlay);
            this.Name = "UcAlphaGameInitialScreen";
            this.Size = new System.Drawing.Size(899, 492);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelPlay;
        private Label label1;
        private Label label2;
        private Label labelSair;
    }
}
