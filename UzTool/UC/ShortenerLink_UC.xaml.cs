using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UzTool.Method;

namespace UzTool.UC
{
    /// <summary>
    /// Interaction logic for ShortenerLink_UC.xaml
    /// </summary>
    public partial class ShortenerLink_UC : UserControl
    {
        public ShortenerLink_UC()
        {
            InitializeComponent();
        }
        
        ShorterLink shorterLink = new ShorterLink();
        private void btnShortener_Click(object sender, RoutedEventArgs e)
        {
            if (txtLink.Text != string.Empty)
            {
                try
                { 
                    txtLink.Text = shorterLink.TinyURL(txtLink.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Kiểm tra lại link!!", "Lỗi", 
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnCopy_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(txtLink.Text);
        }

        private void btnCopy1_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(txtLink_Bom.Text);
        }

        private void ShortenerLink_Bom_Click(object sender, RoutedEventArgs e)
        {
            if (txtLink_Bom.Text != string.Empty)
            {
                try
                {
                    txtLink_Bom.Text = shorterLink.BomURL(txtLink_Bom.Text, txtCustom.Text)
                        .Substring(20).Replace("\"}", "").Replace("\\", "");
                }
                catch (Exception)
                {
                    MessageBox.Show("Kiểm tra lại link hoặc đổi alias bị trùng!!", "Lỗi alias", 
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
