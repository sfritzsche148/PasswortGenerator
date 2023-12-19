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
        string allText = "";

        private void Generate_Click(object sender, RoutedEventArgs e)
        {

            double maxLength = lenghtSlider.Value;

            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w' , 'x', 'y' };
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            char[] specialCharacters = { '@', '~', '#', '_', '*', '%', '.'};
            Random random = new Random();





            switch(maxLength)
            {
                case 8:
                    allText = ""; // Hier wird der TextBlock gelehrt;

                    for (int i = 0; i <= 8; i++)
                    {

                        int letterOrNumberOrSpecialCharacter = random.Next(1, 30);

                        if (letterOrNumberOrSpecialCharacter < 10)
                        {
                            int letterIndex = random.Next(0, alphabet.Length);
                            char letter = alphabet[letterIndex];

                            int upOrLowIndex = random.Next(0, 10);

                            if (upOrLowIndex <= 5) 
                                resultBlock.Text = allText + letter.ToString().ToUpper();

                            else
                                resultBlock.Text = allText + letter.ToString().ToLower();
                            
                        }
                        else if (letterOrNumberOrSpecialCharacter <= 20 && letterOrNumberOrSpecialCharacter > 10)
                        {
                            int numberIndex = random.Next(0, numbers.Length);
                            resultBlock.Text = allText + numbers[numberIndex];
                           
                        } else
                        {
                            int specialCharacterIndex = random.Next(0, specialCharacters.Length);
                            resultBlock.Text = allText + specialCharacters[specialCharacterIndex];
                        }

                        allText = resultBlock.Text;
                    }


                    break;
                case 9:
                    allText = ""; // Hier wird der TextBlock gelehrt;

                    for (int i = 0; i <= 9; i++)
                    {
                        int letterOrNumberOrSpecialCharacter = random.Next(1, 30);

                        if (letterOrNumberOrSpecialCharacter < 10)
                        {
                            int letterIndex = random.Next(0, alphabet.Length);
                            char letter = alphabet[letterIndex];

                            int upOrLowIndex = random.Next(0, 10);

                            if (upOrLowIndex <= 5)
                                resultBlock.Text = allText + letter.ToString().ToUpper();

                            else
                                resultBlock.Text = allText + letter.ToString().ToLower();

                        }
                        else if (letterOrNumberOrSpecialCharacter <= 20 && letterOrNumberOrSpecialCharacter > 10)
                        {
                            int numberIndex = random.Next(0, numbers.Length);
                            resultBlock.Text = allText + numbers[numberIndex];

                        }
                        else
                        {
                            int specialCharacterIndex = random.Next(0, specialCharacters.Length);
                            resultBlock.Text = allText + specialCharacters[specialCharacterIndex];
                        }

                        allText = resultBlock.Text;
                    }
                    

                    break;
                case 10:
                    allText = ""; // Hier wird der TextBlock gelehrt;

                    for (int i = 0; i <= 10; i++)
                    {
                        int letterOrNumberOrSpecialCharacter = random.Next(1, 30);

                        if (letterOrNumberOrSpecialCharacter < 10)
                        {
                            int letterIndex = random.Next(0, alphabet.Length);
                            char letter = alphabet[letterIndex];

                            int upOrLowIndex = random.Next(0, 10);

                            if (upOrLowIndex <= 5)
                                resultBlock.Text = allText + letter.ToString().ToUpper();

                            else
                                resultBlock.Text = allText + letter.ToString().ToLower();

                        }
                        else if (letterOrNumberOrSpecialCharacter <= 20 && letterOrNumberOrSpecialCharacter > 10)
                        {
                            int numberIndex = random.Next(0, numbers.Length);
                            resultBlock.Text = allText + numbers[numberIndex];

                        }
                        else
                        {
                            int specialCharacterIndex = random.Next(0, specialCharacters.Length);
                            resultBlock.Text = allText + specialCharacters[specialCharacterIndex];
                        }

                        allText = resultBlock.Text;
                    }
                    

                    break;
                case 11:
                    allText = ""; // Hier wird der TextBlock gelehrt;

                    for (int i = 0; i <= 11; i++)
                    {
                        int letterOrNumberOrSpecialCharacter = random.Next(1, 30);

                        if (letterOrNumberOrSpecialCharacter < 10)
                        {
                            int letterIndex = random.Next(0, alphabet.Length);
                            char letter = alphabet[letterIndex];

                            int upOrLowIndex = random.Next(0, 10);

                            if (upOrLowIndex <= 5)
                                resultBlock.Text = allText + letter.ToString().ToUpper();

                            else
                                resultBlock.Text = allText + letter.ToString().ToLower();

                        }
                        else if (letterOrNumberOrSpecialCharacter <= 20 && letterOrNumberOrSpecialCharacter > 10)
                        {
                            int numberIndex = random.Next(0, numbers.Length);
                            resultBlock.Text = allText + numbers[numberIndex];

                        }
                        else
                        {
                            int specialCharacterIndex = random.Next(0, specialCharacters.Length);
                            resultBlock.Text = allText + specialCharacters[specialCharacterIndex];
                        }

                        allText = resultBlock.Text;
                    }
                    

                    break;
                case 12:
                    allText = ""; // Hier wird der TextBlock gelehrt;

                    for (int i = 0; i <= 12; i++)
                    {
                        int letterOrNumberOrSpecialCharacter = random.Next(1, 30);

                        if (letterOrNumberOrSpecialCharacter < 10)
                        {
                            int letterIndex = random.Next(0, alphabet.Length);
                            char letter = alphabet[letterIndex];

                            int upOrLowIndex = random.Next(0, 10);

                            if (upOrLowIndex <= 5)
                                resultBlock.Text = allText + letter.ToString().ToUpper();

                            else
                                resultBlock.Text = allText + letter.ToString().ToLower();

                        }
                        else if (letterOrNumberOrSpecialCharacter <= 20 && letterOrNumberOrSpecialCharacter > 10)
                        {
                            int numberIndex = random.Next(0, numbers.Length);
                            resultBlock.Text = allText + numbers[numberIndex];

                        }
                        else
                        {
                            int specialCharacterIndex = random.Next(0, specialCharacters.Length);
                            resultBlock.Text = allText + specialCharacters[specialCharacterIndex];
                        }

                        allText = resultBlock.Text;
                    }
                    

                    break;
                case 13:
                    allText = ""; // Hier wird der TextBlock gelehrt;

                    for (int i = 0; i <= 13; i++)
                    {
                        int letterOrNumberOrSpecialCharacter = random.Next(1, 30);

                        if (letterOrNumberOrSpecialCharacter < 10)
                        {
                            int letterIndex = random.Next(0, alphabet.Length);
                            char letter = alphabet[letterIndex];

                            int upOrLowIndex = random.Next(0, 10);

                            if (upOrLowIndex <= 5)
                                resultBlock.Text = allText + letter.ToString().ToUpper();

                            else
                                resultBlock.Text = allText + letter.ToString().ToLower();

                        }
                        else if (letterOrNumberOrSpecialCharacter <= 20 && letterOrNumberOrSpecialCharacter > 10)
                        {
                            int numberIndex = random.Next(0, numbers.Length);
                            resultBlock.Text = allText + numbers[numberIndex];

                        }
                        else
                        {
                            int specialCharacterIndex = random.Next(0, specialCharacters.Length);
                            resultBlock.Text = allText + specialCharacters[specialCharacterIndex];
                        }

                        allText = resultBlock.Text;
                    }
                    

                    break;
                case 14:
                    allText = ""; // Hier wird der TextBlock gelehrt;

                    for (int i = 0; i <= 14; i++)
                    {
                        int letterOrNumberOrSpecialCharacter = random.Next(1, 30);

                        if (letterOrNumberOrSpecialCharacter < 10)
                        {
                            int letterIndex = random.Next(0, alphabet.Length);
                            char letter = alphabet[letterIndex];

                            int upOrLowIndex = random.Next(0, 10);

                            if (upOrLowIndex <= 5)
                                resultBlock.Text = allText + letter.ToString().ToUpper();

                            else
                                resultBlock.Text = allText + letter.ToString().ToLower();

                        }
                        else if (letterOrNumberOrSpecialCharacter <= 20 && letterOrNumberOrSpecialCharacter > 10)
                        {
                            int numberIndex = random.Next(0, numbers.Length);
                            resultBlock.Text = allText + numbers[numberIndex];

                        }
                        else
                        {
                            int specialCharacterIndex = random.Next(0, specialCharacters.Length);
                            resultBlock.Text = allText + specialCharacters[specialCharacterIndex];
                        }

                        allText = resultBlock.Text;

                    }
                    
                    break;
            }

        }

        private void copy_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(allText);
            bestätigung.Text = "Passwort kopiert";
        }
    }
}
