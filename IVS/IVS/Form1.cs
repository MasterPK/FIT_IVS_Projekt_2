﻿using System;
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
	public partial class Form1 : Form
	{
		public Form1()
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
	}
}
