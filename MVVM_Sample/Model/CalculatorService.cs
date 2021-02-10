using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVVM_Sample.Model
{
    public class CalculatorService : ICalculatorService
    {
        private CalculatorModel calculatorModel = new CalculatorModel(0);

        public void Plus(Action<CalculatorModel, Exception> callback)
        {
            calculatorModel.TestNumber++;
            callback(calculatorModel, null);
        }

        public void Minus(Action<CalculatorModel, Exception> callback)
        {
            calculatorModel.TestNumber--;
            callback(calculatorModel, null);
        }


        public void GetOutput(Action<CalculatorModel, Exception> callback)
        {
            callback(calculatorModel, null);
        }
    }
}
