using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVVM_Sample.Model
{
    public interface ICalculatorService
    {
        void Plus(Action<CalculatorModel, Exception> callback);
        void Minus(Action<CalculatorModel, Exception> callback);
        void GetOutput(Action<CalculatorModel, Exception> callback);
    }
}
