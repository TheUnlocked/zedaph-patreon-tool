using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZedaphPatreonTool
{
    public partial class NewMonth : Form
    {
        Form1 parent;
        Mode selectedMode = Mode.Copy;

        public enum Mode
        {
            Copy,
            Load,
            Blank
        }

        public NewMonth(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
            monthListCopy.Items.AddRange(parent.monthList);
            if (monthListCopy.Items.Count > 0)
                monthListCopy.SelectedIndex = 0;
            monthList.SelectedIndex = DateTime.Today.Month - 1;
            year.Value = DateTime.Today.Year;
        }

        private void addNewMonth_Click(object sender, EventArgs e)
        {
            object data = null;
            if (selectedMode == Mode.Copy)
            {
                data = monthListCopy.SelectedItem;
            }
            if (selectedMode == Mode.Load)
            {
                data = fileDialogue.FileName;
            }
            if (parent.addMonthToFile((string)monthList.SelectedItem, (int)year.Value, selectedMode, data))
                Close();
        }

        private void monthListCopy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void optionCopy_CheckedChanged(object sender, EventArgs e)
        {
            selectedMode = Mode.Copy;
        }

        private void optionSpreadsheet_CheckedChanged(object sender, EventArgs e)
        {
            selectedMode = Mode.Load;
        }

        private void optionNew_CheckedChanged(object sender, EventArgs e)
        {
            selectedMode = Mode.Blank;
        }

        private void fileSelect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fileDialogue.ShowDialog();
            fileSelect.Text = PathShortener(fileDialogue.FileName, 40);
        }

        private void fileDialogue_FileOk(object sender, CancelEventArgs e)
        {

        }

        [DllImport("shlwapi.dll", CharSet = CharSet.Auto)]
        static extern bool PathCompactPathEx(
                       [Out] StringBuilder pszOut,
                       string szPath,
                       int cchMax,
                       int dwFlags);

        static string PathShortener(string path, int length)
        {
            StringBuilder sb = new StringBuilder(length + 1);
            PathCompactPathEx(sb, path, length, 0);
            return sb.ToString();
        }
    }
}
