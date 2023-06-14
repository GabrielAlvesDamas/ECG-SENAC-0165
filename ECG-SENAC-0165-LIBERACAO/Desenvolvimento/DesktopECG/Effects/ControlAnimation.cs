namespace DesktopECG.Effects
{
    public static class ControlAnimation
    {
        private static Control _control;
        public static void Enter(object sender, EventArgs e)
        {
            _control = sender as Control;
            _control.Location = new Point(_control.Location.X - 1, _control.Location.Y - 1);

        }

        public static void Leave(object sender, EventArgs e)
        {
            _control = sender as Control;
            _control.Location = new Point(_control.Location.X + 1, _control.Location.Y + 1);
        }
    }
}
