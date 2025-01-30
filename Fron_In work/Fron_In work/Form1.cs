using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fron_In_work
{
    public partial class Form1 : Form
    {
        private object txtBoxFirstOperand;
        private object txtBoxSecondOperand;
        private object radBtnAdd;
        private object txtBoxExpression;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCalculate_Click(object sender,EventArgs e)
        {
            int fo = int.Parse(txtBoxFirstOperand.Text);
            int so = int.Parse(txtBoxSecondOperand.Text);
            if (radBtnAdd.Checked)
            {
                txtBoxExpression.Text = fo + " + " + so;
                txtBoxResult.Text = (fo + so).ToString();
            }
            else if (radBtnSub.Checked)
            {
                txtBoxExpression.Text = fo + " - " + so;
                txtBoxResult.Text = (fo - so).ToString();
            }
            else if (radBtnMulti.Checked)
            {
                txtBoxExpression.Text = fo + " * " + so;
                txtBoxResult.Text = (fo * so).ToString();
            }
            else if (radBtnDiv.Checked)
            {
                txtBoxExpression.Text = fo + " / " + so;
                txtBoxResult.Text = (fo / so).ToString();
            }
            else if (radBtnRem.Checked)
            {
                txtBoxExpression.Text = fo + " % " + so;
                txtBoxResult.Text = (fo % so).ToString();
            }
        }
    }
}
