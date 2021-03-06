﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Text;

namespace DND5eCharacterGeneratorCSharp
{
    public partial class NewToon : Form
    {
        //List<Character>  CharacterList = new List<Character>();
        string FullName, FirstName, LastName, CharacterRace, CharacterSubrace, CharacterClass, CharacterBackground;
        //Character ThisToon = new Character();

        public NewToon()
        {
            InitializeComponent();
        }

        public NewToon(Character CurrentCharacter)
        {
            InitializeComponent();
            // INITIALISE ITEMS WITH VALUES FROM CurrentCharacter
            TxtFirstName.Text = CurrentCharacter.FirstName;
            TxtLastName.Text = CurrentCharacter.LastName;
            TxtAge.Text = CurrentCharacter.Age;
            TxtHeight.Text = CurrentCharacter.Height;
            TxtWeight.Text = CurrentCharacter.Weight;
            ListRace.SelectedItem = CurrentCharacter.Race;
            ListSubrace.SelectedItem = CurrentCharacter.Subrace;
            ListClass.SelectedItem = CurrentCharacter.Class;
            ListBackground.SelectedItem = CurrentCharacter.Background;
        }

        private void TxtFirstName_TextChanged(object sender, EventArgs e)
        {
            FirstName = TxtFirstName.Text;
            FullName = FirstName + " " + LastName;
            if (string.IsNullOrEmpty(FirstName))
            {
                MessageBox.Show("Please input a first name for your character", "Input error");
                //TxtFirstName.Text = "Input name";
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Feats ToonFeats = new Feats();
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            // TESTS
            // DICE ROLLER RollDice
            //lblDisplayFullName.Text = "d20 dice roll = " + Calcs.RollDice(20);

            // RollArray
            //lblStrength.Text = "Strength - " + RollArray[0];
            //lblDexterity.Text = "Dexterity - " + RollArray[1];
            //lblConstitution.Text = "Constitution - " + RollArray[2];
            //lblIntelligence.Text = "Intelligence - " + RollArray[3];
            //lblWisdom.Text = "Wisdom - " + RollArray[4];
            //lblCharisma.Text = "Charisma - " + RollArray[5];

            // PULLING INFO FROM Character OBJECT
            //lblDisplayFullName.Text = CharacterList[0].FirstName + CharacterList[0].Race + CharacterList[0].Class;

            // RollAttribute
            //int Att = calcs.RollAttribute();
            //String AttString = Att.ToString();
            //lblDisplayFullName.Text = "Attribute roll is - " + Att.ToString();

            // Attributes DICTIONARY IN Character OBJECT
            //foreach (KeyValuePair<string, int> atts in ThisToon.Attributes)
            //{
            //Console.WriteLine("{0} score is - {1}", atts.Key, atts.Value);
            //}

            // Invalid key usage in ModifyAttribute method
            //ThisToon.ModifyAttribute("Bob", 4);

            // Testing CharacterList records
            //Console.WriteLine("CharacterList contains - " + CharacterList.Count + " records.");
            Character TestToon = Globals.CharacterList[Globals.CharacterList.Count - 1];
            Console.WriteLine(Globals.CharacterList.Count);
            Console.WriteLine(TestToon.FirstName);
            if (TestToon.FeatsList.ContainsKey("Darkvision"))
            {
                Console.WriteLine(TestToon.FeatsList["Darkvision"]);
            }

            foreach (KeyValuePair<string, string> kvp in TestToon.FeatsList)
            {
            System.Diagnostics.Debug.WriteLine("FeatName = {0}, FeatDesc = {1}", kvp.Key, kvp.Value);
            }

            
            //Console.WriteLine("Strength - " + TestToon.Attributes["Strength"]);
            //Console.WriteLine(CharacterList[0].FirstName);
            //Console.WriteLine(CharacterList[0].Attributes["Charisma"]);
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Menu = new MainMenu();
            Menu.Show();
        }

        private void BtnRerollStats_Click(object sender, EventArgs e)
        {
            Calcs calcs = new Calcs();
            int[] RollArray = calcs.RollArray();
            lblDisplayRolls.Text = "Your rolls are - " + RollArray[0] + " , " + RollArray[1] + " , " + RollArray[2] + " , " + RollArray[3] + " , " + RollArray[4] + " , " + RollArray[5];
        }

        private void BtnShowSkillsForm_Click(object sender, EventArgs e)
        {
            Form SkillProfs = new SkillProficiency();
            SkillProfs.Show();
        }

        private void BtnShowSheet_Click(object sender, EventArgs e)
        {
            this.Text = FirstName + " " + LastName + " - " + " - D&D 5th Edition Character Generator";
            FullName = FirstName + " " + LastName;
            LblDisplayFullName.Text = FullName;
            LblDisplayAge.Text = TxtAge.Text;
            LblDisplayHeight.Text = TxtHeight.Text;
            LblDisplayWeight.Text = TxtWeight.Text;
            LblDisplayRace.Text = CharacterRace;
            LblDisplaySubrace.Text = CharacterSubrace;
            LblDisplayClass.Text = CharacterClass;
            LblDisplayBackground.Text = CharacterBackground;
            TextDisplayFeats.Text = FullName;
        }

        private void ListRace_SelectedIndexChanged(object sender, EventArgs e)
        {
            CharacterRace = ListRace.SelectedItem.ToString();
            SubraceSetup SRS = new SubraceSetup();
            SRS.SubraceListSetup(ListRace, ListSubrace);
        }

        private void ListSubrace_SelectedIndexChanged(object sender, EventArgs e)
        {
            CharacterSubrace = ListSubrace.SelectedItem.ToString();
        }

        private void TxtLastName_TextChanged(object sender, EventArgs e)
        {
            LastName = TxtLastName.Text;
            if (String.IsNullOrEmpty(FirstName))
            {
                TxtFirstName.Text = "Input name";
            }
        }

        private void ListClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            CharacterClass = ListClass.SelectedItem.ToString();
        }

