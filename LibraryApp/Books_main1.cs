﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp
{
    public partial class Books_main1 : Form
    {
        int ID1 = 0;
        public Books_main1()
        {
            InitializeComponent();
            dataGridView1.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(dataGridView1_RowHeaderMouseClick);
        }

        private void Books_main1_Load(object sender, EventArgs e)
        {
            Table_refresh();
            author_id_combo.DataSource = DB.DataBase.Authors.ToList();
            author_id_combo.DisplayMember = "Author";
            author_id_combo.ValueMember = "id";

            genre_id_combo.DataSource = DB.DataBase.Genres.ToList();
            genre_id_combo.DisplayMember = "Genre";
            genre_id_combo.ValueMember = "id";

            publisher_id_combo.DataSource = DB.DataBase.Publishers.ToList();
            publisher_id_combo.DisplayMember = "Publisher";
            publisher_id_combo.ValueMember = "id";

            author_id_combo2.DataSource = DB.DataBase.Authors.ToList();
            author_id_combo2.DisplayMember = "Author";
            author_id_combo2.ValueMember = "id";

            genre_id_combo2.DataSource = DB.DataBase.Genres.ToList();
            genre_id_combo2.DisplayMember = "Genre";
            genre_id_combo2.ValueMember = "id";

            publisher_id_combo2.DataSource = DB.DataBase.Publishers.ToList();
            publisher_id_combo2.DisplayMember = "Publisher";
            publisher_id_combo2.ValueMember = "id";
        }

        private void Table_refresh()
        {
            DB.DataBase.Books.Load();
            DB.DataBase.Books.Include(t => t.Author).Load();
            DB.DataBase.Books.Include(t => t.Genre).Load();
            DB.DataBase.Books.Include(t => t.Publisher).Load();
            dataGridView1.DataSource = DB.DataBase.Books.Local.ToBindingList();
        }

        private void add_Click(object sender, EventArgs e)
        {
            Books book = new Books();
            book.Name = Name_text.Text;
            book.RelYear = Convert.ToInt32(Rel_year_text.Text);
            book.Pages = Convert.ToInt32(Pages_text.Text);
            book.Description = Description_text.Text;
            book.AuthorId = Convert.ToInt32(author_id_combo.SelectedValue.ToString());
            book.GenreId = Convert.ToInt32(genre_id_combo.SelectedValue.ToString());
            book.PublisherId = Convert.ToInt32(publisher_id_combo.SelectedValue.ToString());
            DB.DataBase.Books.Add(book);
            DB.DataBase.SaveChanges();
            MessageBox.Show("Книга успешно добавлена");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void change_Click(object sender, EventArgs e)
        {
            Books book = DB.DataBase.Books.FirstOrDefault(b => b.Id == Convert.ToInt32(Id_text2.Text));
            book.Name = Name_text2.Text;
            book.RelYear = Convert.ToInt32(Rel_year_text2.Text);
            book.Pages = Convert.ToInt32(Pages_text2.Text);
            book.Description = Description_text2.Text;
            book.AuthorId = Convert.ToInt32(author_id_combo2.SelectedValue.ToString());
            book.GenreId = Convert.ToInt32(genre_id_combo2.SelectedValue.ToString());
            book.PublisherId = Convert.ToInt32(publisher_id_combo2.SelectedValue.ToString());
            DB.DataBase.SaveChanges();
            dataGridView1.Refresh();
            MessageBox.Show("Книга успешно изменена");
        }

        private void delete_Click(object sender, EventArgs e)
        {
            Books book = DB.DataBase.Books.FirstOrDefault(b => b.Id == Convert.ToInt32(id_text3.Text));
            if (book!=null)
            {
                DB.DataBase.Books.Remove(book);
            }
            DB.DataBase.SaveChanges();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID1 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            Id_text2.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Name_text2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Rel_year_text2.Text= dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Pages_text2.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            Description_text2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            id_text3.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
