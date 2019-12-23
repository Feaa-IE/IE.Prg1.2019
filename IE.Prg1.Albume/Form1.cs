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
            Populeaza();
        }

        private void Populeaza()
        {
            OleDbConnection conn = DeschideConexiune();

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
            OleDbConnection conn = DeschideConexiune();

            OleDbCommand select = new OleDbCommand();
            select.Connection = conn;
            select.CommandText = "select * from Albume where ID=@id";
            select.Parameters.AddWithValue("id", (int)uxComboBoxAlbume.SelectedValue);
            OleDbDataReader reader = select.ExecuteReader();
            if (!reader.Read())
            {
                MessageBox.Show("Nu s-au gasit inregistrari!");
                return;
            }

            uxTextBoxInv.Text = reader["ID"].ToString();
            uxTextBoxArtist.Text = reader["Artist"].ToString();
            uxTextBoxDenumire.Text = reader["Denumire"].ToString();
            uxTextBoxPret.Text = reader["Pret"].ToString();
            uxComboBoxSuport.Text = reader["Suport"].ToString();
            uxDateTimePickerData.Value = reader.GetDateTime(1);

            if (reader.IsClosed == false)
            {
                reader.Close();
            }

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

        }

        private void uxButtonNou_Click(object sender, EventArgs e)
        {
            uxTextBoxInv.Text = "0";
            uxTextBoxDenumire.Text = "";
            uxTextBoxArtist.Text = string.Empty;
            uxTextBoxPret.Clear();
            uxComboBoxSuport.Text = "";
            uxDateTimePickerData.Value = DateTime.Today;
        }

        private OleDbConnection DeschideConexiune()
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Vladimir\Documents\FEAA Cursuri\Programare1\2019\IE.Prg1\BD\GestAlbume.accdb;Persist Security Info=False;";
            try
            {
                conn.Open();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Nu s-a putut realiza conexiunea la baza de date! " + ex.Message);
            }
            return conn;
        }

        private void uxButtonSalveaza_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = DeschideConexiune();

            OleDbCommand salveaza = new OleDbCommand();
            salveaza.Connection = conn;

            if (uxTextBoxInv.Text == "0")
            {
                salveaza.CommandText = "insert into Albume(Data, Artist, Denumire, Pret, Suport) values (@data, @artist, @denumire, @pret, @suport)";
            }
            else
            {
                salveaza.CommandText = "update Albume set Data=@data, Denumire=@denumire, Artist=@artist, Pret=@pret, Suport=@suport where ID=@id";
                salveaza.Parameters.AddWithValue("id", long.Parse(uxTextBoxInv.Text));
            }

            OleDbParameter dataParam = new OleDbParameter();
            dataParam.ParameterName = "data";
            dataParam.DbType = DbType.Date;
            dataParam.Value = uxDateTimePickerData.Value;
            salveaza.Parameters.Add(dataParam);

            salveaza.Parameters.AddWithValue("denumire", uxTextBoxDenumire.Text);
            salveaza.Parameters.AddWithValue("artist", uxTextBoxArtist.Text);
            salveaza.Parameters.AddWithValue("pret", double.Parse(uxTextBoxPret.Text));
            salveaza.Parameters.AddWithValue("suport", uxComboBoxSuport.Text);

            int salvate = salveaza.ExecuteNonQuery();

            if (salvate > 0)
            {
                MessageBox.Show("Salvarea a reusit!");
                Populeaza();
            }
            else
            {
                MessageBox.Show("Salvarea a esuat!");
            }
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

        }

        private void uxButtonSterge_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = DeschideConexiune();

            OleDbCommand sterge = new OleDbCommand();
            sterge.Connection = conn;
            sterge.CommandText = "delete from Albume where ID = @id";
            sterge.Parameters.AddWithValue("id",(int)uxComboBoxAlbume.SelectedValue);

            int sterse = sterge.ExecuteNonQuery();
            if (sterse>0)
            {
                MessageBox.Show("Stergerea a reusit!");
                Populeaza();
            }
            else
            {
                MessageBox.Show("Stergerea a esuat!");
            }
        }
    }
}
