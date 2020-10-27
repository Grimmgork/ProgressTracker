using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressTracker.Model
{
    public class WorkNode : INotifyPropertyChanged
    {
        WorkNode parent;

        public List<WorkNode> SubWork = new List<WorkNode>();

        public bool Completed
        {
            get
            {
                return Percentage == 100;
            }
        }

        float _weight;
        public float Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                _weight = value;
                parent.UpdateChildWeights(this);
            }
        }

        LinearWork _work;
        public LinearWork Work
        {
            get
            {
                return _work;
            }
            set
            {
                _work = value;
                OnPropertyChanged("Work");
            }
        }

        int _percentage;
        public int Percentage
        {
            get
            {
                return _percentage;
            }
            private set
            {
                if (value == _percentage)
                    return;

                _percentage = value;
                OnPropertyChanged("Percentage");
                OnPropertyChanged("Completed");
                parent.UpdatePercentage();
            }
        }


        public WorkNode(WorkNode parent)
        {
            this.parent = parent;
        }

        public void AddChild(WorkNode n)
        {
            SubWork.Add(n);
            OnPropertyChanged("SubWork");
            UpdatePercentage();
        }

        public void RemoveChild(WorkNode n)
        {
            SubWork.Remove(n);
            OnPropertyChanged("SubWork");
            UpdatePercentage();
        }


        private void UpdatePercentage()
        {
            float value = 0;
            foreach(WorkNode w in SubWork)
            {
                value += w.Percentage * w.Weight*100;    
            }

            Percentage = (int)value*100;
        }


        internal void SetWeightDiscrete(float value)
        {
            _weight = value;
        }

        internal void UpdateChildWeights(WorkNode staticWeightNode)
        {
            foreach (WorkNode w in SubWork)
            {
                if (w == staticWeightNode)
                    continue;

                w.SetWeightDiscrete(0.5f);
            }

            UpdatePercentage();
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
