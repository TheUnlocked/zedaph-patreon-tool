using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZedaphPatreonTool
{
    public partial class DeleteMonth : Form
    {
        Form1 parent;

        public DeleteMonth(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
            monthListDelete.Items.AddRange(parent.monthList);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string path = parent.months[(string)monthListDelete.SelectedItem];
            if (backup.Checked)
            {
                File.Copy(path, path + "_backup");
            }
            File.Delete(parent.months[(string)monthListDelete.SelectedItem]);
            List<string> newRegister = new List<string>();
            foreach(string k in parent.months.Keys)
            {
                if (!k.Equals((string)monthListDelete.SelectedItem))
                    newRegister.Add($"{k}\t{parent.months[k]}");
            }
            File.WriteAllLines(@".\register.zptdata", newRegister);
            parent.Initialize();
            Close();
        }
    }
}
