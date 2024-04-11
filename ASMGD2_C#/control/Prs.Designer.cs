namespace ASMGD2_C_.control
{
    partial class Prs
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
            dgvProducts = new DataGridView();
            panel1 = new Panel();
            btnSua = new Button();
            btnXoa = new Button();
            cbbSuppyId = new ComboBox();
            rdoNo = new RadioButton();
            rdoYes = new RadioButton();
            txtPrice = new TextBox();
            txtPackage = new TextBox();
            txtNameProduct = new TextBox();
            txtId = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnThem = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(2, 214);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(798, 203);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(cbbSuppyId);
            panel1.Controls.Add(rdoNo);
            panel1.Controls.Add(rdoYes);
            panel1.Controls.Add(txtPrice);
            panel1.Controls.Add(txtPackage);
            panel1.Controls.Add(txtNameProduct);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Segoe UI", 10F);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(794, 205);
            panel1.TabIndex = 1;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(294, 154);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(109, 41);
            btnSua.TabIndex = 19;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(144, 154);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(109, 41);
            btnXoa.TabIndex = 18;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // cbbSuppyId
            // 
            cbbSuppyId.FormattingEnabled = true;
            cbbSuppyId.Location = new Point(144, 119);
            cbbSuppyId.Name = "cbbSuppyId";
            cbbSuppyId.Size = new Size(259, 31);
            cbbSuppyId.TabIndex = 17;
            // 
            // rdoNo
            // 
            rdoNo.AutoSize = true;
            rdoNo.Location = new Point(650, 121);
            rdoNo.Name = "rdoNo";
            rdoNo.Size = new Size(54, 27);
            rdoNo.TabIndex = 16;
            rdoNo.TabStop = true;
            rdoNo.Text = "No";
            rdoNo.UseVisualStyleBackColor = true;
            // 
            // rdoYes
            // 
            rdoYes.AutoSize = true;
            rdoYes.Location = new Point(513, 121);
            rdoYes.Name = "rdoYes";
            rdoYes.Size = new Size(55, 27);
            rdoYes.TabIndex = 15;
            rdoYes.TabStop = true;
            rdoYes.Text = "Yes";
            rdoYes.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(512, 49);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(259, 30);
            txtPrice.TabIndex = 14;
            // 
            // txtPackage
            // 
            txtPackage.Location = new Point(512, 81);
            txtPackage.Name = "txtPackage";
            txtPackage.Size = new Size(259, 30);
            txtPackage.TabIndex = 11;
            // 
            // txtNameProduct
            // 
            txtNameProduct.Location = new Point(144, 81);
            txtNameProduct.Name = "txtNameProduct";
            txtNameProduct.Size = new Size(259, 30);
            txtNameProduct.TabIndex = 10;
            // 
            // txtId
            // 
            txtId.Location = new Point(144, 46);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(259, 30);
            txtId.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(415, 116);
            label7.Name = "label7";
            label7.Size = new Size(80, 23);
            label7.TabIndex = 8;
            label7.Text = "Continue";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(415, 84);
            label6.Name = "label6";
            label6.Size = new Size(72, 23);
            label6.TabIndex = 7;
            label6.Text = "Package";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 84);
            label5.Name = "label5";
            label5.Size = new Size(116, 23);
            label5.TabIndex = 6;
            label5.Text = "ProductName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 116);
            label4.Name = "label4";
            label4.Size = new Size(61, 23);
            label4.TabIndex = 5;
            label4.Text = "Supply";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(415, 52);
            label3.Name = "label3";
            label3.Size = new Size(79, 23);
            label3.TabIndex = 4;
            label3.Text = "UnitPrice";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 52);
            label2.Name = "label2";
            label2.Size = new Size(27, 23);
            label2.TabIndex = 3;
            label2.Text = "ID";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(3, 154);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(109, 41);
            btnThem.TabIndex = 2;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(79, 6);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(324, 30);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(61, 23);
            label1.TabIndex = 0;
            label1.Text = "Search";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(662, 154);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(109, 41);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Prs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(dgvProducts);
            Name = "Prs";
            Size = new Size(800, 417);
            Load += Product_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProducts;
        private Panel panel1;
        private TextBox txtSearch;
        private Label label1;
        private Button btnThem;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private TextBox txtPrice;
        private TextBox txtPackage;
        private TextBox txtNameProduct;
        private TextBox txtId;
        private RadioButton rdoNo;
        private RadioButton rdoYes;
        private ComboBox cbbSuppyId;
        private Button btnXoa;
        private Button btnSua;
        private Button btnClear;
    }
}
