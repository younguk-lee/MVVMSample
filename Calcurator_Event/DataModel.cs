using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcurator_Event
{
    public class DataModel : ViewModelBase
    {
        private string _welcomeTitle = string.Empty;
        public const string WelcomeTitlePropertyName = "WelcomeTitle";
        public string WelcomeTitle
        {
            get
            {
                return _welcomeTitle;
            }

            set
            {
                if (_welcomeTitle == value)
                {
                    return;
                }

                _welcomeTitle = value;
                RaisePropertyChanged(WelcomeTitlePropertyName);
            }
        }

        public DataModel()
        {
            WelcomeTitle = "Welcome to MVVM Light [design]";
        }
    }
}
