namespace Client
{
    partial class ucPredesigned
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbShoe = new System.Windows.Forms.PictureBox();
            this.lblShoe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbShoe)).BeginInit();
            this.SuspendLayout();
            // 
            // pbShoe
            // 
            this.pbShoe.Location = new System.Drawing.Point(23, 20);
            this.pbShoe.Name = "pbShoe";
            this.pbShoe.Size = new System.Drawing.Size(163, 137);
            this.pbShoe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShoe.TabIndex = 0;
            this.pbShoe.TabStop = false;
            // 
            // lblShoe
            // 
            this.lblShoe.AutoSize = true;
            this.lblShoe.Location = new System.Drawing.Point(74, 174);
            this.lblShoe.Name = "lblShoe";
            this.lblShoe.Size = new System.Drawing.Size(65, 17);
            this.lblShoe.TabIndex = 1;
            this.lblShoe.Text = "Designer";
            // 
            // ucPredesigned
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblShoe);
            this.Controls.Add(this.pbShoe);
            this.Name = "ucPredesigned";
            this.Size = new System.Drawing.Size(206, 214);
            this.Load += new System.EventHandler(this.ucPredesigned_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbShoe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbShoe;
        private System.Windows.Forms.Label lblShoe;
    }
}
