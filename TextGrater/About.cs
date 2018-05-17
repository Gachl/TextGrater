using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextGrater
{
    /// <summary>
    /// Useless fun
    /// </summary>
    public partial class About : Form
    {
        double position;

        public About()
        {
            InitializeComponent();
            this.position = this.DesktopLocation.Y;
            this.timer1.Start();
        }

        double speed = 0.0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.position += speed;
            this.DesktopLocation = new Point(this.DesktopLocation.X, (int)this.position);
            speed += 0.02981;

            if (this.DesktopLocation.Y > Screen.FromControl(this).Bounds.Height)
                this.Close();
        }
    }
}
