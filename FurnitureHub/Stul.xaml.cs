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
    /// Логика взаимодействия для Stul.xaml
    /// </summary>
    public partial class Stul : Window
    {
        public Stul()
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

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Krowat krowat = new Krowat();
            krowat.Show();
            this.Close();
        }

        private void Label_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            Shkaf shkaf = new Shkaf();
            shkaf.Show();
            this.Close();
        }

        private void Label_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            Stol stol = new Stol();
            stol.Show();
            this.Close();
        }

        private void Label_MouseDown_3(object sender, MouseButtonEventArgs e)
        {

        }

        private void Label_MouseDown_4(object sender, MouseButtonEventArgs e)
        {
            Zerkalo zerkalo = new Zerkalo();
            zerkalo.Show();
            this.Close();
        }

        private void Label_MouseDown_5(object sender, MouseButtonEventArgs e)
        {
            Tumba tumba = new Tumba();
            tumba.Show();
            this.Close();
        }

        private void Label_MouseDown_6(object sender, MouseButtonEventArgs e)
        {
            Matras matras = new Matras();
            matras.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Oplata oplata = new Oplata();
            oplata.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Oplata oplata = new Oplata();
            oplata.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Oplata oplata = new Oplata();
            oplata.Show();
            this.Close();
        }
    }
}
