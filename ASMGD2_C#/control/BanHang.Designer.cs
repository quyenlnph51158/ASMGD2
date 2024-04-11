namespace ASMGD2_C_.control
{
    partial class BanHang
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvBanHang = new DataGridView();
            panel1 = new Panel();
            label9 = new Label();
            txtquan = new TextBox();
            btnOK1 = new Button();
            txtTotalAmount = new TextBox();
            cbbCustomerID = new ComboBox();
            label3 = new Label();
            txtOrderNumber = new TextBox();
            cbbSelectedProduct = new ComboBox();
            dtpOrderDate = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            txtSearch = new TextBox();
            label4 = new Label();
            label5 = new Label();
            OrderNumber = new Label();
            groupBox1 = new GroupBox();
            btnOK2 = new Button();
            txtQuantity = new TextBox();
            txtUnitPrice = new TextBox();
            txtProductID = new TextBox();
            txtOrderID = new TextBox();
            txt = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBanHang).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvBanHang
            // 
            dgvBanHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBanHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBanHang.Location = new Point(3, 376);
            dgvBanHang.Name = "dgvBanHang";
            dgvBanHang.RowHeadersWidth = 51;
            dgvBanHang.Size = new Size(794, 213);
            dgvBanHang.TabIndex = 0;
            dgvBanHang.CellClick += dgvBanHang_CellClick;
            dgvBanHang.CellDoubleClick += dgvBanHang_CellDoubleClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtquan);
            panel1.Controls.Add(btnOK1);
            panel1.Controls.Add(txtTotalAmount);
            panel1.Controls.Add(cbbCustomerID);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtOrderNumber);
            panel1.Controls.Add(cbbSelectedProduct);
            panel1.Controls.Add(dtpOrderDate);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(OrderNumber);
            panel1.Font = new Font("Segoe UI", 10F);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 370);
            panel1.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(468, 90);
            label9.Name = "label9";
            label9.Size = new Size(76, 23);
            label9.TabIndex = 18;
            label9.Text = "Quantity";
            // 
            // txtquan
            // 
            txtquan.Location = new Point(550, 90);
            txtquan.Name = "txtquan";
            txtquan.Size = new Size(206, 30);
            txtquan.TabIndex = 17;
            txtquan.TextChanged += txtquan_TextChanged;
            // 
            // btnOK1
            // 
            btnOK1.Location = new Point(581, 296);
            btnOK1.Name = "btnOK1";
            btnOK1.Size = new Size(123, 46);
            btnOK1.TabIndex = 16;
            btnOK1.Text = "OK";
            btnOK1.UseVisualStyleBackColor = true;
            btnOK1.Click += btnOK1_Click;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Location = new Point(197, 241);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(337, 30);
            txtTotalAmount.TabIndex = 15;
            txtTotalAmount.TextChanged += txtTotalAmount_TextChanged;
            // 
            // cbbCustomerID
            // 
            cbbCustomerID.FormattingEnabled = true;
            cbbCustomerID.Location = new Point(197, 208);
            cbbCustomerID.Name = "cbbCustomerID";
            cbbCustomerID.Size = new Size(337, 31);
            cbbCustomerID.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 93);
            label3.Name = "label3";
            label3.Size = new Size(139, 23);
            label3.TabIndex = 5;
            label3.Text = "Selected product";
            // 
            // txtOrderNumber
            // 
            txtOrderNumber.Location = new Point(197, 177);
            txtOrderNumber.Name = "txtOrderNumber";
            txtOrderNumber.Size = new Size(337, 30);
            txtOrderNumber.TabIndex = 13;
            // 
            // cbbSelectedProduct
            // 
            cbbSelectedProduct.FormattingEnabled = true;
            cbbSelectedProduct.Location = new Point(155, 90);
            cbbSelectedProduct.Name = "cbbSelectedProduct";
            cbbSelectedProduct.Size = new Size(207, 31);
            cbbSelectedProduct.TabIndex = 4;
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Location = new Point(197, 142);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(337, 30);
            dtpOrderDate.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 19);
            label1.Name = "label1";
            label1.Size = new Size(126, 23);
            label1.TabIndex = 2;
            label1.Text = "Search Product";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 244);
            label2.Name = "label2";
            label2.Size = new Size(108, 23);
            label2.TabIndex = 11;
            label2.Text = "TotalAmount";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(156, 16);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(206, 30);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 211);
            label4.Name = "label4";
            label4.Size = new Size(101, 23);
            label4.TabIndex = 10;
            label4.Text = "CustomerID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 147);
            label5.Name = "label5";
            label5.Size = new Size(90, 23);
            label5.TabIndex = 9;
            label5.Text = "OrderDate";
            // 
            // OrderNumber
            // 
            OrderNumber.AutoSize = true;
            OrderNumber.Location = new Point(15, 180);
            OrderNumber.Name = "OrderNumber";
            OrderNumber.Size = new Size(117, 23);
            OrderNumber.TabIndex = 8;
            OrderNumber.Text = "OrderNumber";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnOK2);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(txtUnitPrice);
            groupBox1.Controls.Add(txtProductID);
            groupBox1.Controls.Add(txtOrderID);
            groupBox1.Controls.Add(txt);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new Point(803, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(575, 589);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "ADD";
            // 
            // btnOK2
            // 
            btnOK2.Location = new Point(422, 244);
            btnOK2.Name = "btnOK2";
            btnOK2.Size = new Size(123, 46);
            btnOK2.TabIndex = 17;
            btnOK2.Text = "OK";
            btnOK2.UseVisualStyleBackColor = true;
            btnOK2.Click += btnOK2_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(169, 144);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(376, 27);
            txtQuantity.TabIndex = 15;
            txtQuantity.Text = "0";
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Enabled = false;
            txtUnitPrice.Location = new Point(169, 100);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(376, 27);
            txtUnitPrice.TabIndex = 14;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(169, 59);
            txtProductID.Name = "txtProductID";
            txtProductID.ReadOnly = true;
            txtProductID.Size = new Size(376, 27);
            txtProductID.TabIndex = 13;
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(169, 23);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.ReadOnly = true;
            txtOrderID.Size = new Size(376, 27);
            txtOrderID.TabIndex = 12;
            // 
            // txt
            // 
            txt.AutoSize = true;
            txt.Location = new Point(6, 147);
            txt.Name = "txt";
            txt.Size = new Size(65, 20);
            txt.TabIndex = 11;
            txt.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 103);
            label6.Name = "label6";
            label6.Size = new Size(68, 20);
            label6.TabIndex = 10;
            label6.Text = "UnitPrice";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 62);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 9;
            label7.Text = "ProductID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 26);
            label8.Name = "label8";
            label8.Size = new Size(62, 20);
            label8.TabIndex = 8;
            label8.Text = "OrderID";
            // 
            // BanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(dgvBanHang);
            Name = "BanHang";
            Size = new Size(1816, 592);
            Load += BanHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBanHang).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBanHang;
        private Panel panel1;
        private TextBox txtSearch;
        private Label label1;
        private Label label3;
        private ComboBox cbbSelectedProduct;
        private GroupBox groupBox1;
        private TextBox txtTotalAmount;
        private ComboBox cbbCustomerID;
        private TextBox txtOrderNumber;
        private DateTimePicker dtpOrderDate;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label OrderNumber;
        private Button btnOK1;
        private Button btnOK2;
        private TextBox txtQuantity;
        private TextBox txtUnitPrice;
        private TextBox txtProductID;
        private TextBox txtOrderID;
        private Label txt;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtquan;
    }
}
