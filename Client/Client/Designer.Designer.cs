namespace Client
{
    partial class Designer
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
            this.gbHomeButtons = new System.Windows.Forms.GroupBox();
            this.lnkPreCustomizedGroup = new System.Windows.Forms.LinkLabel();
            this.lnkHome = new System.Windows.Forms.LinkLabel();
            this.lnkLogin = new System.Windows.Forms.LinkLabel();
            this.btnCreateDesign = new System.Windows.Forms.Button();
            this.btnUploadDesign = new System.Windows.Forms.Button();
            this.gbHomeButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbHomeButtons
            // 
            this.gbHomeButtons.Controls.Add(this.lnkPreCustomizedGroup);
            this.gbHomeButtons.Controls.Add(this.lnkHome);
            this.gbHomeButtons.Controls.Add(this.lnkLogin);
            this.gbHomeButtons.Location = new System.Drawing.Point(30, 12);
            this.gbHomeButtons.Name = "gbHomeButtons";
            this.gbHomeButtons.Size = new System.Drawing.Size(527, 49);
            this.gbHomeButtons.TabIndex = 21;
            this.gbHomeButtons.TabStop = false;
            // 
            // lnkPreCustomizedGroup
            // 
            this.lnkPreCustomizedGroup.AutoSize = true;
            this.lnkPreCustomizedGroup.Location = new System.Drawing.Point(146, 9);
            this.lnkPreCustomizedGroup.Name = "lnkPreCustomizedGroup";
            this.lnkPreCustomizedGroup.Size = new System.Drawing.Size(107, 17);
            this.lnkPreCustomizedGroup.TabIndex = 13;
            this.lnkPreCustomizedGroup.TabStop = true;
            this.lnkPreCustomizedGroup.Text = "Pre Customized";
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
            // lnkLogin
            // 
            this.lnkLogin.AutoSize = true;
            this.lnkLogin.Location = new System.Drawing.Point(341, 9);
            this.lnkLogin.Name = "lnkLogin";
            this.lnkLogin.Size = new System.Drawing.Size(43, 17);
            this.lnkLogin.TabIndex = 10;
            this.lnkLogin.TabStop = true;
            this.lnkLogin.Text = "Login";
            // 
            // btnCreateDesign
            // 
            this.btnCreateDesign.Location = new System.Drawing.Point(62, 246);
            this.btnCreateDesign.Name = "btnCreateDesign";
            this.btnCreateDesign.Size = new System.Drawing.Size(203, 57);
            this.btnCreateDesign.TabIndex = 22;
            this.btnCreateDesign.Text = "Create Design";
            this.btnCreateDesign.UseVisualStyleBackColor = true;
            this.btnCreateDesign.Click += new System.EventHandler(this.btnCreateDesign_Click);
            // 
            // btnUploadDesign
            // 
            this.btnUploadDesign.Location = new System.Drawing.Point(306, 246);
            this.btnUploadDesign.Name = "btnUploadDesign";
            this.btnUploadDesign.Size = new System.Drawing.Size(203, 57);
            this.btnUploadDesign.TabIndex = 23;
            this.btnUploadDesign.Text = "Upload Design";
            this.btnUploadDesign.UseVisualStyleBackColor = true;
            this.btnUploadDesign.Click += new System.EventHandler(this.btnUploadDesign_Click);
            // 
            // Designer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 422);
            this.Controls.Add(this.btnUploadDesign);
            this.Controls.Add(this.btnCreateDesign);
            this.Controls.Add(this.gbHomeButtons);
            this.Name = "Designer";
            this.Text = "Designer";
            this.Load += new System.EventHandler(this.Designer_Load);
            this.gbHomeButtons.ResumeLayout(false);
            this.gbHomeButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbHomeButtons;
        private System.Windows.Forms.LinkLabel lnkPreCustomizedGroup;
        private System.Windows.Forms.LinkLabel lnkHome;
        private System.Windows.Forms.LinkLabel lnkLogin;
        private System.Windows.Forms.Button btnCreateDesign;
        private System.Windows.Forms.Button btnUploadDesign;
    }
}