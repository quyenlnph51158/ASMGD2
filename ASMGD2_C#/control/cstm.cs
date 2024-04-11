using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASMGD2_C_.control
{
    public partial class cstm : UserControl
    {
        public DataTable dt = new DataTable();
        DBASMBLL db = new DBASMBLL();
        public cstm()
        {
            InitializeComponent();
        }
        private void GETvaluesCTSM()
        {
            foreach (var i in db.GetCustomersALLBLL().ToList())
            {
                DataRow dr = dt.NewRow();
                dr["ID"] = i.Id;
                dr["FirstName"] = i.FirstName;
                dr["LastName"] = i.LastName;
                dr["City"] = i.City;
                dr["Country"] = i.Country;
                dr["Phone"] = i.Phone;
                dt.Rows.Add(dr);
            }


        }
        private void customer_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("FirstName", typeof(string));
            dt.Columns.Add("LastName", typeof(string));
            dt.Columns.Add("City", typeof(string));
            dt.Columns.Add("Country", typeof(string));
            dt.Columns.Add("Phone", typeof(string));
            GETvaluesCTSM();
            dgvCTSM.DataSource = dt;
        }




        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "" || txtLastName.Text == "" || txtCity.Text == "" || txtCountry.Text == "" || txtPhone.Text=="")
            {
                MessageBox.Show("Nhap thieu du lieu!!");
            }

            else 
            {
                var fn = txtFirstName.Text;
                var ln = txtLastName.Text;
                var city = txtCity.Text;
                var country = txtCountry.Text;
                var phone = txtPhone.Text;
                db.ADDCustomer(fn, ln, city, country, phone);
                dt.Clear();
                GETvaluesCTSM();
            }
        }

        private void dgvCTSM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow RowHienTai = dgvCTSM.Rows[e.RowIndex];
            txtID.Text = RowHienTai.Cells[0].Value.ToString();
            txtFirstName.Text = RowHienTai.Cells[1].Value.ToString();
            txtLastName.Text = RowHienTai.Cells[2].Value.ToString();
            txtCity.Text = RowHienTai.Cells[3].Value.ToString();
            txtCountry.Text = RowHienTai.Cells[4].Value.ToString();
            txtPhone.Text = RowHienTai.Cells[5].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var idd = txtID.Text;
            db.RemoveCTMS(idd);
            dt.Clear();
            GETvaluesCTSM();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtCity.Text = "";
            txtCountry.Text = "";
            txtPhone.Text = "";

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var i= txtID.Text;
            var fn = txtFirstName.Text;
            var ln = txtLastName.Text;
            var city = txtCity.Text;
            var country = txtCountry.Text;
            var phone = txtPhone.Text;
            db.UpdateCTMS(i,fn, ln, city, country, phone);
            dt.Clear();
            GETvaluesCTSM();
        }
    }
}
