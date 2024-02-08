namespace C__Register_Login
{
    partial class FRM_Loader
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
            panel1 = new Panel();
            label2 = new Label();
            BTN_exit = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(BTN_exit);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(466, 199);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(3, 147);
            label2.Name = "label2";
            label2.Size = new Size(460, 23);
            label2.TabIndex = 2;
            label2.Text = "Loading...";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BTN_exit
            // 
            BTN_exit.FlatAppearance.BorderSize = 0;
            BTN_exit.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            BTN_exit.FlatStyle = FlatStyle.Flat;
            BTN_exit.ForeColor = Color.DodgerBlue;
            BTN_exit.Location = new Point(410, 3);
            BTN_exit.Name = "BTN_exit";
            BTN_exit.Size = new Size(53, 23);
            BTN_exit.TabIndex = 1;
            BTN_exit.Text = "x";
            BTN_exit.UseVisualStyleBackColor = true;
            BTN_exit.Click += BTN_exit_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(3, 72);
            label1.Name = "label1";
            label1.Size = new Size(460, 46);
            label1.TabIndex = 0;
            label1.Text = "Mon Application";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FRM_Loader
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 223);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FRM_Loader";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FRM_Loader";
            Load += FRM_Loader_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BTN_exit;
        private Label label1;
        private Label label2;
    }
}