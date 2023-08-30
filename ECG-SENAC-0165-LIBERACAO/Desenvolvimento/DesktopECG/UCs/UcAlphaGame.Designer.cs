namespace DesktopECG.UCs
{
    partial class UcAlphaGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcAlphaGame));
            paPoint2 = new Panel();
            eletrodoPoint6 = new Panel();
            paPoint4 = new Panel();
            eletrodoPoint5 = new Panel();
            paPoint3 = new Panel();
            eletrodoPoint4 = new Panel();
            label1 = new Label();
            label2 = new Label();
            eletrodo1 = new PictureBox();
            eletrodo2 = new PictureBox();
            eletrodo3 = new PictureBox();
            eletrodo4 = new PictureBox();
            eletrodo5 = new PictureBox();
            eletrodo6 = new PictureBox();
            buttonVoltar = new Button();
            panel1 = new Panel();
            paPoint1 = new Panel();
            eletrodoPoint3 = new Panel();
            eletrodoPoint1 = new Panel();
            eletrodoPoint2 = new Panel();
            Pa4 = new PictureBox();
            Pa3 = new PictureBox();
            Pa2 = new PictureBox();
            Pa1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)eletrodo1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eletrodo2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eletrodo3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eletrodo4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eletrodo5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eletrodo6).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pa4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pa3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pa2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pa1).BeginInit();
            SuspendLayout();
            // 
            // paPoint2
            // 
            paPoint2.BackColor = Color.Red;
            paPoint2.ForeColor = Color.DarkGoldenrod;
            paPoint2.Location = new Point(677, 457);
            paPoint2.Name = "paPoint2";
            paPoint2.Size = new Size(15, 20);
            paPoint2.TabIndex = 0;
            paPoint2.Tag = "8";
            paPoint2.Visible = false;
            paPoint2.MouseDown += eletrodo_MouseDown;
            paPoint2.MouseMove += eletrodo_MouseMove;
            paPoint2.MouseUp += eletrodo_MouseUp;
            // 
            // eletrodoPoint6
            // 
            eletrodoPoint6.BackColor = Color.WhiteSmoke;
            eletrodoPoint6.Location = new Point(563, 381);
            eletrodoPoint6.Name = "eletrodoPoint6";
            eletrodoPoint6.Size = new Size(10, 10);
            eletrodoPoint6.TabIndex = 1;
            eletrodoPoint6.Tag = "1";
            // 
            // paPoint4
            // 
            paPoint4.BackColor = Color.WhiteSmoke;
            paPoint4.Location = new Point(947, 395);
            paPoint4.Name = "paPoint4";
            paPoint4.Size = new Size(15, 20);
            paPoint4.TabIndex = 2;
            paPoint4.Tag = "9";
            paPoint4.Visible = false;
            paPoint4.MouseDown += eletrodo_MouseDown;
            paPoint4.MouseMove += eletrodo_MouseMove;
            paPoint4.MouseUp += eletrodo_MouseUp;
            // 
            // eletrodoPoint5
            // 
            eletrodoPoint5.BackColor = Color.WhiteSmoke;
            eletrodoPoint5.Location = new Point(559, 317);
            eletrodoPoint5.Name = "eletrodoPoint5";
            eletrodoPoint5.Size = new Size(10, 10);
            eletrodoPoint5.TabIndex = 3;
            eletrodoPoint5.Tag = "6";
            eletrodoPoint5.Visible = false;
            // 
            // paPoint3
            // 
            paPoint3.BackColor = Color.WhiteSmoke;
            paPoint3.Location = new Point(947, 337);
            paPoint3.Name = "paPoint3";
            paPoint3.Size = new Size(15, 20);
            paPoint3.TabIndex = 4;
            paPoint3.Tag = "10";
            paPoint3.Visible = false;
            paPoint3.MouseDown += eletrodo_MouseDown;
            paPoint3.MouseMove += eletrodo_MouseMove;
            paPoint3.MouseUp += eletrodo_MouseUp;
            // 
            // eletrodoPoint4
            // 
            eletrodoPoint4.BackColor = Color.WhiteSmoke;
            eletrodoPoint4.Location = new Point(574, 323);
            eletrodoPoint4.Name = "eletrodoPoint4";
            eletrodoPoint4.Size = new Size(10, 10);
            eletrodoPoint4.TabIndex = 5;
            eletrodoPoint4.Tag = "5";
            eletrodoPoint4.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(1134, 13);
            label1.Name = "label1";
            label1.Size = new Size(63, 21);
            label1.TabIndex = 6;
            label1.Text = "SCORE:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(1203, 14);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 7;
            label2.Text = "000000";
            // 
            // eletrodo1
            // 
            eletrodo1.BackColor = Color.Transparent;
            eletrodo1.BackgroundImage = Properties.Resources.eletrodo_8bit;
            eletrodo1.BackgroundImageLayout = ImageLayout.Stretch;
            eletrodo1.Location = new Point(35, 807);
            eletrodo1.Name = "eletrodo1";
            eletrodo1.Size = new Size(43, 43);
            eletrodo1.TabIndex = 8;
            eletrodo1.TabStop = false;
            eletrodo1.Tag = "1";
            eletrodo1.WaitOnLoad = true;
            eletrodo1.MouseDown += eletrodo_MouseDown;
            eletrodo1.MouseMove += eletrodo_MouseMove;
            eletrodo1.MouseUp += eletrodo_MouseUp;
            // 
            // eletrodo2
            // 
            eletrodo2.BackColor = Color.Transparent;
            eletrodo2.BackgroundImage = Properties.Resources._11;
            eletrodo2.BackgroundImageLayout = ImageLayout.Stretch;
            eletrodo2.Location = new Point(105, 807);
            eletrodo2.Name = "eletrodo2";
            eletrodo2.Size = new Size(30, 35);
            eletrodo2.TabIndex = 9;
            eletrodo2.TabStop = false;
            eletrodo2.Tag = "2";
            eletrodo2.MouseDown += eletrodo_MouseDown;
            eletrodo2.MouseMove += eletrodo_MouseMove;
            eletrodo2.MouseUp += eletrodo_MouseUp;
            // 
            // eletrodo3
            // 
            eletrodo3.BackColor = Color.Transparent;
            eletrodo3.BackgroundImage = Properties.Resources.thumbnail_Eletrodo;
            eletrodo3.BackgroundImageLayout = ImageLayout.Stretch;
            eletrodo3.Location = new Point(175, 807);
            eletrodo3.Name = "eletrodo3";
            eletrodo3.Size = new Size(15, 15);
            eletrodo3.TabIndex = 10;
            eletrodo3.TabStop = false;
            eletrodo3.Tag = "3";
            eletrodo3.MouseDown += eletrodo_MouseDown;
            eletrodo3.MouseMove += eletrodo_MouseMove;
            eletrodo3.MouseUp += eletrodo_MouseUp;
            // 
            // eletrodo4
            // 
            eletrodo4.BackColor = Color.Transparent;
            eletrodo4.BackgroundImage = (Image)resources.GetObject("eletrodo4.BackgroundImage");
            eletrodo4.BackgroundImageLayout = ImageLayout.Stretch;
            eletrodo4.Location = new Point(245, 807);
            eletrodo4.Name = "eletrodo4";
            eletrodo4.Size = new Size(12, 27);
            eletrodo4.TabIndex = 11;
            eletrodo4.TabStop = false;
            eletrodo4.Tag = "4";
            eletrodo4.MouseDown += eletrodo_MouseDown;
            eletrodo4.MouseMove += eletrodo_MouseMove;
            eletrodo4.MouseUp += eletrodo_MouseUp;
            // 
            // eletrodo5
            // 
            eletrodo5.BackColor = Color.Transparent;
            eletrodo5.BackgroundImage = (Image)resources.GetObject("eletrodo5.BackgroundImage");
            eletrodo5.BackgroundImageLayout = ImageLayout.Stretch;
            eletrodo5.Location = new Point(385, 807);
            eletrodo5.Name = "eletrodo5";
            eletrodo5.Size = new Size(12, 27);
            eletrodo5.TabIndex = 12;
            eletrodo5.TabStop = false;
            eletrodo5.Tag = "5";
            eletrodo5.MouseDown += eletrodo_MouseDown;
            eletrodo5.MouseMove += eletrodo_MouseMove;
            eletrodo5.MouseUp += eletrodo_MouseUp;
            // 
            // eletrodo6
            // 
            eletrodo6.BackColor = Color.Transparent;
            eletrodo6.BackgroundImage = (Image)resources.GetObject("eletrodo6.BackgroundImage");
            eletrodo6.BackgroundImageLayout = ImageLayout.Stretch;
            eletrodo6.Location = new Point(315, 807);
            eletrodo6.Name = "eletrodo6";
            eletrodo6.Size = new Size(12, 27);
            eletrodo6.TabIndex = 13;
            eletrodo6.TabStop = false;
            eletrodo6.Tag = "6";
            eletrodo6.MouseDown += eletrodo_MouseDown;
            eletrodo6.MouseMove += eletrodo_MouseMove;
            eletrodo6.MouseUp += eletrodo_MouseUp;
            // 
            // buttonVoltar
            // 
            buttonVoltar.BackColor = Color.Transparent;
            buttonVoltar.BackgroundImageLayout = ImageLayout.Center;
            buttonVoltar.Cursor = Cursors.Hand;
            buttonVoltar.FlatAppearance.BorderSize = 0;
            buttonVoltar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonVoltar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonVoltar.FlatStyle = FlatStyle.Flat;
            buttonVoltar.Image = Properties.Resources.back_img;
            buttonVoltar.Location = new Point(0, 1);
            buttonVoltar.Name = "buttonVoltar";
            buttonVoltar.Size = new Size(65, 57);
            buttonVoltar.TabIndex = 19;
            buttonVoltar.UseVisualStyleBackColor = false;
            buttonVoltar.Click += buttonVoltar_Click;
            buttonVoltar.MouseEnter += Enter_Animation;
            buttonVoltar.MouseLeave += Leave_Animation;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Personagem1;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(paPoint2);
            panel1.Controls.Add(paPoint1);
            panel1.Controls.Add(eletrodoPoint3);
            panel1.Controls.Add(eletrodoPoint1);
            panel1.Controls.Add(eletrodoPoint4);
            panel1.Controls.Add(eletrodoPoint2);
            panel1.Controls.Add(buttonVoltar);
            panel1.Controls.Add(eletrodoPoint5);
            panel1.Controls.Add(paPoint4);
            panel1.Controls.Add(eletrodoPoint6);
            panel1.Controls.Add(paPoint3);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1386, 739);
            panel1.TabIndex = 21;
            // 
            // paPoint1
            // 
            paPoint1.BackColor = Color.WhiteSmoke;
            paPoint1.Location = new Point(677, 275);
            paPoint1.Name = "paPoint1";
            paPoint1.Size = new Size(15, 20);
            paPoint1.TabIndex = 1;
            paPoint1.Tag = "7";
            paPoint1.Visible = false;
            paPoint1.MouseDown += eletrodo_MouseDown;
            paPoint1.MouseMove += eletrodo_MouseMove;
            paPoint1.MouseUp += eletrodo_MouseUp;
            // 
            // eletrodoPoint3
            // 
            eletrodoPoint3.BackColor = Color.WhiteSmoke;
            eletrodoPoint3.Location = new Point(580, 338);
            eletrodoPoint3.Name = "eletrodoPoint3";
            eletrodoPoint3.Size = new Size(10, 10);
            eletrodoPoint3.TabIndex = 27;
            eletrodoPoint3.Tag = "4";
            eletrodoPoint3.Visible = false;
            // 
            // eletrodoPoint1
            // 
            eletrodoPoint1.BackColor = Color.WhiteSmoke;
            eletrodoPoint1.Location = new Point(563, 365);
            eletrodoPoint1.Name = "eletrodoPoint1";
            eletrodoPoint1.Size = new Size(10, 10);
            eletrodoPoint1.TabIndex = 6;
            eletrodoPoint1.Tag = "2";
            eletrodoPoint1.Visible = false;
            // 
            // eletrodoPoint2
            // 
            eletrodoPoint2.BackColor = Color.WhiteSmoke;
            eletrodoPoint2.Location = new Point(578, 354);
            eletrodoPoint2.Name = "eletrodoPoint2";
            eletrodoPoint2.Size = new Size(10, 10);
            eletrodoPoint2.TabIndex = 26;
            eletrodoPoint2.Tag = "3";
            eletrodoPoint2.Visible = false;
            // 
            // Pa4
            // 
            Pa4.BackColor = Color.Transparent;
            Pa4.BackgroundImage = Properties.Resources._5;
            Pa4.BackgroundImageLayout = ImageLayout.Stretch;
            Pa4.Location = new Point(797, 763);
            Pa4.Name = "Pa4";
            Pa4.Size = new Size(69, 87);
            Pa4.TabIndex = 25;
            Pa4.TabStop = false;
            Pa4.Tag = "10";
            Pa4.MouseDown += eletrodo_MouseDown;
            Pa4.MouseMove += eletrodo_MouseMove;
            Pa4.MouseUp += eletrodo_MouseUp;
            // 
            // Pa3
            // 
            Pa3.BackColor = Color.Transparent;
            Pa3.BackgroundImage = Properties.Resources._4;
            Pa3.BackgroundImageLayout = ImageLayout.Stretch;
            Pa3.Location = new Point(722, 763);
            Pa3.Name = "Pa3";
            Pa3.Size = new Size(69, 87);
            Pa3.TabIndex = 24;
            Pa3.TabStop = false;
            Pa3.Tag = "9";
            Pa3.MouseDown += eletrodo_MouseDown;
            Pa3.MouseMove += eletrodo_MouseMove;
            Pa3.MouseUp += eletrodo_MouseUp;
            // 
            // Pa2
            // 
            Pa2.BackColor = Color.Transparent;
            Pa2.BackgroundImage = Properties.Resources._3;
            Pa2.BackgroundImageLayout = ImageLayout.Stretch;
            Pa2.Location = new Point(647, 763);
            Pa2.Name = "Pa2";
            Pa2.Size = new Size(69, 87);
            Pa2.TabIndex = 23;
            Pa2.TabStop = false;
            Pa2.Tag = "8";
            Pa2.MouseDown += eletrodo_MouseDown;
            Pa2.MouseMove += eletrodo_MouseMove;
            Pa2.MouseUp += eletrodo_MouseUp;
            // 
            // Pa1
            // 
            Pa1.BackColor = Color.Transparent;
            Pa1.BackgroundImage = Properties.Resources._2;
            Pa1.BackgroundImageLayout = ImageLayout.Stretch;
            Pa1.Location = new Point(572, 763);
            Pa1.Name = "Pa1";
            Pa1.Size = new Size(69, 87);
            Pa1.TabIndex = 22;
            Pa1.TabStop = false;
            Pa1.Tag = "7";
            Pa1.MouseDown += eletrodo_MouseDown;
            Pa1.MouseMove += eletrodo_MouseMove;
            Pa1.MouseUp += eletrodo_MouseUp;
            // 
            // UcAlphaGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Pa4);
            Controls.Add(Pa3);
            Controls.Add(Pa2);
            Controls.Add(Pa1);
            Controls.Add(eletrodo1);
            Controls.Add(eletrodo6);
            Controls.Add(eletrodo5);
            Controls.Add(eletrodo4);
            Controls.Add(eletrodo3);
            Controls.Add(eletrodo2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "UcAlphaGame";
            Size = new Size(1386, 888);
            Load += UcAlphaGame_Load;
            ((System.ComponentModel.ISupportInitialize)eletrodo1).EndInit();
            ((System.ComponentModel.ISupportInitialize)eletrodo2).EndInit();
            ((System.ComponentModel.ISupportInitialize)eletrodo3).EndInit();
            ((System.ComponentModel.ISupportInitialize)eletrodo4).EndInit();
            ((System.ComponentModel.ISupportInitialize)eletrodo5).EndInit();
            ((System.ComponentModel.ISupportInitialize)eletrodo6).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Pa4).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pa3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pa2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pa1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel paPoint2;
        private Panel eletrodoPoint6;
        private Panel paPoint4;
        private Panel eletrodoPoint5;
        private Panel paPoint3;
        private Panel eletrodoPoint4;
        private Label label1;
        private Label label2;
        private PictureBox eletrodo1;
        private PictureBox eletrodo2;
        private PictureBox eletrodo3;
        private PictureBox eletrodo4;
        private PictureBox eletrodo5;
        private PictureBox eletrodo6;
        private Button buttonVoltar;
        private Panel panel1;
        private PictureBox Pa4;
        private PictureBox Pa3;
        private PictureBox Pa2;
        private PictureBox Pa1;
        private Panel eletrodoPoint1;
        private Panel eletrodoPoint2;
        private Panel eletrodoPoint3;
        private Panel paPoint1;
    }
}
