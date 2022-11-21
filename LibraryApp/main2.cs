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
    public partial class main2 : Form
    {
        Thread th;
        public main2()
        {
            InitializeComponent();
        }

        private void exit_main2_Click(object sender, EventArgs e)
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

        private void examples_main2_Click(object sender, EventArgs e)
        {
            Ex_main2 ex_main2 = new Ex_main2();
            ex_main2.Show();
        }

        private void Books_main2_Click(object sender, EventArgs e)
        {
            Books_main2 books_main2 = new Books_main2();
            books_main2.Show();
        }
    }
}
