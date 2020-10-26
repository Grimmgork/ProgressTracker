using ProgressTracker.ViewModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProgressTracker
{
    /// <summary>
    /// Interaktionslogik für OverlayLayer.xaml
    /// </summary>
    public partial class OverlayLayer : UserControl
    {
        public event EventHandler LockAreaClick;
        public bool IsTop { get; set; }

        public OverlayLayer(OverlayViewModel vm)
        {
            InitializeComponent();
            DataContext = vm;
            CP.Content = vm.Visuals;
            vm.Visuals.DataContext = vm;
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(LockAreaClick != null)
                LockAreaClick(this, EventArgs.Empty);
        }
    }
}
