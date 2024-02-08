namespace C__Register_Login
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            LBL_username = new Label();
            LBL_poste = new Label();
            LBL_email = new Label();
            LBL_phone = new Label();
            BTN_reset = new Button();
            BTN_exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(12, 179);
            label1.Name = "label1";
            label1.Size = new Size(776, 82);
            label1.TabIndex = 0;
            label1.Text = "Bienvenue !";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LBL_username
            // 
            LBL_username.AutoSize = true;
            LBL_username.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBL_username.Location = new Point(12, 9);
            LBL_username.Name = "LBL_username";
            LBL_username.Size = new Size(22, 21);
            LBL_username.TabIndex = 1;
            LBL_username.Text = "...";
            // 
            // LBL_poste
            // 
            LBL_poste.AutoSize = true;
            LBL_poste.Location = new Point(12, 34);
            LBL_poste.Name = "LBL_poste";
            LBL_poste.Size = new Size(16, 15);
            LBL_poste.TabIndex = 1;
            LBL_poste.Text = "...";
            // 
            // LBL_email
            // 
            LBL_email.AutoSize = true;
            LBL_email.Location = new Point(12, 62);
            LBL_email.Name = "LBL_email";
            LBL_email.Size = new Size(16, 15);
            LBL_email.TabIndex = 1;
            LBL_email.Text = "...";
            // 
            // LBL_phone
            // 
            LBL_phone.AutoSize = true;
            LBL_phone.Location = new Point(12, 81);
            LBL_phone.Name = "LBL_phone";
            LBL_phone.Size = new Size(16, 15);
            LBL_phone.TabIndex = 1;
            LBL_phone.Text = "...";
            // 
            // BTN_reset
            // 
            BTN_reset.BackColor = Color.Red;
            BTN_reset.FlatAppearance.BorderSize = 0;
            BTN_reset.FlatStyle = FlatStyle.Flat;
            BTN_reset.ForeColor = Color.White;
            BTN_reset.Location = new Point(688, 415);
            BTN_reset.Name = "BTN_reset";
            BTN_reset.Size = new Size(100, 23);
            BTN_reset.TabIndex = 2;
            BTN_reset.Text = "Réinitialiser";
            BTN_reset.UseVisualStyleBackColor = false;
            BTN_reset.Click += BTN_reset_Click;
            // 
            // BTN_exit
            // 
            BTN_exit.FlatAppearance.BorderSize = 0;
            BTN_exit.FlatStyle = FlatStyle.Flat;
            BTN_exit.ForeColor = Color.DodgerBlue;
            BTN_exit.Location = new Point(756, 0);
            BTN_exit.Name = "BTN_exit";
            BTN_exit.Size = new Size(44, 23);
            BTN_exit.TabIndex = 3;
            BTN_exit.Text = "x";
            BTN_exit.UseVisualStyleBackColor = true;
            BTN_exit.Click += BTN_exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BTN_exit);
            Controls.Add(BTN_reset);
            Controls.Add(LBL_phone);
            Controls.Add(LBL_email);
            Controls.Add(LBL_poste);
            Controls.Add(LBL_username);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mon_Application";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label LBL_username;
        private Label LBL_poste;
        private Label LBL_email;
        private Label LBL_phone;
        private Button BTN_reset;
        private Button BTN_exit;
    }
}
