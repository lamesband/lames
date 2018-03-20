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
            Thread.Sleep(varLoopValue);
            CalculateComplete(varLoopValue);
        }

        private void Calculate()
        {
            

            while (!exit)
            {

                var id = 0;
                lock (_mutex)
                {
                    Monitor.Wait(_mutex);
                    if (_list.Count > 0)
                    {
                        id = _list[0];
                        _list.RemoveAt(0);

                    }
                }

                CalculateExpression(id);


            }
        }

        public void Dispose()
        {
            exit = true;
            lock (_mutex)
            {
                Monitor.Pulse(_mutex);
            }
        }
    }
}
