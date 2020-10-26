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
    /// Interaktionslogik für Overlay.xaml
    /// </summary>
    public partial class OverlayHolder : UserControl
    {
        public event EventHandler LockAreaClick;

        Dictionary<OverlayViewModel, OverlayLayer> layers = new Dictionary<OverlayViewModel, OverlayLayer>();

        public OverlayHolder()
        {
            OverlayController.RegisterOverlay(this);
            InitializeComponent();
        }

        public void Add(OverlayViewModel vm)
        {
            OverlayLayer l = new OverlayLayer(vm);
            l.LockAreaClick += L_LockAreaClick;
            layers.Add(vm, l);
            MainGrid.Children.Add(l);
        }

        private void L_LockAreaClick(object sender, EventArgs e)
        {
            if (LockAreaClick != null)
                LockAreaClick(this, EventArgs.Empty);
        }

        public void Remove(OverlayViewModel vm)
        {
            MainGrid.Children.Remove(layers[vm]);
            layers.Remove(vm);
        }
    }

    public static class OverlayController
    {
        static OverlayHolder overlay;

        public static void RegisterOverlay(OverlayHolder o)
        {
            overlay = o;
        }

        public static void Show(OverlayViewModel vm)
        {
            overlay.Add(vm);
        }

        public static void Close(OverlayViewModel vm)
        {
            overlay.Remove(vm);
        }
    }
}
