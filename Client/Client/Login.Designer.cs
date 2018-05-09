namespace Client
{
    partial class Login
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
            this.rbtnDesigner = new System.Windows.Forms.RadioButton();
            this.rbtnAdmin = new System.Windows.Forms.RadioButton();
            this.gbHomeButtons = new System.Windows.Forms.GroupBox();
            this.lnkHome = new System.Windows.Forms.LinkLabel();
            this.lnkPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsernsme = new System.Windows.Forms.TextBox();
            this.gbHomeButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnDesigner
            // 
            this.rbtnDesigner.AutoSize = true;
            this.rbtnDesigner.Location = new System.Drawing.Point(387, 261);
            this.rbtnDesigner.Name = "rbtnDesigner";
            this.rbtnDesigner.Size = new System.Drawing.Size(86, 21);
            this.rbtnDesigner.TabIndex = 28;
            this.rbtnDesigner.TabStop = true;
            this.rbtnDesigner.Text = "Designer";
            this.rbtnDesigner.UseVisualStyleBackColor = true;
            // 
            // rbtnAdmin
            // 
            this.rbtnAdmin.AutoSize = true;
            this.rbtnAdmin.Location = new System.Drawing.Point(272, 261);
            this.rbtnAdmin.Name = "rbtnAdmin";
            this.rbtnAdmin.Size = new System.Drawing.Size(68, 21);
            this.rbtnAdmin.TabIndex = 27;
            this.rbtnAdmin.TabStop = true;
            this.rbtnAdmin.Text = "Admin";
            this.rbtnAdmin.UseVisualStyleBackColor = true;
            // 
            // gbHomeButtons
            // 
            this.gbHomeButtons.Controls.Add(this.lnkHome);
            this.gbHomeButtons.Location = new System.Drawing.Point(67, 39);
            this.gbHomeButtons.Name = "gbHomeButtons";
            this.gbHomeButtons.Size = new System.Drawing.Size(527, 49);
            this.gbHomeButtons.TabIndex = 26;
            this.gbHomeButtons.TabStop = false;
            // 
            // lnkHome
            // 
            this.lnkHome.AutoSize = true;
            this.lnkHome.Location = new System.Drawing.Point(29, 9);
            this.lnkHome.Name = "lnkHome";
            this.lnkHome.Size = new System.Drawing.Size(45, 17);
            this.lnkHome.TabIndex = 12;
            this.lnkHome.TabStop = true;
            this.lnkHome.Text = "Home";
            this.lnkHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkHome_LinkClicked);
            // 
            // lnkPassword
            // 
            this.lnkPassword.AutoSize = true;
            this.lnkPassword.Location = new System.Drawing.Point(96, 217);
            this.lnkPassword.Name = "lnkPassword";
            this.lnkPassword.Size = new System.Drawing.Size(69, 17);
            this.lnkPassword.TabIndex = 25;
            this.lnkPassword.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Username";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(358, 305);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(115, 31);
            this.btnLogin.TabIndex = 23;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(272, 217);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(201, 22);
            this.txtPassword.TabIndex = 22;
            // 
            // txtUsernsme
            // 
            this.txtUsernsme.Location = new System.Drawing.Point(272, 154);
            this.txtUsernsme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsernsme.Name = "txtUsernsme";
            this.txtUsernsme.Size = new System.Drawing.Size(201, 22);
            this.txtUsernsme.TabIndex = 21;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 492);
            this.Controls.Add(this.rbtnDesigner);
            this.Controls.Add(this.rbtnAdmin);
            this.Controls.Add(this.gbHomeButtons);
            this.Controls.Add(this.lnkPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsernsme);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.gbHomeButtons.ResumeLayout(false);
            this.gbHomeButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnDesigner;
        private System.Windows.Forms.RadioButton rbtnAdmin;
        private System.Windows.Forms.GroupBox gbHomeButtons;
        private System.Windows.Forms.LinkLabel lnkHome;
        private System.Windows.Forms.Label lnkPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsernsme;
    }
}