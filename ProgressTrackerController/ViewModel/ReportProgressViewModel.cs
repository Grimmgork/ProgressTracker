using ProgressTracker.Controls;
using ProgressTracker.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace ProgressTracker.ViewModel
{
    public class ReportProgressViewModel : OverlayViewModel
    {
        public ICommand CMDEditData { get; internal set; }
        public ICommand CMDReport { get; internal set; }

        float _increment;
        public float Increment
        {
            get
            {
                return _increment;
            }
            set
            {
                _increment = value;
            }
        }

        LinearWork _work;
        public LinearWork Work
        {
            get
            {
                return _work;
            }
            internal set
            {
                _work = value;
                OnPropertyChanged("Work");
            }
        }

        public void Report()
        {
            Work.IncrementValue((int)Increment);
            this.CloseOverlay();
        }

        public void EditData()
        {
            this.CloseOverlay();
            EditWorkViewModel vm = new EditWorkViewModel(Work);
            vm.ShowOverlay();
        }

        public ReportProgressViewModel(LinearWork w)
        {
            CMDEditData = new EditDataCommand(this);
            CMDReport = new ReportCommand(this);
            Work = w;
            Visuals = new ReportProgress();
            Title = "Report progress";
        }

        public class ReportCommand : ICommand
        {
            public event EventHandler CanExecuteChanged;
            ReportProgressViewModel vm;

            public ReportCommand(ReportProgressViewModel vm)
            {
                this.vm = vm;
            }

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public void Execute(object parameter)
            {
                vm.Report();
            }
        }

        public class EditDataCommand : ICommand
        {
            public event EventHandler CanExecuteChanged;
            ReportProgressViewModel vm;

            public EditDataCommand(ReportProgressViewModel vm)
            {
                this.vm = vm;
            }

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public void Execute(object parameter)
            {
                vm.EditData();
            }
        }
    }
}
