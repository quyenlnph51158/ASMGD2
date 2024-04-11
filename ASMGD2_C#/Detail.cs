using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ASMGD2_C_
{
    public partial class Detail : Form
    {
        DBASMBLL db=new DBASMBLL();
        public Detail()
        {
            InitializeComponent();
        }

        private void Detail_Load(object sender, EventArgs e)
        {

            

                FileStream fl = new FileStream("C#", FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fl);
                txtOrderId.Text = sr.ReadToEnd();

                sr.Close();
                fl.Close();

            
            
        }
    }
}
