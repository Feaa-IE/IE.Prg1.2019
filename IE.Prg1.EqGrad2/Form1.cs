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

            double a = double.Parse(uxTextBoxA.Text);
            double b = double.Parse(uxTextBoxB.Text);
            double c = double.Parse(uxTextBoxC.Text);

            bool areInfinitateSolutii;
            double[] solutiiEq = EqGrad2(a, b, c, out areInfinitateSolutii);

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

        private double[] EqGrad2(double a, double b, double c, out bool infinitateSolutii)
        {
            double[] solutii = new double[0];
            infinitateSolutii = false;
            if (a == 0 && b == 0 && c == 0)
            {
                infinitateSolutii = true;
                return solutii;
            }
            if (a == 0 && b == 0)
            {
                return solutii;
            }

            if (a == 0)
            {
                Array.Resize(ref solutii, 1);
                solutii[0] = -c / b;
                return solutii;
            }

            double delta;
            delta = b * b - 4 * a * c;

            if(delta > 0)
            {

                Array.Resize(ref solutii, 2);
                solutii[0] = (-b + Math.Sqrt(delta)) / 2 * a;
                solutii[1] = (-b - Math.Sqrt(delta)) / 2 * a;
                return solutii;
            }

            if(delta == 0)
            {
                Array.Resize(ref solutii, 2);
                solutii[0] = solutii[1] = -b  / 2 * a;
                return solutii;
            }

            return solutii;
        }


    }
}
