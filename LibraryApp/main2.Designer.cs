namespace LibraryApp
{
    partial class main2
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
            this.exit_main2 = new System.Windows.Forms.Button();
            this.Books_main2 = new System.Windows.Forms.Button();
            this.examples_main2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exit_main2
            // 
            this.exit_main2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.exit_main2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_main2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit_main2.ForeColor = System.Drawing.Color.Black;
            this.exit_main2.Location = new System.Drawing.Point(1065, 634);
            this.exit_main2.Name = "exit_main2";
            this.exit_main2.Size = new System.Drawing.Size(185, 33);
            this.exit_main2.TabIndex = 14;
            this.exit_main2.Text = "Выйти из аккаунта";
            this.exit_main2.UseVisualStyleBackColor = false;
            this.exit_main2.Click += new System.EventHandler(this.exit_main2_Click);
            // 
            // Books_main2
            // 
            this.Books_main2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Books_main2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Books_main2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Books_main2.ForeColor = System.Drawing.Color.Black;
            this.Books_main2.Location = new System.Drawing.Point(474, 377);
            this.Books_main2.Name = "Books_main2";
            this.Books_main2.Size = new System.Drawing.Size(305, 66);
            this.Books_main2.TabIndex = 13;
            this.Books_main2.Text = "Книги";
            this.Books_main2.UseVisualStyleBackColor = false;
            this.Books_main2.Click += new System.EventHandler(this.Books_main2_Click);
            // 
            // examples_main2
            // 
            this.examples_main2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.examples_main2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.examples_main2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.examples_main2.ForeColor = System.Drawing.Color.Black;
            this.examples_main2.Location = new System.Drawing.Point(474, 217);
            this.examples_main2.Name = "examples_main2";
            this.examples_main2.Size = new System.Drawing.Size(305, 66);
            this.examples_main2.TabIndex = 12;
            this.examples_main2.Text = "Экземпляры";
            this.examples_main2.UseVisualStyleBackColor = false;
            this.examples_main2.Click += new System.EventHandler(this.examples_main2_Click);
            // 
            // main2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.exit_main2);
            this.Controls.Add(this.Books_main2);
            this.Controls.Add(this.examples_main2);
            this.Name = "main2";
            this.Text = "main2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exit_main2;
        private System.Windows.Forms.Button Books_main2;
        private System.Windows.Forms.Button examples_main2;
    }
}