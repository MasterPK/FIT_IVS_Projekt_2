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
    public partial class Testy : Form
    { //Kod pro testy

        static int chyby = 0;

        public Testy()
        {
            InitializeComponent();

            int chybneokruhy = 0;

            richTextBox1.AppendText("::::::::::::::::::::::::::::::\r\n::Testy matematicke knihovny::\r\n::::::::::::::::::::::::::::::\r\n\r\n");

            //testy pro plus
            richTextBox1.AppendText(":::Testy Soucet:::");
            chyby = 0;
            ExpectEQ(4.5, math.Soucet(2, 2.5));
            ExpectEQ(4.5, math.Soucet(2.5, 2));
            ExpectNEQ(4.5, math.Soucet(2, 2.500001));
            ExpectNEQ(4.5, math.Soucet(2.500001, 2));
            ExpectNEQ(4.5, math.Soucet(10, 30));
            richTextBox1.AppendText("\r\n:::Konec testu Soucet");
            if (chyby != 0)
            {
                chybneokruhy++;
            };
            richTextBox1.AppendText("Pocet Chyb:" + chyby + ":::\r\n\r\n");

            //testy pro odcitani
            richTextBox1.AppendText(":::Testy Rozdil:::");
            chyby = 0;
            ExpectEQ(4.5, math.Rozdil(6.5, 2));
            ExpectEQ(4.5, math.Rozdil(5.052345, 0.552345));
            ExpectNEQ(4.5, math.Rozdil(2, 6.5));
            ExpectNEQ(4.5, math.Rozdil(0.552345, 5.052345));
            ExpectNEQ(4.5, math.Rozdil(1534, 13));
            ExpectEQ(4.5, math.Rozdil(4, -0.5));
            richTextBox1.AppendText("\r\n:::Konec testu Rozdil:::");
            if (chyby != 0)
            {
                chybneokruhy++;
            };
            richTextBox1.AppendText("Pocet Chyb:" + chyby + ":::\r\n\r\n");

            //testy pro nasobení
            richTextBox1.AppendText(":::Testy Nasob:::");
            chyby = 0;
            ExpectEQ(4.5, math.Nasob(2.25, 2));
            ExpectEQ(4.5, math.Nasob(2, 2.25));
            ExpectNEQ(4.5, math.Nasob(2.25, 2));
            ExpectEQ(-13, math.Nasob(6.5, -2));
            ExpectNEQ(13, math.Nasob(6.5, -2));
            richTextBox1.AppendText("\r\n:::Konec testu Nasob:::");
            if (chyby != 0)
            {
                chybneokruhy++;
            };
            richTextBox1.AppendText("Pocet Chyb:" + chyby + ":::\r\n\r\n");

            //testy pro dělení
            richTextBox1.AppendText(":::Testy Podil:::");
            chyby = 0;
            ExpectEQ(-2, math.Podil(13, -6.5));
            ExpectEQ(4.5, math.Podil(-9, -2));
            ExpectNEQ(4.5, math.Podil(9, -2));
            richTextBox1.AppendText("\r\n:::Konec testu Podil:::");
            if (chyby != 0)
            {
                chybneokruhy++;
            };
            richTextBox1.AppendText("Pocet Chyb:" + chyby + ":::\r\n\r\n");

            richTextBox1.AppendText(":::::::::::::::::::::::::::::\r\n:::Pocet chybnych funkci:" + chybneokruhy + ":::\r\n");
            richTextBox1.AppendText("::::::::::::::::::::::::::::::::::::\r\n::Konec testu matematicke knihovny::\r\n::::::::::::::::::::::::::::::::::::\r\n\r\n");
        }

        void ExpectEQ(double a, double b)
        {
            double odchylka = 0.000000000001;
            double rozdil = Math.Abs(a - b);
            if (rozdil > odchylka)
            {
                chyby++;
                richTextBox1.AppendText("\r\nChybaEQ ");
            }
            else
            {
                richTextBox1.AppendText("\r\nEQ ");
            }
            richTextBox1.AppendText("Ocekavany vysledek:" + a + " / Realny vysledek:" + b);
        }
        void ExpectNEQ(double a, double b)
        {
            double odchylka = 0.000000000001;
            double rozdil = Math.Abs(a - b);
            if (rozdil < odchylka)
            {
                chyby++;
                richTextBox1.AppendText("\r\nChybaNEQ ");
            }
            else
            {
                richTextBox1.AppendText("\r\nNEQ ");
            }
            richTextBox1.AppendText("Ocekavany vysledek:" + a + " / Realny vysledek:" + b);
        }
    }
}
