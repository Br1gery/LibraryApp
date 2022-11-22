using System;
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
        public Books_main1()
        {
            InitializeComponent();
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
            Authors authors = new Authors();
            book.Name = Name_text.Text;
            book.RelYear = Convert.ToInt32(Rel_year_text.Text);
            book.Pages = Convert.ToInt32(Pages_text.Text);
            book.Description = Description_text.Text;
            book.AuthorId = Convert.ToInt32(author_id_combo.SelectedValue.ToString());
            book.GenreId = Convert.ToInt32(genre_id_combo.SelectedValue.ToString());
            book.PublisherId = Convert.ToInt32(publisher_id_combo.SelectedValue.ToString());
            DB.DataBase.Add(book);
            DB.DataBase.SaveChanges();
            MessageBox.Show("Книга успешно добавлена");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
