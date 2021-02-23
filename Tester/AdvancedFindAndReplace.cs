using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tester
{
    public partial class AdvancedFindAndReplace : Form
    {
        public AdvancedFindAndReplace()
        {
            InitializeComponent();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fctb.ShowFindDialog();
        }

        private void findAndReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fctb.ShowAdvancedFindAndReplaceDialog();
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fctb.ShowReplaceDialog();
        }
    }
}
