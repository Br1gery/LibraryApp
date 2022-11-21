namespace LibraryApp
{
    partial class Ex_main2
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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shelfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueDateDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.expDateDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.deliveryDateDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.examplesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examplesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.locationIdDataGridViewTextBoxColumn,
            this.ownderIdDataGridViewTextBoxColumn,
            this.bookIdDataGridViewTextBoxColumn,
            this.shelfDataGridViewTextBoxColumn,
            this.issueDateDataGridViewImageColumn,
            this.expDateDataGridViewImageColumn,
            this.deliveryDateDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.examplesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1240, 657);
            this.dataGridView1.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // locationIdDataGridViewTextBoxColumn
            // 
            this.locationIdDataGridViewTextBoxColumn.DataPropertyName = "LocationId";
            this.locationIdDataGridViewTextBoxColumn.HeaderText = "LocationId";
            this.locationIdDataGridViewTextBoxColumn.Name = "locationIdDataGridViewTextBoxColumn";
            // 
            // ownderIdDataGridViewTextBoxColumn
            // 
            this.ownderIdDataGridViewTextBoxColumn.DataPropertyName = "OwnderId";
            this.ownderIdDataGridViewTextBoxColumn.HeaderText = "OwnderId";
            this.ownderIdDataGridViewTextBoxColumn.Name = "ownderIdDataGridViewTextBoxColumn";
            // 
            // bookIdDataGridViewTextBoxColumn
            // 
            this.bookIdDataGridViewTextBoxColumn.DataPropertyName = "BookId";
            this.bookIdDataGridViewTextBoxColumn.HeaderText = "BookId";
            this.bookIdDataGridViewTextBoxColumn.Name = "bookIdDataGridViewTextBoxColumn";
            // 
            // shelfDataGridViewTextBoxColumn
            // 
            this.shelfDataGridViewTextBoxColumn.DataPropertyName = "Shelf";
            this.shelfDataGridViewTextBoxColumn.HeaderText = "Shelf";
            this.shelfDataGridViewTextBoxColumn.Name = "shelfDataGridViewTextBoxColumn";
            // 
            // issueDateDataGridViewImageColumn
            // 
            this.issueDateDataGridViewImageColumn.DataPropertyName = "IssueDate";
            this.issueDateDataGridViewImageColumn.HeaderText = "IssueDate";
            this.issueDateDataGridViewImageColumn.Name = "issueDateDataGridViewImageColumn";
            // 
            // expDateDataGridViewImageColumn
            // 
            this.expDateDataGridViewImageColumn.DataPropertyName = "ExpDate";
            this.expDateDataGridViewImageColumn.HeaderText = "ExpDate";
            this.expDateDataGridViewImageColumn.Name = "expDateDataGridViewImageColumn";
            // 
            // deliveryDateDataGridViewImageColumn
            // 
            this.deliveryDateDataGridViewImageColumn.DataPropertyName = "DeliveryDate";
            this.deliveryDateDataGridViewImageColumn.HeaderText = "DeliveryDate";
            this.deliveryDateDataGridViewImageColumn.Name = "deliveryDateDataGridViewImageColumn";
            // 
            // examplesBindingSource
            // 
            this.examplesBindingSource.DataSource = typeof(LibraryApp.Examples);
            // 
            // Ex_main2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Ex_main2";
            this.Text = "Ex_main2";
            this.Load += new System.EventHandler(this.Ex_main2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examplesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shelfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn issueDateDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewImageColumn expDateDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewImageColumn deliveryDateDataGridViewImageColumn;
        private System.Windows.Forms.BindingSource examplesBindingSource;
    }
}