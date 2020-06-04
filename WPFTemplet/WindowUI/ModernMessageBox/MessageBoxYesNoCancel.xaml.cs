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
    /// Interaction logic for MessageBoxYesNoCancel.xaml
    /// </summary>
    public partial class MessageBoxYesNoCancel : Window
    {
        public string DialogResultRetern;

        public MessageBoxYesNoCancel(string MessageHeader, string Message, int CustomHeight, int CustomWidth, string IconHeader, string ImageMessage)
        {
            InitializeComponent();

            btnCancel.Focus();

            #region Play System Sound

            //SystemSounds.Asterisk.Play();
            //SystemSounds.Beep.Play();
            //SystemSounds.Exclamation.Play();
            //SystemSounds.Hand.Play();
            //SystemSounds.Question.Play();

            Console.Beep();

            #endregion

            this.Height = CustomHeight;
            this.Width = CustomWidth;

            txtHeader.Text = MessageHeader;
            txtMassage.Text = Message;

            imgIconHeader.Source = new BitmapImage(new Uri(IconHeader, UriKind.RelativeOrAbsolute));
            imgMassage.Source = new BitmapImage(new Uri(ImageMessage, UriKind.RelativeOrAbsolute));
        }

        private void btnYes_Click(object sender, RoutedEventArgs e)
        {
            DialogResultRetern = "yes";
            this.Close();
        }

        private void btnNo_Click(object sender, RoutedEventArgs e)
        {
            DialogResultRetern = "no";
            this.Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResultRetern = "cancel";
            this.Close();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            DialogResultRetern = "cancel";
            this.Close();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                brdrMessageBoxYesNoCancelWindow.Opacity = 0.7;
                imgMassage.Opacity = 0.7;

                if (this.Cursor != Cursors.Wait)
                {
                    Mouse.OverrideCursor = Cursors.SizeAll;
                }

                DragMove();

            }

            if (e.LeftButton == MouseButtonState.Released)
            {
                brdrMessageBoxYesNoCancelWindow.Opacity = 1;
                imgMassage.Opacity = 1;

                if (this.Cursor != Cursors.Wait)
                {
                    Mouse.OverrideCursor = Cursors.Arrow;
                }
            }
        }
    }
}
