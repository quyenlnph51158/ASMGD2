using BLL;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASMGD2_C_.control
{
    public partial class BanHang : UserControl
    {
        DataTable dt = new DataTable();
        DBASMBLL db = new DBASMBLL();
        private int index1;
        public BanHang()
        {
            InitializeComponent();
        }

        private void BanHang_Load(object sender, EventArgs e)
        {

            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("ProductName", typeof(string));
            dt.Columns.Add("SupplierId", typeof(int));
            dt.Columns.Add("UnitPrice", typeof(decimal));
            dt.Columns.Add("Package", typeof(string));
            dt.Columns.Add("IsDiscontinued", typeof(bool));

            foreach (var i in db.GetProductsALLBLL().ToList())
            {
                DataRow dr = dt.NewRow();
                dr["Id"] = i.Id;
                dr["ProductName"] = i.ProductName;
                dr["SupplierId"] = i.SupplierId;
                dr["UnitPrice"] = i.UnitPrice;
                dr["Package"] = i.Package;
                dr["IsDiscontinued"] = i.IsDiscontinued;
                dt.Rows.Add(dr);
            }
            dgvBanHang.DataSource = dt;
            foreach (var i in db.GetCustomersALLBLL())
            {
                cbbCustomerID.Items.Add(i.FirstName + " " + i.LastName);
            }

        }
        private Product GetProductByName(string name)
        {
            foreach (var i in db.GetProductsALLBLL().ToList())
            {
                if (i.ProductName == name)
                {
                    return i;
                }
            }
            return null;
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dt.Clear();

            foreach (var i in db.GetProductBySearchName(txtSearch.Text).ToList())
            {
                DataRow dr = dt.NewRow();
                dr["Id"] = i.Id;
                dr["ProductName"] = i.ProductName;
                dr["SupplierId"] = i.SupplierId;
                dr["UnitPrice"] = i.UnitPrice;
                dr["Package"] = i.Package;
                dr["IsDiscontinued"] = i.IsDiscontinued;
                dt.Rows.Add(dr);
            }
            dgvBanHang.DataSource = dt;
        }

        private void dgvBanHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvBanHang.Rows[e.RowIndex];

        }

        private void dgvBanHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow rowDangChon = dgvBanHang.Rows[e.RowIndex];
            cbbSelectedProduct.Items.Add(rowDangChon.Cells[1].Value.ToString()).ToString();
            index1 = e.RowIndex;
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {







        }

        private void btnOK2_Click(object sender, EventArgs e)
        {
            txtOrderID.Text = db.GetOrdersALLBLL().ToList().Max(i => i.Id).ToString();

            var i = txtOrderID.Text;
            var o = txtProductID.Text;
            var t = Convert.ToDecimal(db.GetProductByName(cbbSelectedProduct.SelectedItem.ToString()).UnitPrice);
            var y = txtQuantity.Text;
            db.addOrderItem(i, o, t, y);
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void btnOK1_Click(object sender, EventArgs e)
        {
            var i = dtpOrderDate.Value;
            var o = txtOrderNumber.Text;
            var u = cbbCustomerID.Text;
            var y = txtTotalAmount.Text;
            //txtUnitPrice.Text = db.GetProductByName(cbbSelectedProduct.SelectedItem.ToString()).UnitPrice * ;
            db.ADDOrder(i, o, u, y);
            var l = cbbSelectedProduct.SelectedItem.ToString();
            txtUnitPrice.Text= db.GetProductByName(cbbSelectedProduct.SelectedItem.ToString()).UnitPrice.ToString();
            txtProductID.Text = GetProductByName(l).Id.ToString();
            txtOrderID.Text = db.GetOrdersALLBLL().ToList().Max(i => i.Id).ToString();
            txtQuantity.Text = txtquan.Text;
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txtTotalAmount_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtquan_TextChanged(object sender, EventArgs e)
        {
            txtTotalAmount.Text = (db.GetProductByName(cbbSelectedProduct.SelectedItem.ToString()).UnitPrice * Convert.ToInt32(txtquan.Text)).ToString();
        }
    }
}
