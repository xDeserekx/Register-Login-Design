using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RegisterLoginUI
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void ButtonBackToLogin_Click(object sender, RoutedEventArgs e)
        {
            new LoginWindow().Show();
            this.Close();
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Register_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void Window_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!IsClickInsideControl(TxtUsernameRegister, e) && !IsClickInsideControl(TxtPasswordRegister, e)
                && !IsClickInsideControl(TxtEmailRegister, e) && !IsClickInsideControl(TxtConfirmPasswordRegister, e))
            {
                Keyboard.ClearFocus();
            }
        }

        private bool IsClickInsideControl(Control control, MouseButtonEventArgs e)
        {
            Point mousePosition = e.GetPosition(control);
            return mousePosition.X >= 0 && mousePosition.X <= control.ActualWidth &&
                   mousePosition.Y >= 0 && mousePosition.Y <= control.ActualHeight;
        }
    }
}
