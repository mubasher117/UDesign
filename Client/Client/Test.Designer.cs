namespace Client
{
    partial class Test
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shoeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShoeDetails = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.deliveryDateSpecifiedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idSpecifiedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.statusSpecifiedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getShoefromOrdersCompletedEventArgsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getShoefromOrdersCompletedEventArgsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.statusDataGridViewCheckBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.deliveryDateDataGridViewTextBoxColumn,
            this.shoeDataGridViewTextBoxColumn,
            this.ShoeDetails,
            this.deliveryDateSpecifiedDataGridViewCheckBoxColumn,
            this.idSpecifiedDataGridViewCheckBoxColumn,
            this.statusSpecifiedDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.orderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(120, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(48, 79);
            this.dataGridView1.TabIndex = 0;
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "Status";
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Adress";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            // 
            // deliveryDateDataGridViewTextBoxColumn
            // 
            this.deliveryDateDataGridViewTextBoxColumn.DataPropertyName = "DeliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.HeaderText = "DeliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.Name = "deliveryDateDataGridViewTextBoxColumn";
            // 
            // shoeDataGridViewTextBoxColumn
            // 
            this.shoeDataGridViewTextBoxColumn.DataPropertyName = "Shoe";
            this.shoeDataGridViewTextBoxColumn.HeaderText = "Shoe";
            this.shoeDataGridViewTextBoxColumn.Name = "shoeDataGridViewTextBoxColumn";
            // 
            // ShoeDetails
            // 
            this.ShoeDetails.HeaderText = "Shoe Details";
            this.ShoeDetails.Name = "ShoeDetails";
            // 
            // deliveryDateSpecifiedDataGridViewCheckBoxColumn
            // 
            this.deliveryDateSpecifiedDataGridViewCheckBoxColumn.DataPropertyName = "DeliveryDateSpecified";
            this.deliveryDateSpecifiedDataGridViewCheckBoxColumn.HeaderText = "DeliveryDateSpecified";
            this.deliveryDateSpecifiedDataGridViewCheckBoxColumn.Name = "deliveryDateSpecifiedDataGridViewCheckBoxColumn";
            this.deliveryDateSpecifiedDataGridViewCheckBoxColumn.Visible = false;
            // 
            // idSpecifiedDataGridViewCheckBoxColumn
            // 
            this.idSpecifiedDataGridViewCheckBoxColumn.DataPropertyName = "IdSpecified";
            this.idSpecifiedDataGridViewCheckBoxColumn.HeaderText = "IdSpecified";
            this.idSpecifiedDataGridViewCheckBoxColumn.Name = "idSpecifiedDataGridViewCheckBoxColumn";
            this.idSpecifiedDataGridViewCheckBoxColumn.Visible = false;
            // 
            // statusSpecifiedDataGridViewCheckBoxColumn
            // 
            this.statusSpecifiedDataGridViewCheckBoxColumn.DataPropertyName = "StatusSpecified";
            this.statusSpecifiedDataGridViewCheckBoxColumn.HeaderText = "StatusSpecified";
            this.statusSpecifiedDataGridViewCheckBoxColumn.Name = "statusSpecifiedDataGridViewCheckBoxColumn";
            this.statusSpecifiedDataGridViewCheckBoxColumn.Visible = false;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(Client.localhost.Order);
            // 
            // getShoefromOrdersCompletedEventArgsBindingSource
            // 
            this.getShoefromOrdersCompletedEventArgsBindingSource.DataSource = typeof(Client.localhost.GetShoefromOrdersCompletedEventArgs);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(290, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(314, 22);
            this.textBox1.TabIndex = 1;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Test";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getShoefromOrdersCompletedEventArgsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shoeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ShoeDetails;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deliveryDateSpecifiedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn idSpecifiedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusSpecifiedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource getShoefromOrdersCompletedEventArgsBindingSource;
        private System.Windows.Forms.TextBox textBox1;
    }
}