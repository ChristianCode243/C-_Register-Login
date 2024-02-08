using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Register_Login
{
    public partial class FRM_Register : Form
    {
        public static FRM_Register F_register = new FRM_Register();
        public FRM_Register()
        {
            F_register = this;
            InitializeComponent();
        }

        public static string Hash_MDP(string mdp)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(mdp));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }

        }

        private void BTN_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FRM_Register_Load(object sender, EventArgs e)
        {
            TXT_prenom.Focus();
        }

        private void BTN_exit__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTN_valider_Click(object sender, EventArgs e)
        {
            bool Text_verifier = this.Controls.OfType<TextBox>().All(textbox => !string.IsNullOrEmpty(textbox.Text));
            
            if (Text_verifier)
            {
                if(TXT_mdp.Text == TXT_mdp_confirmer.Text)
                {
                    MessageBox.Show("Le logiciel va redemarrer !", "Redemarrage", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();

                    Properties.Settings.Default.prenom = TXT_prenom.Text; Properties.Settings.Default.nom = TXT_nom.Text;
                    Properties.Settings.Default.email = TXT_email.Text; Properties.Settings.Default.telephone = TXT_phone.Text;
                    Properties.Settings.Default.poste = TXT_poste.Text; Properties.Settings.Default.mdp = Hash_MDP(TXT_mdp.Text);
                    
                    Properties.Settings.Default.existe = true;

                    Properties.Settings.Default.Save();

                    Process.Start(Application.ExecutablePath);
                    Application.Exit();
                }
                else
                    MessageBox.Show("Le mot de passe que vous avez entré n'est pas le même dans les deux champs !", "Mot de passe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Vous avez oublié de remplir un champ dans le formulaire", "Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
