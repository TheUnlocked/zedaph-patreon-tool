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
    public partial class GenerateReport : Form
    {
        Form1 parent;

        public GenerateReport(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
            currentMonth.Items.AddRange(parent.monthList);
            compareTo.Items.AddRange(parent.monthList);
            if (currentMonth.Items.Count > 0)
                currentMonth.SelectedIndex = 0;
            if (compareTo.Items.Count > 1)
                compareTo.SelectedIndex = 1;
        }

        private void generate_Click(object sender, EventArgs e)
        {
            if (compareTo.SelectedItem == null || currentMonth.SelectedItem == null)
                return;

            BindingList<Patron> origSelectedList = Patron.loadPatronListFromFile(parent.months[(string)currentMonth.SelectedItem]);
            BindingList<Patron> compareList = Patron.loadPatronListFromFile(parent.months[(string)compareTo.SelectedItem]);

            #region General
            BindingList<Patron> difference;
            List<string> report = new List<string>();
            report.Add("// GENERAL DATA");
            foreach (Patron patron in origSelectedList)
            {
                List<string> output = new List<string>();
                if (patreonName.Checked)
                {
                    output.Add(patron.PatreonName);
                }
                if (email.Checked)
                {
                    output.Add(patron.EmailAddress);
                }
                if (pledge.Checked)
                {
                    output.Add(patron.Pledge.ToString());
                }
                if (lifetimePledge.Checked)
                {
                    output.Add(patron.LifetimeContribution.ToString());
                }
                report.Add(string.Join(", ", output.ToArray()));
            } 
            #endregion

            #region Producer
            if (producerName.Checked)
            {
                BindingList<Patron> selectedList = new BindingList<Patron>(origSelectedList.Where(x => true).ToList());
                if (producerMin.Checked)
                {
                    selectedList = new BindingList<Patron>(selectedList.Where(x => x.Pledge >= producerMinBox.Value).ToList());
                }
                report.Add("");
                report.Add("// PRODUCERS IN ORDER");
                List<Patron> asks = new List<Patron>();
                foreach (Patron p in selectedList.OrderByDescending(p => p.Pledge))
                {
                    if (!p.ProducerName.Contains(@"\\") || !ignoreAnonymousProducer.Checked)
                    {
                        if (p.ProducerName == "")
                        {
                            asks.Add(p);
                            report.Add(p.PatreonName);
                        }
                        else
                        {
                            report.Add(p.ProducerName);
                        }
                    }
                }
                report.Add("");
                foreach (Patron p in asks)
                {
                    report.Add($"Ask {p.PatreonName} ({p.EmailAddress}) what their producer name should be. Currently using Patreon name as placeholder.");
                }
            }
            #endregion

            PredCompare<Patron> nameComparer = new PredCompare<Patron>(
                        (p1, p2) => p1.PatreonName.Equals(p2.PatreonName),
                        (p1) => p1.PatreonName.GetHashCode());

            #region Discord
            if (discordName.Checked)
            {
                BindingList<Patron> selectedList = new BindingList<Patron>(origSelectedList.Where(x => true).ToList());
                decimal minPledge = 0;
                if (discordMin.Checked)
                {
                    minPledge = discordMinBox.Value;
                    selectedList = new BindingList<Patron>(selectedList.Where(x => x.Pledge >= minPledge).ToList());
                }
                difference = parent.compareMonths(selectedList, compareList);
                report.Add("");
                report.Add("// DISCORD USERS");
                for (int i = 0; i < difference.Count; i++)
                {
                    Patron patron = difference[i];
                    Patron old = null;
                    if (selectedList.Contains(difference[i], nameComparer) && compareList.Contains(difference[i], nameComparer))
                    {
                        patron = selectedList.First(x => x.PatreonName == difference[i].PatreonName);
                        old = compareList.First(x => x.PatreonName == difference[i].PatreonName);
                        if (patron.DiscordName.Equals(old.DiscordName))
                        {
                            if (patron.Pledge >= minPledge && old.Pledge < minPledge)
                            {
                                i = Helper.Remove(difference, old, i);
                                i = Helper.Remove(difference, patron, i);
                                old = null;
                            }
                            else if (patron.Pledge < minPledge && old.Pledge >= minPledge)
                            {
                                i = Helper.Remove(difference, old, i);
                                i = Helper.Remove(difference, patron, i);
                                patron = null;
                            }
                            else
                            {
                                i = Helper.Remove(difference, old, i);
                                i = Helper.Remove(difference, patron, i);
                                old = null;
                                patron = null;
                            }
                        }
                        else
                        {
                            difference.Remove(old);
                        }
                    }
                    else if (compareList.Contains(difference[i]))
                    {
                        if (compareList.First(x => x.PatreonName == difference[i].PatreonName).Pledge >= minPledge)
                        {
                            old = patron;
                        }
                        patron = null;
                    }
                    else if (selectedList.First(x => x.PatreonName == difference[i].PatreonName).Pledge < minPledge)
                    {
                        patron = null;
                    }

                    if (patron != null && patron.DiscordName != "" && (!patron.DiscordName.Contains(@"\\") || !ignoreAnonymousDiscord.Checked))
                    {
                        report.Add($"Add User {patron.DiscordName}");
                    }

                    if (old != null && old.DiscordName != "" && (!old.DiscordName.Contains(@"\\") || !ignoreAnonymousDiscord.Checked))
                    {
                        report.Add($"Remove User {old.DiscordName}");
                    }
                }

                report.Add("");
                foreach (Patron patron in selectedList)
                {
                    if (patron.DiscordName == "")
                        report.Add($"Ask {patron.PatreonName} (email: {patron.EmailAddress}) for their Discord Name");
                }
            }
            #endregion

            #region Whitelist
            if (whitelistCommand.Checked)
            {
                BindingList<Patron> selectedList = new BindingList<Patron>(origSelectedList.Where(x => true).ToList());
                decimal minPledge = 0;
                if (whitelistMin.Checked)
                {
                    minPledge = whitelistMinBox.Value;
                    selectedList = new BindingList<Patron>(selectedList.Where(x => x.Pledge >= minPledge).ToList());
                }
                difference = parent.compareMonths(selectedList, compareList);
                report.Add("");
                report.Add("// WHITELISTS");
                for (int i = 0; i < difference.Count; i++)
                {
                    Patron patron = difference[i];
                    Patron old = null;
                    if (selectedList.Contains(difference[i], nameComparer) && compareList.Contains(difference[i], nameComparer))
                    {
                        patron = selectedList.First(x => x.PatreonName == difference[i].PatreonName);
                        old = compareList.First(x => x.PatreonName == difference[i].PatreonName);
                        if (patron.MinecraftIGN.Equals(old.MinecraftIGN))
                        {
                            if (patron.Pledge >= minPledge && old.Pledge < minPledge)
                            {
                                i = Helper.Remove(difference, old, i);
                                i = Helper.Remove(difference, patron, i);
                                old = null;
                            }
                            else if (patron.Pledge < minPledge && old.Pledge >= minPledge)
                            {
                                i = Helper.Remove(difference, old, i);
                                i = Helper.Remove(difference, patron, i);
                                patron = null;
                            }
                            else
                            {
                                i = Helper.Remove(difference, old, i);
                                i = Helper.Remove(difference, patron, i);
                                old = null;
                                patron = null;
                            }
                        }
                        else
                        {
                            difference.Remove(old);
                        }
                    }
                    else if (compareList.Contains(difference[i]))
                    {
                        if (compareList.First(x => x.PatreonName == difference[i].PatreonName).Pledge >= minPledge)
                        {
                            old = patron;
                        }
                        patron = null;
                    }
                    else if (selectedList.First(x => x.PatreonName == difference[i].PatreonName).Pledge < minPledge)
                    {
                        patron = null;
                    }

                    if (patron != null && patron.MinecraftIGN != "" && (!patron.MinecraftIGN.Contains(@"\\") || !ignoreAnonymousMC.Checked))
                    {
                        report.Add($"/whitelist add {patron.MinecraftIGN}");
                    }

                    if (old != null && old.MinecraftIGN != "" && (!old.MinecraftIGN.Contains(@"\\") || !ignoreAnonymousMC.Checked))
                    {
                        report.Add($"/whitelist remove {old.MinecraftIGN}");
                    }
                }
                report.Add("");
                foreach (Patron patron in selectedList)
                {
                    if (patron.MinecraftIGN == "")
                        report.Add($"Ask {patron.PatreonName} (email: {patron.EmailAddress}) for their Minecraft IGN");
                }
            }
            #endregion

            #region Special
            if (specialCommand.Checked)
            {
                BindingList<Patron> selectedList = new BindingList<Patron>(origSelectedList.Where(x => true).ToList());
                decimal minPledge = 0;
                if (specialMin.Checked)
                {
                    minPledge = specialMinBox.Value;
                    selectedList = new BindingList<Patron>(selectedList.Where(x => x.Pledge >= minPledge).ToList());
                }
                difference = parent.compareMonths(selectedList, compareList);
                report.Add("");
                report.Add("// SPECIAL");
                for (int i = 0; i < difference.Count; i++)
                {
                    Patron patron = difference[i];
                    Patron old = null;
                    if (selectedList.Contains(difference[i], nameComparer) && compareList.Contains(difference[i], nameComparer))
                    {
                        patron = selectedList.First(x => x.PatreonName == difference[i].PatreonName);
                        old = compareList.First(x => x.PatreonName == difference[i].PatreonName);
                        if (patron.MinecraftIGN.Equals(old.MinecraftIGN))
                        {
                            if (patron.PatreonName == "Patron4")
                            {

                            }
                            if (patron.Pledge >= minPledge && old.Pledge < minPledge)
                            {
                                i = Helper.Remove(difference, old, i);
                                i = Helper.Remove(difference, patron, i);
                                old = null;
                            }
                            else if (patron.Pledge < minPledge && old.Pledge >= minPledge)
                            {
                                i = Helper.Remove(difference, old, i);
                                i = Helper.Remove(difference, patron, i);
                                patron = null;
                            }
                            else
                            {
                                i = Helper.Remove(difference, old, i);
                                i = Helper.Remove(difference, patron, i);
                                old = null;
                                patron = null;
                            }
                        }
                        else
                        {
                            difference.Remove(old);
                        }
                    }
                    else if (compareList.Contains(difference[i]))
                    {
                        if (compareList.First(x => x.PatreonName == difference[i].PatreonName).Pledge >= minPledge)
                        {
                            old = patron;
                        }
                        patron = null;
                    }
                    else if (selectedList.First(x => x.PatreonName == difference[i].PatreonName).Pledge < minPledge)
                    {
                        patron = null;
                    }

                    if (patron != null && patron.MinecraftIGN != "" && (!patron.MinecraftIGN.Contains(@"\\") || !ignoreAnonymousMC.Checked))
                    {
                        report.Add($"/scoreboard teams join SUPER-Patreon {patron.MinecraftIGN}");
                    }

                    if (old != null && old.MinecraftIGN != "" && (!old.MinecraftIGN.Contains(@"\\") || !ignoreAnonymousMC.Checked))
                    {
                        report.Add($"/scoreboard teams Leave SUPER-Patreon {old.MinecraftIGN}");
                    }
                }
                report.Add("");
                foreach (Patron patron in selectedList)
                {
                    if (patron.MinecraftIGN == "")
                        report.Add($"Ask {patron.PatreonName} (email: {patron.EmailAddress}) for their Minecraft IGN");
                }
            }
            #endregion

            Report reportForm = new Report(report.ToArray());
            reportForm.Show();
        }

        #region Other stuff
        private void currentMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void compareTo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lifetimePledge_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GenerateReport_Load(object sender, EventArgs e)
        {

        }

        private void patreonName_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pledge_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void email_CheckedChanged(object sender, EventArgs e)
        {

        } 
        #endregion
    }
}
