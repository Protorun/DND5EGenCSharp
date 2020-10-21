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
        }

        private void BtnFinished_Click(object sender, EventArgs e)
        {
            // Set skill proficiencies according to tagged radio buttons
            // Pass back to main NewToon form




            this.Hide();
        }

        private void PresetClassProfs(Character ThisToon)
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

        private void PresetRaceProfs(Character ThisToon)
        {
            string ToonRace = ThisToon.Race;
            if (ToonRace == "Elf")
            {

            }
            else if (ToonRace == "Half-Elf")
            {

            }

        }

        private void PresetBackgroundProfs(Character ThisToon)
        {
            string ToonBackground = ThisToon.Background;
            if (ToonBackground == "Acolyte")
            {
                ThisToon.SkillProficiencies.Add("Insight");
                ThisToon.SkillProficiencies.Add("Religion");
            }
            else if (ToonBackground == "Charlatan")
            {
                ThisToon.SkillProficiencies.Add("Deception");
                ThisToon.SkillProficiencies.Add("Sleight of Hand");
            }
            else if (ToonBackground == "Criminal/Spy")
            {
                ThisToon.SkillProficiencies.Add("Deception");
                ThisToon.SkillProficiencies.Add("Stealth");
            }
            else if (ToonBackground == "Entertainer")
            {
                ThisToon.SkillProficiencies.Add("Acrobatics");
                ThisToon.SkillProficiencies.Add("Performance");
            }
            else if (ToonBackground == "Folk Hero")
            {
                ThisToon.SkillProficiencies.Add("Animal Handling");
                ThisToon.SkillProficiencies.Add("Survival");
            }
            else if (ToonBackground == "Gladiator")
            {
                ThisToon.SkillProficiencies.Add("Acrobatics");
                ThisToon.SkillProficiencies.Add("Performance");
            }
            else if (ToonBackground == "Guild Artisan/Merchant")
            {
                ThisToon.SkillProficiencies.Add("Insight");
                ThisToon.SkillProficiencies.Add("Persuasion");
            }
            else if (ToonBackground == "Hermit")
            {
                ThisToon.SkillProficiencies.Add("Medicine");
                ThisToon.SkillProficiencies.Add("Religion");
            }
            else if (ToonBackground == "Knight")
            {
                ThisToon.SkillProficiencies.Add("History");
                ThisToon.SkillProficiencies.Add("Persuasion");
            }
            else if (ToonBackground == "Noble")
            {
                ThisToon.SkillProficiencies.Add("History");
                ThisToon.SkillProficiencies.Add("Persuasion");
            }
            else if (ToonBackground == "Outlander")
            {
                ThisToon.SkillProficiencies.Add("Athletics");
                ThisToon.SkillProficiencies.Add("Survival");
            }
            else if (ToonBackground == "Pirate")
            {
                ThisToon.SkillProficiencies.Add("Athletics");
                ThisToon.SkillProficiencies.Add("Perception");
            }
            else if (ToonBackground == "Sage")
            {
                ThisToon.SkillProficiencies.Add("Arcana");
                ThisToon.SkillProficiencies.Add("History");
            }
            else if (ToonBackground == "Sailor")
            {
                ThisToon.SkillProficiencies.Add("Athletics");
                ThisToon.SkillProficiencies.Add("Perception");
            }
            else if (ToonBackground == "Soldier")
            {
                ThisToon.SkillProficiencies.Add("Athletics");
                ThisToon.SkillProficiencies.Add("Intimidation");
            }
            else if (ToonBackground == "Urchin")
            {
                ThisToon.SkillProficiencies.Add("Sleight of Hand");
                ThisToon.SkillProficiencies.Add("Stealth");
            }
        }
    }
}
