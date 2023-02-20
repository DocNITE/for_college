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

using Database;

namespace Anekdoti
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Canvas currWnd;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnSwitchWindow(object sender, RoutedEventArgs e)
        {
            Button _switchButton = (Button)e.Source;

            for(int i = 0; i < this.cMainWindow.Children.Count; i++)
            {
                Canvas _elem = (Canvas)this.cMainWindow.Children[i];
                Console.WriteLine("f. element: " + "c" + _switchButton.Name.Substring(1)
                    + "\ns.element: " + _elem.Name);
                if (_elem.Name == ("c" + _switchButton.Name.Substring(1)))
                {
                    Console.WriteLine("Finded?");
                    if (currWnd != null)
                    {
                        currWnd.Visibility = Visibility.Hidden;
                    }
                    currWnd = _elem;
                    currWnd.Visibility = Visibility.Visible;

                    break;
                }
            }
        }
    }
}
