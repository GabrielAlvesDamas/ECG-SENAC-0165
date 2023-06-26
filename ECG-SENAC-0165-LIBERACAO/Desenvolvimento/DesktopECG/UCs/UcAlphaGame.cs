using DesktopECG.Effects;

namespace DesktopECG.UCs
{
    public partial class UcAlphaGame : UserControl
    {
        private Point _mousePointEletrodo;
        private bool _isDragging;
        private Panel _pointPanel;
        private IList<EletrodoPoint> ListaPontosDropEletrodo;
        private IList<Point> ListaPosicoesIniciais;
        private int pontuacao;

        public UcAlphaGame()
        {
            InitializeComponent();
            pontuacao = 0;
            label2.Text = pontuacao.ToString();
            ListaPontosDropEletrodo = new List<EletrodoPoint>();
            foreach (var control in panel1.Controls)
            {
                if (control is Panel) 
                {
                    Panel panel = (control as Panel);
                    panel.BackColor = Color.Transparent;
                    ListaPontosDropEletrodo.Add(new EletrodoPoint()
                    {
                        PosicaoMaximaX = panel.Location.X + panel.Size.Width,
                        PosicaoMinimaX = panel.Location.X,
                        PosicaoMaximaY = panel.Location.Y + panel.Size.Height,
                        PosicaoMinimaY = panel.Location.Y,
                        Tag = panel.Tag.ToString()
                    });
                }
            }

            ListaPosicoesIniciais = new List<Point>()
            {
                eletrodo1.Location,
                eletrodo2.Location,
                eletrodo3.Location,
                eletrodo4.Location,
                eletrodo5.Location,
                eletrodo6.Location,
            };
        }

        private void eletrodo_MouseDown(object sender, MouseEventArgs e)
        {
            _isDragging = true;
            _mousePointEletrodo = e.Location;
        }

        private void eletrodo_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox pic = (sender as PictureBox);

            if (_isDragging && e.Button == MouseButtons.Left)
            {
                int dx = e.X - _mousePointEletrodo.X;
                int dy = e.Y - _mousePointEletrodo.Y;
                pic.Location = new Point(pic.Location.X + dx, pic.Location.Y + dy);
            }
        }

        private void eletrodo_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox? pic = (sender as PictureBox);
            if (pic != null)
            {
                EletrodoPoint? Eletrodo = ListaPontosDropEletrodo.Where(x => x.PosicaoMinimaX < pic.Location.X && x.PosicaoMaximaX > pic.Location.X &&
                                                                             x.PosicaoMinimaY < pic.Location.Y && x.PosicaoMaximaY > pic.Location.Y &&
                                                                             x.Tag == (string)pic.Tag).FirstOrDefault();
                if (Eletrodo != null)
                {
                    pic.Location = new Point() { X = Eletrodo.PosicaoMinimaX.Value + 10, Y = Eletrodo.PosicaoMinimaY.Value + 10 };
                    if (pontuacao <= 600)
                        pontuacao += 100;
                    label2.Text = pontuacao.ToString();
                }
                else
                {
                    pic.Location = ListaPosicoesIniciais[Convert.ToInt32(pic.Tag) - 1];
                    if (pontuacao >= 100)
                        pontuacao -= 100;
                    label2.Text = pontuacao.ToString();
                }
            }

        }

        private void Enter_Animation(object sender, EventArgs e)
        {
            ControlAnimation.Enter(sender, e);
        }
        private void Leave_Animation(object sender, EventArgs e)
        {
            ControlAnimation.Leave(sender, e);
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do jogo?\nTodo o progresso será perdido!", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                FrmPrincipal.Instance.LoadScreen(new UcAlphaGameInitialScreen());

            return;

        }
    }
}
