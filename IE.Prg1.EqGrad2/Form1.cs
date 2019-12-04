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
            bool valid = double.TryParse(uxTextBoxA.Text, out a);
            if (!valid){
                MessageBox.Show("a invalid! Trebuie sa fie un numar!");
                uxTextBoxA.Clear();
                uxTextBoxA.Focus();
                return;
            }

            double b;
            valid = double.TryParse(uxTextBoxB.Text, out b);
            if (!valid)
            {
                MessageBox.Show("b invalid! Trebuie sa fie un numar!");
                uxTextBoxB.Clear();
                uxTextBoxB.Focus();
                return;
            }

            double c;
            valid = double.TryParse(uxTextBoxC.Text, out c);
            if (!valid)
            {
                MessageBox.Show("c invalid! Trebuie sa fie un numar!");
                uxTextBoxC.Clear();
                uxTextBoxC.Focus();
                return;
            }

            bool areInfinitateSolutii;
            double[] solutiiEq = FunctiiMat.EqGrad2(a, b, c, out areInfinitateSolutii);

            if (areInfinitateSolutii)
            {
                MessageBox.Show("Ecuatia are o infinitate de solutii");
            }
            else if( solutiiEq.Length == 0)
            {
                MessageBox.Show("Ecuatia nu are solutii");
            }
            else if(solutiiEq.Length == 1)
            {
                MessageBox.Show("Ecuatia este de gradul 1. Solutia este:" + solutiiEq[0]);
            }
            else
            {
                MessageBox.Show("Ecuatia este de gradul 2. Solutiile sunt:" + solutiiEq[0] + "," + solutiiEq[1]);
            }
        }

       


    }
}
