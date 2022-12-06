
namespace LibraryApp
{
    partial class main3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.login_text1 = new System.Windows.Forms.TextBox();
            this.pass_text1 = new System.Windows.Forms.TextBox();
            this.role_text1 = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            this.role_text2 = new System.Windows.Forms.TextBox();
            this.pass_text2 = new System.Windows.Forms.TextBox();
            this.login_text2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.id_text3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.id_text2 = new System.Windows.Forms.TextBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usersDataBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(497, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(526, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 152;
            this.label2.Text = "Логин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(622, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 153;
            this.label1.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(725, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 154;
            this.label3.Text = "Роль";
            // 
            // login_text1
            // 
            this.login_text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_text1.Location = new System.Drawing.Point(515, 48);
            this.login_text1.Name = "login_text1";
            this.login_text1.Size = new System.Drawing.Size(88, 26);
            this.login_text1.TabIndex = 155;
            // 
            // pass_text1
            // 
            this.pass_text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass_text1.Location = new System.Drawing.Point(614, 48);
            this.pass_text1.Name = "pass_text1";
            this.pass_text1.Size = new System.Drawing.Size(88, 26);
            this.pass_text1.TabIndex = 156;
            // 
            // role_text1
            // 
            this.role_text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.role_text1.Location = new System.Drawing.Point(708, 48);
            this.role_text1.Name = "role_text1";
            this.role_text1.Size = new System.Drawing.Size(88, 26);
            this.role_text1.TabIndex = 157;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add.ForeColor = System.Drawing.Color.Black;
            this.add.Location = new System.Drawing.Point(547, 99);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(232, 38);
            this.add.TabIndex = 158;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // change
            // 
            this.change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.change.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.change.ForeColor = System.Drawing.Color.Black;
            this.change.Location = new System.Drawing.Point(543, 253);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(232, 38);
            this.change.TabIndex = 165;
            this.change.Text = "Изменить";
            this.change.UseVisualStyleBackColor = false;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // role_text2
            // 
            this.role_text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.role_text2.Location = new System.Drawing.Point(704, 202);
            this.role_text2.Name = "role_text2";
            this.role_text2.Size = new System.Drawing.Size(88, 26);
            this.role_text2.TabIndex = 164;
            // 
            // pass_text2
            // 
            this.pass_text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass_text2.Location = new System.Drawing.Point(610, 202);
            this.pass_text2.Name = "pass_text2";
            this.pass_text2.Size = new System.Drawing.Size(88, 26);
            this.pass_text2.TabIndex = 163;
            // 
            // login_text2
            // 
            this.login_text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_text2.Location = new System.Drawing.Point(511, 202);
            this.login_text2.Name = "login_text2";
            this.login_text2.Size = new System.Drawing.Size(88, 26);
            this.login_text2.TabIndex = 162;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(721, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 161;
            this.label4.Text = "Роль";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(618, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 160;
            this.label5.Text = "Пароль";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(522, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.TabIndex = 159;
            this.label6.Text = "Логин";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete.ForeColor = System.Drawing.Color.Black;
            this.delete.Location = new System.Drawing.Point(547, 365);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(232, 38);
            this.delete.TabIndex = 168;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // id_text3
            // 
            this.id_text3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_text3.Location = new System.Drawing.Point(615, 321);
            this.id_text3.Name = "id_text3";
            this.id_text3.ReadOnly = true;
            this.id_text3.Size = new System.Drawing.Size(88, 26);
            this.id_text3.TabIndex = 167;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(648, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 24);
            this.label7.TabIndex = 166;
            this.label7.Text = "id";
            // 
            // id_text2
            // 
            this.id_text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_text2.Location = new System.Drawing.Point(610, 146);
            this.id_text2.Name = "id_text2";
            this.id_text2.ReadOnly = true;
            this.id_text2.Size = new System.Drawing.Size(88, 26);
            this.id_text2.TabIndex = 169;
            this.id_text2.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Логин";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Пароль";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Роль";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            // 
            // usersDataBindingSource
            // 
            this.usersDataBindingSource.DataSource = typeof(LibraryApp.UsersData);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(527, 423);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(264, 15);
            this.label8.TabIndex = 170;
            this.label8.Text = "Роли (1 - библиотекарь 2 - студент 3-админ)";
            // 
            // main3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.id_text2);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.id_text3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.change);
            this.Controls.Add(this.role_text2);
            this.Controls.Add(this.pass_text2);
            this.Controls.Add(this.login_text2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.add);
            this.Controls.Add(this.role_text1);
            this.Controls.Add(this.pass_text1);
            this.Controls.Add(this.login_text1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "main3";
            this.Text = "main3";
            this.Load += new System.EventHandler(this.main3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox login_text1;
        private System.Windows.Forms.TextBox pass_text1;
        private System.Windows.Forms.TextBox role_text1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.TextBox role_text2;
        private System.Windows.Forms.TextBox pass_text2;
        private System.Windows.Forms.TextBox login_text2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox id_text3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox id_text2;
        private System.Windows.Forms.BindingSource usersDataBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
    }
}