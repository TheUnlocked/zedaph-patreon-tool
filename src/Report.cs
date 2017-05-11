using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZedaphPatreonTool
{
    public partial class Report : Form
    {
        public Report(string[] report)
        {
            InitializeComponent();
            reportOut.Lines = report;
        }

        private void export_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature not yet implemented");
        }
    }
}
