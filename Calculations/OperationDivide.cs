using System;

namespace Calculations
{
    public class OperationDivide : IOperation
    {

        
        private readonly decimal _lhs;
        private readonly decimal _rhs;

        public OperationDivide(decimal leftValue, decimal rightValue)
        {
            _lhs = leftValue;
            _rhs = rightValue;
        }


        decimal IOperation.Calculate()
        {
            if (_rhs != 0)
                return _lhs / _rhs;
            
            throw new Exception("divide by zero");
        }
    }
}
