using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFTemplet.WindowUI.ModernMessageBox
{
    /// <summary>
    /// Interaction logic for MessageBoxYesNo.xaml
    /// </summary>
    public partial class MessageBoxYesNo : Window
    {
        public bool DialogResultRetern = false;

        public MessageBoxYesNo(string MassageHeader, string Massage, int CustomHeight, int CustomWidth, string IconHeader, string ImageMassage)
        {
            InitializeComponent();

            btnYes.Focus();

            #region Play System Sound

            SystemSounds.Asterisk.Play();
            //SystemSounds.Beep.Play();
            //SystemSounds.Exclamation.Play();
            //SystemSounds.Hand.Play();
            //SystemSounds.Question.Play();

            //Console.Beep();

            #endregion

            this.Height = CustomHeight;
            this.Width = CustomWidth;

            txtHeader.Text = MassageHeader;
            txtMassage.Text = Massage;

            imgIconHeader.Source = new BitmapImage(new Uri(IconHeader, UriKind.RelativeOrAbsolute));
            imgMassage.Source = new BitmapImage(new Uri(ImageMassage, UriKind.RelativeOrAbsolute));

        }

        private void btnNo_Click(object sender, RoutedEventArgs e)
        {
            DialogResultRetern = false;
            this.Close();
        }

        private void btnYes_Click(object sender, RoutedEventArgs e)
        {
            DialogResultRetern = true;
            this.Close();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            DialogResultRetern = false;
            this.Close();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                brdrMessageBoxYesNoWindow.Opacity = 0.7;
                imgMassage.Opacity = 0.7;

                if (this.Cursor != Cursors.Wait)
                {
                    Mouse.OverrideCursor = Cursors.SizeAll;
                }

                DragMove();

            }

            if (e.LeftButton == MouseButtonState.Released)
            {
                brdrMessageBoxYesNoWindow.Opacity = 1;
                imgMassage.Opacity = 1;

                if (this.Cursor != Cursors.Wait)
                {
                    Mouse.OverrideCursor = Cursors.Arrow;
                }
            }
        }
    }
}
