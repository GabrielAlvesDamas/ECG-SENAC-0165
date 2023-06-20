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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)eletrodo1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eletrodo2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eletrodo3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eletrodo4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eletrodo5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eletrodo6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // point6
            // 
            point6.BackColor = Color.Transparent;
            point6.Location = new Point(316, 144);
            point6.Name = "point6";
            point6.Size = new Size(38, 37);
            point6.TabIndex = 0;
            point6.Tag = "6";
            point6.Visible = false;
            // 
            // point5
            // 
            point5.BackColor = Color.Transparent;
            point5.Location = new Point(305, 200);
            point5.Name = "point5";
            point5.Size = new Size(40, 30);
            point5.TabIndex = 1;
            point5.Tag = "5";
            point5.Visible = false;
            // 
            // point4
            // 
            point4.BackColor = Color.Transparent;
            point4.Location = new Point(1045, 144);
            point4.Name = "point4";
            point4.Size = new Size(63, 26);
            point4.TabIndex = 2;
            point4.Tag = "4";
            point4.Visible = false;
            // 
            // point2
            // 
            point2.BackColor = Color.Transparent;
            point2.Location = new Point(1078, 240);
            point2.Name = "point2";
            point2.Size = new Size(59, 32);
            point2.TabIndex = 3;
            point2.Tag = "2";
            point2.Visible = false;
            // 
            // point1
            // 
            point1.BackColor = Color.Transparent;
            point1.Location = new Point(588, 71);
            point1.Name = "point1";
            point1.Size = new Size(48, 26);
            point1.TabIndex = 4;
            point1.Tag = "1";
            point1.Visible = false;
            // 
            // point3
            // 
            point3.BackColor = Color.Transparent;
            point3.Location = new Point(571, 364);
            point3.Name = "point3";
            point3.Size = new Size(53, 30);
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
            eletrodo1.Location = new Point(250, 473);
            eletrodo1.Name = "eletrodo1";
            eletrodo1.Size = new Size(30, 61);
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
            eletrodo2.Location = new Point(305, 473);
            eletrodo2.Name = "eletrodo2";
            eletrodo2.Size = new Size(30, 61);
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
            eletrodo3.Location = new Point(360, 473);
            eletrodo3.Name = "eletrodo3";
            eletrodo3.Size = new Size(30, 61);
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
            eletrodo4.Location = new Point(411, 473);
            eletrodo4.Name = "eletrodo4";
            eletrodo4.Size = new Size(30, 61);
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
            eletrodo5.Location = new Point(462, 473);
            eletrodo5.Name = "eletrodo5";
            eletrodo5.Size = new Size(30, 61);
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
            eletrodo6.Location = new Point(511, 473);
            eletrodo6.Name = "eletrodo6";
            eletrodo6.Size = new Size(30, 61);
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
            buttonVoltar.Cursor = Cursors.Hand;
            buttonVoltar.FlatAppearance.BorderSize = 0;
            buttonVoltar.FlatStyle = FlatStyle.Flat;
            buttonVoltar.Image = Properties.Resources.icons8_voltar_16__1_;
            buttonVoltar.Location = new Point(9, 8);
            buttonVoltar.Name = "buttonVoltar";
            buttonVoltar.Size = new Size(21, 23);
            buttonVoltar.TabIndex = 19;
            buttonVoltar.UseVisualStyleBackColor = false;
            buttonVoltar.Click += buttonVoltar_Click;
            buttonVoltar.MouseEnter += Enter_Animation;
            buttonVoltar.MouseLeave += Leave_Animation;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1265, 457);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // UcAlphaGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonVoltar);
            Controls.Add(eletrodo6);
            Controls.Add(eletrodo5);
            Controls.Add(eletrodo4);
            Controls.Add(eletrodo3);
            Controls.Add(eletrodo2);
            Controls.Add(eletrodo1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(point3);
            Controls.Add(point1);
            Controls.Add(point2);
            Controls.Add(point4);
            Controls.Add(point5);
            Controls.Add(point6);
            Controls.Add(pictureBox1);
            Name = "UcAlphaGame";
            Size = new Size(1264, 549);
            ((System.ComponentModel.ISupportInitialize)eletrodo1).EndInit();
            ((System.ComponentModel.ISupportInitialize)eletrodo2).EndInit();
            ((System.ComponentModel.ISupportInitialize)eletrodo3).EndInit();
            ((System.ComponentModel.ISupportInitialize)eletrodo4).EndInit();
            ((System.ComponentModel.ISupportInitialize)eletrodo5).EndInit();
            ((System.ComponentModel.ISupportInitialize)eletrodo6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}
