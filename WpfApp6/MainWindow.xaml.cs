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

namespace WpfApp6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }
        public string Login { get; set; }
        public string Password { get; set; }
        private void Auth(object sender, RoutedEventArgs e)
        {
            var user = DB.Instance.Users.FirstOrDefault(s => s.Login == Login && s.Password == Password);
            if (user != null)
            {
                {
                    Window1 window1 = new Window1();
                    window1.Show();
                    this.Close();
                }

            }

        }
    }
}