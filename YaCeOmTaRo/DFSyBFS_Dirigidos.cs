using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YaCeOmTaRo
{
    public partial class DFSyBFS_Dirigidos : Form
    {
        public DFSyBFS_Dirigidos()
        {
            InitializeComponent();
        }

        private void btnDFS_Click(object sender, EventArgs e)
        {
            using (DFS_Dirigido dfs = new DFS_Dirigido())
                dfs.ShowDialog();
        }
    }
}
