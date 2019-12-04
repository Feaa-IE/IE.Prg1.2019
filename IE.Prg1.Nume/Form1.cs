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

namespace IE.Prg1.Nume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void uxButtonAdauga_Click(object sender, EventArgs e)
        {
            AdaugaNume();
        }

        private void AdaugaNume()
        {
            string nume = uxTextBoxNume.Text;
            bool exista = false;
            for (int i = 0; i < uxListBoxNume.Items.Count; i++)
            {
                if (uxListBoxNume.Items[i].ToString() == nume)
                {
                    MessageBox.Show($"{nume} exista deja!");
                    exista = true;
                    break;
                }
            }
            if (!exista)
            {
                uxListBoxNume.Items.Add(nume);
            }
            uxTextBoxNume.Focus();
            uxTextBoxNume.Select(0, uxTextBoxNume.Text.Length);
        }

        private void uxTextBoxNume_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AdaugaNume();
            }
        }

        private void uxButtonSorteaza_Click(object sender, EventArgs e)
        {
            string[] listNume = new string[uxListBoxNume.Items.Count];
            for (int i = 0; i < uxListBoxNume.Items.Count; i++)
            {
                listNume[i] = uxListBoxNume.Items[i].ToString();
            }

            FunctiiSortare.InsertionSort(listNume, uxCheckBoxDescrescator.Checked);

            uxListBoxNume.Items.Clear();
            uxListBoxNume.Items.AddRange(listNume);

        }
    }
}
