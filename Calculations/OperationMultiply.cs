
namespace Calculations
{
    public class OperationMultiply : IOperation
    {

        private readonly decimal _lhs;
        private readonly decimal _rhs;
        public OperationMultiply(decimal leftValue, decimal rightValue)
        {
            _lhs = leftValue;
            _rhs = rightValue;
        }

        decimal IOperation.Calculate()
        {
            return _lhs * _rhs;
        }
    }
}
