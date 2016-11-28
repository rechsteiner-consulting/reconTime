﻿using System;
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

        private void inputBarcode_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void inputBarcode_Enter(object sender, DragEventArgs e)
        {
            inputValidation();
        }

        private void checkIn(int barcode)
        {   //TODO
            Console.WriteLine("Login: " + barcode);
        }
        private void checkOut(int barcode)
        {   //TODO
            Console.WriteLine("Logout: " + barcode);
        }
        private void printWrongFormat(int length)
        {

            Console.WriteLine("Falsches Format. Bitte geben Sie eine Nummer mit " + length + " Zeichen ein.");
        }

        private void inputValidation()
        {
            int inputLength = 4;
            int barcode = 0;
            String input = inputBarcode.Text;
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
                if (barcode % 2 == 0)
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
