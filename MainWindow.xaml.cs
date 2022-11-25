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

namespace nani
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
        
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           Page1 wishlist=new Page1();
            mainframe.Navigate(wishlist);    
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            Cursor=Cursors.Arrow;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Page2 owned=new Page2();
            mainframe.Navigate(owned);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Page3 links=new Page3();
            mainframe.Navigate(links);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Page4 ordered = new Page4();
            mainframe.Navigate(ordered);
        }
    }
}
