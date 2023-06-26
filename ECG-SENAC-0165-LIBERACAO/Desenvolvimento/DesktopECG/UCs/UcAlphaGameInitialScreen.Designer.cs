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
            labelPlay = new Label();
            label2 = new Label();
            labelSair = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // labelPlay
            // 
            labelPlay.AutoSize = true;
            labelPlay.BackColor = Color.Transparent;
            labelPlay.Cursor = Cursors.Hand;
            labelPlay.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelPlay.Location = new Point(601, 188);
            labelPlay.Name = "labelPlay";
            labelPlay.Size = new Size(104, 37);
            labelPlay.TabIndex = 0;
            labelPlay.Text = "PLAY";
            labelPlay.Click += labelPlay_Click;
            labelPlay.MouseEnter += Enter_Animation;
            labelPlay.MouseLeave += Leave_Animation;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(588, 260);
            label2.Name = "label2";
            label2.Size = new Size(134, 37);
            label2.TabIndex = 1;
            label2.Text = "SCORE";
            label2.MouseEnter += Enter_Animation;
            label2.MouseLeave += Leave_Animation;
            // 
            // labelSair
            // 
            labelSair.AutoSize = true;
            labelSair.BackColor = Color.Transparent;
            labelSair.Cursor = Cursors.Hand;
            labelSair.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelSair.Location = new Point(611, 333);
            labelSair.Name = "labelSair";
            labelSair.Size = new Size(94, 37);
            labelSair.TabIndex = 2;
            labelSair.Text = "SAIR";
            labelSair.Click += label3_Click;
            labelSair.MouseEnter += Enter_Animation;
            labelSair.MouseLeave += Leave_Animation;
            // 
            // comboBox1
            // 
            comboBox1.CausesValidation = false;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Padrão", "Realista", "Lúdico" });
            comboBox1.Location = new Point(3, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            comboBox1.TabStop = false;
            // 
            // UcAlphaGameInitialScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(comboBox1);
            Controls.Add(labelSair);
            Controls.Add(label2);
            Controls.Add(labelPlay);
            Name = "UcAlphaGameInitialScreen";
            Size = new Size(1264, 549);
            Load += UcAlphaGameInitialScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPlay;
        private Label label2;
        private Label labelSair;
        private ComboBox comboBox1;
    }
}
