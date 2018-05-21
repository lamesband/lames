
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

        void IOperation.Calculate(Calculator.CalculateCompleteHandler handler)
        {
            handler.Invoke(_lhs * _rhs);
        }
    }
}
