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
using RegisterPage.Controller;
using RegisterPage.Model;

namespace RegisterPage
{

    public partial class MainWindow : VerificationResponse
    {
        MainWindowController controller;
        public MainWindow()
        {
            InitializeComponent();
            controller = new MainWindowController();
            controller.SubscribeVerificationResult(this);
        }

        private void checkBoxEmail_Checked(object sender, RoutedEventArgs e)
        {
            controller.SubscribeEmailVerification();
        }
        private void checkBoxEmail_Unchecked(object sender, RoutedEventArgs e)
        {
            controller.UnsubscribeEmailVerification();
        }

        private void checkBoxWhatsaap_Checked(object sender, RoutedEventArgs e)
        {
            controller.SubscribeWhatsaapVerification();
        }
        private void checkBoxWhatsaap_Unchecked(object sender, RoutedEventArgs e)
        {
            controller.UnsubscribeWhatsaapVerification();
        }

        private void ButtonDaftarClicked(object sender, RoutedEventArgs e)
        {
            labelEmail.Content = " ";
            labelWhatsaap.Content = " ";
            controller.registeringUser(textBoxNama.Text, textBoxEmail.Text, textBoxWhatsaap.Text);
        }

        public void OnEmailVerificationSucces(object source, EventArgs e)
        {
            labelEmail.Content = "Email berhasil dikirim";
        }
        public void OnWhatsaapVerificationSucces(object source, EventArgs e)
        {
            labelWhatsaap.Content = "Whataap berhasil dikirim";
        }
        
    }
}
