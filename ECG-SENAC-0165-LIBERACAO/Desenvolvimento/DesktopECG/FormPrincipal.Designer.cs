namespace DesktopECG
{
    partial class FrmPrincipal
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
            WindowBorder = new Panel();
            buttonMinimizeWindow = new Button();
            buttonCloseWindow = new Button();
            panelUc = new Panel();
            WindowBorder.SuspendLayout();
            SuspendLayout();
            // 
            // WindowBorder
            // 
            WindowBorder.BackColor = Color.SteelBlue;
            WindowBorder.Controls.Add(buttonMinimizeWindow);
            WindowBorder.Controls.Add(buttonCloseWindow);
            WindowBorder.Dock = DockStyle.Top;
            WindowBorder.Location = new Point(0, 0);
            WindowBorder.Name = "WindowBorder";
            WindowBorder.Size = new Size(1386, 21);
            WindowBorder.TabIndex = 0;
            WindowBorder.MouseDown += WindowBorder_MouseDown;
            WindowBorder.MouseMove += WindowBorder_MouseMove;
            // 
            // buttonMinimizeWindow
            // 
            buttonMinimizeWindow.BackColor = Color.Transparent;
            buttonMinimizeWindow.Cursor = Cursors.Hand;
            buttonMinimizeWindow.FlatAppearance.BorderSize = 0;
            buttonMinimizeWindow.FlatStyle = FlatStyle.Flat;
            buttonMinimizeWindow.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMinimizeWindow.ForeColor = Color.Transparent;
            buttonMinimizeWindow.Location = new Point(1309, 0);
            buttonMinimizeWindow.Name = "buttonMinimizeWindow";
            buttonMinimizeWindow.Size = new Size(37, 21);
            buttonMinimizeWindow.TabIndex = 2;
            buttonMinimizeWindow.Text = "-";
            buttonMinimizeWindow.UseMnemonic = false;
            buttonMinimizeWindow.UseVisualStyleBackColor = false;
            buttonMinimizeWindow.Click += buttonMinimizeWindow_Click;
            // 
            // buttonCloseWindow
            // 
            buttonCloseWindow.BackColor = Color.Transparent;
            buttonCloseWindow.Cursor = Cursors.Hand;
            buttonCloseWindow.FlatAppearance.BorderSize = 0;
            buttonCloseWindow.FlatStyle = FlatStyle.Flat;
            buttonCloseWindow.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCloseWindow.ForeColor = Color.Transparent;
            buttonCloseWindow.Location = new Point(1346, 0);
            buttonCloseWindow.Name = "buttonCloseWindow";
            buttonCloseWindow.Size = new Size(37, 21);
            buttonCloseWindow.TabIndex = 1;
            buttonCloseWindow.Text = "X";
            buttonCloseWindow.UseMnemonic = false;
            buttonCloseWindow.UseVisualStyleBackColor = false;
            buttonCloseWindow.Click += buttonCloseWindow_Click;
            // 
            // panelUc
            // 
            panelUc.Dock = DockStyle.Fill;
            panelUc.Location = new Point(0, 21);
            panelUc.Name = "panelUc";
            panelUc.Size = new Size(1386, 867);
            panelUc.TabIndex = 1;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1386, 888);
            Controls.Add(panelUc);
            Controls.Add(WindowBorder);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPrincipal";
            Text = "Form1";
            Load += FrmPrincipal_Load;
            WindowBorder.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel WindowBorder;
        private Button buttonMinimizeWindow;
        private Button buttonCloseWindow;
        private Panel panelUc;
    }
}