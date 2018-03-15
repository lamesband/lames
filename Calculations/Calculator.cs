using System.Collections.Concurrent;
using System.ComponentModel;
using System.Threading;

namespace Calculations
{
    public partial class Calculator : Component
    {
        
        public int VarLoopValue;
        public double VarTotalCalculations;
        public ConcurrentQueue<int> _list;

        public delegate void Calc();
        public delegate void CalculateCompleteHandler(double totalCalculations);
        public event CalculateCompleteHandler CalculateComplete;
        

        public Calculator()
        {
            InitializeComponent();
            _list = new ConcurrentQueue<int>();

            var CalculateThread = new Thread(Calculate);
            CalculateThread.Start();
        }

        public void StartCalculate(int value)
        {
            _list.Enqueue(value);
        }

        private void Calculate()
        {
            while (true)
            {
                if (_list.TryDequeue(out VarLoopValue))
                {
                    int varX;
                    double varTotalAsOfNow = 0;
                    for (varX = 1; varX <= VarLoopValue; varX++)
                    {
                        for (var varY = 1; varY <= 500; varY++)
                        {
                            lock (this)
                            {
                                VarTotalCalculations += 1;
                                varTotalAsOfNow = VarTotalCalculations;
                            }
                        }
                    }
                    CalculateComplete(varTotalAsOfNow);
                }
            }
        }

        public Calculator(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }
    }
}
