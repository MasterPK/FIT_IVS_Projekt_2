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
			this.ActiveControl = textBox1;
			//MessageBox.Show(math.Zpracovat_Vyraz("-1-1-1+1+1+1+5*5-5*5*-5/+1/-5"));//==0 FUNGUJE!!! 
			//double[] pole = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			//MessageBox.Show(odchylka_s(10,pole).ToString());
		}

        /// <summary>
        /// textbox na zadávanie vstupov
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// funkcia spracuje a odstráni zátvorky
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private string spracovanie_zatvorky(string text)
        {
            while (text.Contains('(') && text.Contains(')'))
            {
                string vysledok = "";
                int openIndex = 0;
                int closeIndex = 0;
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == '(')
                    {
                        openIndex = i;
                        if (i !=0 && char.IsDigit(text[i - 1]))
                        {
                            text = text.Insert(openIndex, "*");
                        }
                    }
                    if (text[i] == ')')
                    {
                        closeIndex = i;
                        string zatvorka = text.Substring(openIndex + 1, closeIndex - openIndex - 1);
                        text = text.Remove(openIndex, closeIndex - openIndex + 1);
                        try
                        {
                            vysledok = math.Zpracovat_Vyraz(zatvorka);
                        }
                        catch
                        {
                            MessageBox.Show("Chyba vstupu! Zkontrolujte znaménka!", "Chyba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return textBox1.Text;
                        }
                        text = text.Insert(openIndex, vysledok);
                        i = 0;
                    }
                }
            }
            try
            {
                text = math.Zpracovat_Vyraz(text);
            }
            catch
            {
                MessageBox.Show("Chyba vstupu! Zkontrolujte znaménka!", "Chyba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return textBox1.Text;
            }
            return text;
        }

        /// <summary>
        /// Funkcia zistí či je vstup korektný
        /// </summary>
        /// <param name="vstup"></param>
        /// <returns></returns>
        private bool Vstup(string vstup)
        {
            int zatL = 0;
            int zatP = 0;
            for (int j = 0; j < vstup.Length; j++)
            {
                if (vstup[j] == '+' || vstup[j] == '-')
                {
                    if (j == vstup.Length-1 && (vstup[j - 1] == '+' || vstup[j - 1] == '-' || vstup[j - 1] == ','))
                    {
                        MessageBox.Show("Chyba vstupu! Zkontrolujte znamenka!", "Chyba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    if (j != vstup.Length-1 && j != 0 && (vstup[j + 1] == '+' || vstup[j + 1] == '-' || vstup[j + 1] == ','))
                    {
                        MessageBox.Show("Chyba vstupu! Zkontrolujte znamenka!", "Chyba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                if (vstup[j] == '(')
                {
                    zatL++;
                }
                if (vstup[j] == ')')
                {
                    if(zatP == zatL - 1)
                    {
                        zatP++;
                    }
                }

            }
            if (zatL != zatP)
            {
                MessageBox.Show("Chyba vstupu! Zkontrolujte závorky!", "Chyba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        /// <summary>
        /// rovná sa =
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button11_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length == 1)
            {
                return;
            }
            if(textBox1.Text == "")
            {
                return;
            }
            else
            {
                if(Vstup(textBox1.Text) == false)
                {
                    return;
                }
            }
            string vystup="";
            if (textBox1.Text.Contains('√'))
            {
                for(int i = 0; i < textBox1.Text.Length; i++)
                {
                    if(textBox1.Text[i] == '√')
                    {
                        if (i == 0)
                        {
                            textBox1.Text = textBox1.Text.Insert(i, "2");
                        }
                        if (i != 0 && char.IsDigit(textBox1.Text[i - 1]) == false)
                        {
                            textBox1.Text = textBox1.Text.Insert(i, "2");
                        }
                    }
                }
            }
            if(textBox1.Text.Contains('(') || textBox1.Text.Contains(')'))
            {
                vystup=spracovanie_zatvorky(textBox1.Text);
            }
            else
            {
                try
                {
                    vystup = math.Zpracovat_Vyraz(textBox1.Text);
                }
                catch
                {
                    MessageBox.Show("Chyba vstupu! Zkontrolujte znaménka!", "Chyba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
			    

            }

            if (vystup[0] == '+')
            {
                vystup = vystup.Remove(0, 1);
                textBox1.Text = vystup;
            }
            else
            {
                textBox1.Text = vystup;
            }
        }

        /// <summary>
        /// Výpočet tangens zadaného vstupu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1)
            {
                return;
            }
            if (textBox1.Text == "")
            {
                return;
            }
            else
            {
                if (Vstup(textBox1.Text) == false)
                {
                    return;
                }
            }
            if (textBox1.Text.Contains('/') || textBox1.Text.Contains('*') || textBox1.Text.Contains('+') || textBox1.Text.Contains('-') || textBox1.Text.Contains('^'))
            {
                string text = math.Zpracovat_Vyraz(textBox1.Text);
                double cislo = Convert.ToDouble(text);
                textBox1.Text = Convert.ToString(math.Tangens(cislo));
            }
            else
            {
                double cislo = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(math.Tangens(cislo));
            }
        }

        /// <summary>
        /// mazanie jednotlivých znakov
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button23_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length != 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }
        
        /// <summary>
        /// Spustí help
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button24_Click(object sender, EventArgs e)
        {
            Form napoveda = new napoveda();
            napoveda.Show();
        }

        /// <summary>
        /// Spusti testy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Spusteni_testu_Click(object sender, EventArgs e)
        {
            Form testy = new Testy();
            testy.Show();
        }

		/// <summary>
		/// Zapis odmocniny do textbox
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "√";
        }

		

		/// <summary>
		/// Kontroluje stisknuti Enter, Delete
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void textBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter)
			{
				button11.PerformClick();
				textBox1.SelectionStart = textBox1.Text.Length ;
				textBox1.SelectionLength = 0;
			}
			if (e.KeyData == Keys.Delete)
			{
				button22.PerformClick();
			}

		}

		/// <summary>
		/// Pocita smerodatnou odchylku
		/// </summary>
		/// <param name="N">Pocet cisel</param>
		/// <param name="pole">Vstupni pole cisel</param>
		/// <returns></returns>
		private double odchylka_s(int N, double[] pole)
		{
			double tmp = math.Podil(1, math.Rozdil(N,1));
			double soucet = 0;
			for (int i = 0; i < N; i++)
			{
				soucet += math.Umocnit(pole[i], 2);
			}
			soucet -= math.Nasob(N, math.Umocnit(odchylka_x(N, pole), 2));
			tmp = math.Nasob(tmp, soucet);
			tmp = math.Odmocnina(tmp, 2);
			return tmp;
		}

		/// <summary>
		/// Mezivypocet smerodatne odchylky
		/// </summary>
		/// <param name="N"></param>
		/// <param name="pole"></param>
		/// <returns></returns>
		private double odchylka_x(int N,double[] pole)
		{
			double tmp = math.Podil(1, N);
			double soucet = 0;
			for (int i = 0; i < N; i++)
			{
				soucet+= pole[i];
			}
			return math.Nasob(tmp, soucet);
		}

		/// <summary>
		/// Kontroluje jake znaky byly stisknuty, pokud jde o nepovoleny znak, je jeho zapis do textbox zrusen
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			String sKeys = "1234567890+-*/^(),!\b";
			if (!sKeys.Contains(e.KeyChar.ToString().ToUpper()))
				e.Handled = true;
		}

        /// <summary>
        /// Faktorial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "!";
        }

    }

}
