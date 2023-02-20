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
using System.Windows.Shapes;

namespace Anekdoti.Gui
{
    /// <summary>
    /// Логика взаимодействия для Adding.xaml
    /// </summary>
    public partial class Adding : Window
    {
        Canvas currWnd;

        public Adding()
        {
            InitializeComponent();
        }

        private void OnSwitchWindow(object sender, RoutedEventArgs e)
        {
            Button _switchButton = (Button)e.Source;

            for (int i = 0; i < this.cMainWindow.Children.Count; i++)
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
