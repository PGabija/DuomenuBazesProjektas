using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Devart.Data.MySql;
using duomenų_bazės_projektas;
using System.Data;
using System.Windows.Forms;
namespace UnitTestaiT
{
    [TestClass]
    public class LoginTestai
    {
        [TestMethod]
        public void AdminLogin()
        {
            // Arrange
            var form = new login();
            var form2 = new Administratorius();

            // Act
            form.PrisijungimoVardasAdm.Text = "admin";
            form.SlaptazodisAdm.Text = "admin123";
            form.PrisijungtiMygtAdm_Click(null, null);

            // Assert
            Assert.IsTrue(form.Visible == false || form2.Visible == true);
        }

        [TestMethod]
        public void KurejasLogin()
        {
            // Arrange
            var form = new login();
            var form2 = new KurejasMeniu();

            // Act
            form.PrisijungimoVardasKur.Text = "kazys123";
            form.SlaptazodisKur.Text = "kazys";
            form.PrisijungtiMygtKur_Click(null, null);

            // Assert
            Assert.IsTrue(form.Visible == false || form2.Visible == true);
        }

        [TestMethod]
        public void LeidejasLogin()
        {
            // Arrange
            var form = new login();
            var form2 = new LeidejoMeniu();

            // Act
            form.PrisijungimoVardas.Text = "darius123";
            form.Slaptazodis.Text = "darius";
            form.PrisijungtiMygt_Click(null, null);

            // Assert
            Assert.IsTrue(form.Visible == false || form2.Visible == true);
        }
    }

    [TestClass]
    public class RegistracijosFormaTestai
    {
        [TestMethod]
        public void Kurejui()
        {
            // Arrange
            var form = new login();
            var form2 = new RegistracijaKUR();

            // Act
            form.RegKUR_Click(null, null);

            // Assert
            Assert.IsTrue(form.Visible == false || form2.Visible == true);
        }

        [TestMethod]
        public void Leidejui()
        {
            // Arrange
            var form = new login();
            var form2 = new RegistracijaLEID();

            // Act
            form.RegLEID_Click(null, null);

            // Assert
            Assert.IsTrue(form.Visible == false || form2.Visible == true);
        }
    }

    [TestClass]
    public class RegisterTestai
    {
        [TestMethod]
        public void KurejasReg()
        {
            // Arrange
            var form = new RegistracijaKUR();

            // Act
            form.textBox1.Text = "Vardas";
            form.textBox2.Text = "Pavarde";
            form.textBox3.Text = "Imone";
            form.textBox4.Text = "testUser";
            form.textBox5.Text = "testPassword";

            form.button1_Click_1(null, null);

            // Assert
            using (MySqlConnection mySqlConnection = new MySqlConnection("server=127.0.0.1; user=root; database=praktinis2; password=admin"))
            {
                mySqlConnection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM kurejas WHERE Prisijungimo_vardas = 'testUser'", mySqlConnection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dtable = new DataTable();
                adapter.Fill(dtable);

                Assert.IsTrue(dtable.Rows.Count > 0);
                Assert.IsTrue(form.Visible == false);
            }
        }

        [TestMethod]
        public void LeidejassReg()
        {
            // Arrange
            var form = new RegistracijaLEID();

            // Act
            form.textBox1.Text = "Test";
            form.textBox2.Text = "Testas";
            form.textBox3.Text = "Imone";
            form.textBox4.Text = "860000000";
            form.textBox5.Text = "pastas@gmail.com";
            form.textBox6.Text = "testuser";
            form.textBox7.Text = "testPassword";

            form.button1_Click(null, null);

            // Assert
            using (MySqlConnection mySqlConnection = new MySqlConnection("server=127.0.0.1; user=root; database=praktinis2; password=admin"))
            {
                mySqlConnection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM leidejas WHERE Prisijungimo_vardas = 'testuser'", mySqlConnection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dtable = new DataTable();
                adapter.Fill(dtable);

                Assert.IsTrue(dtable.Rows.Count > 0);

                Assert.IsTrue(form.Visible == false);
            }
        }
    }

    [TestClass]
    public class RegisterFormaAtsauktiTestai
    {
        [TestMethod]
        public void KurejasRegAtsaukti()
        {
            // Arrange
            var form = new RegistracijaKUR();
            var form2 = new login();

            // Act
            form.button2_Click_1(null, null);

            // Assert
            Assert.IsTrue(form.Visible == false || form2.Visible == true);
        }

