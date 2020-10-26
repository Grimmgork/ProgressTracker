using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;

namespace ProgressTracker.Model
{
    [System.Serializable]
    public class LinearWork : INotifyPropertyChanged
    {
        public bool Completed
        {
            get
            {
                if(Value >= Total)
                    return true;
                return false;
            }
        }

        string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        int _total;
        public int Total
        {
            get
            {
                return _total;
            }
            set
            {
                _total = value;
                OnPropertyChanged("Total");
                OnPropertyChanged("Percentage");
                OnPropertyChanged("AntiValue");
                OnPropertyChanged("Completed");
            }
        }

        int _value;
        public int Value
        {
            get
            {
                return _value;
            }
            set
            {
                if (value > Total)
                    value = Total;
                _value = value;

                OnPropertyChanged("Value");

                OnPropertyChanged("Percentage");
                OnPropertyChanged("AntiValue");
                OnPropertyChanged("Completed");
            }
        }

        public int Percentage
        {
            get
            {
                return Value * 100 / Total;
            }
            set
            {

            }
        }

        public int AntiValue
        {
            get
            {
                return Total - Value;
            }
        }


        public void IncrementValue(int increment)
        {
            Value += increment;
        }

        [field:NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
