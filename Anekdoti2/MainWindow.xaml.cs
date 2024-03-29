﻿using System;
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
using Anekdoti.ViewModel;
using Database;

namespace Anekdoti
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        RoleViewModel vmRole;
        PersonViewModel vmPerson;
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
