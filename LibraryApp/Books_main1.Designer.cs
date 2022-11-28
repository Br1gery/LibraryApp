namespace LibraryApp
{
    partial class Books_main1
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
            this.author_id_combo = new System.Windows.Forms.ComboBox();
            this.delete = new System.Windows.Forms.Button();
            this.id_text3 = new System.Windows.Forms.TextBox();
            this.change = new System.Windows.Forms.Button();
            this.Description_text2 = new System.Windows.Forms.TextBox();
            this.Pages_text2 = new System.Windows.Forms.TextBox();
            this.Rel_year_text2 = new System.Windows.Forms.TextBox();
            this.Name_text2 = new System.Windows.Forms.TextBox();
            this.Id_text2 = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.Description_text = new System.Windows.Forms.TextBox();
            this.Pages_text = new System.Windows.Forms.TextBox();
            this.Rel_year_text = new System.Windows.Forms.TextBox();
            this.Name_text = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.genre_id_combo = new System.Windows.Forms.ComboBox();
            this.publisher_id_combo = new System.Windows.Forms.ComboBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author_id_combo2 = new System.Windows.Forms.ComboBox();
            this.genre_id_combo2 = new System.Windows.Forms.ComboBox();
            this.publisher_id_combo2 = new System.Windows.Forms.ComboBox();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // author_id_combo
            // 
            this.author_id_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.author_id_combo.FormattingEnabled = true;
            this.author_id_combo.Location = new System.Drawing.Point(838, 53);
            this.author_id_combo.Name = "author_id_combo";
            this.author_id_combo.Size = new System.Drawing.Size(100, 28);
            this.author_id_combo.TabIndex = 108;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete.ForeColor = System.Drawing.Color.Black;
            this.delete.Location = new System.Drawing.Point(891, 573);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(232, 38);
            this.delete.TabIndex = 107;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // id_text3
            // 
            this.id_text3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_text3.Location = new System.Drawing.Point(950, 527);
            this.id_text3.Name = "id_text3";
            this.id_text3.ReadOnly = true;
            this.id_text3.Size = new System.Drawing.Size(100, 26);
            this.id_text3.TabIndex = 106;
            // 
            // change
            // 
            this.change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.change.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.change.ForeColor = System.Drawing.Color.Black;
            this.change.Location = new System.Drawing.Point(890, 429);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(232, 38);
            this.change.TabIndex = 105;
            this.change.Text = "Изменить";
            this.change.UseVisualStyleBackColor = false;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // Description_text2
            // 
            this.Description_text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Description_text2.Location = new System.Drawing.Point(951, 379);
            this.Description_text2.Name = "Description_text2";
            this.Description_text2.Size = new System.Drawing.Size(100, 26);
            this.Description_text2.TabIndex = 103;
            // 
            // Pages_text2
            // 
            this.Pages_text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pages_text2.Location = new System.Drawing.Point(1156, 298);
            this.Pages_text2.Name = "Pages_text2";
            this.Pages_text2.Size = new System.Drawing.Size(100, 26);
            this.Pages_text2.TabIndex = 101;
            // 
            // Rel_year_text2
            // 
            this.Rel_year_text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rel_year_text2.Location = new System.Drawing.Point(1050, 298);
            this.Rel_year_text2.Name = "Rel_year_text2";
            this.Rel_year_text2.Size = new System.Drawing.Size(100, 26);
            this.Rel_year_text2.TabIndex = 100;
            // 
            // Name_text2
            // 
            this.Name_text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_text2.Location = new System.Drawing.Point(944, 298);
            this.Name_text2.Name = "Name_text2";
            this.Name_text2.Size = new System.Drawing.Size(100, 26);
            this.Name_text2.TabIndex = 99;
            // 
            // Id_text2
            // 
            this.Id_text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Id_text2.Location = new System.Drawing.Point(732, 298);
            this.Id_text2.Name = "Id_text2";
            this.Id_text2.ReadOnly = true;
            this.Id_text2.Size = new System.Drawing.Size(100, 26);
            this.Id_text2.TabIndex = 97;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add.ForeColor = System.Drawing.Color.Black;
            this.add.Location = new System.Drawing.Point(890, 183);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(232, 38);
            this.add.TabIndex = 96;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Description_text
            // 
            this.Description_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Description_text.Location = new System.Drawing.Point(842, 132);
            this.Description_text.Name = "Description_text";
            this.Description_text.Size = new System.Drawing.Size(100, 26);
            this.Description_text.TabIndex = 94;
            // 
            // Pages_text
            // 
            this.Pages_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pages_text.Location = new System.Drawing.Point(1050, 55);
            this.Pages_text.Name = "Pages_text";
            this.Pages_text.Size = new System.Drawing.Size(100, 26);
            this.Pages_text.TabIndex = 92;
            // 
            // Rel_year_text
            // 
            this.Rel_year_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rel_year_text.Location = new System.Drawing.Point(944, 55);
            this.Rel_year_text.Name = "Rel_year_text";
            this.Rel_year_text.Size = new System.Drawing.Size(100, 26);
            this.Rel_year_text.TabIndex = 91;
            // 
            // Name_text
            // 
            this.Name_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_text.Location = new System.Drawing.Point(732, 55);
            this.Name_text.Name = "Name_text";
            this.Name_text.Size = new System.Drawing.Size(100, 26);
            this.Name_text.TabIndex = 89;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(988, 496);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(25, 24);
            this.label16.TabIndex = 88;
            this.label16.Text = "id";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(774, 255);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 24);
            this.label15.TabIndex = 87;
            this.label15.Text = "id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(951, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 24);
            this.label8.TabIndex = 86;
            this.label8.Text = "Описание";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(795, 339);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 24);
            this.label9.TabIndex = 85;
            this.label9.Text = "Жанр";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(1130, 339);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 24);
            this.label10.TabIndex = 84;
            this.label10.Text = "Издатель";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(1156, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 24);
            this.label11.TabIndex = 83;
            this.label11.Text = "Страницы";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(1039, 255);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 24);
            this.label12.TabIndex = 82;
            this.label12.Text = "Год издания";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(946, 255);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 24);
            this.label13.TabIndex = 81;
            this.label13.Text = "Название";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(855, 254);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 24);
            this.label14.TabIndex = 80;
            this.label14.Text = "Автор";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(1051, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 24);
            this.label7.TabIndex = 79;
            this.label7.Text = "Издатель";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(841, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 24);
            this.label6.TabIndex = 78;
            this.label6.Text = "Описание";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(1177, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 77;
            this.label5.Text = "Жанр";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1052, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 24);
            this.label4.TabIndex = 76;
            this.label4.Text = "Страницы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(932, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 24);
            this.label3.TabIndex = 75;
            this.label3.Text = "Год издания";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(853, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 74;
            this.label2.Text = "Автор";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(735, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 73;
            this.label1.Text = "Название";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.relYearDataGridViewTextBoxColumn,
            this.pagesDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.Author_name,
            this.Genre_name,
            this.Publisher_name});
            this.dataGridView1.DataSource = this.booksBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(717, 657);
            this.dataGridView1.TabIndex = 72;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // genre_id_combo
            // 
            this.genre_id_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genre_id_combo.FormattingEnabled = true;
            this.genre_id_combo.Location = new System.Drawing.Point(1156, 53);
            this.genre_id_combo.Name = "genre_id_combo";
            this.genre_id_combo.Size = new System.Drawing.Size(100, 28);
            this.genre_id_combo.TabIndex = 109;
            // 
            // publisher_id_combo
            // 
            this.publisher_id_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.publisher_id_combo.FormattingEnabled = true;
            this.publisher_id_combo.Location = new System.Drawing.Point(1050, 132);
            this.publisher_id_combo.Name = "publisher_id_combo";
            this.publisher_id_combo.Size = new System.Drawing.Size(100, 28);
            this.publisher_id_combo.TabIndex = 110;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Author";
            this.dataGridViewTextBoxColumn1.HeaderText = "Author";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 674;
            // 
            // author_id_combo2
            // 
            this.author_id_combo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.author_id_combo2.FormattingEnabled = true;
            this.author_id_combo2.Location = new System.Drawing.Point(838, 298);
            this.author_id_combo2.Name = "author_id_combo2";
            this.author_id_combo2.Size = new System.Drawing.Size(100, 28);
            this.author_id_combo2.TabIndex = 111;
            // 
            // genre_id_combo2
            // 
            this.genre_id_combo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genre_id_combo2.FormattingEnabled = true;
            this.genre_id_combo2.Location = new System.Drawing.Point(778, 379);
            this.genre_id_combo2.Name = "genre_id_combo2";
            this.genre_id_combo2.Size = new System.Drawing.Size(100, 28);
            this.genre_id_combo2.TabIndex = 112;
            // 
            // publisher_id_combo2
            // 
            this.publisher_id_combo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.publisher_id_combo2.FormattingEnabled = true;
            this.publisher_id_combo2.Location = new System.Drawing.Point(1127, 379);
            this.publisher_id_combo2.Name = "publisher_id_combo2";
            this.publisher_id_combo2.Size = new System.Drawing.Size(100, 28);
            this.publisher_id_combo2.TabIndex = 113;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataSource = typeof(LibraryApp.Books);
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
            // relYearDataGridViewTextBoxColumn
            // 
            this.relYearDataGridViewTextBoxColumn.DataPropertyName = "RelYear";
            this.relYearDataGridViewTextBoxColumn.HeaderText = "RelYear";
            this.relYearDataGridViewTextBoxColumn.Name = "relYearDataGridViewTextBoxColumn";
            // 
            // pagesDataGridViewTextBoxColumn
            // 
            this.pagesDataGridViewTextBoxColumn.DataPropertyName = "Pages";
            this.pagesDataGridViewTextBoxColumn.HeaderText = "Pages";
            this.pagesDataGridViewTextBoxColumn.Name = "pagesDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // Author_name
            // 
            this.Author_name.DataPropertyName = "Author_name";
            this.Author_name.HeaderText = "Author_name";
            this.Author_name.Name = "Author_name";
            this.Author_name.ReadOnly = true;
            // 
            // Genre_name
            // 
            this.Genre_name.DataPropertyName = "Genre_name";
            this.Genre_name.HeaderText = "Genre_name";
            this.Genre_name.Name = "Genre_name";
            this.Genre_name.ReadOnly = true;
            // 
            // Publisher_name
            // 
            this.Publisher_name.DataPropertyName = "Publisher_name";
            this.Publisher_name.HeaderText = "Publisher_name";
            this.Publisher_name.Name = "Publisher_name";
            this.Publisher_name.ReadOnly = true;
            // 
            // Books_main1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.publisher_id_combo2);
            this.Controls.Add(this.genre_id_combo2);
            this.Controls.Add(this.author_id_combo2);
            this.Controls.Add(this.publisher_id_combo);
            this.Controls.Add(this.genre_id_combo);
            this.Controls.Add(this.author_id_combo);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.id_text3);
            this.Controls.Add(this.change);
            this.Controls.Add(this.Description_text2);
            this.Controls.Add(this.Pages_text2);
            this.Controls.Add(this.Rel_year_text2);
            this.Controls.Add(this.Name_text2);
            this.Controls.Add(this.Id_text2);
            this.Controls.Add(this.add);
            this.Controls.Add(this.Description_text);
            this.Controls.Add(this.Pages_text);
            this.Controls.Add(this.Rel_year_text);
            this.Controls.Add(this.Name_text);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Books_main1";
            this.Text = "Books_main1";
            this.Load += new System.EventHandler(this.Books_main1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox author_id_combo;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox id_text3;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.TextBox Description_text2;
        private System.Windows.Forms.TextBox Pages_text2;
        private System.Windows.Forms.TextBox Rel_year_text2;
        private System.Windows.Forms.TextBox Name_text2;
        private System.Windows.Forms.TextBox Id_text2;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox Description_text;
        private System.Windows.Forms.TextBox Pages_text;
        private System.Windows.Forms.TextBox Rel_year_text;
        private System.Windows.Forms.TextBox Name_text;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private System.Windows.Forms.ComboBox genre_id_combo;
        private System.Windows.Forms.ComboBox publisher_id_combo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.ComboBox author_id_combo2;
        private System.Windows.Forms.ComboBox genre_id_combo2;
        private System.Windows.Forms.ComboBox publisher_id_combo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn relYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher_name;
    }
}