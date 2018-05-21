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

        void IOperation.Calculate(Calculator.CalculateCompleteHandler handler)
        {
            handler.Invoke(_lhs + _rhs);
        }
    }
}