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

namespace CalcOnline
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        public void init(int lvl)
        {
            MainWindow.Difficulty = lvl;
            MainWindow taskWindow = new MainWindow();
            taskWindow.Show();
            
            this.Close();
        }
        private void Easy_Click(object sender, RoutedEventArgs e)
        {
            init(1);
        }

        private void Medium_Click(object sender, RoutedEventArgs e)
        {
            init(4);
        }

        private void Hard_Click(object sender, RoutedEventArgs e)
        {
            init(50);
        }

        private void Impossible_Click(object sender, RoutedEventArgs e)
        {
            init(400);
        }
    }
}
