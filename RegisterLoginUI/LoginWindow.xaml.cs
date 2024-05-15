using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RegisterLoginUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }


        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BtnCreateAccount_Click(object sender, RoutedEventArgs e)
        {
            new RegisterWindow().Show();
            this.Close();
        }

        private void Login_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private bool IsClickInsideControl(Control control, MouseButtonEventArgs e)
        {
            Point mousePosition = e.GetPosition(control);
            return mousePosition.X >= 0 && mousePosition.X <= control.ActualWidth &&
                   mousePosition.Y >= 0 && mousePosition.Y <= control.ActualHeight;
        }

        private void Window_PrevieMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!IsClickInsideControl(TxtUsernameLogin, e) && !IsClickInsideControl(TxtPasswordLogin, e))
            {
                Keyboard.ClearFocus();
            }
        }
    }
}