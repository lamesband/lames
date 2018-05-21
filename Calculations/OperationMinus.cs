namespace Calculations
{
    public class OperationMinus : IOperation
    {

        private readonly decimal _lhs;
        private readonly decimal _rhs;
        public OperationMinus(decimal leftValue, decimal rightValue)
        {
            _lhs = leftValue;
            _rhs = rightValue;
        }

        void IOperation.Calculate(Calculator.CalculateCompleteHandler handler)
        {
            handler.Invoke(_lhs - _rhs);
        }
    }
}
