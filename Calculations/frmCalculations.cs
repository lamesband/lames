using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Calculations
{
    public partial class FrmCalculations : Form
    {
        private readonly Calculator _calculator1;
        public delegate void ClHandler(decimal calculations);

        
        public void CalculateOuterHandler(decimal calculations)
        {
            btnCalculate.Enabled = true;
            result.Text = calculations.ToString();

        }

        public FrmCalculations()
        {
            InitializeComponent();
            _calculator1 = new Calculator();
        }

        private KeyValuePair<string,  IOperation> GetOperation()
        {

            IOperation operation;
            decimal lValue;
            decimal rValue;
            if (!decimal.TryParse(lTxtValue.Text, out lValue))
            return  new KeyValuePair<string, IOperation>("Левый операнд неверный", null); 
            if (!decimal.TryParse(rTxtValue.Text, out rValue))
                return new KeyValuePair<string, IOperation>("Правый операнд неверный", null);

            switch (this.operation.Text)
            {
                case "":
                    return new KeyValuePair<string, IOperation>("Выбрать операцию", null);
                case "/":
                    if (rValue == 0)
                    {
                        return new KeyValuePair<string, IOperation>("Деление на 0", null);
                    }
                    operation = new OperationDivide(lValue, rValue, CalculateHandler);
                    break;
                case "*":
                    operation = new OperationMultiply(lValue, rValue, CalculateHandler);
                    break;
                case "+":
                    operation = new OperationPlus(lValue, rValue, CalculateHandler);
                    break;
                default:
                    operation = new OperationMinus(lValue, rValue, CalculateHandler);
                    break;
            }

            return new KeyValuePair<string, IOperation>("", operation);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {


            var operation = GetOperation();

            if (string.IsNullOrEmpty(operation.Key))
            {
                result.Text = "Looping";
                _calculator1.StartCalculate(operation.Value);
            }
            else
                result.Text = operation.Key;
        }


        private void CalculateHandler(decimal calculations)
        {
            BeginInvoke(new ClHandler(CalculateOuterHandler), calculations);
        }

        private void FrmCalculations_Closed(object sender, EventArgs e)
        {
            _calculator1.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            operation.Text = "+";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            operation.Text = "-";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            operation.Text = "/";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            operation.Text = "*";
        }

        
    }
}
