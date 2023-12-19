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
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
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
                            int numberIndex = random.Next(0, 9);
                            resultBlock.Text = allText + numbers[numberIndex];
                           
                        }

                        allText = resultBlock.Text;
                    }
                   
                    break;
                case 9:
                    for (int i = 0; i <= 9; i++)
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
                            int numberIndex = random.Next(0, 9);
                            resultBlock.Text = allText + numbers[numberIndex];

                        }

                        allText = resultBlock.Text;
                    }
                    break;
                case 10:
                    for (int i = 0; i <= 10; i++)
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
                            int numberIndex = random.Next(0, 9);
                            resultBlock.Text = allText + numbers[numberIndex];

                        }

                        allText = resultBlock.Text;
                    }
                    break;
                case 11:
                    for (int i = 0; i <= 11; i++)
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
                            int numberIndex = random.Next(0, 9);
                            resultBlock.Text = allText + numbers[numberIndex];

                        }

                        allText = resultBlock.Text;
                    }
                    break;
                case 12:
                    for (int i = 0; i <= 12; i++)
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
                            int numberIndex = random.Next(0, 9);
                            resultBlock.Text = allText + numbers[numberIndex];

                        }

                        allText = resultBlock.Text;
                    }
                    break;
                case 13:
                    for (int i = 0; i <= 13; i++)
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
                            int numberIndex = random.Next(0, 9);
                            resultBlock.Text = allText + numbers[numberIndex];

                        }

                        allText = resultBlock.Text;
                    }
                    break;
                case 14:
                    for (int i = 0; i <= 14; i++)
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
                            int numberIndex = random.Next(0, 9);
                            resultBlock.Text = allText + numbers[numberIndex];

                        }

                        allText = resultBlock.Text;
                    }
                    break;
            }

        }
    }
}
