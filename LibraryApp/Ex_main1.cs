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
    public partial class Ex_main1 : Form
    {
        int ID1 = 0;
        public Ex_main1()
        {
            InitializeComponent();
            dataGridView1.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(dataGridView1_RowHeaderMouseClick);
        }

        private void Table_refresh()
        {
            DB.DataBase.Examples.Load();
            DB.DataBase.Examples.Include(t => t.Location).Load();
            DB.DataBase.Examples.Include(t => t.Book).Load();
            dataGridView1.DataSource = DB.DataBase.Examples.Local.ToBindingList();
        }

        private void Ex_main1_Load(object sender, EventArgs e)
        {
            Table_refresh();

            loc_combo.DataSource = DB.DataBase.Locations.ToList();
            loc_combo.DisplayMember = "Location";
            loc_combo.ValueMember = "id";

            book_combo.DataSource = DB.DataBase.Books.ToList();
            book_combo.DisplayMember = "Name";
            book_combo.ValueMember = "id";

            Owner_combo1.DataSource = DB.DataBase.Students.ToList();
            Owner_combo1.DisplayMember = "Name";
            Owner_combo1.ValueMember = "id";

            loc__combo2.DataSource = DB.DataBase.Locations.ToList();
            loc__combo2.DisplayMember = "Location";
            loc__combo2.ValueMember = "id";

            book_combo2.DataSource = DB.DataBase.Books.ToList();
            book_combo2.DisplayMember = "Name";
            book_combo2.ValueMember = "id";

            Owner_combo2.DataSource = DB.DataBase.Students.ToList();
            Owner_combo2.DisplayMember = "Name";
            Owner_combo2.ValueMember = "id";
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID1 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            Shelf_text2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Issue_date_text2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString().Split(' ')[0];
            Experation_date_text2.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString().Split(' ')[0];
            Delivery_date_text2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString().Split(' ')[0];
            id_text2.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            id_text3.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void add_Click(object sender, EventArgs e)
        {
            Examples example = new Examples();
            example.LocationId = Convert.ToInt32(loc_combo.SelectedValue.ToString());
            example.OwnderId = Convert.ToInt32(Owner_combo1.SelectedValue.ToString());
            example.BookId = Convert.ToInt32(book_combo.SelectedValue.ToString());
            example.Shelf = Shelf__text.Text;
            example.IssueDate = DateTime.ParseExact(Issue_date_text.Text, "dd.MM.yyyy", null);
            example.ExpDate = DateTime.ParseExact(Experation_date_text.Text, "dd.MM.yyyy", null);
            example.DeliveryDate = DateTime.ParseExact(Delivery_date_text.Text, "dd.MM.yyyy", null);
            DB.DataBase.Examples.Add(example);
            DB.DataBase.SaveChanges();
            MessageBox.Show("Экземпляр успешно добавлена");
        }

        private void change_ex_Click(object sender, EventArgs e)
        {
            Examples example = DB.DataBase.Examples.FirstOrDefault(b => b.Id == Convert.ToInt32(id_text2.Text));
            example.LocationId = Convert.ToInt32(loc__combo2.SelectedValue.ToString());
            example.OwnderId = Convert.ToInt32(Owner_combo2.SelectedValue.ToString());
            example.BookId = Convert.ToInt32(book_combo2.SelectedValue.ToString());
            example.Shelf = Shelf_text2.Text;
            example.IssueDate = DateTime.ParseExact(Issue_date_text2.Text, "dd.MM.yyyy", null);
            example.ExpDate = DateTime.ParseExact(Experation_date_text2.Text, "dd.MM.yyyy", null);
            example.DeliveryDate = DateTime.ParseExact(Delivery_date_text2.Text, "dd.MM.yyyy", null);
            DB.DataBase.SaveChanges();
            dataGridView1.Refresh();
            MessageBox.Show("Экземпляр изменен");
        }

        private void delete_Click(object sender, EventArgs e)
        {
            Examples example = DB.DataBase.Examples.FirstOrDefault(b => b.Id == Convert.ToInt32(id_text3.Text));
            if (example != null)
            {
                DB.DataBase.Examples.Remove(example);
            }
            DB.DataBase.SaveChanges();
        }
    }
}
