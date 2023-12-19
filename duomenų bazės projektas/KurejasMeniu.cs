using System;
using System.Windows.Forms;

namespace duomenų_bazės_projektas
{
    public partial class KurejasMeniu : Form
    {
        public static int KurejoID { get; set; }

        public KurejasMeniu()
        {
            InitializeComponent();
        }

        public void button3_Click(object sender, EventArgs e)
        {
            login form = new login();
            form.Show();
            this.Hide();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            int kurejoId = KurejasMeniu.KurejoID;

            Zaidimokelimas form2 = new Zaidimokelimas(kurejoId);
            form2.Show();
            this.Hide();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            Zaidimostatusas form3 = new Zaidimostatusas(KurejasMeniu.KurejoID);
            form3.Show();
            this.Hide();
        }
    }
}
