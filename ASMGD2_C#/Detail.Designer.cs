namespace ASMGD2_C_
{
    partial class Detail
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            txtOrderId = new TextBox();
            label5 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtOrderId);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Segoe UI", 10F);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 447);
            panel1.TabIndex = 0;
            // 
            // txtOrderId
            // 
            txtOrderId.Location = new Point(11, 197);
            txtOrderId.Multiline = true;
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new Size(776, 239);
            txtOrderId.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 363);
            label5.Name = "label5";
            label5.Size = new Size(0, 23);
            label5.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(270, 89);
            label1.Name = "label1";
            label1.Size = new Size(202, 35);
            label1.TabIndex = 0;
            label1.Text = "Thong tin chi tiet";
            // 
            // Detail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Detail";
            Text = "Detail";
            Load += Detail_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtOrderId;
        private Label label5;
        private Label label1;
    }
}