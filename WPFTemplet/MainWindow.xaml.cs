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
using WPFTemplet.WindowUI;
using WPFTemplet.WindowUI.ModernMessageBox; //Adding Windows Folder Path To The Project
using WPFTemplet.WindowUI.EULA;
using WPFTemplet.Class;
using WPFTemplet.WindowUI.AppLog;

namespace WPFTemplet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
            MaxWidth = SystemParameters.MaximizedPrimaryScreenWidth;

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
                    brdrMainWindow.Opacity = 0.7;

                    if (this.Cursor != Cursors.Wait)
                    {
                        Mouse.OverrideCursor = Cursors.SizeAll;
                    }

                    DragMove();
                }
            }

            if (e.LeftButton == MouseButtonState.Released)
            {
                brdrMainWindow.Opacity = 1;

                if (this.Cursor != Cursors.Wait)
                {
                    Mouse.OverrideCursor = Cursors.Arrow;
                }
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            //this.Close();

            Application.Current.Shutdown();
        }

        private void btnMaximize_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
            {
                WindowState = WindowState.Maximized;
                brdrMainWindow.CornerRadius = new CornerRadius(0);

            }
            else
            {
                WindowState = WindowState.Normal;
                brdrMainWindow.CornerRadius = new CornerRadius(10);
            }
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
            {
                WindowState = WindowState.Minimized;
            }
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxOk messageBoxOk = new MessageBoxOk("Test OK" , "This is Ok Test .....",200,350, @"/Images/MessageBoxIcons/Information.png", @"/Images/MessageBoxIcons/Information.png");
            messageBoxOk.Owner = this;
            messageBoxOk.ShowDialog();
        }

        private void btnOkCancel_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxOkCancel messageBoxOkCancel = new MessageBoxOkCancel("Test OK & Cancel", "This is Ok & Cancel Test .....", 200, 500, @"/Images/MessageBoxIcons/Information.png", @"/Images/MessageBoxIcons/Information.png");
            messageBoxOkCancel.Owner = this;
            messageBoxOkCancel.ShowDialog();

            if (messageBoxOkCancel.DialogResultRetern)
            {
                MessageBox.Show("True");
            }
            else
            {
                MessageBox.Show("False");
            }
        }

        private void btnYesNo_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxYesNo messageBoxYesNo = new MessageBoxYesNo("Test Yes& No", "This is Yes & No Test .....", 200, 500, @"/Images/MessageBoxIcons/Information.png", @"/Images/MessageBoxIcons/Information.png");
            messageBoxYesNo.Owner = this;
            messageBoxYesNo.ShowDialog();

            if (messageBoxYesNo.DialogResultRetern)
            {
                MessageBox.Show("True");
            }
            else
            {
                MessageBox.Show("False");
            }
        }

        private void btnYesNoCancel_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxYesNoCancel messageBoxYesNoCancel = new MessageBoxYesNoCancel("Test Yes& No", "This is Yes & No Test .....", 200, 500, @"/Images/MessageBoxIcons/Information.png", @"/Images/MessageBoxIcons/Information.png");
            messageBoxYesNoCancel.Owner = this;
            messageBoxYesNoCancel.ShowDialog();

            if (messageBoxYesNoCancel.DialogResultRetern == "yes")
            {
                MessageBox.Show("Retern yes");
            }
            else if (messageBoxYesNoCancel.DialogResultRetern == "no")
            {
                MessageBox.Show("Retern no");

            }
            else
            {
                MessageBox.Show("Retern cancel");
            }
        }

        private void OpenNewTest_Click(object sender, RoutedEventArgs e)
        {
            UserAgreementWindow userAgreementWindow = new UserAgreementWindow();
            userAgreementWindow.Owner = this;
            userAgreementWindow.ShowDialog();
        }
    }
}
