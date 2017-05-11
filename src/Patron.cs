using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZedaphPatreonTool
{
    public class Patron
    {
        public string PatreonName { get; set; } = "";
        public string EmailAddress { get; set; } = "";
        public decimal Pledge { get; set; } = 0;
        public string ProducerName { get; set; } = "";
        public string DiscordName { get; set; } = "";
        public string MinecraftIGN { get; set; } = "";
        public decimal LifetimeContribution { get; set; } = 0;

        public Patron()
        {

        }

        public static BindingList<Patron> loadPatronListFromFile(string path)
        {
            var patrons = new BindingList<Patron>();

            foreach (var line in File.ReadAllLines(path))
            {
                var columns = line.Split('\t');
                patrons.Add(new Patron
                {
                    PatreonName = columns[0],
                    EmailAddress = columns[1],
                    Pledge = Convert.ToDecimal(columns[2]),
                    ProducerName = columns[3],
                    DiscordName = columns[4],
                    MinecraftIGN = columns[5],
                    LifetimeContribution = Convert.ToDecimal(columns[6])
                });
            }
            return patrons;
        }

        public static void writePatronListToFile(string path, BindingList<Patron> list)
        {
            string[] writeout = new string[list.Count];
            for (int i = 0; i < writeout.Length; i++)
            {
                Patron p = list[i];
                writeout[i] = string.Join("\t", new string[]{
                p.PatreonName,
                p.EmailAddress,
                p.Pledge.ToString(),
                p.ProducerName,
                p.DiscordName,
                p.MinecraftIGN,
                p.LifetimeContribution.ToString()
                });
            }
            File.WriteAllLines(path, writeout);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Patron p = (Patron)obj;
            return
                p.PatreonName.Equals(PatreonName) &&
                p.EmailAddress.Equals(EmailAddress) &&
                p.Pledge.Equals(Pledge) &&
                p.ProducerName.Equals(ProducerName) &&
                p.DiscordName.Equals(DiscordName) &&
                p.MinecraftIGN.Equals(MinecraftIGN) &&
                p.LifetimeContribution.Equals(LifetimeContribution);
        }

        public override int GetHashCode()
        {
            int hash = 2;
            hash *= 3 + ((PatreonName == null) ? 0 : PatreonName.GetHashCode());
            hash *= 5 + ((EmailAddress == null) ? 0 : EmailAddress.GetHashCode());
            hash *= 7 +  Pledge.GetHashCode();
            hash *= 11 + ((ProducerName == null) ? 0 : ProducerName.GetHashCode());
            hash *= 13 + ((DiscordName == null) ? 0 : DiscordName.GetHashCode());
            hash *= 17 + ((MinecraftIGN == null) ? 0 : MinecraftIGN.GetHashCode());
            hash *= 19 + LifetimeContribution.GetHashCode();
            return hash;
        }
    }
}
