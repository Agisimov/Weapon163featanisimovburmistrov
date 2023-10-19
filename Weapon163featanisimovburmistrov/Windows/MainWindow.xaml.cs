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
using Weapon163featanisimovburmistrov.ClassHelper;
using Weapon163featanisimovburmistrov.DB;
using static Weapon163featanisimovburmistrov.ClassHelper.EFClass;
using static Weapon163featanisimovburmistrov.ClassHelper.CartClass;

namespace Weapon163featanisimovburmistrov
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public object selProduct;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void korz_Click(object sender, RoutedEventArgs e)
        {
            Windows.Cart cart = new Windows.Cart();
            cart.Show();
            this.Close();
        }

        private void gg()
        {
            List<DB.Product> products = new List<DB.Product>();
            products = context.Product.ToList();
            pistolList.ItemsSource = products;
        }




        private void vhod_Click_1(object sender, RoutedEventArgs e)
        {
            Windows.Auth auth = new Windows.Auth();
            auth.Show();
            this.Close();
        }

        private void pist_Click(object sender, RoutedEventArgs e)
        {
            gg();
        }

        private void BtnAddToCart_Click(object sender, RoutedEventArgs e)
        {
            bool a = true;
            Button button = sender as Button;
            if (button == null)
            {
                return;
            }
            var selectedProduct = button.DataContext as DB.Product;
            selProduct = selectedProduct;


            if (selectedProduct != null)
            {
                for (int i = 0; i < Products.Count; i++)
                {
                    if (Products[i] == selectedProduct)
                    {
                        Products[i].Quantity++;
                        a = false;
                    }
                }
                if (a)
                {
                    selectedProduct.Quantity = 1;
                    Products.Add(selectedProduct);
                }
            }
        }
    }
}
