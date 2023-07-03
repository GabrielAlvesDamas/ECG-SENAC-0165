using DesktopECG.Enums;
using DesktopECG.UCs;
using System.Security.Principal;

namespace DesktopECG
{
    public partial class FrmPrincipal : Form
    {

        private Point _mousePointWindow;

        private static FrmPrincipal _instance;
        public static FrmPrincipal Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FrmPrincipal();
                return _instance;
            }
        }

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        // Movimentação de janela via borda personalizada // 
        private void WindowBorder_MouseDown(object sender, MouseEventArgs e)
        {
            _mousePointWindow = new Point(-e.X, -e.Y);
        }

        private void WindowBorder_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = MousePosition;
                mousePos.Offset(_mousePointWindow.X, _mousePointWindow.Y);
                Location = mousePos;
            }
        }


        // Ação de borda personalizada //
        private void buttonCloseWindow_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do jogo?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.CloseScreen();
            return;
        }

        private void buttonMinimizeWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        // Load de Telas Subsequentes //

        public void LoadScreen(UserControl uC)
        {
            UserControl uCScreen = uC;

            panelUc.Controls.Clear();
            panelUc.Controls.Add(uCScreen);
            uCScreen.Dock = DockStyle.Fill;
        }

        public void CloseScreen()
        {
            Close();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            LoadScreen(new UcAlphaGameInitialScreen());
        }

    }
}