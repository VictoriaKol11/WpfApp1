using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        public string _synchonizedText;
        public string SynchonizedText
        {
            get => _synchonizedText;
            set
            {
                _synchonizedText = value;
                OnPropertyChanged(nameof(SynchonizedText));
            }
        }
    }
}
