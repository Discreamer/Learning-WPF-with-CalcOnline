using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
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
using System.Reflection;

namespace CalcOnline
{
    
    public partial class MainWindow : Window
    {
        public static int Difficulty;
        string Vivod = "0";
        string Rand;
        int Counter;
        public MainWindow()
        {
            InitializeComponent();
            NewGame();
        }
        public void NewGame()
        {
            Vivod = "0";
            Counter = 0;
            Random rnd = new Random();
            Rand=rnd.Next(100*Difficulty, 1000*Difficulty).ToString();
            label.Content = "Вы должны получить число %RandomNum%".Replace("%RandomNum%", Rand);
            CountLab.Content = "Количество ходов: ";
        }
        public void init()
        {
            CountLab.Content = "Количество ходов: " + Counter.ToString();
            Output.Content = Vivod;
            if (Vivod == "")
            {
                Vivod = "0";
            } 
        }
        public void CheckToRules(string Let)
        {
            string Word = Vivod.ToString();
            if (Word[0] == '0')
            {
                Vivod = "";
            }
            if (Vivod.Length == 0)
            {
                Vivod += Let;
            }
            else
            {
                if (!"1234567890".Contains(Vivod[Vivod.Length - 1]))
                {
                    Vivod += Let;
                }
            }
            init();
        }
        public void CheckToRules2(string Let)
        {
            Counter++;
            if (Vivod[Vivod.Length - 1]!=' ')
            {
                Vivod += Let;
            }
            init();
        }
        private void One_Click(object sender, RoutedEventArgs e)
        {
            CheckToRules("1");
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            CheckToRules("2");
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            CheckToRules("3");
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            CheckToRules("4");
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            CheckToRules("5");
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            CheckToRules("6");
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            CheckToRules("7");
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            CheckToRules("8");
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            CheckToRules("9");
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            CheckToRules("0");
        }
        private void point_Click(object sender, RoutedEventArgs e)
        {
            if (Vivod[Vivod.Length - 1] != ' ')
            {
                Vivod += '.';
            }
            init();
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            Vivod=Vivod.Remove(Vivod.Length - 1);
            init();
        }

        private void Mnoj_Click(object sender, RoutedEventArgs e)
        {

            CheckToRules2("*");
        }

        private void Rovno_Click(object sender, RoutedEventArgs e)
        {
            object result=0.0;
            Counter++;
            if(Vivod[Vivod.Length-1]!=' ')
            {
                try
                {
                    result = new DataTable().Compute(Vivod, null);
                }
                catch
                {
                    MessageBox.Show("Ошибка в Output!!!!!!!!!!!!!!!!!!!!!!!!!!\n!!!!!!!!!!!");
                }
                Vivod = result.ToString().Replace(',', '.'); ;
                
            }
            init();
            if (Vivod == Rand)
            {
                MessageBox.Show("Ты красавчик");
                NewGame();
            }

        }

        private void Delit_Click(object sender, RoutedEventArgs e)
        {
            CheckToRules2("/");
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            CheckToRules2("+");
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            CheckToRules2("-");
        }

        private void Leftskob_Click(object sender, RoutedEventArgs e)
        {
            Vivod += "(";
            init();
        }

        private void Rightskob_Click(object sender, RoutedEventArgs e)
        {
            Vivod += ")";
            init();
        }
    }
}
