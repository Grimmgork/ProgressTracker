using ProgressTracker.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Timers;
using System.Windows;

namespace ProgressTracker.ViewModel
{
    public class ProgressViewViewModel : ViewModelBase
    {
        public ICommand CMDRefresh { get; internal set; }

        Project _proj;
        public Project Proj
        {
            get
            {
                return _proj;
            }
            set
            {
                _proj = value;
                OnPropertyChanged("Proj");
            }
        }

        public LinearWork Work
        {
            get
            {
                if(Proj.Work != null && Proj.Work.Length > 0)
                    return Proj.Work[0];
                return null;
            }
        }

        System.Timers.Timer T;

        bool refresh;
        bool buisy;

        bool end;

        Thread BackgroundLoop;

        public ProgressViewViewModel(Project p)
        {
            Proj = p;
            CMDRefresh = new RefreshCommand(this);

            BackgroundLoop = new Thread(BackgroundRoutine);
            BackgroundLoop.Start();

            T = new System.Timers.Timer(5000);
            T.Elapsed += T_Elapsed;
            T.AutoReset = true;
            T.Start();

            ForceRefresh();
        }


        public void ForceRefresh()
        {
            if (!buisy)
                refresh = true;
        }

        public void End()
        {
            end = true;
            T.Stop();
            while (BackgroundLoop.IsAlive) { }
            if(Proj != null)
                Proj.FreeWriteLock();
        }

        private void Refresh()
        {
            if (Proj.FileChanged())
            if(!buisy)
               refresh = true;
        }


        private void T_Elapsed(object sender, ElapsedEventArgs e)
        {
            Refresh();
        }

        private void BackgroundRoutine()
        {
            while(!end)
            {
                if(refresh && !buisy)
                {
                    T.Stop();
                    buisy = true;
                    refresh = false;
                    Proj.Load();
                    OnPropertyChanged("Work");
                    buisy = false;
                    T.Start();
                }

                Thread.Sleep(10);
            }
        }


        public class RefreshCommand : ICommand
        {
            ProgressViewViewModel vm;

            public event EventHandler CanExecuteChanged;

            public RefreshCommand(ProgressViewViewModel vm)
            {
                this.vm = vm;
            }

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public void Execute(object parameter)
            {
                vm.ForceRefresh();
            }
        }
    }
}
