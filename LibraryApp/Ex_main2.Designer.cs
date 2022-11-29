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
            this.examplesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shelfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Owner_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.shelfDataGridViewTextBoxColumn,
            this.Book_name,
            this.Location_name,
            this.Owner_name,
            this.IssueDate,
            this.ExpDate,
            this.DeliveryDate});
            this.dataGridView1.DataSource = this.examplesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1240, 657);
            this.dataGridView1.TabIndex = 1;
            // 
            // examplesBindingSource
            // 
            this.examplesBindingSource.DataSource = typeof(LibraryApp.Examples);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // shelfDataGridViewTextBoxColumn
            // 
            this.shelfDataGridViewTextBoxColumn.DataPropertyName = "Shelf";
            this.shelfDataGridViewTextBoxColumn.HeaderText = "Полка";
            this.shelfDataGridViewTextBoxColumn.Name = "shelfDataGridViewTextBoxColumn";
            // 
            // Book_name
            // 
            this.Book_name.DataPropertyName = "Book_name";
            this.Book_name.HeaderText = "Книга";
            this.Book_name.Name = "Book_name";
            this.Book_name.ReadOnly = true;
            // 
            // Location_name
            // 
            this.Location_name.DataPropertyName = "Location_name";
            this.Location_name.HeaderText = "Место";
            this.Location_name.Name = "Location_name";
            this.Location_name.ReadOnly = true;
            // 
            // Owner_name
            // 
            this.Owner_name.DataPropertyName = "Owner_name";
            this.Owner_name.HeaderText = "Владелец";
            this.Owner_name.Name = "Owner_name";
            this.Owner_name.ReadOnly = true;
            // 
            // IssueDate
            // 
            this.IssueDate.DataPropertyName = "IssueDate";
            this.IssueDate.HeaderText = "Срок(начало)";
            this.IssueDate.Name = "IssueDate";
            // 
            // ExpDate
            // 
            this.ExpDate.DataPropertyName = "ExpDate";
            this.ExpDate.HeaderText = "Срок(до)";
            this.ExpDate.Name = "ExpDate";
            // 
            // DeliveryDate
            // 
            this.DeliveryDate.DataPropertyName = "DeliveryDate";
            this.DeliveryDate.HeaderText = "Дата получения";
            this.DeliveryDate.Name = "DeliveryDate";
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
        private System.Windows.Forms.BindingSource examplesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shelfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Owner_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryDate;
    }
}