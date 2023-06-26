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
    /// Логика взаимодействия для Home2.xaml
    /// </summary>
    public partial class Home2 : Window
    {
        public Home2()
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

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Krowat krowat = new Krowat();
            krowat.Show();
            this.Close();
        }
    }
}
