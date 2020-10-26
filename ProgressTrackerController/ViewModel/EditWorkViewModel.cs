using ProgressTracker.Controls;
using ProgressTracker.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace ProgressTracker.ViewModel
{
    public class EditWorkViewModel : OverlayViewModel
    {
        public ICommand CMDApply { get; internal set; }

        public string Name { get; set; }

        public float Total { get; set; }

        float _value;
        public float CurrentValue
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
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

        public EditWorkViewModel(LinearWork work)
        {
            CMDApply = new ApplyCommand(this);

            Work = work;
            Name = work.Name;
            CurrentValue = work.Value;
            Total = work.Total;

            Visuals = new EditWork();
            Title = "Edit";
        }

        public void Apply()
        {

            //do stuff to work data
            Work.Name = Name;
            Work.Total = (int)Total;
            Work.Value = (int)CurrentValue;

            this.CloseOverlay();
        }

        public class ApplyCommand : ICommand
        {
            EditWorkViewModel vm;
            public event EventHandler CanExecuteChanged;

            public ApplyCommand(EditWorkViewModel vm)
            {
                this.vm = vm;
            }

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public void Execute(object parameter)
            {
                vm.Apply();
            }
        }
    }
}
