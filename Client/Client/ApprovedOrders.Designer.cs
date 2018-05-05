namespace Client
{
    partial class ApprovedOrders
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
            this.gvApprovedOrders = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvApprovedOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkBack
            // 
            this.lnkBack.AutoSize = true;
            this.lnkBack.Location = new System.Drawing.Point(713, 9);
            this.lnkBack.Name = "lnkBack";
            this.lnkBack.Size = new System.Drawing.Size(39, 17);
            this.lnkBack.TabIndex = 0;
            this.lnkBack.TabStop = true;
            this.lnkBack.Text = "Back";
            this.lnkBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBack_LinkClicked);
            // 
            // gvApprovedOrders
            // 
            this.gvApprovedOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvApprovedOrders.Location = new System.Drawing.Point(12, 48);
            this.gvApprovedOrders.Name = "gvApprovedOrders";
            this.gvApprovedOrders.RowTemplate.Height = 24;
            this.gvApprovedOrders.Size = new System.Drawing.Size(748, 450);
            this.gvApprovedOrders.TabIndex = 1;
            // 
            // ApprovedOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 526);
            this.Controls.Add(this.gvApprovedOrders);
            this.Controls.Add(this.lnkBack);
            this.Name = "ApprovedOrders";
            this.Text = "ApprovedOrders";
            this.Load += new System.EventHandler(this.ApprovedOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvApprovedOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkBack;
        private System.Windows.Forms.DataGridView gvApprovedOrders;
    }
}