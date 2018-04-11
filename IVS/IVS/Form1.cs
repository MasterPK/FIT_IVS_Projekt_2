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

        private void Calculator_Load(object sender, EventArgs e)
        {
			MessageBox.Show(math.Zpracovat_Vyraz("5+5-5*5*5").ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Vloženie '0' do textového pola
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        /// <summary>
        /// Vloženie '+' do textového pola
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "+";
        }

        /// <summary>
        /// vloženie '(' do textového pola
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "(";
        }

        /// <summary>
        /// Vloženie '1' do textového pola
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        /// <summary>
        /// Vloženie '2' do textového pola
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        /// <summary>
        /// Vloženie '3' do textového pola
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        /// <summary>
        /// Vloženie '4' do textového pola
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        /// <summary>
        /// Vloženie '5' do textového pola
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        /// <summary>
        /// Vloženie '6' do textového pola
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        /// <summary>
        /// Vloženie '7' do textového pola
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        /// <summary>
        /// Vloženie '8' do textového pola
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        /// <summary>
        /// Vloženie '9' do textového pola
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        /// <summary>
        /// Vloženie ')' do textového pola
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ")";
        }

        /// <summary>
        /// Vyčistenie textového pola
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        /// <summary>
        /// Vloženie ',' do textového pola
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        /// <summary>
        /// Vloženie '-' do textového pola
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "-";
        }

        /// <summary>
        /// Vloženie 'x' do textového pola
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "*";
        }

        /// <summary>
        /// Vloženie '/' do textového pola
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "/";
        }

        /// <summary>
        /// Vloženie '^' do textového pola
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "^";
        }

        private void spracovanie_zatvorky(string text)
        {
            while (text.Contains('(') && text.Contains(')'))
            {
                int openIndex = 0;
                int closeIndex = 0;
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == '(')
                    {
                        openIndex = i;
                    }
                    if (text[i] == ')')
                    {
                        closeIndex = i;
                        string zatvorka = text.Substring(openIndex + 1, closeIndex - openIndex - 1);
                        text = text.Remove(openIndex, closeIndex - openIndex + 1);
                    }
                }
            }
        }

        /// <summary>
        /// rovná sa =
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button11_Click(object sender, EventArgs e)
        {
            spracovanie_zatvorky(textBox1.Text);
        }

        /// <summary>
        /// tangens
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains('/') || textBox1.Text.Contains('*') || textBox1.Text.Contains('+') || textBox1.Text.Contains('-') || textBox1.Text.Contains('^'))
            {
                textBox1.Text = "Syntax Error!";
            }
            double cislo = Convert.ToDouble(textBox1.Text);
            textBox1.Text =Convert.ToString(math.Tangens(cislo));
        }

        /// <summary>
        /// mazanie jednotlivých znakov
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            
        }
    }
}
