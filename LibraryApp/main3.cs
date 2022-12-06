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
    public partial class main3 : Form
    {
        int ID1=0;
        public main3()
        {
            InitializeComponent();
            dataGridView1.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(dataGridView1_RowHeaderMouseClick);
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID1 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            id_text2.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            login_text2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            role_text2.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            id_text3.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void add_Click(object sender, EventArgs e)
        {
            UsersData user = new UsersData();
            user.Login = login_text1.Text;
            user.Password = BCrypt.Net.BCrypt.HashPassword(pass_text1.Text);
            user.Role = Convert.ToInt32(role_text1.Text);
            DB.DataBase.UsersData.Add(user);
            DB.DataBase.SaveChanges();
            MessageBox.Show("Пользователь добавлен");
        }

        private void change_Click(object sender, EventArgs e)
        {
            UsersData user = DB.DataBase.UsersData.FirstOrDefault(b => b.Id == Convert.ToInt32(id_text2.Text));
            user.Login = login_text2.Text;
            user.Password = BCrypt.Net.BCrypt.HashPassword(pass_text2.Text);
            user.Role = Convert.ToInt32(role_text2.Text);
            DB.DataBase.SaveChanges();
            dataGridView1.Refresh();
            MessageBox.Show("Пользователь успешно изменен");
        }

        private void delete_Click(object sender, EventArgs e)
        {
            UsersData user = DB.DataBase.UsersData.FirstOrDefault(b => b.Id == Convert.ToInt32(id_text3.Text));
            if (user != null)
            {
                DB.DataBase.UsersData.Remove(user);
            }
            DB.DataBase.SaveChanges();
        }

        private void main3_Load(object sender, EventArgs e)
        {
            Table_refresh();
        }

        private void Table_refresh()
        {
            DB.DataBase.UsersData.Load();
            dataGridView1.DataSource = DB.DataBase.UsersData.Local.ToBindingList();
        }
    }
}
