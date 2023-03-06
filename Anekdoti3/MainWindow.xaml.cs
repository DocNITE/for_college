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
            // update
            aList.ItemsSource = null;
            aList.ItemsSource = vmPerson.ListPerson;
        }

        private void OnCtxEditPerson(object sender, RoutedEventArgs e)
        {
            var st = new StackTrace();
            var sf = st.GetFrame(0);
            var currentMethodName = sf.GetMethod();
            LogInfo("Fired event: '" + currentMethodName + "'");
        }

        private void OnCtxDeletePerson(object sender, RoutedEventArgs e)
        {
            var st = new StackTrace();
            var sf = st.GetFrame(0);
            var currentMethodName = sf.GetMethod();
            LogInfo("Fired event: '" + currentMethodName + "'");

            Person _delPerson = (Person)aList.SelectedItem;

            List<Person> persons = vmPerson.ListPerson;
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

        private void OnCtxAddRole(object sender, RoutedEventArgs e)
        {
            var st = new StackTrace();
            var sf = st.GetFrame(0);
            var currentMethodName = sf.GetMethod();
            LogInfo("Fired event: '" + currentMethodName + "'");

            AddRoleWindow addWnd = new AddRoleWindow(this);
            addWnd.ShowDialog();
            // update
            aChildPo.ItemsSource = null;
            aChildPo.ItemsSource = vmRole.ListRole;
        }

        private void OnCtxEditRole(object sender, RoutedEventArgs e)
        {
            var st = new StackTrace();
            var sf = st.GetFrame(0);
            var currentMethodName = sf.GetMethod();
            LogInfo("Fired event: '" + currentMethodName + "'");
        }

        private void OnCtxDeleteRole(object sender, RoutedEventArgs e)
        {
            var st = new StackTrace();
            var sf = st.GetFrame(0);
            var currentMethodName = sf.GetMethod();
            LogInfo("Fired event: '" + currentMethodName + "'");

            Role _delPerson = (Role)aChildPo.SelectedItem;

            List<Role> roles = vmRole.ListRole;
            for (int i = 0; i < roles.Count; i++)
            {
                if (roles[i] == _delPerson)
                {
                    roles.RemoveAt(i);
                    aChildPo.ItemsSource = null;
                    aChildPo.ItemsSource = roles;
                }
            }
        }
    }
}
