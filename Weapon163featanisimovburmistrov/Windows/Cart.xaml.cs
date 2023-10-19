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
using System.Collections.ObjectModel;


namespace Weapon163featanisimovburmistrov.Windows
{
    /// <summary>
    /// Логика взаимодействия для Cart.xaml
    /// </summary>
    public partial class Cart : Window
    {
        public Cart()
        {
            InitializeComponent();
        }
        private void GetListProduct()
        {
            ObservableCollection<DB.Product> products = new ObservableCollection<DB.Product>(ClassHelper.CartClass.Products);

            CartList.ItemsSource = products;
        }

        private void BtnRemoveToCart_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button == null)
            {
                return;
            }

            var selectedProduct = button.DataContext as DB.Product;


            if (selectedProduct != null)
            {
                CartClass.Products.Remove(selectedProduct);
            }
            GetListProduct();
        }

        private void btnAddOnCart_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button == null)
            {
                return;
            }

            DB.Product selectedProduct = button.DataContext as DB.Product;
            if (selectedProduct != null)
            {
                selectedProduct.Quantity++;
                int o = Products.IndexOf(selectedProduct);
                Products.Remove(selectedProduct);
                Products.Insert(o, selectedProduct);
            }
            GetListProduct();
        }

        private void Pay_Click(object sender, RoutedEventArgs e)
        {
            DB.Order sale = new DB.Order();
            //sale.IdEmployee = ClassHelper.EmployeeDataContextClass.employee.Id;
            sale.IdClient = 1;
            sale.Date = DateTime.Now;
            if (sale != null)
            {
                context.Order.Add(sale);
                context.SaveChanges();
            }


            foreach (var item in Products)
            {
                DB.OrderProduct productSale = new DB.OrderProduct();
                productSale.IdProduct = item.Id;
               productSale.IdOrder = item.Id;
                context.OrderProduct.Add(productSale);
                context.SaveChanges();
            }
            MessageBox.Show("Продукты успешно добавлены");
            MainWindow productListWindow = new MainWindow();
            productListWindow.Show();
            Close();
        }
    }
}
