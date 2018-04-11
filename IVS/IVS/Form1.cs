using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathLibrary;

namespace IVS
{
	public partial class Calculator : Form
	{
		public Calculator()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			double tmp = math.Soucet(1, 1);
			try 
			{
				tmp = math.Podil(1, 0);
			}
			catch (DivideByZeroException) 
			{
				MessageBox.Show("Dělení nulou!");
				return;
			}
			MessageBox.Show(tmp.ToString());
		}

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }
    }
}
