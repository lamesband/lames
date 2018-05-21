namespace Calculations
{
    public class OperationPlus : IOperation
    {

        private readonly decimal _lhs;
        private readonly decimal _rhs;
        public OperationPlus(decimal leftValue, decimal rightValue)
        {
            _lhs = leftValue;
            _rhs = rightValue;
        }

        decimal IOperation.Calculate()
        {
            return _lhs + _rhs;
        }
    }
}