        private void ListBackground_SelectedIndexChanged(object sender, EventArgs e)
        {
            CharacterBackground = ListBackground.SelectedItem.ToString();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {

            Character ThisToon = new Character(FirstName, LastName, TxtAge.Text, TxtHeight.Text, TxtWeight.Text, CharacterRace, CharacterSubrace, CharacterClass, CharacterBackground);

            Calcs calcs = new Calcs();
            int[] RollArray = calcs.RollArray();
            ThisToon.SetAttribute(ThisToon, "Strength", RollArray[0]);
            ThisToon.SetAttribute(ThisToon, "Dexterity", RollArray[1]);
            ThisToon.SetAttribute(ThisToon, "Constitution", RollArray[2]);
            ThisToon.SetAttribute(ThisToon, "Intelligence", RollArray[3]);
            ThisToon.SetAttribute(ThisToon, "Wisdom", RollArray[4]);
            ThisToon.SetAttribute(ThisToon, "Charisma", RollArray[5]);

            ThisToon.Strength = RollArray[0];
            ThisToon.Dexterity = RollArray[1];
            ThisToon.Constitution = RollArray[2];
            ThisToon.Intelligence = RollArray[3];
            ThisToon.Wisdom = RollArray[4];
            ThisToon.Charisma = RollArray[5];

            //ThisToon.InitialiseAttributes();
            ThisToon.InitialiseSkills(ThisToon);
            ThisToon.SetAttMods(ThisToon);

            SubraceSetup SRS = new SubraceSetup();
            if (CharacterRace == "Dragonborn")
            {
                SRS.DragonbornSetup(ThisToon);
            }
            else if (CharacterRace == "Dwarf")
            {
                SRS.DwarfSetup(ThisToon);
            }
            else if (CharacterRace == "Elf")
            {
                SRS.ElfSetup(ThisToon);
            }
            else if (CharacterRace == "Gnome")
            {
                SRS.GnomeSetup(ThisToon);
            }
            else if (CharacterRace == "Half-Elf")
            {
                SRS.HalfElfSetup(ThisToon);
            }
            else if (CharacterRace == "Halfling")
            {
                SRS.HalflingSetup(ThisToon);
            }
            else if (CharacterRace == "Half-Orc")
            {
                SRS.HalfOrcSetup(ThisToon);
            }
            else if (CharacterRace == "Human")
            {
                SRS.HumanSetup(ThisToon);
            }
            else if (CharacterRace == "Tiefling")
            {
                SRS.TieflingSetup(ThisToon);
            }

            if (ThisToon.Attributes.ContainsKey("Strength"))
            {
                lblStrength.Text = "Strength - " + ThisToon.Attributes["Strength"];
            }

            lblStrength.Text = "Strength - " + ThisToon.Attributes["Strength"];
            lblDexterity.Text = "Dexterity - " + ThisToon.Attributes["Dexterity"];
            lblConstitution.Text = "Constitution - " + ThisToon.Attributes["Constitution"];
            lblIntelligence.Text = "Intelligence - " + ThisToon.Attributes["Intelligence"];
            lblWisdom.Text = "Wisdom - " + ThisToon.Attributes["Wisdom"];
            lblCharisma.Text = "Charisma - " + ThisToon.Attributes["Charisma"];

            LblStrSave.Text = "Strength - " + ThisToon.SavingThrows["Strength"];
            LblDexSave.Text = "Dexterity - " + ThisToon.SavingThrows["Dexterity"];
            LblConSave.Text = "Constitution - " + ThisToon.SavingThrows["Constitution"];
            LblIntSave.Text = "Intelligence - " + ThisToon.SavingThrows["Intelligence"];
            LblWisSave.Text = "Wisdom - " + ThisToon.SavingThrows["Wisdom"];
            LblChaSave.Text = "Charisma - " + ThisToon.SavingThrows["Charisma"];

            lblAthletics.Text = "Athletics - " + ThisToon.SkillsList["Athletics"];
            lblAcrobatics.Text = "Acrobatics - " + ThisToon.SkillsList["Acrobatics"];
            lblSleightofhand.Text = "Sleight of Hand - " + ThisToon.SkillsList["Sleight of Hand"];
            lblStealth.Text = "Stealth - " + ThisToon.SkillsList["Stealth"];
            lblArcana.Text = "Arcana - " + ThisToon.SkillsList["Arcana"];
            lblHistory.Text = "History - " + ThisToon.SkillsList["History"];
            lblInvestigation.Text = "Investigation - " + ThisToon.SkillsList["Investigation"];
            lblNature.Text = "Nature - " + ThisToon.SkillsList["Nature"];
            lblReligion.Text = "Religion - " + ThisToon.SkillsList["Religion"];
            lblAnimalHandling.Text = "Animal Handling - " + ThisToon.SkillsList["Animal Handling"];
            lblInsight.Text = "Insight - " + ThisToon.SkillsList["Insight"];
            lblMedicine.Text = "Medicine - " + ThisToon.SkillsList["Medicine"];
            lblPerception.Text = "Perception - " + ThisToon.SkillsList["Perception"];
            lblSurvival.Text = "Survival - " + ThisToon.SkillsList["Survival"];
            lblDeception.Text = "Deception - " + ThisToon.SkillsList["Deception"];
            lblIntimidation.Text = "Intimidation - " + ThisToon.SkillsList["Intimidation"];
            lblPerformance.Text = "Performance - " + ThisToon.SkillsList["Performance"];
            lblPersuasion.Text = "Persuasion - " + ThisToon.SkillsList["Persuasion"];

            lblDisplayRolls.Text = "Your rolls are - " + RollArray[0] + " , " + RollArray[1] + " , " + RollArray[2] + " , " + RollArray[3] + " , " + RollArray[4] + " , " + RollArray[5];

            ThisToon.ReCalcSkills(ThisToon);

            LblDisplayFullName.Text = ThisToon.StrMod.ToString();

            // Globals.CharacterList.Add(ThisToon);
            //Form Confirm = new ConfirmForm(ThisToon);
            //Confirm.Show();
            //this.Hide();
            Form SkillProfs = new SkillProficiency(ThisToon);
            SkillProfs.Show();

        }

    }
}
