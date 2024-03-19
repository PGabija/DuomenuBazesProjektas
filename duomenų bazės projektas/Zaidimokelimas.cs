using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace duomenų_bazės_projektas
{
    public partial class Zaidimokelimas : Form
    {
        public static int kurejoId;

        public Zaidimokelimas(int kurejoId)
        {
            InitializeComponent();
            Zaidimokelimas.kurejoId = kurejoId; 
            textBox5.Text = Zaidimokelimas.kurejoId.ToString(); 
        }

        public void button2_Click(object sender, EventArgs e)
        {
            KurejasMeniu form2 = new KurejasMeniu();
            form2.Show();
            this.Hide();
        }

        public void button1_Click_1(object sender, EventArgs e)
        {
            string connectionString = "server=127.0.0.1; user=root; database=praktinis2; password=admin";
            string pavadinimas = textBox1.Text;
            string aprasymas = textBox3.Text;
            string platforma = textBox2.Text;
            DateTime isleidimoData = dateTimePicker1.Value;
            string zanras = textBox4.Text;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO zaidimas (pavadinimas, aprasymas, platforma, `isleidimo data`, zanras, KurejoID) " +
               "VALUES (@pavadinimas, @aprasymas, @platforma, @isleidimoData, @zanras, @kurejoId)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@pavadinimas", pavadinimas);
                        command.Parameters.AddWithValue("@aprasymas", aprasymas);
                        command.Parameters.AddWithValue("@platforma", platforma);
                        command.Parameters.AddWithValue("@isleidimoData", isleidimoData);
                        command.Parameters.AddWithValue("@zanras", zanras);
                        command.Parameters.AddWithValue("@kurejoId", kurejoId);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Žaidimo duomenys sėkmingai įrašyti į duomenų bazę.");
                        }
                        else
                        {
                            MessageBox.Show("Nepavyko įrašyti žaidimo duomenų į duomenų bazę.");
                            Zaidimostatusas zaidimostatusasForma = new Zaidimostatusas(kurejoId);
                            zaidimostatusasForma.Show();
                            this.Hide();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Klaida įrašant žaidimo duomenis: " + ex.Message);
            }
        }
    }
}