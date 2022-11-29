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
    public partial class Students_main1 : Form
    {
        int ID1 = 0;
        public Students_main1()
        {
            InitializeComponent();
            dataGridView1.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(dataGridView1_RowHeaderMouseClick);
        }

        private void Students_main1_Load(object sender, EventArgs e)
        {
            Table_refresh();
            group_combo.DataSource = DB.DataBase.Groups.ToList();
            group_combo.DisplayMember = "Group";
            group_combo.ValueMember = "id";

            gender_combo.DataSource = DB.DataBase.Genders.ToList();
            gender_combo.DisplayMember = "Gender";
            gender_combo.ValueMember = "id";

            group_combo2.DataSource = DB.DataBase.Groups.ToList();
            group_combo2.DisplayMember = "Group";
            group_combo2.ValueMember = "id";

            gender_combo2.DataSource = DB.DataBase.Genders.ToList();
            gender_combo2.DisplayMember = "Gender";
            gender_combo2.ValueMember = "id";
        }
        private void Table_refresh()
        {
            DB.DataBase.Students.Load();
            DB.DataBase.Students.Include(t => t.Group).Load();
            DB.DataBase.Students.Include(t => t.Gender).Load();
            dataGridView1.DataSource = DB.DataBase.Students.Local.ToBindingList();
        }

        private void add_Click(object sender, EventArgs e)
        {
            Students student = new Students();
            student.Name = Name_text.Text;
            student.Surname = Surname_text.Text;
            student.Lastname = Lastname_text.Text;
            student.Address = Address_text.Text;
            student.DateOfBirth = Date_of_birth_text.Text;
            student.GenderId = Convert.ToInt32(gender_combo.SelectedValue.ToString());
            student.GroupId = Convert.ToInt32(group_combo.SelectedValue.ToString());
            student.RegDate = DateTime.ParseExact(Reg_date_text.Text,"dd.MM.yyyy",null);
            DB.DataBase.Students.Add(student);
            DB.DataBase.SaveChanges();
            MessageBox.Show("Студент успешно добавлен");
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID1 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            Name_text2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Surname_text2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Lastname_text2.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            Address_text2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            Date_of_birth_text2.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            Reg_date_text2.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            id_text3.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            id_text2.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void change_Click(object sender, EventArgs e)
        {
            Students student = DB.DataBase.Students.FirstOrDefault(b => b.Id == Convert.ToInt32(id_text2.Text));
            student.Name = Name_text2.Text;
            student.Surname = Surname_text2.Text;
            student.Lastname = Lastname_text2.Text;
            student.Address = Address_text2.Text;
            student.DateOfBirth = Date_of_birth_text2.Text;
            student.GenderId = Convert.ToInt32(gender_combo2.SelectedValue.ToString());
            student.GroupId = Convert.ToInt32(group_combo2.SelectedValue.ToString());
            student.RegDate = DateTime.ParseExact(Reg_date_text2.Text, "dd.MM.yyyy", null);
            DB.DataBase.SaveChanges();
            dataGridView1.Refresh();
            MessageBox.Show("Студент изменен");
        }

        private void delete_Click(object sender, EventArgs e)
        {
            Students student = DB.DataBase.Students.FirstOrDefault(b => b.Id == Convert.ToInt32(id_text3.Text));
            if (student != null)
            {
                DB.DataBase.Students.Remove(student);
            }
            DB.DataBase.SaveChanges();
        }
    }
}
