using ProgressTracker.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.Windows;
using Microsoft.Win32;
using System.IO;

namespace ProgressTracker.ViewModel
{
    public class ProgressEditViewModel : ViewModelBase
    {
        public ICommand CMDOpenProject { get; internal set; }
        public ICommand CMDCreateProject { get; internal set; }
        public ICommand CMDSave { get; internal set; }
        public ICommand CMDReload { get; internal set; }

        bool _changes;
        public bool HasChanges
        {
            get
            {
                return _changes;
            }
            internal set
            {
                _changes = value;
                OnPropertyChanged("HasChanges");
            }
        }

        public bool HasProject
        {
            get
            {
                return Proj != null;
            }
            set
            {

            }
        }

        WorkNode _root;
        public WorkNode Root
        {
            get
            {
                return _root;
            }
            set
            {
                _root = value;
                OnPropertyChanged("Root");
            }
        }

        Project _proj;
        public Project Proj
        {
            get
            {
                return _proj;
            }
            internal set
            {
                if (Proj != null)
                    Proj.FreeWriteLock();

                _proj = value;

                HasChanges = false;
                OnPropertyChanged("HasProject");
                OnPropertyChanged("Proj");
            }
        }

        public ProgressEditViewModel()
        {
            CMDCreateProject = new CreateProjectCommand(this);
            CMDOpenProject = new OpenProjectCommand(this);
            CMDSave = new SaveCommand(this);
            CMDReload = new ReloadCommand(this);

            Root = new WorkNode();
            WorkNode w = new WorkNode();
            w.AddChild(new WorkNode());
            w.AddChild(new WorkNode());
            w.AddChild(new WorkNode());
            w.AddChild(new WorkNode());

            Root.AddChild(w);
            Root.AddChild(new WorkNode());
            Root.AddChild(new WorkNode());
            Root.AddChild(new WorkNode());
            Root.AddChild(new WorkNode());
        }


        public void OpenProject(string filepath)
        {
            if (Proj != null)
                if (!CloseProject())
                    return;

            if (filepath == string.Empty)
            {
                OpenFileDialog d = new OpenFileDialog();
                d.Filter = "prgs files (*.prgs) | *prgs";
                if (d.ShowDialog() == false)
                    return;

                filepath = d.FileName;
            }

            Project p = new Project(Path.GetDirectoryName(filepath));
            p.Load();

            if (p.TryGetWriteLock())
            {
                Proj = p;
            }
            else
                MessageBox.Show("Project could not be opened! someone is edititng it right now!");
        }

        public bool CloseProject()
        {
            if(Proj != null && HasChanges)
            {
                MessageBoxResult r = MessageBox.Show("Save changes?", "Close " + Proj.FileName, MessageBoxButton.YesNoCancel);
                if (r == MessageBoxResult.Cancel)
                    return false;
                else
                if (r == MessageBoxResult.Yes){
                    SaveProject();
                }
            }

            Proj = null;
            return true;
        }

        public void CreateProject()
        {
            SaveFileDialog d = new SaveFileDialog();
            if (d.ShowDialog() == false)
                return;

            string directory = d.FileName;
            OpenProject(Project.Create(directory));
        }

        public void SaveProject()
        {
            if (Proj == null)
                return;

            if(Proj.TrySave())
                HasChanges = false;
        }

        public void ReloadProject()
        {
            if (Proj == null)
                return;

            Proj.Load();
        }


        public void BeforeEnd()
        {
            Proj = null;
        }

        public void EditWork(LinearWork w)
        {
            ReportProgressViewModel vm = new ReportProgressViewModel(w);
            vm.ShowOverlay();
            HasChanges = true;
        }

        class OpenProjectCommand : ICommand
        {
            ProgressEditViewModel vm;

            public event EventHandler CanExecuteChanged;

            public OpenProjectCommand(ProgressEditViewModel vm)
            {
                this.vm = vm;
            }

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public void Execute(object parameter)
            {
                vm.OpenProject(string.Empty);
            }
        }

        class CreateProjectCommand : ICommand
        {
            ProgressEditViewModel vm;

            public event EventHandler CanExecuteChanged;

            public CreateProjectCommand(ProgressEditViewModel vm)
            {
                this.vm = vm;
            }

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public void Execute(object parameter)
            {
                vm.CreateProject();
            }
        }

        class ReloadCommand : ICommand
        {
            ProgressEditViewModel vm;

            public event EventHandler CanExecuteChanged;

            public ReloadCommand(ProgressEditViewModel vm)
            {
                this.vm = vm;
            }

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public void Execute(object parameter)
            {
                vm.ReloadProject();
            }
        }

        class SaveCommand : ICommand
        {
            ProgressEditViewModel vm;

            public event EventHandler CanExecuteChanged;

            public SaveCommand(ProgressEditViewModel vm)
            {
                this.vm = vm;
            }

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public void Execute(object parameter)
            {
                vm.SaveProject();
            }
        }
    }
}
