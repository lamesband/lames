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
        private List<Operation> _list = new List<Operation>();
        private int exit;
        

        public Calculator()
        {
            var CalculateThread = new Thread(Calculate);
            CalculateThread.Start();
        }

        public void StartCalculate(Operation operation)
        {

            lock (_mutex)
            {
                _list.Add(operation);
                Monitor.Pulse(_mutex);
            }
            

        }

        private void CalculateExpression(Operation operation)
        {
            operation.calculateOperation(operation);
        }

        private void Calculate()
        {
            

            while (exit==0)
            {

                Operation id;
                lock (_mutex)
                {
                    if (_list.Count == 0)
                        Monitor.Wait(_mutex);
                    if (exit == 1)
                        break;
                    id = _list[0];
                    _list.RemoveAt(0);
                }

                CalculateExpression(id);


            }
        }

        public void Dispose()
        {
            Interlocked.Increment(ref exit);
            lock (_mutex)
            {
                Monitor.Pulse(_mutex);
            }
        }
    }
}
