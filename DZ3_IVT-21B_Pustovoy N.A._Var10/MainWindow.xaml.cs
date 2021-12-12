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

namespace DZ3_IVT_21B_Pustovoy_N.A._Var10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private string getAnswer(string input)
        {
            string output = "";
            string[] words = input.Split(" ");

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    output += words[i][words[i].Length - j - 1];
                }
                output += " ";
            }

            return output;
        }

        private void bt_Click(object sender, RoutedEventArgs e)
        {
            string input, output;

            input = tbtxt.Text;
            output = getAnswer(input);

            tbtxt.Text = "";
            tbres.Text = output;
        }
    }
}
