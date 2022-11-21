namespace LibraryApp
{
    partial class Main1
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
            this.exit_main1 = new System.Windows.Forms.Button();
            this.examples_main1 = new System.Windows.Forms.Button();
            this.Students_button = new System.Windows.Forms.Button();
            this.books_main1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exit_main1
            // 
            this.exit_main1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.exit_main1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_main1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit_main1.ForeColor = System.Drawing.Color.Black;
            this.exit_main1.Location = new System.Drawing.Point(1069, 637);
            this.exit_main1.Name = "exit_main1";
            this.exit_main1.Size = new System.Drawing.Size(185, 33);
            this.exit_main1.TabIndex = 13;
            this.exit_main1.Text = "Выйти из аккаунта";
            this.exit_main1.UseVisualStyleBackColor = false;
            this.exit_main1.Click += new System.EventHandler(this.exit_main1_Click);
            // 
            // examples_main1
            // 
            this.examples_main1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.examples_main1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.examples_main1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.examples_main1.ForeColor = System.Drawing.Color.Black;
            this.examples_main1.Location = new System.Drawing.Point(466, 133);
            this.examples_main1.Name = "examples_main1";
            this.examples_main1.Size = new System.Drawing.Size(305, 66);
            this.examples_main1.TabIndex = 12;
            this.examples_main1.Text = "Экземпляры";
            this.examples_main1.UseVisualStyleBackColor = false;
            this.examples_main1.Click += new System.EventHandler(this.examples_main1_Click);
            // 
            // Students_button
            // 
            this.Students_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Students_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Students_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Students_button.ForeColor = System.Drawing.Color.Black;
            this.Students_button.Location = new System.Drawing.Point(466, 431);
            this.Students_button.Name = "Students_button";
            this.Students_button.Size = new System.Drawing.Size(305, 66);
            this.Students_button.TabIndex = 11;
            this.Students_button.Text = "Студенты";
            this.Students_button.UseVisualStyleBackColor = false;
            this.Students_button.Click += new System.EventHandler(this.Students_button_Click);
            // 
            // books_main1
            // 
            this.books_main1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.books_main1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.books_main1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.books_main1.ForeColor = System.Drawing.Color.Black;
            this.books_main1.Location = new System.Drawing.Point(466, 283);
            this.books_main1.Name = "books_main1";
            this.books_main1.Size = new System.Drawing.Size(305, 66);
            this.books_main1.TabIndex = 10;
            this.books_main1.Text = "Книги";
            this.books_main1.UseVisualStyleBackColor = false;
            this.books_main1.Click += new System.EventHandler(this.books_main1_Click);
            // 
            // Main1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.exit_main1);
            this.Controls.Add(this.examples_main1);
            this.Controls.Add(this.Students_button);
            this.Controls.Add(this.books_main1);
            this.Name = "Main1";
            this.Text = "Main1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exit_main1;
        private System.Windows.Forms.Button examples_main1;
        private System.Windows.Forms.Button Students_button;
        private System.Windows.Forms.Button books_main1;
    }
}