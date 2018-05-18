using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace in_class_demo
{
    public class Florp : INotifyPropertyChanged
    {
        private string _flizoop;

        public string Flizoop
        {
            get => _flizoop;
            set
            {
                _flizoop = value;
                OnPropertyChanged(nameof(Flizoop));

            }
        }

        public override string ToString()
        {
            return $"You got a Flizoop called {Flizoop}";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
