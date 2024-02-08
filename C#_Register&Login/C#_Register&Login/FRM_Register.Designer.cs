namespace C__Register_Login
{
    partial class FRM_Register
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
            TXT_prenom = new TextBox();
            label1 = new Label();
            label2 = new Label();
            TXT_nom = new TextBox();
            TXT_phone = new TextBox();
            TXT_email = new TextBox();
            TXT_poste = new TextBox();
            TXT_mdp = new TextBox();
            TXT_mdp_confirmer = new TextBox();
            BTN_exit_ = new Button();
            BTN_valider = new Button();
            SuspendLayout();
            // 
            // BTN_exit
            // 
            BTN_exit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BTN_exit.FlatAppearance.BorderSize = 0;
            BTN_exit.FlatAppearance.MouseDownBackColor = Color.DodgerBlue;
            BTN_exit.FlatStyle = FlatStyle.Flat;
            BTN_exit.ForeColor = Color.DodgerBlue;
            BTN_exit.Location = new Point(357, 1);
            BTN_exit.Name = "BTN_exit";
            BTN_exit.Size = new Size(50, 23);
            BTN_exit.TabIndex = 9;
            BTN_exit.Text = "x";
            BTN_exit.UseVisualStyleBackColor = true;
            BTN_exit.Click += BTN_exit_Click;
            // 
            // TXT_prenom
            // 
            TXT_prenom.BorderStyle = BorderStyle.None;
            TXT_prenom.ForeColor = Color.DodgerBlue;
            TXT_prenom.Location = new Point(60, 129);
            TXT_prenom.Name = "TXT_prenom";
            TXT_prenom.PlaceholderText = "Prénom";
            TXT_prenom.Size = new Size(285, 16);
            TXT_prenom.TabIndex = 0;
            // 
            // label1
            // 
            label1.Location = new Point(12, 79);
            label1.Name = "label1";
            label1.Size = new Size(384, 23);
            label1.TabIndex = 11;
            label1.Text = "Renseigner vos informations pour votre identification.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(384, 25);
            label2.TabIndex = 10;
            label2.Text = "Enregistrement";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TXT_nom
            // 
            TXT_nom.BorderStyle = BorderStyle.None;
            TXT_nom.ForeColor = Color.DodgerBlue;
            TXT_nom.Location = new Point(60, 158);
            TXT_nom.Name = "TXT_nom";
            TXT_nom.PlaceholderText = "Nom";
            TXT_nom.Size = new Size(285, 16);
            TXT_nom.TabIndex = 1;
            // 
            // TXT_phone
            // 
            TXT_phone.BorderStyle = BorderStyle.None;
            TXT_phone.ForeColor = Color.DodgerBlue;
            TXT_phone.Location = new Point(60, 199);
            TXT_phone.Name = "TXT_phone";
            TXT_phone.PlaceholderText = "Téléphone";
            TXT_phone.Size = new Size(285, 16);
            TXT_phone.TabIndex = 2;
            // 
            // TXT_email
            // 
            TXT_email.BorderStyle = BorderStyle.None;
            TXT_email.ForeColor = Color.DodgerBlue;
            TXT_email.Location = new Point(60, 228);
            TXT_email.Name = "TXT_email";
            TXT_email.PlaceholderText = "Email";
            TXT_email.Size = new Size(285, 16);
            TXT_email.TabIndex = 3;
            // 
            // TXT_poste
            // 
            TXT_poste.BorderStyle = BorderStyle.None;
            TXT_poste.ForeColor = Color.DodgerBlue;
            TXT_poste.Location = new Point(60, 257);
            TXT_poste.Name = "TXT_poste";
            TXT_poste.PlaceholderText = "Poste";
            TXT_poste.Size = new Size(285, 16);
            TXT_poste.TabIndex = 4;
            // 
            // TXT_mdp
            // 
            TXT_mdp.BorderStyle = BorderStyle.None;
            TXT_mdp.ForeColor = Color.DodgerBlue;
            TXT_mdp.Location = new Point(60, 306);
            TXT_mdp.Name = "TXT_mdp";
            TXT_mdp.PlaceholderText = "Mot de passe";
            TXT_mdp.Size = new Size(285, 16);
            TXT_mdp.TabIndex = 5;
            TXT_mdp.UseSystemPasswordChar = true;
            // 
            // TXT_mdp_confirmer
            // 
            TXT_mdp_confirmer.BorderStyle = BorderStyle.None;
            TXT_mdp_confirmer.ForeColor = Color.DodgerBlue;
            TXT_mdp_confirmer.Location = new Point(60, 335);
            TXT_mdp_confirmer.Name = "TXT_mdp_confirmer";
            TXT_mdp_confirmer.PlaceholderText = "Confirmer le mot de passe";
            TXT_mdp_confirmer.Size = new Size(285, 16);
            TXT_mdp_confirmer.TabIndex = 6;
            TXT_mdp_confirmer.UseSystemPasswordChar = true;
            // 
            // BTN_exit_
            // 
            BTN_exit_.BackColor = Color.Red;
            BTN_exit_.FlatAppearance.BorderSize = 0;
            BTN_exit_.FlatStyle = FlatStyle.Flat;
            BTN_exit_.ForeColor = Color.White;
            BTN_exit_.Location = new Point(60, 385);
            BTN_exit_.Name = "BTN_exit_";
            BTN_exit_.Size = new Size(75, 23);
            BTN_exit_.TabIndex = 8;
            BTN_exit_.Text = "Quitter";
            BTN_exit_.UseVisualStyleBackColor = false;
            BTN_exit_.Click += BTN_exit__Click;
            // 
            // BTN_valider
            // 
            BTN_valider.BackColor = Color.DodgerBlue;
            BTN_valider.FlatAppearance.BorderSize = 0;
            BTN_valider.FlatStyle = FlatStyle.Flat;
            BTN_valider.ForeColor = Color.White;
            BTN_valider.Location = new Point(270, 385);
            BTN_valider.Name = "BTN_valider";
            BTN_valider.Size = new Size(75, 23);
            BTN_valider.TabIndex = 7;
            BTN_valider.Text = "Valider";
            BTN_valider.UseVisualStyleBackColor = false;
            BTN_valider.Click += BTN_valider_Click;
            // 
            // FRM_Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 450);
            Controls.Add(BTN_valider);
            Controls.Add(BTN_exit_);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TXT_mdp_confirmer);
            Controls.Add(TXT_mdp);
            Controls.Add(TXT_poste);
            Controls.Add(TXT_email);
            Controls.Add(TXT_phone);
            Controls.Add(TXT_nom);
            Controls.Add(TXT_prenom);
            Controls.Add(BTN_exit);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "FRM_Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += FRM_Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTN_exit;
        private TextBox TXT_prenom;
        private Label label1;
        private Label label2;
        private TextBox TXT_nom;
        private TextBox TXT_phone;
        private TextBox TXT_email;
        private TextBox TXT_poste;
        private TextBox TXT_mdp;
        private TextBox TXT_mdp_confirmer;
        private Button BTN_exit_;
        private Button BTN_valider;
    }
}