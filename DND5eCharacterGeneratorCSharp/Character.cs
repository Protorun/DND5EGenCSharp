using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Character
{
	public String FirstName, LastName, Age, Height, Weight, Race, Class, Background;
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

	public Character(String ToonFirstName, String ToonLastName, String ToonAge, String ToonHeight, String ToonWeight, String ToonRace, String ToonClass, String ToonBackground)
	{
		FirstName = ToonFirstName;
		LastName = ToonLastName;
		Age = ToonAge;
		Height = ToonHeight;
		Weight = ToonWeight;
		Race = ToonRace;
		Class = ToonClass;
		Background = ToonBackground;
		HitPoints = RollHP(Class);
		Level = 1;
		Dictionary<String, int> Attributes = new Dictionary<String, int>();
	}

	private int RollHP(String ClassName)
    {
		int Result;
		if(ClassName == "Barbarian")
        {
            Result = Calcs.RollDice(12);
        }
		if(ClassName == "Bard")
        {
			Result = Calcs.RollDice(8);
        }
		if (ClassName == "Cleric")
		{
			Result = Calcs.RollDice(8);
		}
		if (ClassName == "Druid")
		{
			Result = Calcs.RollDice(8);
		}
		if (ClassName == "Fighter")
		{
			Result = Calcs.RollDice(10);
		}
		if (ClassName == "Monk")
		{
			Result = Calcs.RollDice(8);
		}
		if (ClassName == "Paladin")
		{
			Result = Calcs.RollDice(10);
		}
		if (ClassName == "Ranger")
		{
			Result = Calcs.RollDice(10);
		}
		if (ClassName == "Rogue")
		{
			Result = Calcs.RollDice(8);
		}
		if (ClassName == "Sorcerer")
		{
			Result = Calcs.RollDice(6);
		}
		if (ClassName == "Warlock")
		{
			Result = Calcs.RollDice(8);
		}
		if (ClassName == "Wizard")
		{
			Result = Calcs.RollDice(6);
		}
        else
        {
			Result = 0;
        }
		return Result;
    }

	public String LevelUp(String ClassName)
    {
		HitPoints = HitPoints + RollHP(ClassName);
		String Confirm = ("HP roll for level up = " + HitPoints);
		return Confirm;
    }


}
