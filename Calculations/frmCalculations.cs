using System;
using System.Windows.Forms;

namespace Calculations
{
    public partial class FrmCalculations : Form
    {
        private readonly Calculator _calculator1;
        public delegate void ClHandler(double calculations);

        public void CalculateOuterHandler(double calculations)
        {
            btnCalculate.Enabled = true;
            lblCalculate.Text = calculations.ToString();

        }

        public FrmCalculations()
        {
            InitializeComponent();
            _calculator1 = new Calculator();
            _calculator1.CalculateComplete += CalculateHandler;
         
        }

        
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
            btnCalculate.Enabled = false;
            lblCalculate.Text = "Looping";
            _calculator1.StartCalculate(int.Parse(txtValue.Text));
        }

        
        private void CalculateHandler(double calculations)
        {
            BeginInvoke(new ClHandler(CalculateOuterHandler), calculations);
        }

        private void FrmCalculations_Closed(object sender, EventArgs e)
        {
            _calculator1.Dispose();
        }
    }
}
