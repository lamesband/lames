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


        void IOperation.Calculate(Calculator.CalculateCompleteHandler handler)
        {
            //Calculator.CalculateCompleteHandler complete= new Calculator.CalculateCompleteHandler(Calculator.CalculateCompleteHandler);
            if (_rhs != 0)
            {
                handler.Invoke(_lhs / _rhs);
                //BeginInvoke(new FrmCalculations.ClHandler(CalculateOperationComplete), );
            }

            else
            throw new Exception("divide by zero");
        }

    }
}
