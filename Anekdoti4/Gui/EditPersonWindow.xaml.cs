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
    /// Логика взаимодействия для EditPersonWindow.xaml
    /// </summary>
    public partial class EditPersonWindow : Window
    {
        MainWindow currentWnd;
        Person currentPerson;
        public EditPersonWindow(MainWindow Wnd, Person pers)
        {
            InitializeComponent();
            currentWnd = Wnd;
            currentPerson = pers;

            LogInfo("EditPerson window is open!");
        }

        private void OnPersonEdit(object sender, RoutedEventArgs e)
        {
            try
            {
                var firstName = this.PersonFirstName.Text;
                var secondName = this.PersonSecondName.Text;
                var datebirth = this.PersonDate.Text.Split('.');
                var roleId = this.PersonRole.Text;

                currentPerson.RoleId = currentWnd.vmRole.GetRoleWithId(int.Parse(roleId));
                currentPerson.FirstName = firstName;
                currentPerson.LastName = secondName;
                currentPerson.Birthday = new DateTime(int.Parse(datebirth[2]), int.Parse(datebirth[1]), int.Parse(datebirth[0]));

                var vmPerson = currentWnd.vmPerson;
                var pers = currentPerson;

                for (int i = 0; i < vmPerson.ListPerson.Count; i++)
                {
                    if (vmPerson.ListPerson[i].Id == pers.Id)
                    {
                        var id = vmPerson.ListPerson[i].Id;

                        vmPerson.ListPerson[i] = new Person
                        {
                            Id = id,
                            FirstName = pers.FirstName,
                            LastName = pers.LastName,
                            RoleId = pers.RoleId,
                            Birthday = pers.Birthday
                        };
                    }
                }

                //currentWnd.EditPersonFromEdit(currentPerson);
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
