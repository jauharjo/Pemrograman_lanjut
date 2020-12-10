using FreshFruit.Controller;
using FreshFruit.Model;
using System.Windows;

namespace FreshFruit
{

    public partial class MainWindow : Window, BucketEventListener
    {
        private Seller Jo;
        Fruit anggur = new Fruit("Anggur");
        Fruit apel = new Fruit("Apel");
        Fruit pisang = new Fruit("Pisang");
        Fruit jeruk = new Fruit("Jeruk");

        public MainWindow()
        {
            InitializeComponent();
            Bucket keranjangBuah = new Bucket(4);
            BucketController bucketController = new BucketController(keranjangBuah, this);

            Jo = new Seller("Jo", bucketController);

            ListBoxBucket.ItemsSource = keranjangBuah.findAll();

        }

        private void OnButtonAddAnggurClicked(object sender, RoutedEventArgs e)
        {
            Jo.addFruit(anggur);
        }

        private void OnButtonAddApelClicked(object sender, RoutedEventArgs e)
        {
            Jo.addFruit(apel);
        }

        private void OnButtonAddPisangClicked(object sender, RoutedEventArgs e)
        {
            Jo.addFruit(pisang);
        }

        private void OnButtonAddJerukClicked(object sender, RoutedEventArgs e)
        {
            Jo.addFruit(jeruk);
        }
        private void OnButtonClearClicked(object sender, RoutedEventArgs e)
        {
            Jo.removeFruit(anggur);
            Jo.removeFruit(apel);
            Jo.removeFruit(pisang);
            Jo.removeFruit(jeruk);
        }
        public void onSucceed(string message)
        {
            ListBoxBucket.Items.Refresh();
        }

        public void onFailed(string message)
        {
            MessageBox.Show(message, "Warning !");
        }

        private void ListBoxBucket_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            Jo.removeFruit(anggur);
            Jo.removeFruit(apel);
            Jo.removeFruit(pisang);
            Jo.removeFruit(jeruk);
        }
    }
}
