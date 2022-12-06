using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using BCrypt;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp
{
    public partial class Form1 : Form
    {
        Thread th;
        Thread th1;
        Thread th2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Log_in_Click(object sender, EventArgs e)
        {
            UsersData user = DB.DataBase.UsersData.FirstOrDefault(u => u.Login == Login_log_screen.Text);
            if (user == null)
            {
                MessageBox.Show("Пользователь не найден");
                return;
            }
            if (BCrypt.Net.BCrypt.Verify(Password_log_screen.Text, user.Password))
            {
                if (user.Role == 1)
                {
                    this.Close();
                    th = new Thread(open);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                if (user.Role == 2)
                {
                    this.Close();
                    th1 = new Thread(open1);
                    th1.SetApartmentState(ApartmentState.STA);
                    th1.Start();
                }
                if (user.Role == 3)
                {
                    this.Close();
                    th2 = new Thread(open2);
                    th2.SetApartmentState(ApartmentState.STA);
                    th2.Start();
                }
                MessageBox.Show("Пользователь не найден");
            }
            MessageBox.Show("Неверный пароль");
        }
        public void open(object obj)
        {
            Application.Run(new Main1());
        }
        public void open1(object obj1)
        {
            Application.Run(new main2());
        }
        public void open2(object obj2)
        {
            Application.Run(new main3());
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
