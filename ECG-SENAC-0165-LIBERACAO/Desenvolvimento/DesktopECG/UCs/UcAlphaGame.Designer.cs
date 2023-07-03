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
            point6 = new Panel();
            point5 = new Panel();
            point4 = new Panel();
            point2 = new Panel();
            point1 = new Panel();
            point3 = new Panel();
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
            ((System.ComponentModel.ISupportInitialize)eletrodo1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eletrodo2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eletrodo3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eletrodo4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eletrodo5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eletrodo6).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // point6
            // 
            point6.BackColor = Color.WhiteSmoke;
            point6.Location = new Point(316, 138);
            point6.Name = "point6";
            point6.Size = new Size(57, 47);
            point6.TabIndex = 0;
            point6.Tag = "6";
            point6.Visible = false;
            // 
            // point5
            // 
            point5.BackColor = Color.WhiteSmoke;
            point5.Location = new Point(305, 200);
            point5.Name = "point5";
            point5.Size = new Size(58, 42);
            point5.TabIndex = 1;
            point5.Tag = "5";
            point5.Visible = false;
            // 
            // point4
            // 
            point4.BackColor = Color.WhiteSmoke;
            point4.Location = new Point(1049, 128);
            point4.Name = "point4";
            point4.Size = new Size(56, 57);
            point4.TabIndex = 2;
            point4.Tag = "4";
            point4.Visible = false;
            // 
            // point2
            // 
            point2.BackColor = Color.WhiteSmoke;
            point2.Location = new Point(1049, 227);
            point2.Name = "point2";
            point2.Size = new Size(70, 55);
            point2.TabIndex = 3;
            point2.Tag = "2";
            point2.Visible = false;
            // 
            // point1
            // 
            point1.BackColor = Color.WhiteSmoke;
            point1.Location = new Point(579, 67);
            point1.Name = "point1";
            point1.Size = new Size(55, 40);
            point1.TabIndex = 4;
            point1.Tag = "1";
            point1.Visible = false;
            // 
            // point3
            // 
            point3.BackColor = Color.WhiteSmoke;
            point3.Location = new Point(562, 353);
            point3.Name = "point3";
            point3.Size = new Size(57, 54);
            point3.TabIndex = 5;
            point3.Tag = "3";
            point3.Visible = false;
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
            eletrodo1.BackgroundImage = (Image)resources.GetObject("eletrodo1.BackgroundImage");
            eletrodo1.BackgroundImageLayout = ImageLayout.Stretch;
            eletrodo1.Location = new Point(239, 446);
            eletrodo1.Name = "eletrodo1";
            eletrodo1.Size = new Size(39, 88);
            eletrodo1.TabIndex = 8;
            eletrodo1.TabStop = false;
            eletrodo1.Tag = "1";
            eletrodo1.MouseDown += eletrodo_MouseDown;
            eletrodo1.MouseMove += eletrodo_MouseMove;
            eletrodo1.MouseUp += eletrodo_MouseUp;
            // 
            // eletrodo2
            // 
            eletrodo2.BackColor = Color.Transparent;
            eletrodo2.BackgroundImage = (Image)resources.GetObject("eletrodo2.BackgroundImage");
            eletrodo2.BackgroundImageLayout = ImageLayout.Stretch;
            eletrodo2.Location = new Point(295, 446);
            eletrodo2.Name = "eletrodo2";
            eletrodo2.Size = new Size(39, 88);
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
            eletrodo3.BackgroundImage = (Image)resources.GetObject("eletrodo3.BackgroundImage");
            eletrodo3.BackgroundImageLayout = ImageLayout.Stretch;
            eletrodo3.Location = new Point(349, 446);
            eletrodo3.Name = "eletrodo3";
            eletrodo3.Size = new Size(39, 88);
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
            eletrodo4.Location = new Point(402, 446);
            eletrodo4.Name = "eletrodo4";
            eletrodo4.Size = new Size(39, 88);
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
            eletrodo5.Location = new Point(453, 446);
            eletrodo5.Name = "eletrodo5";
            eletrodo5.Size = new Size(39, 88);
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
            eletrodo6.Location = new Point(504, 446);
            eletrodo6.Name = "eletrodo6";
            eletrodo6.Size = new Size(39, 88);
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
            buttonVoltar.Location = new Point(3, 71);
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
            panel1.BackgroundImage = Properties.Resources.Tela_do_Jogo___01;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(point3);
            panel1.Controls.Add(buttonVoltar);
            panel1.Controls.Add(point2);
            panel1.Controls.Add(point4);
            panel1.Controls.Add(point5);
            panel1.Controls.Add(point6);
            panel1.Controls.Add(point1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1264, 457);
            panel1.TabIndex = 21;
            // 
            // UcAlphaGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Size = new Size(1264, 549);
            Load += UcAlphaGame_Load;
            ((System.ComponentModel.ISupportInitialize)eletrodo1).EndInit();
            ((System.ComponentModel.ISupportInitialize)eletrodo2).EndInit();
            ((System.ComponentModel.ISupportInitialize)eletrodo3).EndInit();
            ((System.ComponentModel.ISupportInitialize)eletrodo4).EndInit();
            ((System.ComponentModel.ISupportInitialize)eletrodo5).EndInit();
            ((System.ComponentModel.ISupportInitialize)eletrodo6).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel point6;
        private Panel point5;
        private Panel point4;
        private Panel point2;
        private Panel point1;
        private Panel point3;
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
    }
}
