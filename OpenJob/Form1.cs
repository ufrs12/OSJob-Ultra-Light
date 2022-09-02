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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        public void Main_Load(object sender, EventArgs e)
        {
        }
        private void добавитьОрганизациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Companies f2 = new Companies();
            f2.Show(); 
        }

        private void сруктурыОрганизацийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Struct f2 = new Struct();
            f2.Show();
        }

        private void штатноеРасписаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
