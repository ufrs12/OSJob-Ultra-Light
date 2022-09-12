using OpenJob;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
namespace OSJob
{
    public partial class Objects : Form
    {
        public Objects()
        {
            InitializeComponent();
            treeView1.HideSelection = false;
        }

        private void Objects_Load(object sender, EventArgs e)
        {

        }
        private void Objects_Activated(object sender, EventArgs e)
        {
            BindTreeViewControl();
        }
        private void BindTreeViewControl() //Построение дерева
        {
            treeView1.Nodes.Clear();
            //Добавляем основной узел
            TreeNode root = new TreeNode
            {
                Text = "Все объекты",
                Tag = "1",
                Name = "Все объекты",
                //ImageIndex = 1,
                //SelectedImageIndex = 1
            };
            root.Expand(); //Разворачиваем узел
            CreateNode(root);
            treeView1.Nodes.Add(root);
        }
        public void CreateNode(TreeNode node)
        {
            string sel = "SELECT * FROM objects WHERE par_id=" + node.Tag.ToString();
            var nodes = Db_class.Ds(sel).Tables[0].Rows;
            if (nodes.Count == 0) { return; }
            foreach (DataRow selNode in nodes)
            {
                TreeNode ChildNode = new TreeNode
                {
                    Text = selNode["s_name"].ToString(),
                    Tag = selNode["id"].ToString(),
                    Name = selNode["f_name"].ToString(),
                    //ImageIndex = 1,
                    //SelectedImageIndex = 1
                };
                node.Nodes.Add(ChildNode);
                node.Expand(); // Разворачиваем узел
                CreateNode(ChildNode);
            }
        }
        //}
        //catch (Exception ex)
        //{
        //MessageBox.Show("Ошибка в родительских узлах" + sel + ex.Message);
        //}
        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (treeView1.SelectedNode != null) //если что-то выбрано
                {
                    Form Object_add = new Object_add(
                        treeView1.SelectedNode.Tag.ToString(),
                        treeView1.SelectedNode.Text)
                    {
                        FormBorderStyle = FormBorderStyle.FixedSingle
                    };
                    Object_add.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Не выбран родительский элемент.");
                }
            }
        }
    }
}

