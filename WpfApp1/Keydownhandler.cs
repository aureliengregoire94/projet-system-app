using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    internal class Keydownhandler
    {
        private object sender;
        private RoutedEventArgs e;
        private TextBox txt;

        public Keydownhandler(object sender, RoutedEventArgs e, TextBox txt)
        {
            this.sender = sender;
            this.e = e;
            this.txt = txt;
        }
    }
}