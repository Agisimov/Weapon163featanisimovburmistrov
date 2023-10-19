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

namespace Weapon163featanisimovburmistrov.Windows
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
            Gender.SelectedIndex = 0;
            Gender.ItemsSource = ClassHelper.EFClass.context.Gender.ToList();
            Gender.DisplayMemberPath = "Title";
        }

        private void Vhod_Click(object sender, RoutedEventArgs e)
        {

            var ayth = context.Client.ToList()
            .Where(i => TextLogin.Text==i.Email).FirstOrDefault();
            if (ayth!= null)
            {
                MessageBox.Show("Логин занят");
                return;

            }



            if (string.IsNullOrWhiteSpace(TextFirstName.Text))
            {
                MessageBox.Show("Имя не может быть пустым");
                return;
            }
            if (string.IsNullOrWhiteSpace(TextLastName.Text))
            {
                MessageBox.Show("Фамилия не может быть пустым");
                return;
            }
            if (string.IsNullOrWhiteSpace(TextBirthday.Text))
            {
                MessageBox.Show("Дата не может быть пустым");
                return;
            }
            if (string.IsNullOrWhiteSpace(TextPhone.Text))
            {
                MessageBox.Show("Телефон не может быть пустым");
                return;
            }
            if (string.IsNullOrWhiteSpace(TextLogin.Text))
            {
                MessageBox.Show("Логин не может быть пустым");
                return;
            }
            if (string.IsNullOrWhiteSpace(TbPassword.Text))
            {
                MessageBox.Show("Пароль не может быть пустым");
                return;
            }
            DB.Client client = new DB.Client();
            client.FirstName = TextFirstName.Text;
            client.LastName = TextLastName.Text;
            client.Patronymic = TextPatr.Text;
            client.Phone = TextPhone.Text;
            client.Birthday = TextBirthday.SelectedDate.Value;
            client.Email = TextLogin.Text;
            client.Password = PBPasswoed.Password;
            client.IdGender = Gender.SelectedIndex;
             context.Client.Add(client);
            context.SaveChanges();
            MessageBox.Show("окккк");
            






            Auth auth = new Auth();
            auth.Show();
            this.Close();

        }
    }
}
