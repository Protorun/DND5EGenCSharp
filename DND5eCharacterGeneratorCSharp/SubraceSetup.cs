using DND5eCharacterGeneratorCSharp;
using System;
using System.Windows.Forms;

public class SubraceSetup
{

    public SubraceSetup()
    {
        //Feats feats = new Feats();
    }

    public void SubraceListSetup(ListBox ListRace, ListBox ListSubrace)
    {
        if (ListRace.SelectedItem.ToString() == "Dragonborn")
        {
            ListSubrace.Items.Clear();
            ListSubrace.Items.AddRange(new object[]
            {
                    "Black Dragonborn",
                    "Blue Dragonborn",
                    "Brass Dragonborn",
                    "Bronze Dragonborn",
                    "Copper Dragonborn",
                    "Gold Dragonborn",
                    "Green Dragonborn",
                    "Red Dragonborn",
                    "Silver Dragonborn",
                    "White Dragonborn"
            });
        }
        else if (ListRace.SelectedItem.ToString() == "Dwarf")
        {
            ListSubrace.Items.Clear();
            ListSubrace.Items.AddRange(new object[]
            {
                    "Hill Dwarf",
                    "Mountain Dwarf"
            });
        }
        else if (ListRace.SelectedItem.ToString() == "Elf")
        {
            ListSubrace.Items.Clear();
            ListSubrace.Items.AddRange(new object[]
            {
                    "High Elf",
                    "Wood Elf",
                    "Drow"
            });
        }
        else if (ListRace.SelectedItem.ToString() == "Gnome")
        {
            ListSubrace.Items.Clear();
            ListSubrace.Items.AddRange(new object[]
            {
                    "Deep Gnome",
                    "Rock Gnome"
            });
        }
        else if (ListRace.SelectedItem.ToString() == "Half-Elf")
        {
            ListSubrace.Items.Clear();
        }
        else if (ListRace.SelectedItem.ToString() == "Halfling")
        {
            ListSubrace.Items.Clear();
            ListSubrace.Items.AddRange(new object[]
            {
                    "Lightfoot Halfling",
                    "Stout Halfling"
            });
        }
        else if (ListRace.SelectedItem.ToString() == "Half-Orc")
        {
            ListSubrace.Items.Clear();
        }
        else if (ListRace.SelectedItem.ToString() == "Human")
        {
            ListSubrace.Items.Clear();
        }
        else if (ListRace.SelectedItem.ToString() == "Tiefling")
        {
            ListSubrace.Items.Clear();
        }
    }

    public void DragonbornSetup(Character ThisToon)
    {
        ThisToon.ModifyAttribute(ThisToon, "Strength", 2);
        ThisToon.ModifyAttribute(ThisToon, "Charisma", 1);

        if (ThisToon.Subrace == "Black Dragonborn")
        {          
            ThisToon.AddFeat(ThisToon, "Darkvision");
        }
        else if (ThisToon.Subrace == "Blue Dragonborn")
        {

        }
        else if (ThisToon.Subrace == "Brass Dragonborn")
        {

        }
        else if (ThisToon.Subrace == "Bronze Dragonborn")
        {

        }
        else if (ThisToon.Subrace == "Copper Dragonborn")
        {

        }
        else if (ThisToon.Subrace == "Gold Dragonborn")
        {

        }
        else if (ThisToon.Subrace == "Green Dragonborn")
        {

        }
        else if (ThisToon.Subrace == "Red Dragonborn")
        {

        }
        else if (ThisToon.Subrace == "Silver Dragonborn")
        {

        }
        else if (ThisToon.Subrace == "White Dragonborn")
        {

        }
    }

    public void DwarfSetup(Character ThisToon)
    {
        ThisToon.ModifyAttribute(ThisToon, "Constitution", 2);

        ThisToon.AddFeat(ThisToon, "Darkvision");

        if (ThisToon.Subrace == "Hill Dwarf")
        {
            ThisToon.ModifyAttribute(ThisToon, "Wisdom", 1);
        }
        else if (ThisToon.Subrace == "Mountain Dwarf")
        {
            ThisToon.ModifyAttribute(ThisToon, "Strength", 2);
        }
    }

    public void ElfSetup(Character ThisToon)
    {
        ThisToon.ModifyAttribute(ThisToon, "Dexterity", 2);
        ThisToon.AddFeat(ThisToon, "Darkvision");
        ThisToon.AddFeat(ThisToon, "Keen Senses");
        ThisToon.AddFeat(ThisToon, "Fey Ancestry");
        ThisToon.AddFeat(ThisToon, "Trance");
        if (ThisToon.Subrace == "High Elf")
        {

        }
        else if (ThisToon.Subrace == "Wood Elf")
        {

        }
        else if (ThisToon.Subrace == "Drow")
        {

        }

    }

    public void GnomeSetup(Character ThisToon)
    {
        if (ThisToon.Subrace == "Deep Gnome")
        {

        }
        else if (ThisToon.Subrace == "Rock Gnome")
        {

        }
    }

    public void HalfElfSetup(Character ThisToon)
    {
        
    }

    public void HalflingSetup(Character ThisToon)
    {
        if (ThisToon.Subrace == "Lightfoot Halfling")
        {

        }
        else if (ThisToon.Subrace == "Stout Halfling")
        {

        }
    }

    public void HalfOrcSetup(Character ThisToon)
    {

    }

    public void HumanSetup(Character ThisToon)
    {

    }

    public void TieflingSetup(Character ThisToon)
    {

    }

}
