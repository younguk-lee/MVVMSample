using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MVVM_Sample.Model;

namespace MVVM_Sample.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private readonly IDataService _dataService;
        private readonly ICalculatorService _calculatorService;

        #region Commands

        public RelayCommand PlusCommand
        {
            get;
            private set;
        }

        private bool CanPlusCommand()
        {
            if (string.IsNullOrEmpty(Output))
                return true;

            if (int.Parse(Output) < 10)
                return true;
            
            return false;
        }

        public RelayCommand MinusCommand
        {
            get;
            private set;
        }
        
        private bool CanMinusCommand()
        {
            if (string.IsNullOrEmpty(Output))
                return true;

            if (int.Parse(Output) <= 0)
                return false;

            return true;
        }

        public RelayCommand SubWindowCommand
        {
            get;
            private set;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The <see cref="WelcomeTitle" /> property's name.
        /// </summary>
        public const string WelcomeTitlePropertyName = "";

        private string _welcomeTitle = string.Empty;

        /// <summary>
        /// Gets the WelcomeTitle property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
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

        private string _output = string.Empty;
        public string Output
        {
            get
            {
                return _output;
            }
            set
            {
                if (_output == value)
                {
                    return;
                }

                _output = value;
                RaisePropertyChanged("Output");
            }
        }

        public string Output2
        {
            get
            {
                return _output;
            }
            set
            {
                if (_output == value)
                {
                    return;
                }

                _output = value;
                RaisePropertyChanged("Output");
            }
        }

        #endregion
        

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(IDataService dataService, ICalculatorService calculatorService)
        {
            _dataService = dataService;
            _calculatorService = calculatorService;

            PlusCommand = new RelayCommand(Plus, CanPlusCommand);
            MinusCommand = new RelayCommand(Minus, CanMinusCommand);
            SubWindowCommand = new RelayCommand(OpenSubWindow);
            GetWelcomeMessage();
            GetOutput();
        }

        private void Plus()
        {
            _calculatorService.Plus(
               (item, error) =>
                {
                    if (error != null)
                    {
                        // Report error here
                        return;
                    }

                    Output = item.TestNumber.ToString();
                });
        }

        private void Minus()
        {
            _calculatorService.Minus(
               (item, error) =>
               {
                   if (error != null)
                   {
                       // Report error here
                       return;
                   }

                   Output = item.TestNumber.ToString();
               });
        }

        private void GetWelcomeMessage()
        {
            _dataService.GetWelcomeData(
                (item, error) =>
                {
                    if (error != null)
                    {
                        // Report error here
                        return;
                    }

                    WelcomeTitle = item.Title;
                });
        }

        private void GetOutput()
        {
            _calculatorService.GetOutput(
                (item, error) =>
                {
                    if (error != null)
                    {
                        // Report error here
                        return;
                    }

                    Output = item.TestNumber.ToString();
                });
        }

        private void OpenSubWindow()
        {
            SubWindow subWindow = new SubWindow();
            subWindow.Show();
        }
        public override void Cleanup()
        {
            // Clean up if needed

            base.Cleanup();
        }
    }
}