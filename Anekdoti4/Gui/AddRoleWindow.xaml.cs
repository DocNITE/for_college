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
using Anekdoti.ViewModel;
using Database;

namespace Anekdoti.Gui
{
    /// <summary>
    /// Логика взаимодействия для AddRoleWindow.xaml
    /// </summary>
    public partial class AddRoleWindow : Window
    {
        MainWindow currentWnd;
        public AddRoleWindow(MainWindow currentWnd)
        {
            InitializeComponent();
            this.currentWnd = currentWnd;

            LogInfo("Opened AddRoleWindow");
        }

        private void OnRoleAdd(object sender, RoutedEventArgs e)
        {
            try
            {
                var role = this.RoleName.Text;

                int nId = 0;
                foreach (var item in currentWnd.vmRole.ListRole)
                {
                    if (item.Id >= nId)
                    {
                        nId = item.Id + 1;
                    }
                }

                currentWnd.vmRole.ListRole.Add(new Role
                {
                    Id = nId,
                    Name = role
                });
            }
            catch 
            {

            }
            this.Close();
        }

        private void OnCancelEv(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
