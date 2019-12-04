using IE.Prg1.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IE.Prg1.EqGrad2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void uxButtonRezolva_Click(object sender, EventArgs e)
        {
            double a;
            bool valid = Convert(uxTextBoxA, "a", out a);
            if (!valid)
            {
                return;
            }

            double b;
            valid = Convert(uxTextBoxB, "b", out b);
            if (!valid)
            {
                return;
            }

            double c;
            valid = Convert(uxTextBoxC, "c", out c);
            if (!valid)
            {

                return;
            }

            bool areInfinitateSolutii;
            double[] solutiiEq = FunctiiMat.EqGrad2(a, b, c, out areInfinitateSolutii);

            if (areInfinitateSolutii)
            {
                MessageBox.Show("Ecuatia are o infinitate de solutii");
            }
            else if (solutiiEq.Length == 0)
            {
                MessageBox.Show("Ecuatia nu are solutii");
            }
            else if (solutiiEq.Length == 1)
            {
                MessageBox.Show("Ecuatia este de gradul 1. Solutia este:" + solutiiEq[0]);
            }
            else
            {
                MessageBox.Show("Ecuatia este de gradul 2. Solutiile sunt:" + solutiiEq[0] + "," + solutiiEq[1]);
            }
        }
        private bool Convert(TextBox txt, string numeVar, out double valoare)
        {
            bool valid;
            valid = double.TryParse(txt.Text, out valoare);
            if (!valid)
            {
                MessageBox.Show(numeVar + " invalid! Trebuie sa fie un numar!");
                txt.Clear();
                txt.Focus();

            }
            return valid;

        }



    }
}
