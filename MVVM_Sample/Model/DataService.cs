using System;

namespace MVVM_Sample.Model
{
    public class DataService : IDataService
    {
        public void GetWelcomeData(Action<WelcomeModel, Exception> callback)
        {
            // Use this to connect to the actual data service

            var item = new WelcomeModel("Welcome to MVVM Light");
            callback(item, null);
        }
    }
}