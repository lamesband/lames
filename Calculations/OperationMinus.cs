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

        decimal IOperation.Calculate()
        {
            return _lhs - _rhs;
        }
    }
}
