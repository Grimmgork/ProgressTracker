using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Win32;
using ProgressTracker.Model;
using ProgressTracker.ViewModel;

namespace ProgressTracker
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            string path = string.Empty;
            string[] args = Environment.GetCommandLineArgs();
            if(args.Length >= 2)
                path = args[1];

            if (path == string.Empty)
            {
                Window v = new ProgressEdit();
                v.DataContext = new ProgressEditViewModel(); 
                v.Show();
            }
            else
            {
                string extension = Path.GetExtension(path);
                if (extension == Project.projectFileExtension)
                {
                    Window pe = new ProgressEdit();
                    ProgressEditViewModel vm = new ProgressEditViewModel();
                    vm.OpenProject(path);
                    pe.DataContext = vm;
                    pe.Show();
                }
                else
                if (extension == Project.viewConfigFileExtension)
                { 
                    Window pv = new ProgressView();

                    pv.DataContext = new ProgressViewViewModel(new Project(Path.GetDirectoryName(path)));
                    pv.Show();
                }
            }
        }

        public void Close()
        {
            Environment.Exit(0);
        }
    }
}
