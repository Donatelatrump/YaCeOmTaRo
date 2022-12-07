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
            MinimizeBox = false;
            MaximizeBox = false;
        }

        private void btnDFS_Click(object sender, EventArgs e)
        {
            using (DFS_Dirigido dfs = new DFS_Dirigido())
                dfs.ShowDialog();
        }

        private void DFSyBFS_Dirigidos_Load(object sender, EventArgs e)
        {

        }

        private void btnBFS_Click(object sender, EventArgs e)
        {
            //anchura
            using (Anchura_dirigidos xd = new Anchura_dirigidos())
            {
                xd.ShowDialog();
            }
        }
    }
}
