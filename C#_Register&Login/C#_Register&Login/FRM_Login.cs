using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Register_Login
{
    public partial class FRM_Login : Form
    {
        public static FRM_Login F_login = new FRM_Login();
        public FRM_Login()
        {
            F_login = this;
            InitializeComponent();
        }

        private void BTN_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTN_exit__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTN_valider_Click(object sender, EventArgs e)
        {
            if (TXT_mdp.Text == TXT_mdp_confirmer.Text)
            {
                if(FRM_Register.Hash_MDP(TXT_mdp.Text) == Properties.Settings.Default.mdp)
                {
                    this.Hide();
                    Form1.F_main.Show();
                }
                else
                    MessageBox.Show("Le mot de passe que vous avez entré est incorrect !", "Mot de passe", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Le mot de passe que vous avez entré est différent sur les deux champs !", "Mot de passe", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void FRM_Login_Load(object sender, EventArgs e)
        {
            LBL_username.Text = Properties.Settings.Default.prenom + " " + Properties.Settings.Default.nom;
        }
    }
}
