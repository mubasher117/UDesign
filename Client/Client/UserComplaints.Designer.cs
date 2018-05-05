namespace Client
{
    partial class UserComplaints
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
            this.lnkBack = new System.Windows.Forms.LinkLabel();
            this.gvAllComplaints = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvAllComplaints)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkBack
            // 
            this.lnkBack.AutoSize = true;
            this.lnkBack.Location = new System.Drawing.Point(644, 9);
            this.lnkBack.Name = "lnkBack";
            this.lnkBack.Size = new System.Drawing.Size(39, 17);
            this.lnkBack.TabIndex = 0;
            this.lnkBack.TabStop = true;
            this.lnkBack.Text = "Back";
            // 
            // gvAllComplaints
            // 
            this.gvAllComplaints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAllComplaints.Location = new System.Drawing.Point(23, 104);
            this.gvAllComplaints.Name = "gvAllComplaints";
            this.gvAllComplaints.RowTemplate.Height = 24;
            this.gvAllComplaints.Size = new System.Drawing.Size(667, 404);
            this.gvAllComplaints.TabIndex = 1;
            // 
            // UserComplaints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 530);
            this.Controls.Add(this.gvAllComplaints);
            this.Controls.Add(this.lnkBack);
            this.Name = "UserComplaints";
            this.Text = "UserComplaints";
            this.Load += new System.EventHandler(this.UserComplaints_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvAllComplaints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkBack;
        private System.Windows.Forms.DataGridView gvAllComplaints;
    }
}