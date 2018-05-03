namespace Client
{
    partial class Customize
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
            this.lblLaces = new System.Windows.Forms.Label();
            this.btnRemoveLaces = new System.Windows.Forms.Button();
            this.btnAddLaces = new System.Windows.Forms.Button();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.rbtnSide = new System.Windows.Forms.RadioButton();
            this.rbtnMain = new System.Windows.Forms.RadioButton();
            this.btnSelectedColor = new System.Windows.Forms.Button();
            this.btnPink = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnBlack = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnSky = new System.Windows.Forms.Button();
            this.btnBrown = new System.Windows.Forms.Button();
            this.btnGrey = new System.Windows.Forms.Button();
            this.btnOrange = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.lblSelectedColor = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.pbSide = new System.Windows.Forms.PictureBox();
            this.gbHomeButtons = new System.Windows.Forms.GroupBox();
            this.lnkPreCustomizedGroup = new System.Windows.Forms.LinkLabel();
            this.lnkHome = new System.Windows.Forms.LinkLabel();
            this.lnkAddComplaint = new System.Windows.Forms.LinkLabel();
            this.lblAvailableColors = new System.Windows.Forms.Label();
            this.lblSelectBrand = new System.Windows.Forms.Label();
            this.btnSendOrder = new System.Windows.Forms.Button();
            this.cmbBrands = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSide)).BeginInit();
            this.gbHomeButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLaces
            // 
            this.lblLaces.AutoSize = true;
            this.lblLaces.Location = new System.Drawing.Point(365, 444);
            this.lblLaces.Name = "lblLaces";
            this.lblLaces.Size = new System.Drawing.Size(114, 17);
            this.lblLaces.TabIndex = 81;
            this.lblLaces.Text = "Laces not added";
            // 
            // btnRemoveLaces
            // 
            this.btnRemoveLaces.Location = new System.Drawing.Point(144, 468);
            this.btnRemoveLaces.Name = "btnRemoveLaces";
            this.btnRemoveLaces.Size = new System.Drawing.Size(116, 30);
            this.btnRemoveLaces.TabIndex = 80;
            this.btnRemoveLaces.Text = "RemoveLaces";
            this.btnRemoveLaces.UseVisualStyleBackColor = true;
            this.btnRemoveLaces.Click += new System.EventHandler(this.btnRemoveLaces_Click);
            // 
            // btnAddLaces
            // 
            this.btnAddLaces.Location = new System.Drawing.Point(19, 469);
            this.btnAddLaces.Name = "btnAddLaces";
            this.btnAddLaces.Size = new System.Drawing.Size(119, 28);
            this.btnAddLaces.TabIndex = 79;
            this.btnAddLaces.Text = "Add Laces";
            this.btnAddLaces.UseVisualStyleBackColor = true;
            this.btnAddLaces.Click += new System.EventHandler(this.btnAddLaces_Click);
            // 
            // pbMain
            // 
            this.pbMain.Image = global::Client.Properties.Resources.ShoeTemplateFront;
            this.pbMain.Location = new System.Drawing.Point(19, 306);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(188, 135);
            this.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMain.TabIndex = 78;
            this.pbMain.TabStop = false;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(341, 246);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(80, 25);
            this.btnApply.TabIndex = 77;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // rbtnSide
            // 
            this.rbtnSide.AutoSize = true;
            this.rbtnSide.Location = new System.Drawing.Point(328, 213);
            this.rbtnSide.Name = "rbtnSide";
            this.rbtnSide.Size = new System.Drawing.Size(94, 21);
            this.rbtnSide.TabIndex = 76;
            this.rbtnSide.TabStop = true;
            this.rbtnSide.Text = "Side Color";
            this.rbtnSide.UseVisualStyleBackColor = true;
            // 
            // rbtnMain
            // 
            this.rbtnMain.AutoSize = true;
            this.rbtnMain.Location = new System.Drawing.Point(226, 213);
            this.rbtnMain.Name = "rbtnMain";
            this.rbtnMain.Size = new System.Drawing.Size(96, 21);
            this.rbtnMain.TabIndex = 75;
            this.rbtnMain.TabStop = true;
            this.rbtnMain.Text = "Main Color";
            this.rbtnMain.UseVisualStyleBackColor = true;
            // 
            // btnSelectedColor
            // 
            this.btnSelectedColor.Location = new System.Drawing.Point(226, 178);
            this.btnSelectedColor.Name = "btnSelectedColor";
            this.btnSelectedColor.Size = new System.Drawing.Size(52, 27);
            this.btnSelectedColor.TabIndex = 74;
            this.btnSelectedColor.UseVisualStyleBackColor = true;
            // 
            // btnPink
            // 
            this.btnPink.BackColor = System.Drawing.Color.Pink;
            this.btnPink.Location = new System.Drawing.Point(540, 124);
            this.btnPink.Name = "btnPink";
            this.btnPink.Size = new System.Drawing.Size(40, 25);
            this.btnPink.TabIndex = 73;
            this.btnPink.UseVisualStyleBackColor = false;
            this.btnPink.Click += new System.EventHandler(this.btnPink_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnYellow.Location = new System.Drawing.Point(489, 124);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(40, 25);
            this.btnYellow.TabIndex = 72;
            this.btnYellow.UseVisualStyleBackColor = false;
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.Green;
            this.btnGreen.Location = new System.Drawing.Point(213, 124);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(40, 25);
            this.btnGreen.TabIndex = 71;
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnBlack
            // 
            this.btnBlack.BackColor = System.Drawing.Color.Black;
            this.btnBlack.Location = new System.Drawing.Point(121, 124);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(40, 25);
            this.btnBlack.TabIndex = 70;
            this.btnBlack.UseVisualStyleBackColor = false;
            this.btnBlack.Click += new System.EventHandler(this.btnBlack_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.Location = new System.Drawing.Point(259, 124);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(40, 25);
            this.btnBlue.TabIndex = 69;
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnSky
            // 
            this.btnSky.BackColor = System.Drawing.Color.Aqua;
            this.btnSky.Location = new System.Drawing.Point(167, 124);
            this.btnSky.Name = "btnSky";
            this.btnSky.Size = new System.Drawing.Size(40, 25);
            this.btnSky.TabIndex = 68;
            this.btnSky.UseVisualStyleBackColor = false;
            this.btnSky.Click += new System.EventHandler(this.btnSky_Click);
            // 
            // btnBrown
            // 
            this.btnBrown.BackColor = System.Drawing.Color.Brown;
            this.btnBrown.Location = new System.Drawing.Point(351, 124);
            this.btnBrown.Name = "btnBrown";
            this.btnBrown.Size = new System.Drawing.Size(40, 25);
            this.btnBrown.TabIndex = 67;
            this.btnBrown.UseVisualStyleBackColor = false;
            this.btnBrown.Click += new System.EventHandler(this.btnBrown_Click);
            // 
            // btnGrey
            // 
            this.btnGrey.BackColor = System.Drawing.Color.Gray;
            this.btnGrey.Location = new System.Drawing.Point(397, 124);
            this.btnGrey.Name = "btnGrey";
            this.btnGrey.Size = new System.Drawing.Size(40, 25);
            this.btnGrey.TabIndex = 66;
            this.btnGrey.UseVisualStyleBackColor = false;
            this.btnGrey.Click += new System.EventHandler(this.btnGrey_Click);
            // 
            // btnOrange
            // 
            this.btnOrange.BackColor = System.Drawing.Color.Orange;
            this.btnOrange.Location = new System.Drawing.Point(438, 124);
            this.btnOrange.Name = "btnOrange";
            this.btnOrange.Size = new System.Drawing.Size(40, 25);
            this.btnOrange.TabIndex = 65;
            this.btnOrange.UseVisualStyleBackColor = false;
            this.btnOrange.Click += new System.EventHandler(this.btnOrange_Click);
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.Location = new System.Drawing.Point(305, 124);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(40, 25);
            this.btnRed.TabIndex = 64;
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // lblSelectedColor
            // 
            this.lblSelectedColor.AutoSize = true;
            this.lblSelectedColor.Location = new System.Drawing.Point(107, 183);
            this.lblSelectedColor.Name = "lblSelectedColor";
            this.lblSelectedColor.Size = new System.Drawing.Size(100, 17);
            this.lblSelectedColor.TabIndex = 63;
            this.lblSelectedColor.Text = "Selected Color";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(294, 499);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(128, 34);
            this.btnReset.TabIndex = 62;
            this.btnReset.Text = "Reset Changes";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pbSide
            // 
            this.pbSide.Image = global::Client.Properties.Resources.ShoeTemplate;
            this.pbSide.Location = new System.Drawing.Point(294, 306);
            this.pbSide.Name = "pbSide";
            this.pbSide.Size = new System.Drawing.Size(266, 135);
            this.pbSide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSide.TabIndex = 61;
            this.pbSide.TabStop = false;
            // 
            // gbHomeButtons
            // 
            this.gbHomeButtons.Controls.Add(this.lnkPreCustomizedGroup);
            this.gbHomeButtons.Controls.Add(this.lnkHome);
            this.gbHomeButtons.Controls.Add(this.lnkAddComplaint);
            this.gbHomeButtons.Location = new System.Drawing.Point(94, 20);
            this.gbHomeButtons.Name = "gbHomeButtons";
            this.gbHomeButtons.Size = new System.Drawing.Size(527, 49);
            this.gbHomeButtons.TabIndex = 60;
            this.gbHomeButtons.TabStop = false;
            // 
            // lnkPreCustomizedGroup
            // 
            this.lnkPreCustomizedGroup.AutoSize = true;
            this.lnkPreCustomizedGroup.Location = new System.Drawing.Point(162, 9);
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
            this.lnkAddComplaint.Location = new System.Drawing.Point(341, 9);
            this.lnkAddComplaint.Name = "lnkAddComplaint";
            this.lnkAddComplaint.Size = new System.Drawing.Size(99, 17);
            this.lnkAddComplaint.TabIndex = 11;
            this.lnkAddComplaint.TabStop = true;
            this.lnkAddComplaint.Text = "Add Complaint";
            // 
            // lblAvailableColors
            // 
            this.lblAvailableColors.AutoSize = true;
            this.lblAvailableColors.Location = new System.Drawing.Point(16, 124);
            this.lblAvailableColors.Name = "lblAvailableColors";
            this.lblAvailableColors.Size = new System.Drawing.Size(109, 17);
            this.lblAvailableColors.TabIndex = 59;
            this.lblAvailableColors.Text = "Available Colors";
            // 
            // lblSelectBrand
            // 
            this.lblSelectBrand.AutoSize = true;
            this.lblSelectBrand.Location = new System.Drawing.Point(433, 84);
            this.lblSelectBrand.Name = "lblSelectBrand";
            this.lblSelectBrand.Size = new System.Drawing.Size(89, 17);
            this.lblSelectBrand.TabIndex = 58;
            this.lblSelectBrand.Text = "Select Brand";
            // 
            // btnSendOrder
            // 
            this.btnSendOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendOrder.Location = new System.Drawing.Point(558, 491);
            this.btnSendOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnSendOrder.Name = "btnSendOrder";
            this.btnSendOrder.Size = new System.Drawing.Size(156, 41);
            this.btnSendOrder.TabIndex = 57;
            this.btnSendOrder.Text = "Send Order";
            this.btnSendOrder.UseVisualStyleBackColor = true;
            this.btnSendOrder.Click += new System.EventHandler(this.btnSendOrder_Click);
            // 
            // cmbBrands
            // 
            this.cmbBrands.FormattingEnabled = true;
            this.cmbBrands.Items.AddRange(new object[] {
            "ADIDAS",
            "NIKE",
            "REEBOK",
            "HUSH PUPPIES",
            "BATA "});
            this.cmbBrands.Location = new System.Drawing.Point(540, 81);
            this.cmbBrands.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBrands.Name = "cmbBrands";
            this.cmbBrands.Size = new System.Drawing.Size(193, 24);
            this.cmbBrands.TabIndex = 56;
            // 
            // Customize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 560);
            this.Controls.Add(this.lblLaces);
            this.Controls.Add(this.btnRemoveLaces);
            this.Controls.Add(this.btnAddLaces);
            this.Controls.Add(this.pbMain);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.rbtnSide);
            this.Controls.Add(this.rbtnMain);
            this.Controls.Add(this.btnSelectedColor);
            this.Controls.Add(this.btnPink);
            this.Controls.Add(this.btnYellow);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btnBlack);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnSky);
            this.Controls.Add(this.btnBrown);
            this.Controls.Add(this.btnGrey);
            this.Controls.Add(this.btnOrange);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.lblSelectedColor);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.pbSide);
            this.Controls.Add(this.gbHomeButtons);
            this.Controls.Add(this.lblAvailableColors);
            this.Controls.Add(this.lblSelectBrand);
            this.Controls.Add(this.btnSendOrder);
            this.Controls.Add(this.cmbBrands);
            this.Name = "Customize";
            this.Text = "Customize";
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSide)).EndInit();
            this.gbHomeButtons.ResumeLayout(false);
            this.gbHomeButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLaces;
        private System.Windows.Forms.Button btnRemoveLaces;
        private System.Windows.Forms.Button btnAddLaces;
        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.RadioButton rbtnSide;
        private System.Windows.Forms.RadioButton rbtnMain;
        private System.Windows.Forms.Button btnSelectedColor;
        private System.Windows.Forms.Button btnPink;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnBlack;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnSky;
        private System.Windows.Forms.Button btnBrown;
        private System.Windows.Forms.Button btnGrey;
        private System.Windows.Forms.Button btnOrange;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Label lblSelectedColor;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox pbSide;
        private System.Windows.Forms.GroupBox gbHomeButtons;
        private System.Windows.Forms.LinkLabel lnkPreCustomizedGroup;
        private System.Windows.Forms.LinkLabel lnkHome;
        private System.Windows.Forms.LinkLabel lnkAddComplaint;
        private System.Windows.Forms.Label lblAvailableColors;
        private System.Windows.Forms.Label lblSelectBrand;
        private System.Windows.Forms.Button btnSendOrder;
        private System.Windows.Forms.ComboBox cmbBrands;
    }
}