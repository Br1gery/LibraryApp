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

namespace LibraryApp
{
    public partial class Main1 : Form
    {
        Thread th;
        public Main1()
        {
            InitializeComponent();
        }

        private void exit_main1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        public void open(object obj)
        {
            Application.Run(new Form1());
        }

        private void examples_main1_Click(object sender, EventArgs e)
        {
            Ex_main1 ex_Main1 = new Ex_main1();
            ex_Main1.Show();
        }

        private void books_main1_Click(object sender, EventArgs e)
        {
            Books_main1 books_Main1 = new Books_main1();
            books_Main1.Show();
        }

        private void Students_button_Click(object sender, EventArgs e)
        {
            Students_main1 students_Main1 = new Students_main1();
            students_Main1.Show();
        }

        private void authors_main1_Click(object sender, EventArgs e)
        {
            Authors_main1 authors_Main1 = new Authors_main1();
            authors_Main1.Show();
        }

        private void genres_main1_Click(object sender, EventArgs e)
        {
            Genres_main1 genres_Main1 = new Genres_main1();
            genres_Main1.Show();
        }

        private void publishers_main1_Click(object sender, EventArgs e)
        {
            Publishers_main1 publishers_Main1 = new Publishers_main1();
            publishers_Main1.Show();
        }
    }
}
