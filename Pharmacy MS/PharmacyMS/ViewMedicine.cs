using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PharmacyMS
{
    public partial class ViewMedicine : Form
    {
        public ViewMedicine()
        {
            InitializeComponent();
        }

        private void butLogout_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            this.Hide();
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            AddMedicine am = new AddMedicine();
            am.Show();
            this.Hide();
        }

        private void btnViewMedicine_Click(object sender, EventArgs e)
        {
            //ViewMedicine vm = new ViewMedicine();
            //vm.Show();
            //this.Close();

            var medicines = GetAllMedicines();
            dtMedicines.DataSource = medicines;
        }
        List<Medicine> GetAllMedicines()
        {
            string connString = @"Server=DESKTOP-9IIAKR5\SQLEXPRESS; Database=PharmacyMS; Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);

            List<Medicine> medicines = new List<Medicine>();
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string query = "select * from Medicine";
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Medicine m = new Medicine();
                    m.mid = reader.GetString(reader.GetOrdinal("Medicine_ID"));
                    m.mname = reader.GetString(reader.GetOrdinal("Medicine_Name"));
                    m.number = reader.GetString(reader.GetOrdinal("Number"));
                    m.quantity = reader.GetInt32(reader.GetOrdinal("Quantity"));
                    m.mdate = reader.GetString(reader.GetOrdinal("mDate"));
                    m.edate = reader.GetString(reader.GetOrdinal("eDate"));
                    m.price = reader.GetInt32(reader.GetOrdinal("Price_Per_Unit"));
                    medicines.Add(m);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            return medicines;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var medicines = GetAllMedicines();
            dtMedicines.DataSource = medicines;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var medicines = GetAllMedicines();
            dtMedicines.DataSource = medicines;
        }

        private void btnModifyMedicine_Click(object sender, EventArgs e)
        {
            ModifyMedicine mf = new ModifyMedicine();
            mf.Show();
            this.Close();
        }
    }
}
