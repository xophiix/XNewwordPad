using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XNewwordPadCS
{
    public class NewWordItem
    {
        public enum ProficiencyLevel
        {
            ProficiencyLevelFirstSee,
            ProficiencyLevelUnfamiliar,
            ProficiencyLevelKnown,
            ProficiencyLevelFamiliar,
            ProficiencyLevelMastered,

            ProficiencyLevelCount
        };

        public String Name { get; set; }
        public String Annoucement { get; set; }
        public String Meaning { get; set; }
        public DateTime AddTime { get; set; }
        public ProficiencyLevel Proficiency { get; set; }

        public NewWordItem()
        {
            Name = "";
            Annoucement = "";
            Meaning = "";
            AddTime = DateTime.Now.ToLocalTime();
        }

        public void IncProficiency()
        {
            Proficiency = (ProficiencyLevel)( ((Int32)Proficiency + 1) % (Int32)ProficiencyLevel.ProficiencyLevelCount);
        }

        public void DecProficiency()
        {
            Proficiency = (ProficiencyLevel)( ((Int32)Proficiency - 1) % (Int32)ProficiencyLevel.ProficiencyLevelCount);
        }

        private static string[] ProficiencyNames = new string[]{ "First", "Unfamiliar", "Known", "Familiar", "Mastered" };
        public static string ToProficiencyString( ProficiencyLevel p )
        {
            if ( (Int32)p >= ProficiencyNames.Count<string>() )
                return "Unknown";

            return ProficiencyNames[Convert.ToInt32(p)];
        }

        public NewWordItem Clone()
        {
            NewWordItem cloned = new NewWordItem();
            cloned.Name = Name;
            cloned.Annoucement = Annoucement;
            cloned.Meaning = Meaning;
            cloned.AddTime = AddTime;
            cloned.Proficiency = Proficiency;

            return cloned;
        }

        public string ToText()
        {
            string result = Name.ToString() + "\r\n";
            result += Annoucement.ToString() + "\r\n";
            result += Meaning.ToString() + "\r\n";
            result += AddTime.ToString() + "\r\n";
            result += ToProficiencyString(Proficiency) + "\r\n";
            return result;
        }
    }
}
