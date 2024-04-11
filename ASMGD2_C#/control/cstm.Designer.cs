namespace ASMGD2_C_.control
{
    partial class cstm
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
            dgvCTSM = new DataGridView();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            panel1 = new Panel();
            btnClear = new Button();
            txtLastName = new TextBox();
            txtCity = new TextBox();
            txtCountry = new TextBox();
            txtPhone = new TextBox();
            txtFirstName = new TextBox();
            txtID = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCTSM).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCTSM
            // 
            dgvCTSM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCTSM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCTSM.Location = new Point(0, 192);
            dgvCTSM.Name = "dgvCTSM";
            dgvCTSM.RowHeadersWidth = 51;
            dgvCTSM.Size = new Size(800, 225);
            dgvCTSM.TabIndex = 0;
            dgvCTSM.CellClick += dgvCTSM_CellClick;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(233, 139);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(109, 41);
            btnSua.TabIndex = 22;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(118, 139);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(109, 41);
            btnXoa.TabIndex = 21;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(3, 139);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(109, 41);
            btnThem.TabIndex = 20;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(txtCity);
            panel1.Controls.Add(txtCountry);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(txtFirstName);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnXoa);
            panel1.Font = new Font("Segoe UI", 10F);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(794, 183);
            panel1.TabIndex = 23;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(659, 136);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(109, 41);
            btnClear.TabIndex = 36;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(102, 100);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(240, 30);
            txtLastName.TabIndex = 35;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(448, 10);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(320, 30);
            txtCity.TabIndex = 34;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(448, 55);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(320, 30);
            txtCountry.TabIndex = 33;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(448, 100);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(320, 30);
            txtPhone.TabIndex = 32;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(102, 55);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(240, 30);
            txtFirstName.TabIndex = 31;
            // 
            // txtID
            // 
            txtID.Location = new Point(102, 10);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(240, 30);
            txtID.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(371, 103);
            label7.Name = "label7";
            label7.Size = new Size(59, 23);
            label7.TabIndex = 29;
            label7.Text = "Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 58);
            label6.Name = "label6";
            label6.Size = new Size(87, 23);
            label6.TabIndex = 28;
            label6.Text = "FirstName";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(371, 13);
            label5.Name = "label5";
            label5.Size = new Size(39, 23);
            label5.TabIndex = 27;
            label5.Text = "City";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(371, 58);
            label4.Name = "label4";
            label4.Size = new Size(71, 23);
            label4.TabIndex = 26;
            label4.Text = "Country";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 103);
            label3.Name = "label3";
            label3.Size = new Size(86, 23);
            label3.TabIndex = 25;
            label3.Text = "LastName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 49);
            label2.Name = "label2";
            label2.Size = new Size(0, 23);
            label2.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 13);
            label1.Name = "label1";
            label1.Size = new Size(27, 23);
            label1.TabIndex = 23;
            label1.Text = "ID";
            // 
            // cstm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(dgvCTSM);
            Name = "cstm";
            Size = new Size(800, 417);
            Load += customer_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCTSM).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCTSM;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Panel panel1;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private TextBox txtLastName;
        private TextBox txtCity;
        private TextBox txtCountry;
        private TextBox txtPhone;
        private TextBox txtFirstName;
        private TextBox txtID;
        private Button btnClear;
    }
}
