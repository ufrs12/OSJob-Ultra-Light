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
    public partial class Object_add : Form
    {
        string p_id, p_s_n;
        public Object_add(string P_ID, string P_S_NAME)
        {
            InitializeComponent();
            p_id = P_ID;    
            p_s_n = P_S_NAME; 
        }

        private void Object_add_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            textBox1.Text = p_s_n;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }
    }
}
