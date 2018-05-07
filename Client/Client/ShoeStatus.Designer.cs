namespace Client
{
    partial class ShoeStatus
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
            this.lblCurrentStatus = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnApproveShoe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCurrentStatus
            // 
            this.lblCurrentStatus.AutoSize = true;
            this.lblCurrentStatus.Location = new System.Drawing.Point(12, 64);
            this.lblCurrentStatus.Name = "lblCurrentStatus";
            this.lblCurrentStatus.Size = new System.Drawing.Size(99, 17);
            this.lblCurrentStatus.TabIndex = 0;
            this.lblCurrentStatus.Text = "Current Status";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 22);
            this.textBox1.TabIndex = 1;
            // 
            // btnApproveShoe
            // 
            this.btnApproveShoe.Location = new System.Drawing.Point(313, 100);
            this.btnApproveShoe.Name = "btnApproveShoe";
            this.btnApproveShoe.Size = new System.Drawing.Size(101, 27);
            this.btnApproveShoe.TabIndex = 2;
            this.btnApproveShoe.Text = "Approve";
            this.btnApproveShoe.UseVisualStyleBackColor = true;
            this.btnApproveShoe.Click += new System.EventHandler(this.btnApproveShoe_Click);
            // 
            // ShoeStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 158);
            this.Controls.Add(this.btnApproveShoe);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCurrentStatus);
            this.Name = "ShoeStatus";
            this.Text = "ShoeStatus";
            this.Load += new System.EventHandler(this.ShoeStatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentStatus;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnApproveShoe;
    }
}