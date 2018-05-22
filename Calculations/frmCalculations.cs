using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Calculations
{
    public class Operation
    {
        public decimal lValue;
        public decimal rValue;
        public FrmCalculations.CalculateOperation calculateOperation;
        public FrmCalculations.ClHandler clHandler;

        public void SetCalculateOperation(FrmCalculations.CalculateOperation handle)
        {
            calculateOperation = handle;
        }
    }


    public partial class FrmCalculations : Form
    {
        private readonly Calculator _calculator1;
        public delegate void ClHandler(decimal calculations);
        public  delegate void CalculateOperation(Operation oper);

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

        private KeyValuePair<string, Operation> GetOperation()
        {

            
            decimal lValue;
            decimal rValue;
            if (!decimal.TryParse(lTxtValue.Text, out lValue))
            return  new KeyValuePair<string, Operation>("Левый операнд неверный", null); 
            if (!decimal.TryParse(rTxtValue.Text, out rValue))
                return new KeyValuePair<string, Operation>("Правый операнд неверный", null);
            var operation = new
                Operation()
                {
                    clHandler = CalculateHandler,
                    lValue = lValue,
                    rValue = rValue
                };

            switch (this.operation.Text)
            {
                case "":
                    return new KeyValuePair<string, Operation>("Выбрать операцию", null);
                case "/":
                    if (rValue == 0)
                    {

                        return new KeyValuePair<string, Operation>("Деление на 0", null);
                    }
                    operation.SetCalculateOperation((oper) => oper.clHandler(oper.lValue / oper.rValue));
                    
                    
                    //operation = new OperationDivide(lValue, rValue, CalculateHandler);
                    break;
                case "*":
                    operation.SetCalculateOperation((oper) => oper.clHandler(oper.lValue * oper.rValue));
                    //operation = new OperationMultiply(lValue, rValue, CalculateHandler);
                    break;
                case "+":
                    operation.SetCalculateOperation((oper) => oper.clHandler(oper.lValue + oper.rValue));
                    //operation = new OperationPlus(lValue, rValue, CalculateHandler);
                    break;
                default:
                    operation.SetCalculateOperation((oper) => oper.clHandler(oper.lValue - oper.rValue));
                    //operation = new OperationMinus(lValue, rValue, CalculateHandler);
                    break;
            }

            return new KeyValuePair<string, Operation>("", operation);
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
