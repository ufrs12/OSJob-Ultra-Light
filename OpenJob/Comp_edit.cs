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

        private void button1_Click(object sender, EventArgs e) //кнопка Сохранить
        {
            Db_class.Upd("UPDATE companies SET f_name = '" + textBox1.Text + "', s_name = '" + textBox2.Text + "' WHERE id=" + Convert.ToString(id_c));
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) //кнопка Отменить
        {
            this.Close();
        }
    }
}
