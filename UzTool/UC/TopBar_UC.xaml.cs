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

namespace UzTool.UC
{
    /// <summary>
    /// Interaction logic for TopBar_UC.xaml
    /// </summary>
    public partial class TopBar_UC : UserControl
    {
        //protected bool isDragging;
        //private Point clickPosition;
        public TopBar_UC()
        {
            InitializeComponent();
        }

        

        //private void TopBar_UC_MouseMove(object sender, MouseEventArgs e)
        //{
        //    var draggableControl = sender as UserControl;

        //    if (isDragging && draggableControl != null)
        //    {
        //        Point currentPosition = e.GetPosition(this.Parent as UIElement);

        //        var transform = draggableControl.RenderTransform as TranslateTransform;
        //        if (transform == null)
        //        {
        //            transform = new TranslateTransform();
        //            draggableControl.RenderTransform = transform;
        //        }

        //        transform.X = currentPosition.X - clickPosition.X;
        //        transform.Y = currentPosition.Y - clickPosition.Y;
        //    }
        //}

        //private void TopBar_UC_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        //{
        //    isDragging = false;
        //    var draggable = sender as UserControl;
        //    draggable.ReleaseMouseCapture();
        //}

        //private void TopBar_UC_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    isDragging = true;
        //    var draggableControl = sender as UserControl;
        //    clickPosition = e.GetPosition(this);
        //    draggableControl.CaptureMouse();
        //}
    }
}
