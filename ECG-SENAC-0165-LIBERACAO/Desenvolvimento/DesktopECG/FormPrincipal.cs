using DesktopECG.UCs;

namespace DesktopECG
{
    public partial class FrmPrincipal : Form
    {
        private Point _mousePointWindow;


        public FrmPrincipal()
        {
            InitializeComponent();

            PlayLoopMusic();
        }
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

        private void buttonCloseWindow_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do jogo?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
            return;
        }

        private void buttonMinimizeWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private async Task PlayLoopMusic()
        {
            //SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\jande\Downloads\PrincipalMusicInicialGame.wav");
            //simpleSound.PlayLooping();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            UcAlphaGame ucAlphaGame = new UcAlphaGame();

            Controls.Add(ucAlphaGame);
            ucAlphaGame.Dock = DockStyle.Fill;
        }
    }
}