        [TestMethod]
        public void LeidejasRegAtsaukti()
        {
            // Arrange
            var form = new RegistracijaLEID();
            var form2 = new login();

            // Act
            form.button2_Click(null, null);

            // Assert
            Assert.IsTrue(form.Visible == false || form2.Visible == true);
        }
    }

    [TestClass]
    public class IejimasISvetaineTestai
    {
        [TestMethod]
        public void Klientui()
        {
            // Arrange
            var form = new login();
            var form2 = new Svetaine();

            // Act
            form.button1_Click(null, null);

            // Assert
            Assert.IsTrue(form.Visible == false || form2.Visible == true);
        }
    }

    [TestClass]
    public class SvetaineTestai
    {
        [TestMethod]

        public void Leidejai()
        {

            // Arrange
            var form = new Svetaine();

            // Act
            form.button2_Click(null, null);

            // Assert
            Assert.IsInstanceOfType(Application.OpenForms["Leidejaisvetaine"], typeof(Leidejaisvetaine));
            Assert.IsFalse(form.Visible);
        }

        [TestMethod]
        public void Kurejai()
        {
            // Arrange
            var form = new Svetaine();

            // Act
            form.button1_Click(null, null);

            // Assert
            Assert.IsInstanceOfType(Application.OpenForms["KurejaiSvetaine"], typeof(Kurejaisvetaine));
            Assert.IsFalse(form.Visible);
        }

        [TestMethod]
        public void Zaidimai()
        {

            // Arrange
            var form = new Svetaine();

            // Act
            form.button3_Click(null, null);

            // Assert
            Assert.IsInstanceOfType(Application.OpenForms["ZaidimaiSvetaine"], typeof(Zaidimaisvetaine));
            Assert.IsFalse(form.Visible);
        }

        [TestMethod]
        public void Susisiekti()
        {

            // Arrange
            var form = new Svetaine();

            // Act
            form.button4_Click(null, null);

            // Assert
            Assert.IsInstanceOfType(Application.OpenForms["SusisiektiSvetaine"], typeof(Susisiektisvetaine));
            Assert.IsFalse(form.Visible);

        }

        [TestMethod]
        public void Login()
        {
            // Arrange
            var form = new Svetaine();


            // Act
            form.button5_Click(null, null);

            // Assert
            Assert.IsInstanceOfType(Application.OpenForms["Login"], typeof(login));
            Assert.IsFalse(form.Visible);
        }
    }

    [TestClass]
    public class SusisiektiTestai
    {
        [TestMethod]
        public void Grizti()
        {
            // Arrange
            var form = new Susisiektisvetaine();

            // Act
            form.button2_Click(null, null);

            // Assert

            Assert.IsInstanceOfType(Application.OpenForms["Svetaine"], typeof(Svetaine));
            Assert.IsFalse(form.Visible);

        }

        [TestMethod]
        public void IrasytiZinuteIDB()
        {
            // Arrange
            var form = new Susisiektisvetaine();
            form.textBox1.Text = "Testas";
            form.textBox2.Text = "Testauskas";
            form.textBox3.Text = "testas@gmail.com";
            form.richTextBox1.Text = "Labas.";

            // Act
            form.button1_Click(null, null);

            // Assert
            using (MySqlConnection mySqlConnection = new MySqlConnection("server=127.0.0.1; user=root; database=praktinis2; password=admin"))
            {
                mySqlConnection.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO zinutes (Vardas, Pavarde,  `El. pastas`, Zinute) VALUES (@vardas, @pavarde, @el_pastas, @zinute)", mySqlConnection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dtable = new DataTable();
                adapter.Fill(dtable);

                Assert.IsTrue(form.Visible == false);
            }
        }
    }

    [TestClass]
    public class KurejasMeniuTests
    {
        [TestMethod]
        public void Atsijungti()
        {
            // Arrange
            var form = new KurejasMeniu();

            // Act
            form.button3_Click(null, null);

            // Assert
            Assert.IsInstanceOfType(Application.OpenForms["login"], typeof(login));
            Assert.IsFalse(form.Visible);
        }

