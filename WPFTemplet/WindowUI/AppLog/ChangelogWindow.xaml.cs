using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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

namespace WPFTemplet.WindowUI.AppLog
{
    /// <summary>
    /// Interaction logic for ChangelogWindow.xaml
    /// </summary>
    public partial class ChangelogWindow : Window
    {

        public ChangelogWindow()
        {
            InitializeComponent();

            txtBxChangeLog.Text = Properties.Resources.ChangeLog;

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

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
