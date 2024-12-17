using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class lblResult : Form
    {
        public lblResult()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int fo = int.Parse(txtfristoperand.Text);
            int so = int.Parse(txtsecoundOperand.Text);
            if (radbtnAdd.Checked)
            {
                textBox3.Text = fo + " + " + so;
                textBox4.Text = (fo + so).ToString();
            }
            else if (radbtnsub.Checked)
            {
                textBox3.Text = fo + " - " + so;
                textBox4.Text = (fo - so).ToString();
            }
            else if (radbtnmul.Checked)
            {
                textBox3.Text = fo + " * " + so;
                textBox4.Text = (fo * so).ToString();
            }
            else if (radbtndiv.Checked)
            {
                textBox3.Text = fo + " / " + so;
                textBox4.Text = (fo / so).ToString();
            }
            else if (radbtnred.Checked)
            {
                textBox3.Text = fo + " % " + so;
                textBox4.Text = (fo % so).ToString();
            }
        }

    }
}