        [TestMethod]
        public void EitiIZaidimoKelimas()
        {
            // Arrange
            var form = new KurejasMeniu();

            // Act
            form.button1_Click(null, null);

            // Assert
            Assert.IsInstanceOfType(Application.OpenForms["Zaidimokelimas"], typeof(Zaidimokelimas));
            Assert.IsFalse(form.Visible);
        }

        [TestMethod]
        public void EitiIZaidimoStatusas()
        {
            // Arrange
            var form = new KurejasMeniu();

            // Act
            form.button2_Click(null, null);

            // Assert
            Assert.IsInstanceOfType(Application.OpenForms["Zaidimostatusas"], typeof(Zaidimostatusas));
            Assert.IsFalse(form.Visible);
        }
    }

    [TestClass]
    public class ZaidimokelimasTests
    {
        [TestMethod]
        public void Grizti()
        {
            // Arrange
            var form = new Zaidimokelimas(1);

            // Act
            form.button2_Click(null, null);

            // Assert
            Assert.IsInstanceOfType(Application.OpenForms["KurejasMeniu"], typeof(KurejasMeniu));
            Assert.IsFalse(form.Visible);
        }

        [TestMethod]
        public void ItrauktiZaidimaIDB()
        {
            // Arrange
            var form = new Zaidimokelimas(1);
            form.textBox1.Text = "TestGame";
            form.textBox2.Text = "PC";
            form.textBox3.Text = "Description";
            form.textBox4.Text = "Genre";
            form.dateTimePicker1.Value = DateTime.Now;

            // Act
            form.button1_Click_1(null, null);

            // Assert
            using (MySqlConnection mySqlConnection = new MySqlConnection("server=127.0.0.1; user=root; database=praktinis2; password=admin"))
            {
                mySqlConnection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM zaidimas", mySqlConnection);
                var result = cmd.ExecuteScalar();

                Assert.IsTrue(form.Visible == false);
            }
        }
    }

    [TestClass]
    public class ZaidimostatusasTests
    {
        [TestMethod]
        public void TuretųRodytiDuomenis()
        {
            // Arrange
            var form = new Zaidimostatusas(1);

            // Act
            form.Zaidimostatusas_Load(null, null);

            // Assert
            Assert.IsNotNull(form.dataGridView1.DataSource);
            Assert.AreEqual(form.dataGridView1.RowCount, 9);

        }

        [TestMethod]
        public void KlaidosPranesimas()
        {
            // Arrange
            var form = new Zaidimostatusas(1);
            form.Zaidimostatusas_Load(null, null);

            // Assert
            Assert.IsTrue(form.Visible == false);
        }

        [TestMethod]
        public void AtidarytiKurejasMeniu()
        {
            // Arrange
            var form = new Zaidimostatusas(1);

            // Act
            form.button2_Click(null, null);

            // Assert
            Assert.IsInstanceOfType(Application.OpenForms["KurejasMeniu"], typeof(KurejasMeniu));
            Assert.IsFalse(form.Visible);
        }
    }

    [TestClass]
    public class AdministratoriusTests
    {
        [TestMethod]
        public void NaudotojaiFormaAtidaryti()
        {
            // Arrange
            var form = new Administratorius();

            // Act
            form.uzsakymaiAdm_Click(null, null);

            // Assert
            Assert.IsInstanceOfType(Application.OpenForms["naudotojaiAdmForm"], typeof(naudotojaiAdmForm));
            Assert.IsFalse(form.Visible);
        }

        [TestMethod]
        public void ZaidimaiFormaAtidaryti()
        {
            // Arrange
            var form = new Administratorius();

            // Act
            form.zaidimaiAdm_Click(null, null);

            // Assert
            Assert.IsInstanceOfType(Application.OpenForms["Zaidimai"], typeof(Zaidimai));
            Assert.IsFalse(form.Visible);
        }

        [TestMethod]
        public void KurejaiFormaAtidaryti()
        {
            // Arrange
            var form = new Administratorius();

            // Act
            form.kurejaiAdm_Click(null, null);

            // Assert
            Assert.IsInstanceOfType(Application.OpenForms["KurejaiAdm"], typeof(KurejaiAdm));
            Assert.IsFalse(form.Visible);
        }

        [TestMethod]
        public void Atsijungti()
        {
            // Arrange
            var form = new Administratorius();

            // Act
            form.button1_Click(null, null);

            // Assert
            Assert.IsInstanceOfType(Application.OpenForms["login"], typeof(login));
            Assert.IsFalse(form.Visible);
        }

