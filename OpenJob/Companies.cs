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
    public partial class Companies : Form
    {
        public Companies()
        {
            InitializeComponent();
        }
        private void DisplayData() //процедура обновления данных
        {
            dataGridView1.DataSource = Db_class.Ds("SELECT * FROM companies");
            dataGridView1.DataMember = "table1";
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.AllowUserToAddRows = false;
        }
        private void button1_Click(object sender, EventArgs e) //кнопка Добавить
        {
            Form Comp_add = new Comp_add();
            Comp_add.Show();
        }
        private void button3_Click(object sender, EventArgs e) //кнопка Удалить
        {
            if (dataGridView1.CurrentCell != null)
            {
                DialogDel dd = new DialogDel();
                dd.ShowDialog();
                if (DialogResult.OK == dd.DialogResult)
                {
                    int i = dataGridView1.CurrentCell.RowIndex;
                    Db_class.Del("companies", dataGridView1.Rows[i].Cells[0].Value.ToString());
                }
                DisplayData();
            }
            else
            {
                MessageBox.Show("Выберите запись для удаления.");
            }
        }
        private void Companies_Activated(object sender, EventArgs e) //обновление данных при активации формы
        {
            DisplayData();
        }
        private void button2_Click(object sender, EventArgs e) //кнопка Редактированть
        {
            if (dataGridView1.CurrentCell != null)
            {
                int i = dataGridView1.CurrentCell.RowIndex;
                Form Comp_edit = new Comp_edit(
                    dataGridView1.Rows[i].Cells[0].Value.ToString(), 
                    dataGridView1.Rows[i].Cells[1].Value.ToString(), 
                    dataGridView1.Rows[i].Cells[2].Value.ToString());
                Comp_edit.Show();
            }
            else
            {
                MessageBox.Show("Выберите запиь для редактирования.");
            }
        }
        private void button4_Click(object sender, EventArgs e) //кнопка Выход
        {
            this.Close();
        }
    }
}
