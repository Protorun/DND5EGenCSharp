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
    public partial class LoadToon : Form
    {
        public LoadToon()
        {
            InitializeComponent();
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Menu = new MainMenu();
            Menu.Show();
        }

        private void BtnLoadToon_Click(object sender, EventArgs e)
        {
            //LoadedToon = Globals.CharacterList
            for (int i = 0; i <= Globals.CharacterList.Count - 1; i++)
            {
                if (Globals.CharacterList[i].FirstName == TxtSearchName.Text)
                {
                    Character LoadedToon = Globals.CharacterList[i];
                    PopulateDetails(LoadedToon);
                }
            }
            GroupDisplayDetails.Visible = true;
            GroupDisplayAttributes.Visible = true;
            GroupDisplayFeats.Visible = true;
            GroupDisplayProf.Visible = true;
            GroupDisplaySkills.Visible = true;
        }

        private void PopulateDetails(Character SelectedToon)
        {
            this.Text = SelectedToon.FirstName + " " + SelectedToon.LastName + " - " + " - D&D 5th Edition Character Generator";
            String FullName = SelectedToon.FirstName + " " + SelectedToon.LastName;

            // Display details
            LblDisplayFullName.Text = FullName;
            LblDisplayAge.Text = SelectedToon.Age;
            LblDisplayHeight.Text = SelectedToon.Height;
            LblDisplayWeight.Text = SelectedToon.Weight;
            LblDisplayRace.Text = SelectedToon.Race;
            LblDisplaySubrace.Text = SelectedToon.Subrace;
            LblDisplayClass.Text = SelectedToon.Class;
            LblDisplayBackground.Text = SelectedToon.Background;

            // Display attributes
            lblStrength.Text = "Strength - " + SelectedToon.Attributes["Strength"];
            lblDexterity.Text = "Dexterity - " + SelectedToon.Attributes["Dexterity"];
            lblConstitution.Text = "Constitution - " + SelectedToon.Attributes["Constitution"];
            lblIntelligence.Text = "Intelligence - " + SelectedToon.Attributes["Intelligence"];
            lblWisdom.Text = "Wisdom - " + SelectedToon.Attributes["Wisdom"];
            lblCharisma.Text = "Charisma - " + SelectedToon.Attributes["Charisma"];

            // Display skills
            lblAcrobatics.Text = "Acrobatics: " + SelectedToon.SkillsList["Acrobatics"];
            lblArcana.Text = "Arcana: " + SelectedToon.SkillsList["Arcana"];
            lblAthletics.Text = "Athletics: " + SelectedToon.SkillsList["Athletics"];
            lblAnimalHandling.Text = "Animal Handling: " + SelectedToon.SkillsList["Animal Handling"];
            lblDeception.Text = "Deception: " + SelectedToon.SkillsList["Deception"];
            lblHistory.Text = "History: " + SelectedToon.SkillsList["History"];
            lblInsight.Text = "Insight: " + SelectedToon.SkillsList["Insight"];
            lblIntimidation.Text = "Intimidation: " + SelectedToon.SkillsList["Intimidation"];
            lblInvestigation.Text = "Investigation: " + SelectedToon.SkillsList["Investigation"];
            lblMedicine.Text = "Medicine: " + SelectedToon.SkillsList["Medicine"];
            lblNature.Text = "Nature: " + SelectedToon.SkillsList["Nature"];
            lblPerception.Text = "Perception: " + SelectedToon.SkillsList["Perception"];
            lblPerformance.Text = "Performance: " + SelectedToon.SkillsList["Performance"];
            lblPersuasion.Text = "Persuasion: " + SelectedToon.SkillsList["Persuasion"];
            lblReligion.Text = "Religion: " + SelectedToon.SkillsList["Religion"];
            lblSleightofhand.Text = "Sleight of Hand: " + SelectedToon.SkillsList["Sleight of Hand"];
            lblStealth.Text = "Stealth: " + SelectedToon.SkillsList["Stealth"];
            lblSurvival.Text = "Survival: " + SelectedToon.SkillsList["Survival"];
        }
    }
}
