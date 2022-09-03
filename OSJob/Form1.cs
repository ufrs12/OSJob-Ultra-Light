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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void организацииToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form Comp = new Companies
            {
                FormBorderStyle = FormBorderStyle.FixedSingle
            };
            Comp.ShowDialog();
        }

        private void структурыОрганизацийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Struct = new Struct
            {
                FormBorderStyle = FormBorderStyle.FixedSingle
            };
            Struct.ShowDialog();
        }
    }
}
