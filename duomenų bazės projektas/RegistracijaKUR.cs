using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace duomenų_bazės_projektas
{
    public partial class RegistracijaKUR : Form
    {
        string mysqlCon = "server=127.0.0.1; user=root; database=praktinis2; password=admin";

        public RegistracijaKUR()
        {
            InitializeComponent();
        }

        public void button2_Click_1(object sender, EventArgs e)
        {
            login form = new login();
            form.Show();
            this.Hide();
        }

        public void button1_Click_1(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
                {
                    MessageBox.Show("Visi laukai turi būti užpildyti.", "Klaida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon))
                {
                    try
                    {
                        mySqlConnection.Open();

                        MySqlCommand cmd1 = new MySqlCommand("INSERT INTO kurejas (Vardas, Pavarde, Imone, Prisijungimo_vardas, Slaptazodis) VALUES (@vardas, @pavarde, @imone, @prisijungimo_vardas, @slaptazodis)", mySqlConnection);
                        cmd1.Parameters.AddWithValue("@vardas", textBox1.Text);
                        cmd1.Parameters.AddWithValue("@pavarde", textBox2.Text);
                        cmd1.Parameters.AddWithValue("@imone", textBox3.Text);
                        cmd1.Parameters.AddWithValue("@prisijungimo_vardas", textBox4.Text);
                        cmd1.Parameters.AddWithValue("@slaptazodis", textBox5.Text);
                        cmd1.ExecuteNonQuery();

                        int kurejoID = (int)cmd1.LastInsertedId;

                        MessageBox.Show("Duomenys sėkmingai išsaugoti.", "Pranešimas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        KurejasMeniu form = new KurejasMeniu();
                        form.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Klaida įrašant duomenis į duomenų bazę: " + ex.Message, "Klaida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
