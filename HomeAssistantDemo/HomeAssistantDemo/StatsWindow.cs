using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeAssistantDemo
{
    public partial class StatsWindow : UserControl
    {
        public StatsWindow()
        {
            InitializeComponent();
        }

        private void StatsWindow_Load(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
