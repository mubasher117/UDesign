namespace Client
{
    partial class Precustomized
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
            this.gvMorePrecustomized = new System.Windows.Forms.DataGridView();
            this.lnkBack = new System.Windows.Forms.LinkLabel();
            this.flPrecustomized = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gvMorePrecustomized)).BeginInit();
            this.SuspendLayout();
            // 
            // gvMorePrecustomized
            // 
            this.gvMorePrecustomized.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMorePrecustomized.Location = new System.Drawing.Point(41, 491);
            this.gvMorePrecustomized.Name = "gvMorePrecustomized";
            this.gvMorePrecustomized.RowTemplate.Height = 24;
            this.gvMorePrecustomized.Size = new System.Drawing.Size(761, 162);
            this.gvMorePrecustomized.TabIndex = 0;
            // 
            // lnkBack
            // 
            this.lnkBack.AutoSize = true;
            this.lnkBack.Location = new System.Drawing.Point(792, 9);
            this.lnkBack.Name = "lnkBack";
            this.lnkBack.Size = new System.Drawing.Size(39, 17);
            this.lnkBack.TabIndex = 1;
            this.lnkBack.TabStop = true;
            this.lnkBack.Text = "Back";
            this.lnkBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBack_LinkClicked);
            // 
            // flPrecustomized
            // 
            this.flPrecustomized.Location = new System.Drawing.Point(41, 64);
            this.flPrecustomized.Name = "flPrecustomized";
            this.flPrecustomized.Size = new System.Drawing.Size(765, 325);
            this.flPrecustomized.TabIndex = 2;
            // 
            // Precustomized
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 721);
            this.Controls.Add(this.flPrecustomized);
            this.Controls.Add(this.lnkBack);
            this.Controls.Add(this.gvMorePrecustomized);
            this.Name = "Precustomized";
            this.Text = "Precustomized";
            this.Load += new System.EventHandler(this.PrecustomizedDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvMorePrecustomized)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvMorePrecustomized;
        private System.Windows.Forms.LinkLabel lnkBack;
        private System.Windows.Forms.FlowLayoutPanel flPrecustomized;
    }
}