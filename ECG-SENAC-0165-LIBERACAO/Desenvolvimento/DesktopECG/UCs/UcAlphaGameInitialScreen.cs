using DesktopECG.Effects;

namespace DesktopECG.UCs
{
    public partial class UcAlphaGameInitialScreen : UserControl
    {
        private Panel _panel;
        private Form _form;
        public UcAlphaGameInitialScreen(Panel panel, Form form)
        {
            InitializeComponent();
            _panel = panel;
            _form = form;
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
            UcAlphaGame ucAlphaGame = new UcAlphaGame(_panel, _form);

            _panel.Controls.Clear();
            _panel.Controls.Add(ucAlphaGame);
            ucAlphaGame.Dock = DockStyle.Fill;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do jogo?\nTodo o progresso será perdido!", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                _form.Close();
            return;
        }
    }
}
