using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPF_test_obdelnik.ViewModel
{
    class ViewModel : INotifyPropertyChanged
    {
        private double _width;

        public event PropertyChangedEventHandler PropertyChanged;

        //Použití jinde - hotovo
        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public double WidthValue
        {
            get { return _width; }
            set { _width = value; NotifyPropertyChanged(); }
        }
    }
}
