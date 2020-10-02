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



namespace DND5eCharacterGeneratorCSharp
{
    public partial class MainForm : Form
    {
        List<Character>  CharacterList = new List<Character>();
        string FullName, FirstName, LastName, CharacterRace, CharacterSubrace, CharacterClass, CharacterBackground;
        //Character ThisToon = new Character();

        public MainForm()
        {
            InitializeComponent();
        }


        private void TxtFirstName_TextChanged(object sender, EventArgs e)
        {
            FirstName = TxtFirstName.Text;
            FullName = FirstName + " " + LastName;
            if (string.IsNullOrEmpty(FirstName))
            {
                TxtFirstName.Text = "Input name";
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnTest_Click(object sender, EventArgs e)
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
            Character TestToon = CharacterList[CharacterList.Count - 1];
            Console.WriteLine(CharacterList.Count);
            Console.WriteLine(TestToon.FirstName);
            if (TestToon.Feats.ContainsKey("Darkvision"))
            {
                Console.WriteLine(TestToon.Feats["Darkvision"]);
            }
            
            //Console.WriteLine("Strength - " + TestToon.Attributes["Strength"]);
            //Console.WriteLine(CharacterList[1].FirstName);
            //Console.WriteLine(CharacterList[1].Attributes["Charisma"]);
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
            this.Text = FirstName + " " + LastName + " - " + " - D&D 5th Edition Character Generator";
            FullName = FirstName + " " + LastName;
            lblDisplayFullName.Text = FullName;
            lblDisplayRace.Text = CharacterRace;
            lblDisplaySubrace.Text = CharacterSubrace;
            lblDisplayClass.Text = CharacterClass;
            lblDisplayBackground.Text = CharacterBackground;
            Character ThisToon = new Character(FirstName, LastName, TxtAge.Text, TxtHeight.Text, TxtWeight.Text, CharacterRace, CharacterSubrace, CharacterClass, CharacterBackground);

            Calcs calcs = new Calcs();
            int[] RollArray = calcs.RollArray();
            ThisToon.SetAttribute(ThisToon, "Strength", RollArray[0]);
            ThisToon.SetAttribute(ThisToon, "Dexterity", RollArray[1]);
            ThisToon.SetAttribute(ThisToon, "Constitution", RollArray[2]);
            ThisToon.SetAttribute(ThisToon, "Intelligence", RollArray[3]);
            ThisToon.SetAttribute(ThisToon, "Wisdom", RollArray[4]);
            ThisToon.SetAttribute(ThisToon, "Charisma", RollArray[5]);

            SubraceSetup SRS = new SubraceSetup();
            if (CharacterRace == "Dragonborn")
            {
                SRS.DragonbornSetup(ListSubrace);
            }
            else if (CharacterRace == "Dwarf")
            {
                SRS.DwarfSetup(ThisToon);
            }
            else if (CharacterRace == "Elf")
            {
                SRS.ElfSetup(ListSubrace);
            }
            else if (CharacterRace == "Gnome")
            {
                SRS.GnomeSetup(ListSubrace);
            }
            else if (CharacterRace == "Half-Elf")
            {
                SRS.HalfElfSetup();
            }
            else if (CharacterRace == "Halfling")
            {
                SRS.HalflingSetup(ListSubrace);
            }
            else if (CharacterRace == "Half-Orc")
            {
                SRS.HalfOrcSetup();
            }
            else if (CharacterRace == "Human")
            {
                SRS.HumanSetup();
            }
            else if (CharacterRace == "Tiefling")
            {
                SRS.TieflingSetup();
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

            lblDisplayRolls.Text = "Your rolls are - " + RollArray[0] + " , " + RollArray[1] + " , " + RollArray[2] + " , " + RollArray[3] + " , " + RollArray[4] + " , " + RollArray[5];

            CharacterList.Add(ThisToon);


        }

    }
}
