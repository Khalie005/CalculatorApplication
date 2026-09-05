using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApplication
{
       public partial class FrmCalculator : Form
        {
            private CalculatorClass cal;

            double num1, num2;   
        public FrmCalculator()
        {
            InitializeComponent();
      cal = new CalculatorClass();
            }

        private void lblDisplayTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnEqual_Click_1(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtBoxInput1.Text);
            num2 = Convert.ToDouble(txtBoxInput2.Text);

            switch (cbOperator.SelectedItem.ToString())
            {
                case "+":
                    cal.CalculateEvent += cal.GetSum;
                    break;
                case "-":
                    cal.CalculateEvent += cal.GetDifference;
                    break;
                case "*":
                    cal.CalculateEvent += cal.GetProduct;
                    break;
                case "/":
                    cal.CalculateEvent += cal.GetQuotient;
                    break;

            }

            var total = cal.Calculate(num1, num2);
            lblDisplayTotal.Text = total.ToString();

            cal.CalculateEvent -= cal.GetSum;
            cal.CalculateEvent -= cal.GetDifference;
            cal.CalculateEvent -= cal.GetProduct;
            cal.CalculateEvent -= cal.GetQuotient;
        }

    }
}
