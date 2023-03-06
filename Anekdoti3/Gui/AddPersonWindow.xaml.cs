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

/*
 * this.ListPerson.Add(
            new Person
            {
                Id = 1,
                RoleId = roles.GetRoleWithId(1),
                FirstName = "Иван",
                LastName = "Иванов",
                Birthday = new DateTime(1980, 02, 28)
            });
 */

namespace Anekdoti.Gui
{
    /// <summary>
    /// Логика взаимодействия для AddPersonWindow.xaml
    /// </summary>
    public partial class AddPersonWindow : Window
    {
        MainWindow currentWnd;

        public AddPersonWindow(MainWindow _wnd)
        {
            InitializeComponent();
            currentWnd = _wnd;

            LogInfo("Opened AddPersonWindow");
        }

        private void OnPersonAdd(object sender, RoutedEventArgs e)
        {
            try
            {
                var firstName = this.PersonFirstName.Text;
                var secondName = this.PersonSecondName.Text;
                var datebirth = this.PersonDate.Text.Split('.');
                var roleId = this.PersonRole.Text;

                int nId = 0;
                foreach (var item in currentWnd.vmPerson.ListPerson)
                {
                    if (item.Id >= nId)
                    {
                        nId = item.Id + 1;
                    }
                }

                currentWnd.vmPerson.ListPerson.Add(new Person
                {
                    Id = nId,
                    RoleId = currentWnd.vmRole.GetRoleWithId(int.Parse(roleId)),
                    FirstName = firstName,
                    LastName = secondName,
                    Birthday = new DateTime(int.Parse(datebirth[2]), int.Parse(datebirth[1]), int.Parse(datebirth[0]))
                });
            }
            catch 
            {
                // TODO: Надо сделать логгер об ошибке.
                // но я хочу сделать для каждой переменной
                // но я хз как организовать код, чтобы это не было жопой.
            }
            this.Close();
        }

        private void OnCancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
