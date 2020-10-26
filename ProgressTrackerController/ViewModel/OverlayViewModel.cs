using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ProgressTracker.ViewModel
{
    public class OverlayViewModel : ViewModelBase
    {
        public ICommand CMDCloseOverlay { get; internal set; }
        public event EventHandler OnClosed;

        public OverlayViewModel()
        {
            CMDCloseOverlay = new CloseOverlayCommand(this);
        }

        string _title;
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
                OnPropertyChanged("Title");
            }
        }

        public bool IsTop
        {
            get
            {
                return true;
            }
        }

        UserControl _visuals;
        public UserControl Visuals
        {
            get
            {
                return _visuals;
            }
            internal set
            {
                _visuals = value;
                OnPropertyChanged("Visuals");
            }
        }

        public void CloseOverlay()
        {
            OverlayController.Close(this);
            if(OnClosed != null)
                OnClosed(this, EventArgs.Empty);
        }

        public void ShowOverlay()
        {
            OverlayController.Show(this);
        }


        public class CloseOverlayCommand : ICommand
        {
            OverlayViewModel vm;

            public event EventHandler CanExecuteChanged;

            public CloseOverlayCommand(OverlayViewModel vm)
            {
                this.vm = vm;
            }

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public void Execute(object parameter)
            {
                vm.CloseOverlay();
            }
        }
    }
}
