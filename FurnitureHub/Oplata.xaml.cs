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

namespace FurnitureHub
{
    /// <summary>
    /// Логика взаимодействия для Oplata.xaml
    /// </summary>
    public partial class Oplata : Window
    {
        public Oplata()
        {
            InitializeComponent();
        }
        private void ExitButt_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void MinButt_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Toolbar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (tb1.Text != "")
            {
                if (tb2.Text != "")
                {
                    if (tb3.Text != "")
                    {
                        if (tb4.Text != "")
                        {
                            if (tb5.Text != "")
                            {
                                MessageBox.Show("Заказ успешно оформлен!");
                                Home home = new Home();
                                home.Show();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Адрес доставки не заполнен");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Город не заполнен");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email не заполнен");
                    }
                }
                else
                {
                    MessageBox.Show("Номер телефона не заполнен");
                }
            }
            else
            {
                MessageBox.Show("ФИО не заполнено");
            }

        }
    }
}
