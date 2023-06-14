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
            this.WindowBorder = new System.Windows.Forms.Panel();
            this.buttonMinimizeWindow = new System.Windows.Forms.Button();
            this.buttonCloseWindow = new System.Windows.Forms.Button();
            this.WindowBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // WindowBorder
            // 
            this.WindowBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.WindowBorder.Controls.Add(this.buttonMinimizeWindow);
            this.WindowBorder.Controls.Add(this.buttonCloseWindow);
            this.WindowBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.WindowBorder.Location = new System.Drawing.Point(0, 0);
            this.WindowBorder.Name = "WindowBorder";
            this.WindowBorder.Size = new System.Drawing.Size(954, 21);
            this.WindowBorder.TabIndex = 0;
            this.WindowBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowBorder_MouseDown);
            this.WindowBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WindowBorder_MouseMove);
            // 
            // buttonMinimizeWindow
            // 
            this.buttonMinimizeWindow.BackColor = System.Drawing.Color.Transparent;
            this.buttonMinimizeWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinimizeWindow.FlatAppearance.BorderSize = 0;
            this.buttonMinimizeWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimizeWindow.Font = new System.Drawing.Font("Fun City Level 2", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMinimizeWindow.ForeColor = System.Drawing.Color.Transparent;
            this.buttonMinimizeWindow.Location = new System.Drawing.Point(876, 0);
            this.buttonMinimizeWindow.Name = "buttonMinimizeWindow";
            this.buttonMinimizeWindow.Size = new System.Drawing.Size(37, 21);
            this.buttonMinimizeWindow.TabIndex = 2;
            this.buttonMinimizeWindow.Text = "-";
            this.buttonMinimizeWindow.UseMnemonic = false;
            this.buttonMinimizeWindow.UseVisualStyleBackColor = false;
            this.buttonMinimizeWindow.Click += new System.EventHandler(this.buttonMinimizeWindow_Click);
            // 
            // buttonCloseWindow
            // 
            this.buttonCloseWindow.BackColor = System.Drawing.Color.Transparent;
            this.buttonCloseWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCloseWindow.FlatAppearance.BorderSize = 0;
            this.buttonCloseWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseWindow.Font = new System.Drawing.Font("Fun City Level 2", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCloseWindow.ForeColor = System.Drawing.Color.Transparent;
            this.buttonCloseWindow.Location = new System.Drawing.Point(913, 0);
            this.buttonCloseWindow.Name = "buttonCloseWindow";
            this.buttonCloseWindow.Size = new System.Drawing.Size(37, 21);
            this.buttonCloseWindow.TabIndex = 1;
            this.buttonCloseWindow.Text = "X";
            this.buttonCloseWindow.UseMnemonic = false;
            this.buttonCloseWindow.UseVisualStyleBackColor = false;
            this.buttonCloseWindow.Click += new System.EventHandler(this.buttonCloseWindow_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(954, 492);
            this.Controls.Add(this.WindowBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.WindowBorder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel WindowBorder;
        private Button buttonMinimizeWindow;
        private Button buttonCloseWindow;
    }
}