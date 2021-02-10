using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVVM_Sample.Model
{
    public class WelcomeModel
    {
        public WelcomeModel(string title)
        {
            Title = title;
        }

        public string Title
        {
            get;
            private set;
        }
    }
}
