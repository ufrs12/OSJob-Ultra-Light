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
    public partial class Companies : Form
    {
        public Companies()
        {
            InitializeComponent();
        }
        private void Companies_Activated(object sender, EventArgs e)
        {
            DisplayData();
        }
        private void DisplayData() //процедура обновления данных
        {
            dataGridView1.DataSource = Db_class.Ds("SELECT * FROM companies");
            dataGridView1.DataMember = "table1";
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
        }
        private void btn_add_Click(object sender, EventArgs e) //кнопка Добавить
        {
            {
                Form Comp_add = new Comp_add
                {
                    FormBorderStyle = FormBorderStyle.FixedSingle
                };
                Comp_add.ShowDialog();
            }
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                int i = dataGridView1.CurrentCell.RowIndex;
                Form Comp_edit = new Comp_edit(
                    dataGridView1.Rows[i].Cells[0].Value.ToString(),
                    dataGridView1.Rows[i].Cells[1].Value.ToString(),
                    dataGridView1.Rows[i].Cells[2].Value.ToString());
                //{
                //    FormBorderStyle = FormBorderStyle.FixedSingle
                //};
                Comp_edit.Show(); ;
            }
            else
            {
                MessageBox.Show("Выберите запиь для редактирования.");
            }
        }
        private void btn_exit_Click(object sender, EventArgs e) //кнопка Выход
        {
            this.Close();
        }
        private void btn_del_Click(object sender, EventArgs e) //кнопка Удалить
        {
            if (dataGridView1.CurrentCell != null)
            {
                DialogDel dd = new DialogDel();
                dd.ShowDialog();
                if (DialogResult.OK == dd.DialogResult)
                {
                    int i = dataGridView1.CurrentCell.RowIndex;
                    string s = Db_class.Del("companies", dataGridView1.Rows[i].Cells[0].Value.ToString());
                    MessageBox.Show(s);
                }
                DisplayData();
            }
            else
            {
                MessageBox.Show("Выберите запись для удаления.");
            }
        }
    }
}
