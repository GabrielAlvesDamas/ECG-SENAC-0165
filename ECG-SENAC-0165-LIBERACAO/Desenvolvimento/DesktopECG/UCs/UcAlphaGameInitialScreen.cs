using DesktopECG.Effects;

namespace DesktopECG.UCs
{
    public partial class UcAlphaGameInitialScreen : UserControl
    {
        public UcAlphaGameInitialScreen()
        {
            InitializeComponent();
        }

        private void Enter_Animation(object sender, EventArgs e)
        {
            ControlAnimation.Enter(sender, e);
        }

        private void Leave_Animation(object sender, EventArgs e)
        {
            ControlAnimation.Leave(sender, e);
        }

        private void labelPlay_Click(object sender, EventArgs e)
        {
            FrmPrincipal.Instance.LoadScreen(new UcAlphaGame());

        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do jogo?\nTodo o progresso será perdido!", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                FrmPrincipal.Instance.CloseScreen();
            return;
        }

        private void UcAlphaGameInitialScreen_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
    }
}
