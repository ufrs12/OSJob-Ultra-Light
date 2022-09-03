using OpenJob;
using System;
using System.Windows.Forms;

namespace OSJob
{
    public partial class Depart_add : Form
    {
        string p;
        string p_id;
        string c_id;
        string p_s_n;
        public Depart_add(string P, string C_ID, string P_ID, string P_S_NAME)
        {
            InitializeComponent();
            p = P;
            p_id = P_ID;
            c_id = C_ID;
            p_s_n = P_S_NAME;
        }
        private void Depart_add_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            textBox1.Text = p_s_n;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string q = "";
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    try
                    {
                        if (p == "1") //если родительский объет предприятие
                        {
                            p_id = "0";
                        }
                        q = "INSERT INTO departs (f_name, s_name, comp_id, parent_dep) VALUES('" + textBox2.Text + "','" + textBox3.Text + "'," + c_id + "," + p_id + ")";
                        Db_class.Ins(q);
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка! Возможно такое подразделение уже существует.");
                        textBox2.Text = q;
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все поля.");
                }
            }
            else
            {
                MessageBox.Show("Заполните необходимые поля.");
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
