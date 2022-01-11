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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfTask14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Product> products;

        public MainWindow()
        {
            InitializeComponent();
            products = new List<Product>();
            products.Add(new Product()
            {
                Name = "Burger",
                Price = 1000,
                Image = "images/burger.png",
                Category = Categories.Food
            });
            products.Add(new Product()
            {
                Name = "Samsung TV 50 QLED",
                Price = 1000000,
                Image = "images/TV.png",
                Category = Categories.Appliance
            });
            products.Add(new Product()
            {
                Name = "Hotdog",
                Price = 200,
                Image = "images/hotdog.png",
                Category = Categories.Food
            });
            products.Add(new Product()
            {
                Name = "Sushi",
                Price = 300,
                Image = "images/sushi.png",
                Category = Categories.Food
            });
            products.Add(new Product()
            {
                Name = "French Fries",
                Price = 100,
                Image = "images/french_fries.png",
                Category = Categories.Food
            });
            products.Add(new Product()
            {
                Name = "Microwave",
                Price = 500000,
                Image = "images/microwave.png",
                Category = Categories.Appliance
            });
            ListBoxProducts.ItemsSource = products;
        }
    }
}
