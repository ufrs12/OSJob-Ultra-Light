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
    public partial class Comp_add : Form
    {
        public Comp_add()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                try
                {
                    string q = "INSERT INTO companies(f_name, s_name) VALUES('" + textBox1.Text + "','" + textBox2.Text + "')";
                    Db_class.Ins(q);
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Ошибка! Возможно такое предприятие уже существует.");
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля.");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
