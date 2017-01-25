using System;
using System.Globalization;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;

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
            TimeWriter writer = new TimeWriter();
            barcode = Decimal.ToInt32(Math.Floor(Convert.ToDecimal(barcode / 10)));
            if (writer.CheckIn(DateTime.Now, barcode))
            {
                writeCheck("Hallo", barcode, DateTime.Now);
            } else
            {
                setScanLable("Da ist was schief gelaufen. Überprüfe deine Eingabe!");
            }

        }
        private void checkOut(int barcode)
        {   //TODO
            TimeWriter writer = new ReconTime.TimeWriter();
            barcode = Decimal.ToInt32(Math.Floor(Convert.ToDecimal(barcode/10)));
            writeCheck("Tschüss", barcode, DateTime.Now);   
            writer.CheckOut(DateTime.Now, barcode);
        }

        private void writeCheck(String checkType, int barcode, DateTime time)
        {
            String outputString = checkType + " " + barcode + "\nDatum / Zeit:\t " + time.ToString(new CultureInfo("de-DE"));
            Console.WriteLine(outputString);
            setScanLable(outputString);
        }
        private void printWrongFormat(int length)
        {
            String errormessage = "Falsches Format. Bitte geben Sie eine Nummer mit " + length + " Zeichen ein.";
            if(length == -1)
            {
                errormessage = "Keine führende 0 erlaubt";
            }
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
                    if (barcode < 1000)
                    {
                        throw new FormatException();
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
                catch (FormatException e)
                {
                    printWrongFormat(-1);
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

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            setScanLable("");
        }
    }
}
