using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DND5eCharacterGeneratorCSharp
{
    public partial class SkillProficiency : Form
    {
        public SkillProficiency()
        {
            InitializeComponent();
        }

        public SkillProficiency(Character ThisToon)
        {
            InitializeComponent();
            PresetBackgroundProfs(ThisToon);
            LblNumberProfs.Text = ThisToon.ExcessProfs.ToString();
            if (ThisToon.SkillProficiencies.Contains("Acrobatics"))
            {
                RadioAcrobatics.Checked = true;
            }
        }

        private void BtnFinished_Click(object sender, EventArgs e)
        {
            // Set skill proficiencies according to tagged radio buttons
            // Pass back to main NewToon form
            //Form Confirm = new ConfirmForm(ThisToon);
            //Confirm.Show();



            this.Hide();
        }

        public void PresetClassProfs(Character ThisToon)
        {
            // Preselect and lock automatic proficiencies for class
            string ToonClass = ThisToon.Class;
            if (ToonClass == "Barbarian")
            {

            }
            else if (ToonClass == "Bard")
            {

            }

        }

        public void PresetRaceProfs(Character ThisToon)
        {
            string ToonRace = ThisToon.Race;
            if (ToonRace == "Elf")
            {

            }
            else if (ToonRace == "Half-Elf")
            {

            }

        }

        public void PresetBackgroundProfs(Character ThisToon)
        {
            if (ThisToon.Background == "Acolyte")
            {
                AddProficiency(ThisToon, "Insight");
                AddProficiency(ThisToon, "Religion");
                RadioInsight.Checked = true;
                RadioInsight.Enabled = false;
            }
            else if (ThisToon.Background == "Charlatan")
            {
                AddProficiency(ThisToon, "Deception");
                AddProficiency(ThisToon, "Sleight of Hand");
            }
            else if (ThisToon.Background == "Criminal/Spy")
            {
                AddProficiency(ThisToon, "Deception");
                AddProficiency(ThisToon, "Stealth");
            }
            else if (ThisToon.Background == "Entertainer")
            {
                AddProficiency(ThisToon, "Acrobatics");
                AddProficiency(ThisToon, "Performance");
            }
            else if (ThisToon.Background == "Folk Hero")
            {
                AddProficiency(ThisToon, "Animal Handling");
                AddProficiency(ThisToon, "Survival");
            }
            else if (ThisToon.Background == "Gladiator")
            {
                AddProficiency(ThisToon, "Acrobatics");
                AddProficiency(ThisToon, "Performance");
            }
            else if (ThisToon.Background == "Guild Artisan/Merchant")
            {
                AddProficiency(ThisToon, "Insight");
                AddProficiency(ThisToon, "Persuasion");
            }
            else if (ThisToon.Background == "Hermit")
            {
                AddProficiency(ThisToon, "Medicine");
                AddProficiency(ThisToon, "Religion");
            }
            else if (ThisToon.Background == "Knight")
            {
                AddProficiency(ThisToon, "History");
                AddProficiency(ThisToon, "Persuasion");
            }
            else if (ThisToon.Background == "Noble")
            {
                AddProficiency(ThisToon, "History");
                AddProficiency(ThisToon, "Persuasion");
            }
            else if (ThisToon.Background == "Outlander")
            {
                AddProficiency(ThisToon, "Athletics");
                AddProficiency(ThisToon, "Survival");
            }
            else if (ThisToon.Background == "Pirate")
            {
                AddProficiency(ThisToon, "Athletics");
                AddProficiency(ThisToon, "Survival");
            }
            else if (ThisToon.Background == "Sage")
            {
                AddProficiency(ThisToon, "Arcana");
                AddProficiency(ThisToon, "History");
            }
            else if (ThisToon.Background == "Sailor")
            {
                AddProficiency(ThisToon, "Athletics");
                AddProficiency(ThisToon, "Perception");
            }
            else if (ThisToon.Background == "Soldier")
            {
                AddProficiency(ThisToon, "Athletics");
                AddProficiency(ThisToon, "Intimidation");
            }
            else if (ThisToon.Background == "Urchin")
            {
                AddProficiency(ThisToon, "Sleight of Hand");
                AddProficiency(ThisToon, "Stealth");
            }
        }

        public void AddProficiency(Character ThisToon, string Skill)
        {
            if (!ThisToon.SkillProficiencies.Contains(Skill))
            {
                ThisToon.SkillProficiencies.Add(Skill);
            }
            else if (ThisToon.SkillProficiencies.Contains(Skill))
            {
                ThisToon.ExcessProfs += 1;
            }
        }

    }
}
