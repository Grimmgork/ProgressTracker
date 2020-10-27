using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Windows;

namespace ProgressTracker.Model
{
    [System.Serializable]
    public class Project : INotifyPropertyChanged
    {
        public static string projectFileExtension = ".prgs";
        public static string viewConfigFileExtension = ".prgsv";

        private DateTime lastRefresh;
        private ViewConfig vc;

        private string filePath; //path to project data file
        private string lockfilePath; //path to lockfile
        private FileStream lockFileStream;


        public string FileName
        {
            get
            {
                return Path.GetFileName(filePath);
            }
        }

        public bool HasWriteLock
        {
            get
            {
                return lockFileStream != null;
            }
        }

        public bool HasFileChanges
        {
            get
            {
                return lastRefresh != File.GetLastWriteTime(filePath) || Work == null;
            }
        }

        public bool IsLocked
        {
            get
            {
                return File.Exists(lockfilePath) && !HasWriteLock;
            }
        }
        

        string _status;
        public string Status
        {
            get
            {
                return _status;
            }
            internal set
            {
                _status = value;
                OnPropertyChanged("Status");
            }
        }

        LinearWork[] _work;
        public LinearWork[] Work
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


        public Project(string directory)
        {
            Init(directory);
        }


        public static string Create(string path)
        {
            Directory.CreateDirectory(path);

            Project p = new Project(path);
            p.Work = new LinearWork[] { new LinearWork(){ Name = "New work", Total = 100, Value = 0 } };
            p.vc = new ViewConfig();

            string[] s = path.Split('\\');
            string name = s[s.Length - 1];
            File.Create(path + "\\" + name + projectFileExtension).Close();
            
            p.Init(path);
            p.TryGetWriteLock();
            p.Save();
            p.FreeWriteLock();

            return p.filePath;
        }

        private bool Init(string directory)
        {
            foreach (string s in Directory.GetFiles(directory))
            {
                if (Path.GetExtension(s) == projectFileExtension)
                    filePath = s;
            }

            if (filePath == string.Empty)
            {
                Status = "Project could net be initialized!";
                return false;
            }
                
            vc = new ViewConfig();

            lockfilePath = Path.GetDirectoryName(filePath) + "\\lock.txt";
            Status = "Project initialized!";
            return true;
        }

        
        public bool TryGetWriteLock()
        {
            if (HasWriteLock)
                return true;

            if (IsLocked)
                return false;

            try
            {
                lockFileStream = new FileStream(lockfilePath, FileMode.Create, FileAccess.Write, FileShare.None, 4032, FileOptions.DeleteOnClose);
            }
            catch
            {
                return false;
            }

            OnPropertyChanged("HasWriteLock");
            return true;
        }

        public void FreeWriteLock()
        {
            if (!HasWriteLock)
                return;

            lockFileStream.Close();
            lockFileStream = null;
            OnPropertyChanged("HasWriteLock");
        }


        public bool TrySave()
        {
            if (HasWriteLock) 
            {
                Save(); //<--- Bad logic: cant realy know if the file was saved!!!
                return true;
            }

            return false;
        }

        private void Save()
        {
            Status = "Saving ...";

            IFormatter formatter = new BinaryFormatter();

            FileStream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, Work);
            stream.Close();

            stream = new FileStream(Path.GetDirectoryName(filePath) + "\\ViewConfig" + viewConfigFileExtension, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, vc);
            stream.Close();

            Status = "Project saved!";
        }

        public void Load()
        {
            Work = null;
            Status = "Refreshing!";
            Thread.Sleep(100);
            
            if (!File.Exists(filePath))
            {
                Status = "File missing!";
                Work = null;
                return;
            }

            if (IsLocked)
            {
                Status = "File locked! (Somebody is edititng it)";
                Work = null;
                return;
            }
                
            Status = "Trying to read file ...";
            Stream stream = null;
            int numberOfTries = 10;
            while (numberOfTries > 0)
            {
                try{
                    stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                }
                catch (IOException){
                    stream = null;
                }

                if (stream != null)
                    break;

                Thread.Sleep(100);
                numberOfTries--;
            }

            if (stream == null || stream.Length == 0)
            {
                stream.Close();
                Status = "Could not open filestream!";
                return;
            }

            IFormatter formatter = new BinaryFormatter();

            Status = "Reading file ...";
            Work = formatter.Deserialize(stream) as LinearWork[];
            stream.Close();

            if(Work == null)
            {
                Status = "File could not be deserialized!";
                return;
            }

            lastRefresh = File.GetLastWriteTime(filePath);
            Status = "Data loadet!";
        }


        #region INotifyPropertyChanged Members  

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
