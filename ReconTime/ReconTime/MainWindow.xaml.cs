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

namespace ReconTime
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

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                inputValidation();
            }
        }

        private void checkIn(int barcode)
        {   //TODO
            String outputString = "Login: " + barcode;
            Console.WriteLine(outputString);
            setScanLable(outputString);
        }
        private void checkOut(int barcode)
        {   //TODO
            String outputString = "Logout: " + barcode;
            Console.WriteLine(outputString);
            setScanLable(outputString);
            
        }
        private void printWrongFormat(int length)
        {
            String errormessage = "Falsches Format. Bitte geben Sie eine Nummer mit " + length + " Zeichen ein.";
            Console.WriteLine(errormessage);
            setScanLable(errormessage);
        }

        private void setScanLable(String input)
        {
            scanLable.Document.Blocks.Clear();
            scanLable.Document.Blocks.Add(new Paragraph(new Run(input)));
            scanBarcodeBox.Text = "";
        }

        private void inputValidation()
        {
            int inputLength = 4;
            int barcode = 0;
            String input = scanBarcodeBox.Text;
            if (input.Length == inputLength)
            {
                try
                {
                    barcode = int.Parse(input);
                }
                catch
                {
                    printWrongFormat(inputLength);
                }

                if (barcode % 2 == 0) //Refactor: iseven method
                {
                    checkIn(barcode);
                }
                else
                {
                    checkOut(barcode);
                }
            }
            else
            {
                printWrongFormat(inputLength);
            }
        }
        private void buttonOk_Click(object sender, RoutedEventArgs e)
        {
            inputValidation();
        }
    }
}
