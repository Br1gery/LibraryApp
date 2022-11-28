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
    public partial class Publishers_main1 : Form
    {
        int ID1 = 0;
        public Publishers_main1()
        {
            InitializeComponent();
            dataGridView1.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(dataGridView1_RowHeaderMouseClick);
        }

        private void Table_refresh()
        {
            dataGridView1.DataSource = DB.DataBase.Publishers.Local.ToBindingList();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID1 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            name_text2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            id_text2.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            id_text3.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void Publishers_main1_Load(object sender, EventArgs e)
        {
            Table_refresh();
            DB.DataBase.Publishers.Load();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Publishers publisher = new Publishers();
            publisher.Publisher = Name_text.Text;
            DB.DataBase.Publishers.Add(publisher);
            DB.DataBase.SaveChanges();
            MessageBox.Show("Издатель добавлен");
        }

        private void Change_Click(object sender, EventArgs e)
        {
            Publishers publisher = DB.DataBase.Publishers.FirstOrDefault(b => b.Id == Convert.ToInt32(id_text2.Text));
            publisher.Publisher = name_text2.Text;
            DB.DataBase.SaveChanges();
            dataGridView1.Refresh();
            MessageBox.Show("Издатель изменен");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Publishers publisher = DB.DataBase.Publishers.FirstOrDefault(b => b.Id == Convert.ToInt32(id_text3.Text));
            if (publisher != null)
            {
                DB.DataBase.Publishers.Remove(publisher);
            }
            DB.DataBase.SaveChanges();
            MessageBox.Show("Издатель удален");
        }
    }
}
