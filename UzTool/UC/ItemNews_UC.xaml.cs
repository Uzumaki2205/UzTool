using Microsoft.Toolkit.Wpf.UI.Controls;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
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

namespace UzTool.UC
{
    /// <summary>
    /// Interaction logic for ItemNews_UC.xaml
    /// </summary>
    public partial class ItemNews_UC : UserControl
    {
        public ItemNews_UC()
        {
            InitializeComponent();
        }

        private void btnCopy_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(this.Tag.ToString());
        }

        [Obsolete]
        private void btnNavigate_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult res = MessageBox.Show("Bạn có muốn chuyển tới trang web không??", "Chuyển hướng tới vnexpress",
                MessageBoxButton.OKCancel, MessageBoxImage.Question);

            Application.Current.Dispatcher.Invoke((Action)delegate
            {
                if (res == MessageBoxResult.OK)
                {
                    Browsers browsers = new Browsers();
                    browsers.Show();
                    browsers.webBrowser.Navigate(this.Tag.ToString()); 
                }
            });
        }
    }
}
