using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PasswortGenerator
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

        private void Generate_Click(object sender, RoutedEventArgs e)
        {

            string allText = "";
            double maxLength = lenghtSlider.Value;

            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w' , 'x', 'y' };
            Random random = new Random();





            switch(maxLength)
            {
                case 8:
                    for (int i = 0; i <= 8; i++)
                    {
                        int letterOrNumber = random.Next(1, 20);

                        if (letterOrNumber < 10)
                        {
                            int letterIndex = random.Next(0, 25);
                            char letter = alphabet[letterIndex];

                            int upOrLowIndex = random.Next(0, 10);

                            if (upOrLowIndex <= 5) 
                                resultBlock.Text = allText + letter.ToString().ToUpper();

                            else
                                resultBlock.Text = allText + letter.ToString().ToLower();
                            
                        }
                        else
                        {
                            resultBlock.Text = allText + "1";
                        }

                        allText = resultBlock.Text;
                    }
                   
                    break;
                case 9:
                    resultBlock.Text = "maxLength = 9";
                    break;
                case 10:
                    resultBlock.Text = "maxLength = 10";
                    break;
                case 11:
                    resultBlock.Text = "maxLength = 11";
                    break;
                case 12:
                    resultBlock.Text = "maxLength = 12";
                    break;
                case 13:
                    resultBlock.Text = "maxLength = 13";
                    break;
                case 14:
                    resultBlock.Text = "maxLength = 14";
                    break;
            }

        }
    }
}
