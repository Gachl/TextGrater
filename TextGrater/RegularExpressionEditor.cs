using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextGrater
{
    public partial class RegularExpressionEditor : UserControl
    {
        private int index;
        public int Index { get { return this.index; } set { this.index = value; lblRxIndex.Text = $"Rx{this.index}:"; } }

        public string Expression { get { return this.txtSearch.Text; } set { this.txtSearch.Text = value; } }
        public string Replacement { get { return this.txtReplace.Text; } set { this.txtReplace.Text = value; } }

        public bool UserEnabled { get { return !String.IsNullOrEmpty(this.txtSearch.Text) && this.cbEnabled.Checked; } set { this.cbEnabled.Checked = value; } }

        public RegularExpressionEditor()
        {
            InitializeComponent();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.cbEnabled.Enabled = !String.IsNullOrEmpty(txtSearch.Text);
        }
    }
}
