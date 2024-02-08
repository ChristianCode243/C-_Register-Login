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
    public partial class FRM_Loader : Form
    {
        System.Windows.Forms.Timer clock = new System.Windows.Forms.Timer();
        int tictac;
        public FRM_Loader()
        {
            clock.Interval = 1000;
            clock.Tick += Clock_Tick;
            InitializeComponent();
        }

        private void Clock_Tick(object? sender, EventArgs e)
        {
            tictac++;

            if(tictac == 3)
            {
                if (Properties.Settings.Default.existe == true)
                { 
                    this.Hide();
                    FRM_Login.F_login.Show();
                }
                else
                {
                    this.Hide();
                    FRM_Register.F_register.Show();
                }

                clock.Stop();
            }
        }

        private void BTN_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FRM_Loader_Load(object sender, EventArgs e)
        {
            clock.Start();
        }
    }
}
