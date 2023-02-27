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
using static Anekdoti.Utils.Logs;

using Database;

namespace Anekdoti.Gui
{
    /// <summary>
    /// Логика взаимодействия для AddPersonWindow.xaml
    /// </summary>
    public partial class AddPersonWindow : Window
    {
        Person makingPerson;
        MainWindow currentWnd;

        public AddPersonWindow(MainWindow _wnd)
        {
            InitializeComponent();
            currentWnd = _wnd;

            LogInfo("Opened AddPersonWindow");
        }
    }
}