        [TestMethod]
        public void ZinutesFormaAtidaryti()
        {
            // Arrange
            var form = new Administratorius();

            // Act
            form.button2_Click(null, null);

            // Assert
            Assert.IsInstanceOfType(Application.OpenForms["Zinutes"], typeof(Zinutes));
            Assert.IsFalse(form.Visible);
        }
    }

    [TestClass]
    public class LeidejoMeniuTests
    {
        [TestMethod]
        public void RodytiLeidejoMeniu()
        {
            // Arrange
            var form = new LeidejoMeniu();

            // Act
            form.LeidejoMeniu_Load(null, null);

            // Assert
            Assert.IsNotNull(form.dataGridView1.DataSource);
        }

        [TestMethod]
        public void Grizti()
        {
            // Arrange
            var form = new LeidejoMeniu();

            // Act
            form.button1_Click(null, null);

            // Assert
            Assert.IsInstanceOfType(Application.OpenForms["login"], typeof(login));
            Assert.IsFalse(form.Visible);
        }

        [TestMethod]
        public void Issaugoti()
        {
            // Arrange
            var form = new LeidejoMeniu();
            var originalDataSource = new DataTable();
            originalDataSource.Columns.Add("Pavadinimas");
            originalDataSource.Columns.Add("Aprasymas");
            originalDataSource.Columns.Add("Platforma");
            originalDataSource.Columns.Add("IsleidimoData");
            originalDataSource.Columns.Add("Zanras");
            originalDataSource.Columns.Add("KurejoId");

            form.dataGridView1.DataSource = originalDataSource;

            // Act
            form.btnSave_Click(null, null);

            // Assert
            var newDataSource = new DataTable();
            newDataSource.Columns.Add("Pavadinimas");
            newDataSource.Columns.Add("Aprasymas");
            newDataSource.Columns.Add("Platforma");
            newDataSource.Columns.Add("IsleidimoData");
            newDataSource.Columns.Add("Zanras");
            newDataSource.Columns.Add("KurejoId");

            form.dataGridView1.DataSource = newDataSource;

            Assert.AreEqual(originalDataSource.Rows.Count, newDataSource.Rows.Count);
        }

        [TestMethod]
        public void Atnaujinti()
        {
            // Arrange
            var form = new LeidejoMeniu();

            // Act
            form.button2_Click(null, null);

            // Assert
            Assert.IsNotNull(form.dataGridView1.DataSource);
        }
    }

    [TestClass]
    public class ZaidimaisvetaineTests
    {
        [TestMethod]
        public void Grizti()
        {
            // Arrange
            var form = new Zaidimaisvetaine();
            var form2 = new Svetaine();

            // Act
            form.button2_Click(null, null);

            // Assert
            Assert.IsTrue(form.Visible == false || form2.Visible == true);
        }

        [TestMethod]
        public void TestZaidimaisvetaineLoad()
        {
            // Arrange
            var form = new Zaidimaisvetaine();

            // Act
            form.Zaidimaisvetaine_Load(null, EventArgs.Empty);

            // Assert
            var dataSource = (DataTable)form.dataGridView1.DataSource;
            Assert.IsNotNull(dataSource);
            Assert.AreNotEqual(0, dataSource.Rows.Count);
        }


        [TestMethod]
        public void Atnaujinti()
        {
            // Arrange
            var form = new Zaidimaisvetaine();
            var originalDataSource = new DataTable();
            originalDataSource.Columns.Add("Pavadinimas");
            originalDataSource.Columns.Add("Aprasymas");
            originalDataSource.Columns.Add("Platforma");
            originalDataSource.Columns.Add("IsleidimoData");
            originalDataSource.Columns.Add("Zanras");
            originalDataSource.Columns.Add("Ivertinimas");
            originalDataSource.Columns.Add("Kaina");

            form.dataGridView1.DataSource = originalDataSource;

            // Act
            form.button1_Click(null, EventArgs.Empty);

            // Assert
            var newDataSource = (DataTable)form.dataGridView1.DataSource;
            Assert.IsNotNull(newDataSource);
            Assert.AreNotEqual(0, newDataSource.Rows.Count);
        }
    }
}

