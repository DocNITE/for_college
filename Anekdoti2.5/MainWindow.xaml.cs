using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using Anekdoti.Gui;
using Anekdoti.ViewModel;
using static Anekdoti.Utils.Logs;
using System.Diagnostics;

namespace Anekdoti
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public RoleViewModel vmRole;
        public PersonViewModel vmPerson;
        Canvas currWnd;

        public MainWindow()
        {
            InitializeComponent();
            vmRole = new RoleViewModel();
            vmPerson = new PersonViewModel(vmRole);
            // GAY SEX
            aList.ItemsSource = vmPerson.ListPerson;  // PERSONALITY
            // CHILD P0RN
            aChildPo.ItemsSource = vmRole.ListRole;
        }

        private void OnSwitchWindow(object sender, RoutedEventArgs e)
        {
            Button _switchButton = (Button)e.Source;

            for (int i = 0; i < this.cMainWindow.Children.Count; i++)
            {
                Canvas _elem = (Canvas)this.cMainWindow.Children[i];

                if (_elem.Name == ("c" + _switchButton.Name.Substring(1)))
                {
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

        private void OnCtxAddPerson(object sender, RoutedEventArgs e)
        {
            var st = new StackTrace();
            var sf = st.GetFrame(0);
            var currentMethodName = sf.GetMethod();
            LogInfo("Fired event: '" + currentMethodName + "'");

            AddPersonWindow addPersonWnd = new AddPersonWindow(this);
            addPersonWnd.ShowDialog();
        }

        private void OnCtxEditPerson(object sender, RoutedEventArgs e)
        {

        }

        private void OnCtxDeletePerson(object sender, RoutedEventArgs e)
        {
            Person _delPerson = (Person)aList.SelectedItem;
            Person d = new Person();

            List<Person> persons = (List<Person>)aList.ItemsSource;
            for (int i = 0; i < persons.Count;i++)
            {
                if (persons[i] == _delPerson)
                {
                    persons.RemoveAt(i);
                    aList.ItemsSource = null; 
                    aList.ItemsSource = persons;
                }
            }
        }

        /*private void OnPersonMouseUp(object sender, MouseButtonEventArgs e)
        {
            LogInfo(sender.ToString());
            NextLine();
        }*/

        /*private void btnEdit_Click(object sender, RoutedEventArgs e)
{
WindowNewRole wnRole = new WindowNewRole
{
 Title = "Редактирование должности",
 Owner = this
};
Role role = lvRole.SelectedItem as Role;
if (role != null)
{
 Role tempRole = role.ShallowCopy();
 wnRole.DataContext = tempRole;
 if (wnRole.ShowDialog() == true)
 {
 // сохранение данных
 role.NameRole = tempRole.NameRole;
 lvRole.ItemsSource = null;
 lvRole.ItemsSource = vmRole.ListRole;
 }
}
else
{
 MessageBox.Show("Необходимо выбрать должность для редактированния",
 "Предупреждение",MessageBoxButton.OK, MessageBoxImage.Warning);
}
}
*/
    }
}
