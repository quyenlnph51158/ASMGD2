using BLL;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASMGD2_C_.control
{
    public partial class Prs : UserControl
    {
        DataTable dt = new DataTable();
        DBASMBLL db = new DBASMBLL();
        public Prs()
        {
            InitializeComponent();
        }

        private void GETvalues()
        {
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

            foreach (var i in db.GetSuppliersALLBLL().ToList())
            {
                cbbSuppyId.Items.Add(i.CompanyName);
            }
        }
        private void Product_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("ProductName", typeof(string));
            dt.Columns.Add("SupplierId", typeof(int));
            dt.Columns.Add("UnitPrice", typeof(decimal));
            dt.Columns.Add("Package", typeof(string));
            dt.Columns.Add("IsDiscontinued", typeof(bool));

            GETvalues();
            dgvProducts.DataSource = dt;
        }


        //search name Product

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
            dgvProducts.DataSource = dt;

        }
        //Them product

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtPackage.Text==""||txtNameProduct.Text==""||txtPrice.Text==""||cbbSuppyId.SelectedItem==""||rdoNo.Checked==false&&rdoYes.Checked==false)
            {
                MessageBox.Show("Nhap thieu du lieu!!!");
            }
            else {
                var productName = txtNameProduct.Text;
                var Price = txtPrice.Text;
                var supplyId = cbbSuppyId.SelectedItem.ToString();
                var package = txtPackage.Text;
                var continuee = true;
                if (rdoNo.Checked == true)
                {
                    continuee = false;
                }
                else if (rdoYes.Checked == true)
                {
                    continuee = true;
                }
                db.ADDProduct(productName, supplyId, Price, package, continuee);

                dt.Clear();
                GETvalues();
            }


            


        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow rowHienTai = dgvProducts.Rows[e.RowIndex];
            txtId.Text = rowHienTai.Cells[0].Value.ToString();
            txtNameProduct.Text = rowHienTai.Cells[1].Value.ToString();
            cbbSuppyId.SelectedItem = GetSupplyfromId(Convert.ToInt32(rowHienTai.Cells[2].Value)).CompanyName;
            txtPrice.Text = rowHienTai.Cells[3].Value.ToString();
            txtPackage.Text = rowHienTai.Cells[4].Value.ToString();


            if (Convert.ToBoolean(rowHienTai.Cells[5].Value) == false)
            {
                rdoNo.Checked = true;

            }
            else if (Convert.ToBoolean(rowHienTai.Cells[5].Value) == true)
            {
                rdoYes.Checked = true;

            }
        }
        private Supplier GetSupplyfromId(int id)
        {
            foreach (var i in db.GetSuppliersALLBLL())
            {
                if (i.Id.Equals(id))
                {
                    return i;
                }
            }
            return null;
        }
        //Xoa product
        private void btnXoa_Click(object sender, EventArgs e)
        {
            var prId = txtId.Text;
            //var h = db.GetOrderItembyIdProduct(Convert.ToInt32(prId)).Id;
            //var k= db.GetOrderItembyIdProduct(Convert.ToInt32(prId)).ProductId;
            //var l = db.GetOrderItembyIdProduct(Convert.ToInt32(prId)).OrderId;
            //var r = db.GetOrderItembyIdProduct(Convert.ToInt32(prId)).UnitPrice;
            //var u = db.GetOrderItembyIdProduct(Convert.ToInt32(prId)).Quantity;
            
            db.removeProduct(prId);
            dt.Clear();
            GETvalues();

        }


        //Sua product
        private void btnSua_Click(object sender, EventArgs e)
        {
            var prId = txtId.Text;
            var productName = txtNameProduct.Text;
            var Price = txtPrice.Text;
            var supplyId = cbbSuppyId.SelectedItem.ToString();
            var package = txtPackage.Text;
            var continuee = true;
            if (rdoNo.Checked == true)
            {
                continuee = false;
            }
            else
            {
                continuee = true;
            }



            db.UpdateProduct(prId, productName, supplyId, Price, package, continuee);

            dt.Clear();
            GETvalues();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtNameProduct.Text = "";
            txtPackage.Text = "";
            txtPrice.Text = "";
            cbbSuppyId.SelectedItem = null;
            rdoNo.Checked = false;
            rdoYes.Checked = false;
        }
    }
}
