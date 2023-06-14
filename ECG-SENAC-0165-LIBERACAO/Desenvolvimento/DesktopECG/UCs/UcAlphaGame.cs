using System.Runtime.InteropServices;

namespace DesktopECG.UCs
{
    public partial class UcAlphaGame : UserControl
    {
        private Point _mousePointEletrodo;
        private Point _startPoint;
        private bool _enterPoint;
        private Panel painelSelecionado;
        private bool _isDragging;
        private Panel _pointPanel;
        private IList<EletrodoPoint> _elPoints = new List<EletrodoPoint>();
        public UcAlphaGame()
        {
            InitializeComponent();
            painelSelecionado = null;
            foreach(Control control in Controls)
            {
                if (control is PictureBox)
                    _elPoints.Add(new EletrodoPoint{ Tag = control.Tag.ToString(), Point = control.Location });
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
            if (painelSelecionado != null)
            {

                PictureBox pic = (sender as PictureBox);

                foreach (var point in _elPoints)
                {
                    if (point.Tag == pic.Tag)
                        _startPoint = point.Point;
                }

                var rangeX = painelSelecionado.Location.X + painelSelecionado.Size.Width;
                var rangeY = painelSelecionado.Location.Y + painelSelecionado.Size.Height;

                int mouseX = MousePosition.X;
                int mouseY = MousePosition.Y;

                if (painelSelecionado.Tag != pic.Tag
                    && !(mouseX < rangeX
                    && mouseX > painelSelecionado.Location.X)
                    || !(mouseY < rangeY
                    && mouseY > painelSelecionado.Location.Y)
                )
                    pic.Location = _startPoint;

                else
                    pic.Location = _startPoint;
            }
        }

        private void point_MouseLeave(object sender, EventArgs e) 
        { 
        }

        private void point6_MouseUp(object sender, MouseEventArgs e)
        {
            painelSelecionado = sender as Panel;
        }

        private void point_DragDrop(object sender, DragEventArgs e)
        {
            painelSelecionado = sender as Panel;
        }
        
        private void point_DragLeave(object sender, DragEventArgs e)
        {
            painelSelecionado = null;
        }
    }
}
