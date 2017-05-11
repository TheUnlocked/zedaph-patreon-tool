using LumenWorks.Framework.IO.Csv;
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
    public partial class Form1 : Form
    {
        public Dictionary<string, string> months;
        public string[] monthList;
        private string selected;
        private BindingList<Patron> selectedList;
        private BindingList<Patron> compareList;

        DataGridViewCellStyle REMOVED { get; } = new DataGridViewCellStyle();
        DataGridViewCellStyle ADDED { get; } = new DataGridViewCellStyle();
        DataGridViewCellStyle CHANGED { get; } = new DataGridViewCellStyle();

        public static readonly Dictionary<string, int> MONTHS = new Dictionary<string, int>
        {
            {"January", 1},
            {"February", 2},
            {"March", 3},
            {"April", 4},
            {"May", 5},
            {"June", 6},
            {"July", 7},
            {"August", 8},
            {"September", 9},
            {"October", 10},
            {"November", 11},
            {"December", 12}
        };

        public Form1()
        {
            REMOVED.BackColor = Color.Red;
            REMOVED.SelectionBackColor = Color.Red;
            REMOVED.ForeColor = Color.White;
            REMOVED.SelectionForeColor = Color.White;
            ADDED.BackColor = Color.Green;
            ADDED.SelectionBackColor = Color.Green;
            ADDED.ForeColor = Color.White;
            ADDED.SelectionForeColor = Color.White;
            CHANGED.BackColor = Color.Blue;
            CHANGED.SelectionBackColor = Color.Blue;
            CHANGED.ForeColor = Color.White;
            CHANGED.SelectionForeColor = Color.White;

            InitializeComponent();
            Initialize();
        }

        public void Initialize()
        {
            months = new Dictionary<string, string>();
            string path = "register.zptdata";
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
            else
            {
                foreach (string line in File.ReadAllLines(path))
                {
                    string[] split = line.Split('\t');
                    months[split[0]] = split[1];
                }
            }
            path = "defaults.zptdata";
            if (!File.Exists(path))
                File.Create(path).Close();

            monthList = months.Keys.OrderByDescending(x => (Convert.ToDecimal(x.Split(' ')[0]) * 13) + MONTHS[x.Split(' ')[1]]).ToArray();
            monthListSelected.Items.Clear();
            monthListSelected.Items.AddRange(monthList);
            monthListCompare.Items.Clear();
            monthListCompare.Items.AddRange(monthList);
        }

        public bool addMonthToFile(string month, int year, NewMonth.Mode mode, object data = null)
        {
            void failure(string msg = "Oops! That month already exists. Delete it first before continuing.")
            {
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string path = $@"{year}_{month}.zptdata";
            if (!File.Exists(path))
            {
                if (mode == NewMonth.Mode.Blank)
                    File.Create(path).Close();
            }
            else
            {
                failure();
                return false;
            }
            if (mode == NewMonth.Mode.Copy)
            {
                try
                {
                    File.Copy(months[(string)data], path);
                }
                catch (IOException)
                {
                    failure();
                    return false;
                }
                catch (ArgumentNullException)
                {
                    MessageBox.Show("You can't copy from a month that doesn't exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            if (mode == NewMonth.Mode.Load)
            {
                try
                {
                    using (CsvReader csv = new CsvReader(
                               new StreamReader((string)data), true))
                    {
                        BindingList<Patron> parsed = new BindingList<Patron>();
                        foreach (string[] field in csv)
                        {
                            if (field[0] != null && !field[0].Contains(" "))
                            {
                                Patron p = new Patron();
                                p.PatreonName = $"{field[0]} {field[1]}";
                                p.EmailAddress = $"{field[2]}";
                                p.Pledge = Convert.ToDecimal(field[3]);
                                p.LifetimeContribution = Convert.ToDecimal(field[4]);
                                parsed.Add(p);
                            }
                        }
                        Patron.writePatronListToFile(path, parsed);
                    }
                }
                catch (MalformedCsvException)
                {
                    MessageBox.Show("Please use a valid CSV file.");
                    return false;
                }
                catch
                {
                    MessageBox.Show("There was an unknown error. Check that you selected the right file and make sure you close any programs that might be using it.");
                    return false;
                }
            }
            List<string> newRegister = new List<string>();
            foreach (string k in months.Keys)
            {
                newRegister.Add($"{k}\t{months[k]}");
            }
            newRegister.Add($"{year} {month}\t" + path);

            File.WriteAllLines("register.zptdata", newRegister);

            Initialize();

            monthListSelected.SelectedIndex = monthListSelected.Items.IndexOf($"{year} {month}");
            monthListSelected_SelectedIndexChanged(monthListSelected, new EventArgs());
            applyDefaults_Click(applyDefaults, new EventArgs());
            return true;
        }

        #region Tables
        private void patronListSelected_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void patronListSelected_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            tableChanged();
        }

        private void patronListSelected_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            tableChanged();
        }

        private void patronListCompare_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion

        private void monthListSelected_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedList = Patron.loadPatronListFromFile(months[monthListSelected.SelectedItem.ToString()]);
            patronListSelected.DataSource = selectedList;
            selected = monthListSelected.SelectedItem.ToString();
            refreshCompareTable();
        }

        private void monthListCompare_SelectedIndexChanged(object sender, EventArgs e)
        {
            compareList = Patron.loadPatronListFromFile(months[monthListCompare.SelectedItem.ToString()]);
            patronListCompare.DataSource = compareList;
            refreshCompareTable();
        }

        private void compareValues_CheckedChanged(object sender, EventArgs e)
        {
            refreshCompareTable();
        }

        private void addMonth_Click(object sender, EventArgs e)
        {
            NewMonth newMonthForm = new NewMonth(this);
            newMonthForm.Show();
        }

        private void generateReport_Click(object sender, EventArgs e)
        {
            GenerateReport generateReportForm = new GenerateReport(this);
            generateReportForm.Show();
        }

        private void lockEditing_CheckedChanged(object sender, EventArgs e)
        {
            patronListSelected.ReadOnly = lockEditing.Checked;
        }

        private void switchSelected_Click(object sender, EventArgs e)
        {
            int old = monthListSelected.SelectedIndex;
            monthListSelected.SelectedIndex = monthListCompare.SelectedIndex;
            monthListCompare.SelectedIndex = old;
            monthListSelected_SelectedIndexChanged(monthListSelected, new EventArgs());
            monthListCompare_SelectedIndexChanged(monthListCompare, new EventArgs());
        }

        #region Labels
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void deleteMonth_Click(object sender, EventArgs e)
        {
            DeleteMonth deleteMonthForm = new DeleteMonth(this);
            deleteMonthForm.Show();
        }

        public BindingList<Patron> compareMonths(BindingList<Patron> month1, BindingList<Patron> month2)
        {
            return new BindingList<Patron>(month1.Except(month2).Union(month2.Except(month1)).OrderBy(x => x.PatreonName).ToList());
        }

        private void tableChanged()
        {
            refreshCompareTable();
            Patron.writePatronListToFile(months[selected], (BindingList<Patron>)patronListSelected.DataSource);
        }

        private void refreshCompareTable()
        {
            if (patronListCompare.DataSource != null && patronListSelected.DataSource != null)
            {
                if (compareValues.Checked)
                {
                    PredCompare<Patron> nameComparer = new PredCompare<Patron>(
                        (p1, p2) => p1.PatreonName.Equals(p2.PatreonName),
                        (p1) => p1.PatreonName.GetHashCode());
                    BindingList<Patron> compare = compareMonths(
                        selectedList,
                        compareList);
                    patronListCompare.DataSource = compare;
                    for (int row = 0; row < compare.Count; row++)
                    {
                        if (selectedList.Contains(compare[row], nameComparer) && compareList.Contains(compare[row], nameComparer))
                        {
                            Patron oldPatron = compareList.First(x => x.PatreonName == compare[row].PatreonName);
                            Patron newPatron = selectedList.First(x => x.PatreonName == compare[row].PatreonName);

                            if (!oldPatron.EmailAddress.Equals(newPatron.EmailAddress))
                                patronListCompare.Rows[row].Cells[1].Style = CHANGED;
                            if (!oldPatron.Pledge.Equals(newPatron.Pledge))
                                patronListCompare.Rows[row].Cells[2].Style = CHANGED;
                            if (!oldPatron.ProducerName.Equals(newPatron.ProducerName))
                                patronListCompare.Rows[row].Cells[3].Style = CHANGED;
                            if (!oldPatron.DiscordName.Equals(newPatron.DiscordName))
                                patronListCompare.Rows[row].Cells[4].Style = CHANGED;
                            if (!oldPatron.MinecraftIGN.Equals(newPatron.MinecraftIGN))
                                patronListCompare.Rows[row].Cells[5].Style = CHANGED;
                            if (!oldPatron.LifetimeContribution.Equals(newPatron.LifetimeContribution))
                                patronListCompare.Rows[row].Cells[6].Style = CHANGED;

                            row = Helper.Remove(compare, oldPatron, row);
                        }
                        else if (selectedList.Contains(compare[row]))
                        {

                            patronListCompare.Rows[row].DefaultCellStyle = ADDED;
                        }
                        else
                        {
                            patronListCompare.Rows[row].DefaultCellStyle = REMOVED;
                        }
                    }
                }
                else
                    patronListCompare.DataSource = compareList;
            }
        }

        private void defaults_Click(object sender, EventArgs e)
        {
            defaultsMenu.Show(MousePosition);
        }

        private void modifyDefaults_Click(object sender, EventArgs e)
        {
            DefaultPatronValues form = new DefaultPatronValues();
            form.Show();
        }

        private void createAnonymousBackup_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory("Anonymous");
            Dictionary<string, int> patronDict = new Dictionary<string, int>();
            foreach (string path in months.Values)
            {
                BindingList<Patron> anon = new BindingList<Patron>();
                foreach (Patron patron in Patron.loadPatronListFromFile(path))
                {
                    int id;
                    if (patronDict.ContainsKey(patron.PatreonName))
                    {
                        id = patronDict[patron.PatreonName];
                    }
                    else
                    {
                        id = patronDict.Keys.Count;
                        patronDict[patron.PatreonName] = id;
                    }
                    patron.PatreonName = $"Patron{id}";
                    patron.EmailAddress = $"patron{id}@gmail.com";
                    patron.ProducerName = patron.ProducerName != "" ? $"Prod{id}" : "";
                    patron.DiscordName = patron.DiscordName != "" ? $"Patron#{id}" : "";
                    patron.MinecraftIGN = patron.MinecraftIGN != "" ? $"MC{id}" : "";
                    anon.Add(patron);
                }
                Patron.writePatronListToFile($@"Anonymous\anon_{path}", anon);
            }
            List<string> newRegister = new List<string>();
            foreach (string k in months.Keys)
            {
                newRegister.Add($"{k}\tanon_{months[k]}");
            }
            File.WriteAllLines(@"Anonymous\register.zptdata", newRegister);

            BindingList<Patron> anon_defaults = new BindingList<Patron>();
            foreach (Patron patron in Patron.loadPatronListFromFile(@"Anonymous\defaults"))
            {
                int id;
                if (patronDict.ContainsKey(patron.PatreonName))
                {
                    id = patronDict[patron.PatreonName];
                }
                else
                {
                    id = patronDict.Keys.Count;
                    patronDict[patron.PatreonName] = id;
                }
                patron.PatreonName = $"Patron{id}";
                patron.EmailAddress = $"patron{id}@gmail.com";
                patron.ProducerName = patron.ProducerName != "" ? $"Prod{id}" : "";
                patron.DiscordName = patron.DiscordName != "" ? $"Patron#{id}" : "";
                patron.MinecraftIGN = patron.MinecraftIGN != "" ? $"MC{id}" : "";
                anon_defaults.Add(patron);
            }
            Patron.writePatronListToFile(@"Anonymous\defaults.zptdata", anon_defaults);

            MessageBox.Show("Backup Made!");
        }

        private void debug_Click(object sender, EventArgs e)
        {
            debugMenu.Show(MousePosition);
        }

        private void applyDefaults_Click(object sender, EventArgs e)
        {
            if (selectedList == null)
            {
                MessageBox.Show("No month is currently selected!");
                return;
            }
            if (MessageBox.Show($"Apply defaults to {(string)monthListSelected.SelectedItem}?", "Apply Defaults", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                BindingList<Patron> patrons = new BindingList<Patron>();
                BindingList<Patron> defaults = Patron.loadPatronListFromFile("defaults.zptdata");
                foreach (Patron p in selectedList.ToArray())
                {
                    Patron[] d = defaults.Where(x => p.PatreonName == x.PatreonName).ToArray();
                    if (d.Length > 0)
                    {
                        if (d[0].ProducerName != "")
                            p.ProducerName = d[0].ProducerName;
                        if (d[0].DiscordName != "")
                            p.DiscordName = d[0].DiscordName;
                        if (d[0].MinecraftIGN != "")
                            p.MinecraftIGN = d[0].MinecraftIGN;
                        if (d[0].EmailAddress != "")
                            p.EmailAddress = d[0].EmailAddress;
                        patrons.Add(p);
                    }
                    else
                    {
                        patrons.Add(p);
                    }
                }
                patronListSelected.DataSource = patrons;
                tableChanged();
            }
        }
    }
}
