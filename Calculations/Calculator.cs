using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Threading;

namespace Calculations
{
    public class Calculator : IDisposable
    {

        private ConcurrentQueue<int> _list;
        private bool exit;

        public delegate void CalculateCompleteHandler(double totalCalculations);

        public event CalculateCompleteHandler CalculateComplete;


        public Calculator()
        {

            _list = new ConcurrentQueue<int>();

            var CalculateThread = new Thread(Calculate);
            CalculateThread.Start();
        }

        public void StartCalculate(int value)
        {
            _list.Enqueue(value);
        }

        private void CalculateExpression(int varLoopValue)
        {

            int varX;
            var varTotalAsOfNow = 0;
            for (varX = 1; varX <= varLoopValue; varX++)
            {
                for (var varY = 1; varY <= 500; varY++)
                {

                    varTotalAsOfNow++;
                }
            }
            CalculateComplete(varTotalAsOfNow);
        }

        private void Calculate()
        {
            while (!exit)
            {

                var varLoopValue = 0;
                if (_list.TryDequeue(out varLoopValue))
                {
                    CalculateExpression(varLoopValue);
                }
            }
        }

        public void Dispose()
        {
            exit = true;
        }

    }
}
