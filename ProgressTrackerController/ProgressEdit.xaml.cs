using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ProgressTracker.Model;
using ProgressTracker.ViewModel;

namespace ProgressTracker
{
    /// <summary>
    /// Interaction logic for ProgressEdit.xaml
    /// </summary>
    public partial class ProgressEdit : Window
    {
        public ProgressEdit()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (DataContext == null)
                return;

            ProgressEditViewModel vm = DataContext as ProgressEditViewModel;
            if (!vm.CloseProject())
            {
                e.Cancel = true;
                return;
            }

            vm.BeforeEnd();
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Keyboard.ClearFocus();
            this.DragMove();
        }

        private void Minimize(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Keyboard.ClearFocus();
        }


        private void ListBoxItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            (DataContext as ProgressEditViewModel).EditWork( ((sender as TreeViewItem).DataContext as WorkNode).Work );
        }

        private void OverlayHolder_LockAreaClick(object sender, EventArgs e)
        {
            this.DragMove();
        }
    }
}
