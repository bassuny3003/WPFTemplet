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
using System.Windows.Shapes;

namespace WPFTemplet.WindowUI.EULA
{
    /// <summary>
    /// Interaction logic for AgreementAcceptedWindow.xaml
    /// </summary>
    public partial class AgreementAcceptedWindow : Window
    {
        public AgreementAcceptedWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                if (WindowState == WindowState.Maximized)
                {
                    return;
                }
                else
                {
                    brdrChanglogWindow.Opacity = 0.7;

                    if (this.Cursor != Cursors.Wait)
                    {
                        Mouse.OverrideCursor = Cursors.SizeAll;
                    }

                    DragMove();
                }
            }

            if (e.LeftButton == MouseButtonState.Released)
            {
                brdrChanglogWindow.Opacity = 1;

                if (this.Cursor != Cursors.Wait)
                {
                    Mouse.OverrideCursor = Cursors.Arrow;
                }
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void radArabic_Checked(object sender, RoutedEventArgs e)
        {
            txtBxUserAgreement.FlowDirection = FlowDirection.RightToLeft;
            txtBxUserAgreement.Text = Properties.Resources.EULAArabic;
        }

        private void radEnglish_Checked(object sender, RoutedEventArgs e)
        {
            txtBxUserAgreement.FlowDirection = FlowDirection.LeftToRight;
            txtBxUserAgreement.Text = Properties.Resources.EULAEnglish;
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
