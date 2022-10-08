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

namespace zach2
{
    /// <summary>
    /// Логика взаимодействия для Captcha.xaml
    /// </summary>
    public partial class Captcha : Page
    {
        public Captcha()
        {
            InitializeComponent();
            cpt.CreateCaptcha(EasyCaptcha.Wpf.Captcha.LetterOption.Alphanumeric, 4);
            var dsf = cpt.CaptchaText;
        }
        //Вход
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == this.cpt.CaptchaText)
                Manage.MainFrame.Navigate(new Products());
            else
                MessageBox.Show("Ошибка!");
        }
        //Обновление капчи
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            cpt.CreateCaptcha(EasyCaptcha.Wpf.Captcha.LetterOption.Alphanumeric, 4);
            var dsf = cpt.CaptchaText;
        }
    }
}
