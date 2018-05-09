namespace Client
{
    partial class DesignerUpload
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
            this.pbSelectedImage = new System.Windows.Forms.PictureBox();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.lbUploadDesign = new System.Windows.Forms.Label();
            this.gbHomeButtons = new System.Windows.Forms.GroupBox();
            this.lnkSignOut = new System.Windows.Forms.LinkLabel();
            this.lnkPreCustomizedGroup = new System.Windows.Forms.LinkLabel();
            this.lnkHome = new System.Windows.Forms.LinkLabel();
            this.btnUpload = new System.Windows.Forms.Button();
            this.dbSelectDesign = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectedImage)).BeginInit();
            this.gbHomeButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbSelectedImage
            // 
            this.pbSelectedImage.Location = new System.Drawing.Point(118, 168);
            this.pbSelectedImage.Name = "pbSelectedImage";
            this.pbSelectedImage.Size = new System.Drawing.Size(350, 199);
            this.pbSelectedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSelectedImage.TabIndex = 26;
            this.pbSelectedImage.TabStop = false;
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(222, 391);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(123, 30);
            this.btnSelectImage.TabIndex = 25;
            this.btnSelectImage.Text = "Select";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // lbUploadDesign
            // 
            this.lbUploadDesign.AutoSize = true;
            this.lbUploadDesign.Location = new System.Drawing.Point(27, 130);
            this.lbUploadDesign.Name = "lbUploadDesign";
            this.lbUploadDesign.Size = new System.Drawing.Size(101, 17);
            this.lbUploadDesign.TabIndex = 23;
            this.lbUploadDesign.Text = "Upload Design";
            // 
            // gbHomeButtons
            // 
            this.gbHomeButtons.Controls.Add(this.lnkSignOut);
            this.gbHomeButtons.Controls.Add(this.lnkPreCustomizedGroup);
            this.gbHomeButtons.Controls.Add(this.lnkHome);
            this.gbHomeButtons.Location = new System.Drawing.Point(103, 24);
            this.gbHomeButtons.Name = "gbHomeButtons";
            this.gbHomeButtons.Size = new System.Drawing.Size(437, 49);
            this.gbHomeButtons.TabIndex = 22;
            this.gbHomeButtons.TabStop = false;
            // 
            // lnkSignOut
            // 
            this.lnkSignOut.AutoSize = true;
            this.lnkSignOut.Location = new System.Drawing.Point(275, 9);
            this.lnkSignOut.Name = "lnkSignOut";
            this.lnkSignOut.Size = new System.Drawing.Size(63, 17);
            this.lnkSignOut.TabIndex = 15;
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
            this.lnkPreCustomizedGroup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPreCustomizedGroup_LinkClicked);
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
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(368, 389);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(100, 32);
            this.btnUpload.TabIndex = 21;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // dbSelectDesign
            // 
            this.dbSelectDesign.FileName = "openFileDialog1";
            // 
            // DesignerUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 507);
            this.Controls.Add(this.pbSelectedImage);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.lbUploadDesign);
            this.Controls.Add(this.gbHomeButtons);
            this.Controls.Add(this.btnUpload);
            this.Name = "DesignerUpload";
            this.Text = "DesignerUpload";
            this.Load += new System.EventHandler(this.DesignerUpload_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectedImage)).EndInit();
            this.gbHomeButtons.ResumeLayout(false);
            this.gbHomeButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSelectedImage;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.Label lbUploadDesign;
        private System.Windows.Forms.GroupBox gbHomeButtons;
        private System.Windows.Forms.LinkLabel lnkSignOut;
        private System.Windows.Forms.LinkLabel lnkPreCustomizedGroup;
        private System.Windows.Forms.LinkLabel lnkHome;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.OpenFileDialog dbSelectDesign;
    }
}