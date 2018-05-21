namespace Calculations
{
    public class OperationPlus : IOperation
    {

        private readonly decimal _lhs;
        private readonly decimal _rhs;
        private Calculator.CalculateCompleteHandler _handler;
        public OperationPlus(decimal leftValue, decimal rightValue, Calculator.CalculateCompleteHandler handler)
        {

            _handler = handler;
            _lhs = leftValue;
            _rhs = rightValue;
        }


        void IOperation.Calculate()
        {
            _handler.Invoke(_lhs + _rhs);


        }

    }
}
