using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MyAffairs.MyFolder
{
    class AffairsModel : INotifyPropertyChanged
    {
        // exact time when the task was added
        public DateTime CreateTime { get; set; } = DateTime.Now;



        //is the task completed or not?

        private bool _IsCompleted;
        public bool IsCompleted
        {
            get { return _IsCompleted; }
            set {
                if (_IsCompleted == value)
                {
                    return;
                }
                _IsCompleted = value;
                ChangeProperty("IsCompleted");
            }


        }


        //task description

        private string _MyTask;
        public string MyTask
        {
            get { return _MyTask; }
            set {
                if (_MyTask == value)
                {
                    return;
                }
                _MyTask = value;
                ChangeProperty("MyTask");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void ChangeProperty(string PropertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

    }
}
