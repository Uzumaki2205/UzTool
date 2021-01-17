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
    /// Interaction logic for News_UC.xaml
    /// </summary>
    public partial class News_UC : UserControl
    {
        public News_UC()
        {
            InitializeComponent();
        }

        private void TabItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TabItem tab = sender as TabItem;
            News news = new News();

            var listNews = news.getVNNew("https://vnexpress.net/" + tab.Tag.ToString());
            ItemNews_UC itemNews;

            foreach (var item in listNews)
            {
                itemNews = new ItemNews_UC();
                itemNews.newsTitle.Text = item[0];
                itemNews.newsContent.Text = item[1];
                itemNews.Tag = item[2];
                
                switch (tab.Tag.ToString())
                {
                    case "tin-tuc-24h":
                        stack_tinmoi.Children.Add(itemNews);
                        break;
                    case "thoi-su":
                        stack_thoisu.Children.Add(itemNews);
                        break;
                    case "the-gioi":
                        stack_thegioi.Children.Add(itemNews);
                        break;
                    case "kinh-doanh":
                        stack_kinhdoanh.Children.Add(itemNews);
                        break;
                    case "giai-tri": 
                        stack_giaitri.Children.Add(itemNews);
                        break;
                    case "the-thao":
                        stack_thethao.Children.Add(itemNews);
                        break;
                    case "phap-luat":
                        stack_phapluat.Children.Add(itemNews);
                        break;
                    case "giao-duc":
                        stack_giaoduc.Children.Add(itemNews);
                        break;
                    case "doi-song":
                        stack_doisong.Children.Add(itemNews);
                        break;
                    case "du-lich":
                        stack_dulich.Children.Add(itemNews);
                        break;
                    case "khoa-hoc":
                        stack_khoahoc.Children.Add(itemNews);
                        break;
                    case "so-hoa":
                        stack_sohoa.Children.Add(itemNews);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
