namespace Client
{
    partial class Admin
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
            this.lnkSignOut = new System.Windows.Forms.LinkLabel();
            this.lnkPreCustomizedGroup = new System.Windows.Forms.LinkLabel();
            this.lnkHome = new System.Windows.Forms.LinkLabel();
            this.btnComplaints = new System.Windows.Forms.Button();
            this.btnDesignerDesign = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.gbHomeButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbHomeButtons
            // 
            this.gbHomeButtons.Controls.Add(this.lnkSignOut);
            this.gbHomeButtons.Controls.Add(this.lnkPreCustomizedGroup);
            this.gbHomeButtons.Controls.Add(this.lnkHome);
            this.gbHomeButtons.Location = new System.Drawing.Point(63, 35);
            this.gbHomeButtons.Name = "gbHomeButtons";
            this.gbHomeButtons.Size = new System.Drawing.Size(527, 49);
            this.gbHomeButtons.TabIndex = 20;
            this.gbHomeButtons.TabStop = false;
            // 
            // lnkSignOut
            // 
            this.lnkSignOut.AutoSize = true;
            this.lnkSignOut.Location = new System.Drawing.Point(464, 9);
            this.lnkSignOut.Name = "lnkSignOut";
            this.lnkSignOut.Size = new System.Drawing.Size(63, 17);
            this.lnkSignOut.TabIndex = 14;
            this.lnkSignOut.TabStop = true;
            this.lnkSignOut.Text = "Sign Out";
            this.lnkSignOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSignOut_LinkClicked);
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
            // btnComplaints
            // 
            this.btnComplaints.Location = new System.Drawing.Point(515, 355);
            this.btnComplaints.Name = "btnComplaints";
            this.btnComplaints.Size = new System.Drawing.Size(101, 30);
            this.btnComplaints.TabIndex = 19;
            this.btnComplaints.Text = "Complaints";
            this.btnComplaints.UseVisualStyleBackColor = true;
            this.btnComplaints.Click += new System.EventHandler(this.btnComplaints_Click);
            // 
            // btnDesignerDesign
            // 
            this.btnDesignerDesign.Location = new System.Drawing.Point(427, 296);
            this.btnDesignerDesign.Name = "btnDesignerDesign";
            this.btnDesignerDesign.Size = new System.Drawing.Size(189, 35);
            this.btnDesignerDesign.TabIndex = 18;
            this.btnDesignerDesign.Text = "Designer\'s Designs";
            this.btnDesignerDesign.UseVisualStyleBackColor = true;
            this.btnDesignerDesign.Click += new System.EventHandler(this.btnDesignerDesign_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(252, 297);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(153, 33);
            this.btnOrders.TabIndex = 17;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 506);
            this.Controls.Add(this.gbHomeButtons);
            this.Controls.Add(this.btnComplaints);
            this.Controls.Add(this.btnDesignerDesign);
            this.Controls.Add(this.btnOrders);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.gbHomeButtons.ResumeLayout(false);
            this.gbHomeButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbHomeButtons;
        private System.Windows.Forms.LinkLabel lnkSignOut;
        private System.Windows.Forms.LinkLabel lnkPreCustomizedGroup;
        private System.Windows.Forms.LinkLabel lnkHome;
        private System.Windows.Forms.Button btnComplaints;
        private System.Windows.Forms.Button btnDesignerDesign;
        private System.Windows.Forms.Button btnOrders;
    }
}