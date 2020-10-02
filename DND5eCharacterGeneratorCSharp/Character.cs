using DND5eCharacterGeneratorCSharp;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

/// <summary>
/// Character Object
/// </summary>
public class Character
{
	public string FirstName, LastName, Age, Height, Weight, Race, Subrace, Class, Background;
	public int HitPoints,
		Strength,
		Dexterity,
		Constitution,
		Intelligence,
		Wisdom,
		Charisma,
		StrMod,
		DexMod,
		ConMod,
		IntMod,
		WisMod,
		ChaMod,
		Level;

	public Dictionary<string, int> Attributes = new Dictionary<string, int>();
	public Dictionary<string, string> Feats = new Dictionary<string, string>();

	public Character(string ToonFirstName, string ToonLastName, string ToonAge, string ToonHeight, string ToonWeight, string ToonRace, string ToonSubrace, string ToonClass, string ToonBackground)
	{
		FirstName = ToonFirstName;
		LastName = ToonLastName;
		Age = ToonAge;
		Height = ToonHeight;
		Weight = ToonWeight;
		Race = ToonRace;
		Subrace = ToonSubrace;
		Class = ToonClass;
		Background = ToonBackground;
		HitPoints = RollHP(Class);
		Level = 1;
		Dictionary<string, int> Attributes = new Dictionary<string, int>();
		Attributes.Add("Strength", 0);
		Attributes.Add("Dexterity", 0);
		Attributes.Add("Constitution", 0);
		Attributes.Add("Intelligence", 0);
		Attributes.Add("Wisdom", 0);
		Attributes.Add("Charisma", 0);
		Dictionary<string, string> Feats = new Dictionary<string, string>();
	}

	public Character()
    {

    }

	private int RollHP(String ClassName)
    {
		int Result;
		if(ClassName == "Barbarian")
        {
            Result = Calcs.RollDice(12);
        }
		else if(ClassName == "Bard")
        {
			Result = Calcs.RollDice(8);
        }
		else if (ClassName == "Cleric")
		{
			Result = Calcs.RollDice(8);
		}
		else if (ClassName == "Druid")
		{
			Result = Calcs.RollDice(8);
		}
		else if (ClassName == "Fighter")
		{
			Result = Calcs.RollDice(10);
		}
		else if (ClassName == "Monk")
		{
			Result = Calcs.RollDice(8);
		}
		else if (ClassName == "Paladin")
		{
			Result = Calcs.RollDice(10);
		}
		else if (ClassName == "Ranger")
		{
			Result = Calcs.RollDice(10);
		}
		else if (ClassName == "Rogue")
		{
			Result = Calcs.RollDice(8);
		}
		else if (ClassName == "Sorcerer")
		{
			Result = Calcs.RollDice(6);
		}
		else if (ClassName == "Warlock")
		{
			Result = Calcs.RollDice(8);
		}
		else if (ClassName == "Wizard")
		{
			Result = Calcs.RollDice(6);
		}
        else
        {
			Result = 0;
        }
		return Result;
    }

	public string LevelUp(string ClassName)
    {
		HitPoints += RollHP(ClassName) + ConMod;
		string Confirm = ("HP roll for level up = " + HitPoints);
		return Confirm;
    }

	public void SetAttribute(Character ThisToon, string AttName, int AttValue)
    {
        if (ThisToon.Attributes.ContainsKey(AttName))
        {
			ThisToon.Attributes[AttName] = AttValue;
		}
        else
        {
			ThisToon.Attributes.Add(AttName, AttValue);
        }
		
    }

	public void ModifyAttribute(Character ThisToon, string AttName, int AddedValue)
    {
		if (ThisToon.Attributes.ContainsKey(AttName))
        {
			int Value = ThisToon.Attributes[AttName];
			Value += AddedValue;
			ThisToon.Attributes[AttName] = Value;
        }		
    }

	public void AddFeat(Character ThisToon, string FeatName, string FeatDesc)
    {
		if (!ThisToon.Feats.ContainsKey(FeatName))
        {
			ThisToon.Feats.Add(FeatName, FeatDesc);
        }
    }
}
