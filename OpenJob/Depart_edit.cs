using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OpenJob

{
    public partial class Depart_edit : Form
    {
        string dep_id;
        string p_s_n;
        string f_n;
        string s_n;
        public Depart_edit(string DEP_ID, string P_S_NAME, string F_NAME, string S_NAME)
        {
            InitializeComponent();
            dep_id = DEP_ID;
            p_s_n = P_S_NAME;
            f_n = F_NAME;
            s_n = S_NAME;
        }

        private void Depart_edit_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            textBox1.Text = p_s_n;
            textBox2.Text = f_n;
            textBox3.Text = s_n;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) //кнопка Сохранить
        {
                Db_class.Upd("UPDATE departs SET f_name = '" + textBox2.Text + "', s_name = '" + textBox3.Text + "' WHERE id=" + Convert.ToString(dep_id));
                this.Close();
        }
    }
}
