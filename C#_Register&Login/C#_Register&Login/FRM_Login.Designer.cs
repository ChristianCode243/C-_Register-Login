namespace C__Register_Login
{
    partial class FRM_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BTN_exit = new Button();
            label2 = new Label();
            label1 = new Label();
            BTN_valider = new Button();
            BTN_exit_ = new Button();
            TXT_mdp_confirmer = new TextBox();
            TXT_mdp = new TextBox();
            LBL_username = new Label();
            SuspendLayout();
            // 
            // BTN_exit
            // 
            BTN_exit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BTN_exit.FlatAppearance.BorderSize = 0;
            BTN_exit.FlatAppearance.MouseDownBackColor = Color.DodgerBlue;
            BTN_exit.FlatStyle = FlatStyle.Flat;
            BTN_exit.ForeColor = Color.DodgerBlue;
            BTN_exit.Location = new Point(369, 1);
            BTN_exit.Name = "BTN_exit";
            BTN_exit.Size = new Size(50, 23);
            BTN_exit.TabIndex = 4;
            BTN_exit.Text = "x";
            BTN_exit.UseVisualStyleBackColor = true;
            BTN_exit.Click += BTN_exit_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(396, 25);
            label2.TabIndex = 5;
            label2.Text = "Connexion";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Location = new Point(12, 85);
            label1.Name = "label1";
            label1.Size = new Size(396, 23);
            label1.TabIndex = 6;
            label1.Text = "Renseigner vos informations de connexion.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BTN_valider
            // 
            BTN_valider.BackColor = Color.DodgerBlue;
            BTN_valider.FlatAppearance.BorderSize = 0;
            BTN_valider.FlatStyle = FlatStyle.Flat;
            BTN_valider.ForeColor = Color.White;
            BTN_valider.Location = new Point(278, 262);
            BTN_valider.Name = "BTN_valider";
            BTN_valider.Size = new Size(75, 23);
            BTN_valider.TabIndex = 2;
            BTN_valider.Text = "Valider";
            BTN_valider.UseVisualStyleBackColor = false;
            BTN_valider.Click += BTN_valider_Click;
            // 
            // BTN_exit_
            // 
            BTN_exit_.BackColor = Color.Red;
            BTN_exit_.FlatAppearance.BorderSize = 0;
            BTN_exit_.FlatStyle = FlatStyle.Flat;
            BTN_exit_.ForeColor = Color.White;
            BTN_exit_.Location = new Point(68, 262);
            BTN_exit_.Name = "BTN_exit_";
            BTN_exit_.Size = new Size(75, 23);
            BTN_exit_.TabIndex = 3;
            BTN_exit_.Text = "Quitter";
            BTN_exit_.UseVisualStyleBackColor = false;
            BTN_exit_.Click += BTN_exit__Click;
            // 
            // TXT_mdp_confirmer
            // 
            TXT_mdp_confirmer.BorderStyle = BorderStyle.None;
            TXT_mdp_confirmer.ForeColor = Color.DodgerBlue;
            TXT_mdp_confirmer.Location = new Point(68, 212);
            TXT_mdp_confirmer.Name = "TXT_mdp_confirmer";
            TXT_mdp_confirmer.PlaceholderText = "Confirmer le mot de passe";
            TXT_mdp_confirmer.Size = new Size(285, 16);
            TXT_mdp_confirmer.TabIndex = 1;
            TXT_mdp_confirmer.UseSystemPasswordChar = true;
            // 
            // TXT_mdp
            // 
            TXT_mdp.BorderStyle = BorderStyle.None;
            TXT_mdp.ForeColor = Color.DodgerBlue;
            TXT_mdp.Location = new Point(68, 183);
            TXT_mdp.Name = "TXT_mdp";
            TXT_mdp.PlaceholderText = "Mot de passe";
            TXT_mdp.Size = new Size(285, 16);
            TXT_mdp.TabIndex = 0;
            TXT_mdp.UseSystemPasswordChar = true;
            // 
            // LBL_username
            // 
            LBL_username.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBL_username.Location = new Point(12, 141);
            LBL_username.Name = "LBL_username";
            LBL_username.Size = new Size(396, 23);
            LBL_username.TabIndex = 7;
            LBL_username.Text = "...";
            LBL_username.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FRM_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 325);
            Controls.Add(BTN_valider);
            Controls.Add(BTN_exit_);
            Controls.Add(TXT_mdp_confirmer);
            Controls.Add(TXT_mdp);
            Controls.Add(label2);
            Controls.Add(LBL_username);
            Controls.Add(label1);
            Controls.Add(BTN_exit);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "FRM_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += FRM_Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTN_exit;
        private Label label2;
        private Label label1;
        private Button BTN_valider;
        private Button BTN_exit_;
        private TextBox TXT_mdp_confirmer;
        private TextBox TXT_mdp;
        private Label LBL_username;
    }
}