using DesktopECG.Effects;
using DesktopECG.Enums;
using DesktopECG.Properties;

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
            HandleChageLayout();
        }

        private void HandleChageLayout()
        {
            switch (Globals.TIPO_LAYOUT)
            {

                case TipoLayoutEnum.TipoLayout.PADRAO:
                    this.BackgroundImage = Resources.image_inicial_do_jogo;
                    labelPlay.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                    labelSair.ForeColor = Color.Black;
                    break;
                case TipoLayoutEnum.TipoLayout.REALISTA:
                    this.BackgroundImage = Resources.image_inicial_do_jogo;
                    labelPlay.ForeColor = Color.White;
                    label2.ForeColor = Color.White;
                    labelSair.ForeColor = Color.White;
                    break;
                case TipoLayoutEnum.TipoLayout.LUDICO:
                    this.BackgroundImage = Resources.istockphoto_1317505195_612x612_1_png;
                    labelPlay.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                    labelSair.ForeColor = Color.Black;
                    break;

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Globals.TIPO_LAYOUT = (TipoLayoutEnum.TipoLayout)comboBox1.SelectedIndex;
            HandleChageLayout();
        }
    }
}
