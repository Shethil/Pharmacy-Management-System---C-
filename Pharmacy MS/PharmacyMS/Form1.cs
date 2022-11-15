using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSingIn_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "shethil" && txtPassword.Text == "1234")
            {
                Admin tx = new Admin();
                tx.Show();

                this.Hide();
            }


            else
            {
                MessageBox.Show("Wrong user name or password");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }
