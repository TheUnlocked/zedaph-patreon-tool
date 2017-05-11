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
    public partial class DefaultPatronValues : Form
    {
        public DefaultPatronValues()
        {
            InitializeComponent();
            patronList.DataSource = Patron.loadPatronListFromFile("defaults.zptdata");
        }

        private void patronList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            tableChanged();
        }

        private void tableChanged()
        {
            Patron.writePatronListToFile("defaults.zptdata", (BindingList<Patron>)patronList.DataSource);
        }
    }
}
