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
    public partial class ConfirmForm : Form
    {
        Character GeneratedCharacter;
        public ConfirmForm(Character CurrentToon)
        {
            InitializeComponent();
            GeneratedCharacter = CurrentToon;
        }

        private void ConfirmForm_Load(object sender, EventArgs e)
        {
            this.Text = GeneratedCharacter.FirstName + " " + GeneratedCharacter.LastName + " - " + " - D&D 5th Edition Character Generator";
            String FullName = GeneratedCharacter.FirstName + " " + GeneratedCharacter.LastName;

            // Display details
            LblDisplayFullName.Text = FullName;
            LblDisplayAge.Text = GeneratedCharacter.Age;
            LblDisplayHeight.Text = GeneratedCharacter.Height;
            LblDisplayWeight.Text = GeneratedCharacter.Weight;
            LblDisplayRace.Text = GeneratedCharacter.Race;
            LblDisplaySubrace.Text = GeneratedCharacter.Subrace;
            LblDisplayClass.Text = GeneratedCharacter.Class;
            LblDisplayBackground.Text = GeneratedCharacter.Background;

            // Display attributes
            lblStrength.Text = "Strength - " + GeneratedCharacter.Attributes["Strength"];
            lblDexterity.Text = "Dexterity - " + GeneratedCharacter.Attributes["Dexterity"];
            lblConstitution.Text = "Constitution - " + GeneratedCharacter.Attributes["Constitution"];
            lblIntelligence.Text = "Intelligence - " + GeneratedCharacter.Attributes["Intelligence"];
            lblWisdom.Text = "Wisdom - " + GeneratedCharacter.Attributes["Wisdom"];
            lblCharisma.Text = "Charisma - " + GeneratedCharacter.Attributes["Charisma"];

            // Display skills
            lblAcrobatics.Text = "Acrobatics: " + GeneratedCharacter.SkillsList["Acrobatics"];
            lblArcana.Text = "Arcana: " + GeneratedCharacter.SkillsList["Arcana"];
            lblAthletics.Text = "Athletics: " + GeneratedCharacter.SkillsList["Athletics"];
            lblAnimalHandling.Text = "Animal Handling: " + GeneratedCharacter.SkillsList["Animal Handling"];
            lblDeception.Text = "Deception: " + GeneratedCharacter.SkillsList["Deception"];
            lblHistory.Text = "History: " + GeneratedCharacter.SkillsList["History"];
            lblInsight.Text = "Insight: " + GeneratedCharacter.SkillsList["Insight"];
            lblIntimidation.Text = "Intimidation: " + GeneratedCharacter.SkillsList["Intimidation"];
            lblInvestigation.Text = "Investigation: " + GeneratedCharacter.SkillsList["Investigation"];
            lblMedicine.Text = "Medicine: " + GeneratedCharacter.SkillsList["Medicine"];
            lblNature.Text = "Nature: " + GeneratedCharacter.SkillsList["Nature"];
            lblPerception.Text = "Perception: " + GeneratedCharacter.SkillsList["Perception"];
            lblPerformance.Text = "Performance: " + GeneratedCharacter.SkillsList["Performance"];
            lblPersuasion.Text = "Persuasion: " + GeneratedCharacter.SkillsList["Persuasion"];
            lblReligion.Text = "Religion: " + GeneratedCharacter.SkillsList["Religion"];
            lblSleightofhand.Text = "Sleight of Hand: " + GeneratedCharacter.SkillsList["Sleight of Hand"];
            lblStealth.Text = "Stealth: " + GeneratedCharacter.SkillsList["Stealth"];
            lblSurvival.Text = "Survival: " + GeneratedCharacter.SkillsList["Survival"];
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            var ConfirmCharacter = MessageBox.Show("Confirm and save character", "Confirm character", MessageBoxButtons.YesNo);
            if (ConfirmCharacter == DialogResult.Yes)
            {
                Globals.CharacterList.Add(GeneratedCharacter);
                this.Hide();
                Form Menu = new MainMenu();
                Menu.Show();
            }
            
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Form MakeChanges = new NewToon(GeneratedCharacter);
            MakeChanges.Show();
            this.Hide();
        }
    }
}
