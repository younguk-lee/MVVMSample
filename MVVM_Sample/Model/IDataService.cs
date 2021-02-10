using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVVM_Sample.Model
{
    public interface IDataService
    {
        void GetWelcomeData(Action<WelcomeModel, Exception> callback);
    }
}
