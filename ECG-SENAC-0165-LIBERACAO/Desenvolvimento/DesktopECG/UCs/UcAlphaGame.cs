using DesktopECG.Effects;
using DesktopECG.Enums;
using DesktopECG.Properties;

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
        private TipoLayoutEnum.TipoLayout tipoLayoutAtual;

        public UcAlphaGame()
        {
            InitializeComponent();
            pontuacao = 0;
            label2.Text = pontuacao.ToString();
            CriaPontosEletrodo();

            ListaPosicoesIniciais = new List<Point>()
            {
                eletrodo1.Location,
                eletrodo2.Location,
                eletrodo3.Location,
                eletrodo4.Location,
                eletrodo5.Location,
                eletrodo6.Location,
                Pa1.Location,
                Pa2.Location,
                Pa3.Location,
                Pa4.Location,
            };
            tipoLayoutAtual = TipoLayoutEnum.TipoLayout.PADRAO;
        }

        private void CriaPontosEletrodo()
        {
            ListaPontosDropEletrodo = new List<EletrodoPoint>();
            foreach (var control in panel1.Controls)
            {
                if (control is Panel)
                {
                    Panel panel = (control as Panel);
                    panel.BackColor = Color.Transparent;
                    if (panel.Tag != null)
                    {
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
            }
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
                    if (pontuacao <= 900)
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
                FrmPrincipal.Instance.LoadScreen(new UcAlphaGameInitialScreen(tipoLayoutAtual));
            return;

        }

        private void UcAlphaGame_Load(object sender, EventArgs e)
        {
            HandleChageLayout();
            tipoLayoutAtual = Globals.TIPO_LAYOUT;
        }

        private void HandleChageLayout()
        {
            switch (Globals.TIPO_LAYOUT)
            {

                case TipoLayoutEnum.TipoLayout.PADRAO:
                    panel1.BackgroundImage = Resources.Personagem1;

                    eletrodoPoint1.Location = new Point(563, 365);
                    eletrodoPoint1.Size = new Size(10, 10);
                    eletrodo1.Size = new Size(15, 15);
                    eletrodo1.BackgroundImage = Resources.thumbnail_Eletrodo;

                    eletrodoPoint2.Location = new Point(578, 354);
                    eletrodoPoint2.Size = new Size(10, 10);
                    eletrodo2.Size = new Size(15, 15);
                    eletrodo2.BackgroundImage = Resources.thumbnail_Eletrodo;

                    eletrodoPoint3.Location = new Point(580, 338);
                    eletrodoPoint3.Size = new Size(10, 10);
                    eletrodo3.Size = new Size(15, 15);
                    eletrodo3.BackgroundImage = Resources.thumbnail_Eletrodo;

                    eletrodoPoint4.Location = new Point(574, 323);
                    eletrodoPoint4.Size = new Size(10, 10);
                    eletrodo4.Size = new Size(15, 15);
                    eletrodo4.BackgroundImage = Resources.thumbnail_Eletrodo;

                    eletrodoPoint5.Location = new Point(559, 317);
                    eletrodoPoint5.Size = new Size(10, 10);
                    eletrodo5.Size = new Size(15, 15);
                    eletrodo5.BackgroundImage = Resources.thumbnail_Eletrodo;

                    eletrodoPoint6.Location = new Point(563, 381);
                    eletrodoPoint6.Size = new Size(10, 10);
                    eletrodo6.Size = new Size(15, 15);
                    eletrodo6.BackgroundImage = Resources.thumbnail_Eletrodo;

                    paPoint1.Location = new Point(677, 275);
                    paPoint1.Size = new Size(15, 20);
                    Pa1.Size = new Size(31, 45);

                    paPoint2.Location = new Point(677, 457);
                    paPoint2.Size = new Size(15, 20);
                    Pa2.Size = new Size(31, 45);

                    paPoint3.Location = new Point(947, 337);
                    paPoint3.Size = new Size(15, 20);
                    Pa3.Size = new Size(31, 45);

                    paPoint4.Location = new Point(947, 395);
                    paPoint4.Size = new Size(15, 20);
                    Pa4.Size = new Size(31, 45);
                    CriaPontosEletrodo();
                    break;
                case TipoLayoutEnum.TipoLayout.REALISTA:
                    panel1.BackgroundImage = Resources._8;

                    eletrodoPoint1.Location = new Point(365, 341);
                    eletrodoPoint1.Size = new Size(12, 12);
                    eletrodo1.Size = new Size(30, 35);
                    eletrodo1.BackgroundImage = Resources._11;

                    eletrodoPoint2.Location = new Point(376, 324);
                    eletrodoPoint2.Size = new Size(12, 12);
                    eletrodo2.Size = new Size(30, 35);
                    eletrodo2.BackgroundImage = Resources._11;

                    eletrodoPoint3.Location = new Point(383, 308);
                    eletrodoPoint3.Size = new Size(12, 12);
                    eletrodo3.Size = new Size(30, 35);
                    eletrodo3.BackgroundImage = Resources._11;

                    eletrodoPoint4.Location = new Point(383, 291);
                    eletrodoPoint4.Size = new Size(12, 12);
                    eletrodo4.Size = new Size(30, 35);
                    eletrodo4.BackgroundImage = Resources._11;

                    eletrodoPoint5.Location = new Point(378, 274);
                    eletrodoPoint5.Size = new Size(12, 12);
                    eletrodo5.Size = new Size(30, 35);
                    eletrodo5.BackgroundImage = Resources._11;

                    eletrodoPoint6.Location = new Point(365, 395);
                    eletrodoPoint6.Size = new Size(12, 12);
                    eletrodo6.Size = new Size(30, 35);
                    eletrodo6.BackgroundImage = Resources._11;

                    paPoint1.Location = new Point(633, 169);
                    paPoint1.Size = new Size(45, 78);
                    Pa1.Size = new Size(69, 87);

                    paPoint2.Location = new Point(633, 527);
                    paPoint2.Size = new Size(45, 78);
                    Pa2.Size = new Size(69, 87);

                    paPoint3.Location = new Point(1258, 308);
                    paPoint3.Size = new Size(45, 78);
                    Pa3.Size = new Size(69, 87);

                    paPoint4.Location = new Point(1258, 388);
                    paPoint4.Size = new Size(45, 78);
                    Pa4.Size = new Size(69, 87);
                    CriaPontosEletrodo();
                    break;
                case TipoLayoutEnum.TipoLayout.LUDICO:
                    panel1.BackgroundImage = Resources._02___careca_png;

                    eletrodoPoint1.Location = new Point(761, 167);
                    eletrodoPoint1.Size = new Size(25, 25);
                    eletrodo1.Size = new Size(43, 43);
                    eletrodo1.BackgroundImage = Resources.eletrodo_8bit;

                    eletrodoPoint2.Location = new Point(773, 197);
                    eletrodoPoint2.Size = new Size(25, 25);
                    eletrodo2.Size = new Size(43, 43);
                    eletrodo2.BackgroundImage = Resources.eletrodo_8bit;

                    eletrodoPoint3.Location = new Point(778, 229);
                    eletrodoPoint3.Size = new Size(25, 25);
                    eletrodo3.Size = new Size(43, 43);
                    eletrodo3.BackgroundImage = Resources.eletrodo_8bit;

                    eletrodoPoint4.Location = new Point(778, 260);
                    eletrodoPoint4.Size = new Size(25, 25);
                    eletrodo4.Size = new Size(43, 43);
                    eletrodo4.BackgroundImage = Resources.eletrodo_8bit;

                    eletrodoPoint5.Location = new Point(761, 291);
                    eletrodoPoint5.Size = new Size(25, 25);
                    eletrodo5.Size = new Size(43, 43);
                    eletrodo5.BackgroundImage = Resources.eletrodo_8bit;

                    eletrodoPoint6.Location = new Point(761, 364);
                    eletrodoPoint6.Size = new Size(25, 25);
                    eletrodo6.Size = new Size(43, 43);
                    eletrodo6.BackgroundImage = Resources.eletrodo_8bit;

                    paPoint1.Location = new Point(845, 5);
                    paPoint1.Size = new Size(84, 169);
                    Pa1.Size = new Size(69, 123);

                    paPoint2.Location = new Point(845, 530);
                    paPoint2.Size = new Size(84, 169);
                    Pa2.Size = new Size(69, 123);

                    paPoint3.Location = new Point(1155, 144);
                    paPoint3.Size = new Size(84, 169);
                    Pa3.Size = new Size(69, 123);

                    paPoint4.Location = new Point(1155, 381);
                    paPoint4.Size = new Size(84, 169);
                    Pa4.Size = new Size(69, 123);
                    CriaPontosEletrodo();
                    break;

            }
        }

        private void Pa1_Click(object sender, EventArgs e)
        {

        }
    }
}
