using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASMGD2_C_
{
    
    public partial class Form2 : Form
    {
        DBASMBLL db=new DBASMBLL();
        DataTable DataTable=new DataTable();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DataTable.Columns.Add("id",typeof(int));
            DataTable.Columns.Add("OrderID", typeof(int));
            DataTable.Columns.Add("productId",typeof(int));
            DataTable.Columns.Add("Quantity",typeof (int));
            foreach(var i in db.GetOrderItemsALLBLL())
            {
                DataRow row=DataTable.NewRow();
                row["id"] = i.Id;
                row["OrderID"] = i.OrderId;
                row["ProductID"] = i.ProductId;
                row["Quantity"] = i.Quantity;
                DataTable.Rows.Add(row);
            }
            dataGridView1.DataSource = DataTable;
        }
    }
}
