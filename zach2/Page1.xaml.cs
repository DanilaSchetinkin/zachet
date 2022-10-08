using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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

namespace zach2
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }
        //войти
        private void Button_Click(object sender, RoutedEventArgs e)
        {
          
            {
                using (TradeEntities users = new TradeEntities())

                {
                    var query = users.User;
                    foreach (var item in query)
                    {
                        if (item.UserLogin == textBox_login.Text)
                        {

                            if (item.UserPassword == password.Text)
                            {
                                Manage.MainFrame.Navigate(new Captcha());
                            }
                            else
                            {
                                MessageBox.Show("Пароль неверный");

                            }
                        } 

                    }

                }
            }
        }
    
        //войти как гость
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Manage.MainFrame.Navigate(new Products());
        }
    }
}
