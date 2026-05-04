using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WPF_AnimatedPet
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePos = e.GetPosition(MainCanvas);

            double x = mousePos.X - Cat.Width / 2;
            double y = mousePos.Y - Cat.Height / 2;

            x = Math.Clamp(x, 0, MainCanvas.ActualWidth - Cat.Width);
            y = Math.Clamp(y, 0, MainCanvas.ActualHeight - Cat.Height);

            Canvas.SetLeft(Cat, x);
            Canvas.SetTop(Cat, y);

            double offsetX = (mousePos.X - (x + 40)) / 30;
            double offsetY = (mousePos.Y - (y + 40)) / 30;

            offsetX = Math.Clamp(offsetX, -2, 2);
            offsetY = Math.Clamp(offsetY, -2, 2);

            Canvas.SetLeft(LeftPupil, 30 + offsetX);
            Canvas.SetTop(LeftPupil, 17 + offsetY);
            Canvas.SetLeft(RightPupil, 46 + offsetX);
            Canvas.SetTop(RightPupil, 17 + offsetY);
        }
    }
}