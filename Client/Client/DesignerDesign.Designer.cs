namespace Client
{
    partial class DesignerDesign
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
            this.btnApprove = new System.Windows.Forms.Button();
            this.lnkBack = new System.Windows.Forms.LinkLabel();
            this.flDesignerDesign = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnApprove
            // 
            this.btnApprove.Location = new System.Drawing.Point(577, 483);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(134, 26);
            this.btnApprove.TabIndex = 5;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // lnkBack
            // 
            this.lnkBack.AutoSize = true;
            this.lnkBack.Location = new System.Drawing.Point(686, 18);
            this.lnkBack.Name = "lnkBack";
            this.lnkBack.Size = new System.Drawing.Size(39, 17);
            this.lnkBack.TabIndex = 4;
            this.lnkBack.TabStop = true;
            this.lnkBack.Text = "Back";
            this.lnkBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBack_LinkClicked);
            // 
            // flDesignerDesign
            // 
            this.flDesignerDesign.Location = new System.Drawing.Point(13, 65);
            this.flDesignerDesign.Name = "flDesignerDesign";
            this.flDesignerDesign.Size = new System.Drawing.Size(699, 391);
            this.flDesignerDesign.TabIndex = 3;
            this.flDesignerDesign.Paint += new System.Windows.Forms.PaintEventHandler(this.flDesignerDesign_Paint);
            // 
            // DesignerDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 526);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.lnkBack);
            this.Controls.Add(this.flDesignerDesign);
            this.Name = "DesignerDesign";
            this.Text = "DesignerDesign";
            this.Load += new System.EventHandler(this.DesignerDesign_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.LinkLabel lnkBack;
        private System.Windows.Forms.FlowLayoutPanel flDesignerDesign;
    }
}