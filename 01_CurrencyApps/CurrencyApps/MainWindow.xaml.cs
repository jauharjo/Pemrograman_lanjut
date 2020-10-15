using System;
using System.Text.RegularExpressions;
using System.Windows;

namespace CurrencyApps
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CurrencyController currency;
        public MainWindow()
        {
            InitializeComponent();
            currency = new CurrencyController();
        }


        private void Button_Hitung_Click(object sender, RoutedEventArgs e)
        {
            /*
            var nominalString = Input_Textbox.Text;
            var nominalDouble = Convert.ToDouble(nominalString);
            Label_Hasil.Content = Convert.ToString(nominalDouble * 15000);
            */
            /*
            var nominalString = Input_Textbox.Text;
            Regex regex = new Regex("[^0-9.-]+");
            if (!regex.IsMatch(nominalString))
            {
                var nominalDouble = Convert.ToDouble(nominalString);
                Label_Hasil.Content = Convert.ToString(nominalDouble * 15000);
            }
            else             {
               Label_Hasil.Content = "Input harus angka";
            }
            */

            var input = Input_Textbox.Text;
            var hasil = "Input Harus Angka !";
            if (currency.IsAllowed(input))
            {
                hasil = currency.UsdToIdr(input);
            }
            Label_Hasil.Content = hasil;

        }
    }
}
