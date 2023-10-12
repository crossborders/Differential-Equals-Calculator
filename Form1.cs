using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Differential_Equals_Calculator
{
    public partial class DifEqCalc : Form
    {
        public DifEqCalc()
        {
            InitializeComponent();
            
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private bool firstClick = true;
        private void EnterProblem_Click(object sender, EventArgs e)
        {
            if (firstClick)
            {
                EnterProblem.SelectAll();
                if (EnterProblem.Text != "Enter a problem")
                {
                    EnterProblem.Clear();
                }
                firstClick = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button34_Click(object sender, EventArgs e)
        {
            EnterProblem.Text += "^2";
        }

        private void button33_Click(object sender, EventArgs e)
        {
            EnterProblem.Text += "^";
        }

        private void button29_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void DifEqCalc_Load(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {
            EnterProblem.Text += "√";
        }
        
    }
}
