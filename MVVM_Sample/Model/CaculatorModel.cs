using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVVM_Sample.Model
{
    public class CalculatorModel
    {
        public CalculatorModel(int value)
        {
            testNumber = value;
        }

        private int testNumber = 0;
        public int TestNumber
        {
            get
            {
                return testNumber;
            }
            set
            {
                if(0 <= value && value <= 10)
                    testNumber = value;
            }
        }
    }
}
