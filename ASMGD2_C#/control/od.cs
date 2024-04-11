using BLL;
using DTO.Models;
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
    public partial class od : UserControl
    {
        DataTable dt = new DataTable();
        DBASMBLL DBASMBLL = new DBASMBLL();
        public od()
        {
            InitializeComponent();
        }

        private void od_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Orderdate", typeof(DateTime));
            dt.Columns.Add("OrderNumber", typeof(string));
            dt.Columns.Add("CustomerId", typeof(int));
            dt.Columns.Add("TotalAmount", typeof(decimal));
            Getvalues();
        }
        
        private void Getvalues()
        {
            foreach (var i in DBASMBLL.GetOrdersALLBLL().ToList())
            {
                DataRow dr = dt.NewRow();
                dr["ID"] = i.Id;
                dr["Orderdate"] = i.OrderDate;
                dr["OrderNumber"] = i.OrderNumber;
                dr["CustomerId"] = i.CustomerId;
                dr["TotalAmount"] = i.TotalAmount;
                dt.Rows.Add(dr);
            }
            dgvOd.DataSource = dt;
            foreach (var i in DBASMBLL.GetCustomersALLBLL().ToList())
            {
                cbbctms.Items.Add(i.FirstName + " " + i.LastName);
            }
        }
        public OrderItem GetOrderItemById(int id)
        {
            foreach(var i in DBASMBLL.GetOrderItemsALLBLL().ToList())
            {
                if (i.OrderId.Equals(id))
                {
                    return i;
                }
            }
            return null;
        }
        private Customer GetCustomerByID(int id)
        {
            foreach (var i in DBASMBLL.GetCustomersALLBLL().ToList())
            {
                if (i.Id.Equals(id))
                {
                    return i;
                }

            }
            return null;
        }
        private void dgvOd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataGridViewRow = dgvOd.Rows[e.RowIndex];
            txtID.Text = dataGridViewRow.Cells[0].Value.ToString();
            dtpOrderdate.Value = (DateTime)dataGridViewRow.Cells[1].Value;
            txtOrderNumber.Text = dataGridViewRow.Cells[2].Value.ToString();
            cbbctms.SelectedItem = GetCustomerByID(Convert.ToInt32(dataGridViewRow.Cells[3].Value.ToString())).FirstName + " " + GetCustomerByID(Convert.ToInt32(dataGridViewRow.Cells[3].Value.ToString())).LastName;
            txtTotal.Text = dataGridViewRow.Cells[4].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtOrderNumber.Text == "" || txtTotal.Text == ""||cbbctms.SelectedItem=="")
            {
                MessageBox.Show("Nhap thieu thong tin!!");
            }
            else
            {
                var orderdatee = dtpOrderdate.Value;
                var orderNumberr = txtOrderNumber.Text;
                var Cs = cbbctms.SelectedItem.ToString();
                var totall = txtTotal.Text;
                DBASMBLL.ADDOrder(orderdatee, orderNumberr, Cs, totall);
                dt.Clear();
                Getvalues();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var i = txtID.Text;
            DBASMBLL.removeOrder(i);
            dt.Clear();
            Getvalues();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var idd = txtID.Text;
            var orDatebe = dtpOrderdate.Value;
            var orNumbe = txtOrderNumber.Text;
            var ccbe = cbbctms.SelectedItem.ToString();
            var totalbe = txtTotal.Text;
            DBASMBLL.UpdateOrder(idd, orDatebe, orNumbe, ccbe, totalbe);
            dt.Clear();
            Getvalues();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
                try
                {
                    FileStream f = new FileStream("C#", FileMode.OpenOrCreate);
                    StreamWriter wr = new StreamWriter(f);
                    wr.WriteLine($"Id {txtID.Text} " );
                    wr.WriteLine("NumBer: " + txtOrderNumber.Text );
                    wr.WriteLine("Ngay:  " + dtpOrderdate.Value);
                    wr.WriteLine("Ten : " + cbbctms.Text);
                    wr.WriteLine("total :  " + txtTotal.Text );
                    wr.WriteLine("orderItem Id: "+ GetOrderItemById(Convert.ToInt32(txtID.Text)).Id);
                    wr.WriteLine("Product Id : "+ GetOrderItemById(Convert.ToInt32(txtID.Text)).ProductId);
                    wr.WriteLine("UnitPrice : "+ GetOrderItemById(Convert.ToInt32(txtID.Text)).UnitPrice);
                    wr.WriteLine("Quantity : "+ GetOrderItemById(Convert.ToInt32(txtID.Text)).Quantity);
                    wr.Close();
                    f.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            Detail detailForm = new Detail();
            detailForm.ShowDialog();


        }

    }
}
