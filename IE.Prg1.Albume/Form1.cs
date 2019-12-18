using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IE.Prg1.Albume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Vladimir\Documents\FEAA Cursuri\Programare1\2019\IE.Prg1\BD\GestAlbume.accdb;Persist Security Info=False;";
            try
            {
                conn.Open();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Nu s-a putut realiza conexiunea la baza de date!" + ex.Message);
            }

            OleDbCommand select = new OleDbCommand();
            select.Connection = conn;
            select.CommandText = "select ID, Denumire from Albume";
            OleDbDataReader reader = select.ExecuteReader();

            DataTable table = new DataTable("Albume");
            table.Load(reader);

            uxComboBoxAlbume.DataSource = table;

            if (reader.IsClosed == false)
            {
                reader.Close();
            }

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void uxComboBoxAlbume_SelectedIndexChanged(object sender, EventArgs e)
        {

            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Vladimir\Documents\FEAA Cursuri\Programare1\2019\IE.Prg1\BD\GestAlbume.accdb;Persist Security Info=False;";
            try
            {
                conn.Open();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Nu s-a putut realiza conexiunea la baza de date!" + ex.Message);
            }

            OleDbCommand select = new OleDbCommand();
            select.Connection = conn;
            select.CommandText = "select * from Albume where ID=@id";
            select.Parameters.AddWithValue("id", (int)uxComboBoxAlbume.SelectedValue);
            OleDbDataReader reader = select.ExecuteReader();
            reader.Read();

            uxTextBoxInv.Text = reader["ID"].ToString();
            uxTextBoxArtist.Text = reader["Artist"].ToString();
            uxTextBoxDenumire.Text = reader["Denumire"].ToString();
            uxTextBoxPret.Text = reader["Pret"].ToString();
            uxComboBoxSuport.Text = reader["Suport"].ToString();
            uxDateTimePickerData.Value = reader.GetDateTime(1);
        }
    }
}
