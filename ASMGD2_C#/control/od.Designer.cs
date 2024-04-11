namespace ASMGD2_C_.control
{
    partial class od
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
            dgvOd = new DataGridView();
            panel1 = new Panel();
            cbbctms = new ComboBox();
            dtpOrderdate = new DateTimePicker();
            btnClear = new Button();
            txtOrderNumber = new TextBox();
            txtTotal = new TextBox();
            txtID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnDetail = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOd).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvOd
            // 
            dgvOd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOd.Location = new Point(0, 199);
            dgvOd.Name = "dgvOd";
            dgvOd.RowHeadersWidth = 51;
            dgvOd.Size = new Size(800, 218);
            dgvOd.TabIndex = 0;
            dgvOd.CellClick += dgvOd_CellClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDetail);
            panel1.Controls.Add(cbbctms);
            panel1.Controls.Add(dtpOrderdate);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(txtOrderNumber);
            panel1.Controls.Add(txtTotal);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnXoa);
            panel1.Font = new Font("Segoe UI", 10F);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 194);
            panel1.TabIndex = 1;
            // 
            // cbbctms
            // 
            cbbctms.FormattingEnabled = true;
            cbbctms.Location = new Point(493, 14);
            cbbctms.Name = "cbbctms";
            cbbctms.Size = new Size(290, 31);
            cbbctms.TabIndex = 54;
            // 
            // dtpOrderdate
            // 
            dtpOrderdate.Font = new Font("Segoe UI", 9F);
            dtpOrderdate.Location = new Point(133, 61);
            dtpOrderdate.Name = "dtpOrderdate";
            dtpOrderdate.Size = new Size(224, 27);
            dtpOrderdate.TabIndex = 53;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(674, 138);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(109, 41);
            btnClear.TabIndex = 52;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // txtOrderNumber
            // 
            txtOrderNumber.Location = new Point(133, 102);
            txtOrderNumber.Name = "txtOrderNumber";
            txtOrderNumber.Size = new Size(224, 30);
            txtOrderNumber.TabIndex = 51;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(493, 57);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(290, 30);
            txtTotal.TabIndex = 49;
            // 
            // txtID
            // 
            txtID.Location = new Point(133, 12);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(224, 30);
            txtID.TabIndex = 46;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 60);
            label6.Name = "label6";
            label6.Size = new Size(88, 23);
            label6.TabIndex = 44;
            label6.Text = "Orderdate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(386, 15);
            label5.Name = "label5";
            label5.Size = new Size(84, 23);
            label5.TabIndex = 43;
            label5.Text = "Customer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(386, 60);
            label4.Name = "label4";
            label4.Size = new Size(108, 23);
            label4.TabIndex = 42;
            label4.Text = "TotalAmount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 105);
            label3.Name = "label3";
            label3.Size = new Size(117, 23);
            label3.TabIndex = 41;
            label3.Text = "OrderNumber";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 15);
            label1.Name = "label1";
            label1.Size = new Size(27, 23);
            label1.TabIndex = 40;
            label1.Text = "ID";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(18, 141);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(109, 41);
            btnThem.TabIndex = 37;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(248, 141);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(109, 41);
            btnSua.TabIndex = 39;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(133, 141);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(109, 41);
            btnXoa.TabIndex = 38;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnDetail
            // 
            btnDetail.Location = new Point(386, 138);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(109, 41);
            btnDetail.TabIndex = 55;
            btnDetail.Text = "Detail";
            btnDetail.UseVisualStyleBackColor = true;
            btnDetail.Click += btnDetail_Click;
            // 
            // od
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(dgvOd);
            Name = "od";
            Size = new Size(800, 417);
            Load += od_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOd).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvOd;
        private Panel panel1;
        private Button btnClear;
        private TextBox txtOrderNumber;
        private TextBox txtTotal;
        private TextBox txtID;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private DateTimePicker dtpOrderdate;
        private ComboBox cbbctms;
        private Button btnDetail;
    }
}
