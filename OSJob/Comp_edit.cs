using OpenJob;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSJob
{
    public partial class Comp_edit : Form
    {
        string id_c;
        string f_n;
        string s_n;
        public Comp_edit(string ID, string F_NAME, string S_NAME)
        {
            InitializeComponent();
            id_c = ID;
            f_n = F_NAME;
            s_n = S_NAME;
        }

        private void Comp_edit_Load(object sender, EventArgs e)
        {
            textBox1.Text = f_n;
            textBox2.Text = s_n;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Db_class.Upd("UPDATE companies SET f_name = '" + textBox1.Text + "', s_name = '" + textBox2.Text + "' WHERE id=" + Convert.ToString(id_c));
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
