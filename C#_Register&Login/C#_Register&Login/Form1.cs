using System.Diagnostics;

namespace C__Register_Login
{
    public partial class Form1 : Form
    {
        public static Form1 F_main = new Form1();
        public Form1()
        {
            F_main = this;
            InitializeComponent();
        }

        private void BTN_reset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment réinitialiser les paramètres de l'application ?", "Réinitialisation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Properties.Settings.Default.Reset();
                Properties.Settings.Default.Save();

                Process.Start(Application.ExecutablePath);
                Application.Exit();
            }
        }

        private void BTN_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LBL_username.Text = Properties.Settings.Default.prenom + " " + Properties.Settings.Default.nom;
            LBL_poste.Text = Properties.Settings.Default.poste; LBL_email.Text = Properties.Settings.Default.email;
            LBL_phone.Text = Properties.Settings.Default.telephone;
        }
    }
}
