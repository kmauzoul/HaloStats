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
using HaloStats.Library;
using HaloStats.Http;
using System.IO;

namespace HaloStats.WPF
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

        private BitmapImage GetImageFromStream(Stream stream)
        {
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.StreamSource = stream;
            image.CacheOption = BitmapCacheOption.OnLoad;
            image.EndInit();
            image.Freeze(); //This will allow me to use this image across threads
            return image;
        }

        private async void BtnLoadGamertag_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //sloppy testing here but...
                HttpREST rest = new HttpREST();
                //Get Spartan and Emblem...
                //Image spartanImage = Image.FromStream(await rest.GetImage($"profile/h5/profiles/{TxtGamertag.Text}/spartan?size=128"));
                //Image emblemImage = Image.FromStream(await rest.GetImage($"profile/h5/profiles/{TxtGamertag.Text}/emblem?size=128"));

                BitmapImage emblem = GetImageFromStream(await rest.GetImage($"profile/h5/profiles/{TxtGamertag.Text}/emblem?size=128"));
                BitmapImage spartan = GetImageFromStream(await rest.GetImage($"profile/h5/profiles/{TxtGamertag.Text}/spartan?size=128"));

                //Get player history
                //var history = await rest.GetItem<PlayerMatchHistory>($"stats/h5/players/{TxtGamertag.Text}/matches?modes=Arena&start=0&count=10");


                //StopProgress();
                ImgEmblem.Source = emblem;
                ImgSpartan.Source = spartan;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                //Cursor.Current = Cursors.Default;
                //MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //StopProgress();
            }

        }

        private void TxtGamertag_TextChanged(object sender, TextChangedEventArgs e)
        {
            BtnLoadGamertag.IsEnabled = string.IsNullOrWhiteSpace(TxtGamertag.Text) ? false : true;
        }
    }
}
