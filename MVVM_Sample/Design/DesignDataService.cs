using System;
using MVVM_Sample.Model;

namespace MVVM_Sample.Design
{
    public class DesignDataService : IDataService
    {
        public void GetWelcomeData(Action<WelcomeModel, Exception> callback)
        {
            // Use this to create design time data

            var item = new WelcomeModel("Welcome to MVVM Light [design]");
            callback(item, null);
        }
    }
}