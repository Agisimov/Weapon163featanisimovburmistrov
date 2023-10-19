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
using Weapon163featanisimovburmistrov.DB;
using Weapon163featanisimovburmistrov.ClassHelper;
using static Weapon163featanisimovburmistrov.ClassHelper.EFClass;

namespace Weapon163featanisimovburmistrov.Windows
{
    /// <summary>
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Window
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void Vhod1_Click(object sender, RoutedEventArgs e)
        {
           

            var Auth = context.Client.ToList()
                .Where(i => i.Email == TextLogin.Text && i.Password == PBPasswoed.Password)
                .FirstOrDefault();


            if (Auth!= null)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("нет такого пользователя");
            }


        }
    }
}
