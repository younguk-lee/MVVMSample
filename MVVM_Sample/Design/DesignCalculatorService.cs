using MVVM_Sample.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVVM_Sample.Design
{
    public class DesignCalculatorService : ICalculatorService
    {
        private CalculatorModel calculatorModel = new CalculatorModel(100000);

        public void Plus(Action<CalculatorModel, Exception> callback)
        {
            throw new NotImplementedException();
        }

        public void Minus(Action<CalculatorModel, Exception> callback)
        {
            throw new NotImplementedException();
        }


        public void GetOutput(Action<CalculatorModel, Exception> callback)
        {
            callback(calculatorModel, null);
        }
    }
}
