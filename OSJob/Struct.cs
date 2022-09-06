using OpenJob;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OSJob
{
    public partial class Struct : Form
    {
        public Struct()
        {
            InitializeComponent();
        }

        private void Struct_Load(object sender, EventArgs e)
        {
            //ImageList ImgList = new ImageList();
            //ImgList.Images.Add(Properties.Resources.company);
            //ImgList.Images.Add(Properties.Resources.depart);
            //ImgList.Images.Add(Properties.Resources.function);
            //treeView1.ImageList = ImgList;
            treeView1.HideSelection = false;
            comboBox1.DataSource = Db_class.Ds("SELECT * FROM companies").Tables[0];
            comboBox1.DisplayMember = "s_name";
            comboBox1.ValueMember = "id";
            comboBox1.SelectedIndex = -1;
            //var rows = Db_class.Ds("SELECT * FROM departs WHERE parent_dep IS NULL").Tables[0].Rows;
            //foreach (DataRow mains in rows)
            //{
            //TreeNode root = new TreeNode
            //{
            //    Text = mains["s_name"].ToString(),
            //    Tag = mains["id"].ToString(),
            //    Name = mains["f_name"].ToString(),
            //    ImageIndex = 1,
            //    SelectedImageIndex = 1
            //};
            //comboBox1.Items.Add(new ComboBoxItem { Tag = mains["id"], Content = mains["s_name"].ToString() });
            //}


        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count > 0)
            {
                BindTreeViewControl();
                //TreeBuild();
            }
        }
        private void Struct_Activated(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count > 0)
            {
                BindTreeViewControl();
                //TreeBuild();
            }
        }
        //private void TreeBuild() //процедура построения дерева
        //{
            //if (comboBox1.SelectedItem != null)
            //{
            //    treeView1.Nodes.Clear();
            //    treeView1.BeginUpdate();
            //    TreeNode root = new TreeNode
            //    {
            //        Text = comboBox1.Text,
            //        Tag = comboBox1.SelectedValue.ToString(),
            //        ImageIndex = 0,
            //        SelectedImageIndex = 0
            //    };
            //    treeView1.Nodes.Add(root);

             //   BindTreeViewControl();
             //   treeView1.EndUpdate();
              //  treeView1.Nodes[0].Expand(); // Разворачиваем узел
            //}
        //}
        private void BindTreeViewControl() //Создание основных отделов предприятия
        {
            if (comboBox1.SelectedIndex != -1)
            { 
            string sel = "";
            //try
            //{

                //Ищем родительские узлы (parentId=0)
                sel = "SELECT * FROM departs WHERE parent_dep=0 AND comp_id=" + comboBox1.SelectedValue.ToString();//treeView1.Nodes[0].Tag;
                var nodes = Db_class.Ds(sel).Tables[0].Rows;
                foreach (DataRow mains in nodes)
                {
                    TreeNode root = new TreeNode
                    {
                        Text = mains["s_name"].ToString(),
                        Tag = mains["id"].ToString(),
                        Name = mains["f_name"].ToString(),
                        ImageIndex = 1,
                        SelectedImageIndex = 1
                    };
                    root.Expand(); // Разворачиваем узел
                    //root.SelectedImageIndex = 0;
                    MessageBox.Show(sel);
                    CreateNode(root);
                    treeView1.Nodes.Add(root);
                    
                }
            }
            //}
            //catch (Exception ex)
            //{
            //MessageBox.Show("Ошибка в родительских узлах" + sel + ex.Message);
            //}
        }
        public void CreateNode(TreeNode node)
        {
            string sel = "";
            sel = "SELECT * FROM departs WHERE parent_dep=" + node.Tag.ToString();//treeView1.Nodes[0].Tag;
            var nodes = Db_class.Ds(sel).Tables[0].Rows;
            if (nodes.Count == 0) { return; }

            foreach (DataRow selNode in nodes)
            {
                TreeNode ChildNode = new TreeNode
                {
                    Text = selNode["s_name"].ToString(),
                    Tag = selNode["id"].ToString(),
                    Name = selNode["f_name"].ToString(),
                    ImageIndex = 1,
                    SelectedImageIndex = 1
                };
                node.Nodes.Add(ChildNode);
                node.Expand(); // Разворачиваем узел
                CreateNode(ChildNode);
            }
        }

        private void btn_add_Click(object sender, EventArgs e) //кнопка Добавить
        {
            {
                string p = "";
                if (treeView1.SelectedNode != null) //если что-то выбрано
                {
                    if (treeView1.SelectedNode.Parent == null) //если родительский элемент предприятие
                    {
                        p = "1";
                    }
                    Form Depart_add = new Depart_add(
                        p,
                        comboBox1.SelectedValue.ToString(),
                        treeView1.SelectedNode.Tag.ToString(),
                        treeView1.SelectedNode.Text)
                        {
                            FormBorderStyle = FormBorderStyle.FixedSingle
                        };
                    Depart_add.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Не выбран родительский элемент.");
                }
            }
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null) //если что-то выбрано
            {
                Form Depart_edit = new Depart_edit(
                    treeView1.SelectedNode.Tag.ToString(),
                    comboBox1.Text,
                    treeView1.SelectedNode.Name.ToString(),
                    treeView1.SelectedNode.Text.ToString());
                Depart_edit.ShowDialog();
            }
            else
            {
                MessageBox.Show("Не выбран элемент для редактирования.");
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null) //если что-то выбрано
            {
                string id = "";
                id = treeView1.SelectedNode.Tag.ToString();
                DialogDel dd = new DialogDel();
                dd.ShowDialog();
                if (DialogResult.OK == dd.DialogResult)
                {
                    Db_class.Del("departs", id);
                }
                //TreeBuild();
            }
            else
            {
                MessageBox.Show("Выберите запись для удаления.");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
