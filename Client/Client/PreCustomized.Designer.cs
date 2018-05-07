namespace Client
{
    partial class PreCustomized
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gbHomeButtons = new System.Windows.Forms.GroupBox();
            this.lnkCustomize = new System.Windows.Forms.LinkLabel();
            this.lnkPreCustomizedGroup = new System.Windows.Forms.LinkLabel();
            this.lnkHome = new System.Windows.Forms.LinkLabel();
            this.lnkAddComplaint = new System.Windows.Forms.LinkLabel();
            this.lnkLogin = new System.Windows.Forms.LinkLabel();
            this.ucShoe = new Client.ucPredesigned();
            this.flowLayoutPanel1.SuspendLayout();
            this.gbHomeButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.gbHomeButtons);
            this.flowLayoutPanel1.Controls.Add(this.ucShoe);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 15);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(590, 461);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // gbHomeButtons
            // 
            this.gbHomeButtons.Controls.Add(this.lnkCustomize);
            this.gbHomeButtons.Controls.Add(this.lnkPreCustomizedGroup);
            this.gbHomeButtons.Controls.Add(this.lnkHome);
            this.gbHomeButtons.Controls.Add(this.lnkAddComplaint);
            this.gbHomeButtons.Controls.Add(this.lnkLogin);
            this.gbHomeButtons.Location = new System.Drawing.Point(3, 3);
            this.gbHomeButtons.Name = "gbHomeButtons";
            this.gbHomeButtons.Size = new System.Drawing.Size(527, 49);
            this.gbHomeButtons.TabIndex = 16;
            this.gbHomeButtons.TabStop = false;
            // 
            // lnkCustomize
            // 
            this.lnkCustomize.AutoSize = true;
            this.lnkCustomize.Location = new System.Drawing.Point(244, 9);
            this.lnkCustomize.Name = "lnkCustomize";
            this.lnkCustomize.Size = new System.Drawing.Size(69, 17);
            this.lnkCustomize.TabIndex = 14;
            this.lnkCustomize.TabStop = true;
            this.lnkCustomize.Text = "Cusomize";
            // 
            // lnkPreCustomizedGroup
            // 
            this.lnkPreCustomizedGroup.AutoSize = true;
            this.lnkPreCustomizedGroup.Location = new System.Drawing.Point(116, 9);
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
            // lnkAddComplaint
            // 
            this.lnkAddComplaint.AutoSize = true;
            this.lnkAddComplaint.Location = new System.Drawing.Point(412, 9);
            this.lnkAddComplaint.Name = "lnkAddComplaint";
            this.lnkAddComplaint.Size = new System.Drawing.Size(99, 17);
            this.lnkAddComplaint.TabIndex = 11;
            this.lnkAddComplaint.TabStop = true;
            this.lnkAddComplaint.Text = "Add Complaint";
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
            // ucShoe
            // 
            this.ucShoe.Location = new System.Drawing.Point(3, 58);
            this.ucShoe.Name = "ucShoe";
            this.ucShoe.Size = new System.Drawing.Size(139, 112);
            this.ucShoe.TabIndex = 0;
            this.ucShoe.Load += new System.EventHandler(this.ucPredesigned1_Load);
            // 
            // PreCustomized
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 493);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "PreCustomized";
            this.Text = "Pre Customized";
            this.Load += new System.EventHandler(this.PreCustomized_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.gbHomeButtons.ResumeLayout(false);
            this.gbHomeButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ucPredesigned ucShoe;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox gbHomeButtons;
        private System.Windows.Forms.LinkLabel lnkCustomize;
        private System.Windows.Forms.LinkLabel lnkPreCustomizedGroup;
        private System.Windows.Forms.LinkLabel lnkHome;
        private System.Windows.Forms.LinkLabel lnkAddComplaint;
        private System.Windows.Forms.LinkLabel lnkLogin;
    }
}