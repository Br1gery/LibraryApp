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
    public partial class Pass_change : Form
    {
        public Pass_change()
        {
            InitializeComponent();
        }

        private void Pass_change_Load(object sender, EventArgs e)
        {
            DB.DataBase.UsersData.Load();
        }

        private void change_Click(object sender, EventArgs e)
        {
            UsersData usersData = DB.DataBase.UsersData.FirstOrDefault(b => b.Login == login_change.Text);
            if (usersData == null)
            {
                MessageBox.Show("Пользователь не найден");
                return;
            }
            if (BCrypt.Net.BCrypt.Verify(old_pass.Text, usersData.Password))
            {
                if (usersData != null)
                {
                    usersData.Password = BCrypt.Net.BCrypt.HashPassword(new_pass.Text);
                    MessageBox.Show("Пароль изменен");
                }
                DB.DataBase.SaveChanges();
            }
        }
    }
}
