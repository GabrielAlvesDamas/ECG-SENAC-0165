using DesktopECG.Effects;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DesktopECG.UCs
{
    public partial class UcAlphaGame : UserControl
    {
        private Point _mousePointEletrodo;
        private Point _startPoint;
        private bool _enterPoint;
        private Panel _panel;
        private Form _form;
        private bool _isDragging;
        private Panel _pointPanel;
        private IList<EletrodoPoint> ListaPontosDropEletrodo;
        private IList<Point> ListaPosicoesIniciais;
        private int pontuacao;

        public UcAlphaGame(Panel panel, Form form)
        {
            InitializeComponent();
            _panel = panel;
            _form = form;
            pontuacao = 0;
            label2.Text = pontuacao.ToString();
            ListaPontosDropEletrodo = new List<EletrodoPoint>() {
                new EletrodoPoint(){
                    PosicaoMaximaX = point1.Location.X + point1.Size.Width,
                    PosicaoMinimaX = point1.Location.X,
                    PosicaoMaximaY = point1.Location.Y + point1.Size.Height,
                    PosicaoMinimaY = point1.Location.Y,
                    Tag = point1.Tag.ToString()
                },
                new EletrodoPoint(){
                    PosicaoMaximaX = point2.Location.X + point2.Size.Width,
                    PosicaoMinimaX = point2.Location.X,
                    PosicaoMaximaY = point2.Location.Y + point2.Size.Height,
                    PosicaoMinimaY = point2.Location.Y,
                    Tag = point2.Tag.ToString()
                },
                new EletrodoPoint(){
                    PosicaoMaximaX = point3.Location.X + point3.Size.Width,
                    PosicaoMinimaX = point3.Location.X,
                    PosicaoMaximaY = point3.Location.Y + point3.Size.Height,
                    PosicaoMinimaY = point3.Location.Y,
                    Tag = point3.Tag.ToString()
                },
                new EletrodoPoint(){
                    PosicaoMaximaX = point4.Location.X + point4.Size.Width,
                    PosicaoMinimaX = point4.Location.X,
                    PosicaoMaximaY = point4.Location.Y + point4.Size.Height,
                    PosicaoMinimaY = point4.Location.Y,
                    Tag = point4.Tag.ToString()
                },
                new EletrodoPoint(){
                    PosicaoMaximaX = point5.Location.X + point5.Size.Width,
                    PosicaoMinimaX = point5.Location.X,
                    PosicaoMaximaY = point5.Location.Y + point5.Size.Height,
                    PosicaoMinimaY = point5.Location.Y,
                    Tag = point5.Tag.ToString()
                },
                new EletrodoPoint(){
                    PosicaoMaximaX = point6.Location.X + point6.Size.Width,
                    PosicaoMinimaX = point6.Location.X,
                    PosicaoMaximaY = point6.Location.Y + point6.Size.Height,
                    PosicaoMinimaY = point6.Location.Y,
                    Tag = point6.Tag.ToString()
                },
            };

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
                                                                             x.Tag == pic.Tag).FirstOrDefault();
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
            {
                _panel.Controls.Clear();
                _panel.Controls.Add(new UcAlphaGameInitialScreen(_panel, _form));
            }

            return;

        }
    }
}
