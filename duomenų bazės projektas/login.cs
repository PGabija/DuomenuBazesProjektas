using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace duomenų_bazės_projektas
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        public void PrisijungtiMygt_Click(object sender, EventArgs e)
        {
            string mysqlCon = "server=127.0.0.1; user=root; database=praktinis2; password=admin";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);
            String username, user_password;

            username = PrisijungimoVardas.Text;
            user_password = Slaptazodis.Text;
      
            try
            {
                mySqlConnection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM leidejas WHERE Prisijungimo_vardas = '" + username + "' AND Slaptazodis = '" + user_password + "'", mySqlConnection);              
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dtable = new DataTable();
                adapter.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = PrisijungimoVardas.Text;
                    user_password = Slaptazodis.Text;

                    LeidejoMeniu form2 = new LeidejoMeniu();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Neteisingas prisijungimo vardas arba slaptažodis", "Klaida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PrisijungimoVardas.Clear();
                    Slaptazodis.Clear();
                    PrisijungimoVardas.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Klaida: " + ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }
        public void IsvalytiMygt_Click(object sender, EventArgs e)
        {
            PrisijungimoVardas.Clear();
            Slaptazodis.Clear();
            PrisijungimoVardas.Focus();
        }

        public void PrisijungtiMygtAdm_Click(object sender, EventArgs e)
        {
            if((PrisijungimoVardasAdm.Text == "admin" && SlaptazodisAdm.Text == "admin123"))
            {
                Administratorius form3 = new Administratorius();
                form3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Neteisingas prisijungimo vardas arba slaptažodis", "Klaida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PrisijungimoVardasAdm.Clear();
                SlaptazodisAdm.Clear();
                PrisijungimoVardasAdm.Focus();
            }
        }



        public void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Slaptazodis.PasswordChar = '*';
            }
            else
            {
                Slaptazodis.PasswordChar = '\0'; 
            }
        }

        public void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                SlaptazodisKur.PasswordChar = '*';
            }
            else
            {
                SlaptazodisKur.PasswordChar = '\0'; 
            }
        }

        public void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                SlaptazodisAdm.PasswordChar = '*';
            }
            else
            {
                SlaptazodisAdm.PasswordChar = '\0';
            }
        }


        public void RegLEID_Click(object sender, EventArgs e)
        {
            RegistracijaLEID form7 = new RegistracijaLEID();
            form7.Show();
            this.Hide();
        }

        public void RegKUR_Click(object sender, EventArgs e)
        {
            RegistracijaKUR form8 = new RegistracijaKUR();
            form8.Show();
            this.Hide();
        }
        public int PatikrintiPrisijungima(string username, string password)
        {
            int kurejoId = -1;

            string mysqlCon = "server=127.0.0.1; user=root; database=praktinis2; password=admin";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);

            try
            {
                mySqlConnection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT kurejoId FROM kurejas WHERE Prisijungimo_vardas = @username AND Slaptazodis = @password", mySqlConnection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    kurejoId = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Klaida: " + ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }

            return kurejoId;
        }


        public void PrisijungtiMygtKur_Click(object sender, EventArgs e)
        {
            string mysqlCon = "server=127.0.0.1; user=root; database=praktinis2; password=admin";
            string username = PrisijungimoVardasKur.Text;
            string user_password = SlaptazodisKur.Text;

            int kurejoId = PatikrintiPrisijungima(username, user_password); 

            Zaidimokelimas.kurejoId = kurejoId; 
            KurejasMeniu.KurejoID = kurejoId; 

            using (MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon))
            {
                try
                {
                    mySqlConnection.Open();
                    string query = "SELECT * FROM kurejas WHERE Prisijungimo_vardas = @username AND Slaptazodis = @password";
                    MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", user_password);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dtable = new DataTable();
                    adapter.Fill(dtable);

                    if (dtable.Rows.Count > 0)
                    {
                        KurejasMeniu form = new KurejasMeniu();
                        form.Show();
                        this.Hide();
                    }
                    else if (kurejoId != -1)
                    {
                        Zaidimokelimas zaidimokelimasForma = new Zaidimokelimas(kurejoId);
                        zaidimokelimasForma.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Neteisingas prisijungimo vardas arba slaptažodis", "Klaida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        PrisijungimoVardasKur.Clear();
                        SlaptazodisKur.Clear();
                        PrisijungimoVardasKur.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Klaida: " + ex.Message);
                }
            }
        }

        public void login_Load(object sender, EventArgs e)
        {

        }
        public void button1_Click(object sender, EventArgs e)
        {
            Svetaine form = new Svetaine();
            form.Show();
            this.Hide();
        }
    }
}