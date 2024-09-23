using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WpfApp6
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private List<Product> products;
        public Window1()
        {
            InitializeComponent();
            GetProducts();
            DataContext = this;

        }
        public List<Product> Products
        {
            get => products;
            set
            {
                products = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(products)));
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        public List<Product> GetProducts()
        {
            Products = DB.Instance.Products.ToList();
            return Products;
        }
    }
}
