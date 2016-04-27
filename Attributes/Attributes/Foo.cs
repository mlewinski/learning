using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Attributes
{
    //[Obsolete, CLSCompliant(true)]
    public class Foo : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        string customerName;

        public string CustomerName
        {
            get { return customerName;}
            set
            {
                if (value == customerName) return;
                customerName = value;
                RaisePropertyChanged();
            }
        }
    }
}
