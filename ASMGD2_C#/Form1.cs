using ASMGD2_C_.control;

namespace ASMGD2_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Prs pro = new Prs();
            addControlUser(pro);
        }
        private void addControlUser(UserControl user)
        {
            user.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(user);
            user.BringToFront();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prs pro = new Prs();
            addControlUser(pro);
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cstm cs = new cstm();
            addControlUser(cs);
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            od od = new od();
            addControlUser(od);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sETTINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BanHang bh = new BanHang();
            addControlUser(bh);
        }
    }
}
