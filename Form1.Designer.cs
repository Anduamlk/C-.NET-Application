namespace Exam__System
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.techLogin = new Guna.UI2.WinForms.Guna2Button();
            this.wrongLablel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStudentLogin = new Guna.UI2.WinForms.Guna2Button();
            this.btnStudentRegister = new Guna.UI2.WinForms.Guna2Button();
            this.label9 = new System.Windows.Forms.Label();
            this.texSelectUser = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Elephant", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(554, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(444, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Online Exam Appliction System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(674, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Please Select your Type";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(452, 770);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.techLogin);
            this.panel1.Controls.Add(this.wrongLablel);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(679, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 337);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Please click here below Login Button";
            // 
            // techLogin
            // 
            this.techLogin.BorderRadius = 21;
            this.techLogin.BorderThickness = 1;
            this.techLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.techLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.techLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.techLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.techLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.techLogin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.techLogin.ForeColor = System.Drawing.Color.White;
            this.techLogin.Location = new System.Drawing.Point(25, 123);
            this.techLogin.Name = "techLogin";
            this.techLogin.Size = new System.Drawing.Size(296, 45);
            this.techLogin.TabIndex = 11;
            this.techLogin.Text = "Login";
            this.techLogin.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // wrongLablel
            // 
            this.wrongLablel.AutoSize = true;
            this.wrongLablel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongLablel.Location = new System.Drawing.Point(98, 276);
            this.wrongLablel.Name = "wrongLablel";
            this.wrongLablel.Size = new System.Drawing.Size(120, 19);
            this.wrongLablel.TabIndex = 8;
            this.wrongLablel.Text = "wrong passowrd";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Font = new System.Drawing.Font("Elephant", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(58, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(230, 35);
            this.label8.TabIndex = 2;
            this.label8.Text = "Teacher Login";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnStudentLogin);
            this.panel2.Controls.Add(this.btnStudentRegister);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(679, 185);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 337);
            this.panel2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Elephant", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(352, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Please click here below Registeration  Button";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Elephant", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(347, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Please click here below Login Button";
            // 
            // btnStudentLogin
            // 
            this.btnStudentLogin.BorderRadius = 21;
            this.btnStudentLogin.BorderThickness = 1;
            this.btnStudentLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStudentLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStudentLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStudentLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStudentLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnStudentLogin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentLogin.ForeColor = System.Drawing.Color.White;
            this.btnStudentLogin.Location = new System.Drawing.Point(35, 147);
            this.btnStudentLogin.Name = "btnStudentLogin";
            this.btnStudentLogin.Size = new System.Drawing.Size(296, 45);
            this.btnStudentLogin.TabIndex = 12;
            this.btnStudentLogin.Text = "Login";
            this.btnStudentLogin.Click += new System.EventHandler(this.btnStudentLogin_Click);
            // 
            // btnStudentRegister
            // 
            this.btnStudentRegister.BorderRadius = 21;
            this.btnStudentRegister.BorderThickness = 1;
            this.btnStudentRegister.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStudentRegister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStudentRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStudentRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStudentRegister.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnStudentRegister.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentRegister.ForeColor = System.Drawing.Color.White;
            this.btnStudentRegister.Location = new System.Drawing.Point(39, 248);
            this.btnStudentRegister.Name = "btnStudentRegister";
            this.btnStudentRegister.Size = new System.Drawing.Size(296, 45);
            this.btnStudentRegister.TabIndex = 11;
            this.btnStudentRegister.Text = "Register";
            this.btnStudentRegister.Click += new System.EventHandler(this.btnStudentRegister_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Font = new System.Drawing.Font("Elephant", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(58, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(231, 35);
            this.label9.TabIndex = 2;
            this.label9.Text = "Student  Login";
            // 
            // texSelectUser
            // 
            this.texSelectUser.BackColor = System.Drawing.Color.Transparent;
            this.texSelectUser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.texSelectUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.texSelectUser.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.texSelectUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.texSelectUser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.texSelectUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.texSelectUser.ItemHeight = 30;
            this.texSelectUser.Items.AddRange(new object[] {
            "Student",
            "Teacher"});
            this.texSelectUser.Location = new System.Drawing.Point(612, 122);
            this.texSelectUser.Name = "texSelectUser";
            this.texSelectUser.Size = new System.Drawing.Size(502, 36);
            this.texSelectUser.TabIndex = 5;
            this.texSelectUser.SelectedIndexChanged += new System.EventHandler(this.texSelectUser_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.texSelectUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label wrongLablel;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button techLogin;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnStudentRegister;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Button btnStudentLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox texSelectUser;
    }
}

