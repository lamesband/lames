using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;

namespace Calculations
{
    public class Calculator : IDisposable
    {

        static  object _mutex = new object();
        private List<int> _list = new List<int>();
        private bool exit;

        public delegate void CalculateCompleteHandler(double totalCalculations);

        public event CalculateCompleteHandler CalculateComplete;


        public Calculator()
        {


            var CalculateThread = new Thread(Calculate);
            CalculateThread.Start();
            //Monitor.Enter(_mutex);


        }

        public void StartCalculate(int value)
        {

            lock (_mutex)
            {
                _list.Add(value);
                Monitor.Pulse(_mutex);
                

            }
            

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

                lock (_mutex)
                {
                    
                    
                    Monitor.Wait(_mutex);
                    if (_list.Count > 0)
                    {
                        CalculateExpression(_list[0]);
                        _list.RemoveAt(0);
                    }
                }

            }
        }

        public void Dispose()
        {
            exit = true;
        }

    }
}
