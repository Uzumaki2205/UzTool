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
using UzTool.UC;

namespace UzTool
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

        private void TopBar_UC_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }

        private void TopBar_Btn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Tag.Equals("close"))
            {
                MessageBoxResult result = MessageBox.Show("Bạn có muốn thoát không??", "Thông báo", 
                    MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                    Application.Current.Shutdown();
            }
            else if (btn.Tag.Equals("maximize"))
            {
                if (WindowState == WindowState.Maximized)
                    WindowState = WindowState.Normal;
                else WindowState = WindowState.Maximized;
            }
            else WindowState = WindowState.Minimized;
        }

        private void btnShortLink_Click(object sender, RoutedEventArgs e)
        {
            gridContent.Children.Clear();
            ShortenerLink_UC fr = new ShortenerLink_UC();
            gridContent.Children.Add(fr);
        }

        private void btnNews_Click(object sender, RoutedEventArgs e)
        {
            gridContent.Children.Clear();
            News_UC fr = new News_UC();
            gridContent.Children.Add(fr);
        }
    }
}
