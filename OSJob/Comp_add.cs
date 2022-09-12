using OpenJob;
using System;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace OSJob
{
    public partial class Comp_add : Form
    {
        public Comp_add()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                string q = "INSERT INTO companies(f_name, s_name) VALUES('" + textBox1.Text + "','" + textBox2.Text + "')";
                MessageBox.Show(Db_class.Ins(q));
                //q = "SELECT id FROM companies WHERE s_name='" + textBox2.Text + "'";
                //MessageBox.Show(Db_class.Ins(q));
                //DataRow r = Db_class.Ds(q).Tables[0].Rows[0];
                ///q = Db_class.Ds(q).Tables[0].Rows[0];
                //DataColumn column = Db_class.Ds(q).Tables[0].Columns[0];
                //DataTable t = Db_class.Ds(q).Tables[0];
                //q = Convert.ToString(Convert.ToInt32(Db_class.Ds(q).Tables[0].Rows[0][0]));
                //q = "PRAGMA foreign_keys = OFF;INSERT INTO departs(f_name, s_name, comp_id) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'," + q + ")";
                //MessageBox.Show(Db_class.Ins(q) + q);
                this.Close();
            }
            else
            {
                MessageBox.Show("Заполните все поля.");
            }
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
