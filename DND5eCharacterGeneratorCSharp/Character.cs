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
	public int Strength,
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
		Level,
		HitPoints,
		Initiative,
		HitDie,
		TempHP,
		Speed,
		ProficiencyBonus;


	public Dictionary<string, int> Attributes = new Dictionary<string, int>();
	public Dictionary<string, string> FeatsList = new Dictionary<string, string>();
	public Dictionary<string, int> SkillsList = new Dictionary<string, int>();

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
		Initiative = 0;
		Speed = 0;
		ProficiencyBonus = 2;
		Dictionary<string, int> Attributes = new Dictionary<string, int>();
		InitialiseAttributes();
		Dictionary<string, string> FeatsList = new Dictionary<string, string>();
		Dictionary<string, int> SkillsList = new Dictionary<string, int>();
		InitialiseSkills();
		Feats Feats = new Feats();
		SetHitDie(Class);
	}

	public Character()
    {

    }

	public void InitialiseAttributes()
    {
		Attributes.Add("Strength", 0);
		Attributes.Add("Dexterity", 0);
		Attributes.Add("Constitution", 0);
		Attributes.Add("Intelligence", 0);
		Attributes.Add("Wisdom", 0);
		Attributes.Add("Charisma", 0);
	}

	public void InitialiseSkills()
    {
		SkillsList.Add("Athletics", StrMod);
		SkillsList.Add("Acrobatics", DexMod);
		SkillsList.Add("Sleight of Hand", DexMod);
		SkillsList.Add("Stealth", DexMod);
		SkillsList.Add("Arcana", IntMod);
		SkillsList.Add("History", IntMod);
		SkillsList.Add("Investigation", IntMod);
		SkillsList.Add("Nature", IntMod);
		SkillsList.Add("Religion", IntMod);
		SkillsList.Add("Animal Handling", WisMod);
		SkillsList.Add("Insight", WisMod);
		SkillsList.Add("Medicine", WisMod);
		SkillsList.Add("Perception", WisMod);
		SkillsList.Add("Survival", WisMod);
		SkillsList.Add("Deception", ChaMod);
		SkillsList.Add("Intimidation", ChaMod);
		SkillsList.Add("Performance", ChaMod);
		SkillsList.Add("Persuasion", ChaMod);
	}

	public int RollHP(String ClassName)
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

	public void SetSkill(Character ThisToon, string SkillName, int SkillValue)
    {
		ThisToon.SkillsList[SkillName] = SkillValue;
    }

	public void ModifySkill(Character ThisToon, string SkillName, int AddedValue)
    {
		ThisToon.SkillsList[SkillName] = ThisToon.SkillsList[SkillName] + AddedValue;
    }

	public void AddFeat(Character ThisToon, string FeatName)
    {
		if (!ThisToon.FeatsList.ContainsKey(FeatName))
		{
			string FeatDesc = Feats.FeatList[FeatName];
			ThisToon.FeatsList.Add(FeatName, FeatDesc);
		}
    }

	public void RemoveFeat(Character ThisToon, string FeatName)
    {
		if (ThisToon.FeatsList.ContainsKey(FeatName))
        {
			ThisToon.FeatsList.Remove(FeatName);
        }
    }

	public void SetInitiative(Character ThisToon, int Value)
    {
		ThisToon.Initiative = Value;
    }

	public void ModifyInitiative(Character ThisToon, int Value)
    {
		ThisToon.Initiative = ThisToon.Initiative + Value;
    }

	public void SetTempHP(Character ThisToon, int Value)
    {
		ThisToon.TempHP = Value;
    }

	public void ModifyTempHP(Character ThisToon, int Value)
    {
		ThisToon.TempHP = ThisToon.TempHP + Value;
    }

	public int SetHitDie(String ClassName)
    {
		int Result = 0;

		if (ClassName == "Barbarian")
		{
			Result = 12;
		}
		else if (ClassName == "Bard")
		{
			Result = 8;
		}
		else if (ClassName == "Cleric")
		{
			Result = 8;
		}
		else if (ClassName == "Druid")
		{
			Result = 8;
		}
		else if (ClassName == "Fighter")
		{
			Result = 10;
		}
		else if (ClassName == "Monk")
		{
			Result = 8;
		}
		else if (ClassName == "Paladin")
		{
			Result = 10;
		}
		else if (ClassName == "Ranger")
		{
			Result = 10;
		}
		else if (ClassName == "Rogue")
		{
			Result = 8;
		}
		else if (ClassName == "Sorcerer")
		{
			Result = 6;
		}
		else if (ClassName == "Warlock")
		{
			Result = 8;
		}
		else if (ClassName == "Wizard")
		{
			Result = 6;
		}
		else
		{
			Result = 0;
		}

		return Result;
	}

	public void ReCalcSkills(Character ThisToon)
    {
		int stat = 0;
		int modifier = 0;
		//ThisToon.SkillsList["Athletics"] = ThisToon.Attributes["Strength"];
		ThisToon.SetSkill(ThisToon, "Athletics", Calcs.CalcMod(ThisToon.Attributes["Strength"]));
		ThisToon.SetSkill(ThisToon, "Acrobatics", Calcs.CalcMod(ThisToon.Attributes["Dexterity"]));
		ThisToon.SetSkill(ThisToon, "Sleight of Hand", Calcs.CalcMod(ThisToon.Attributes["Dexterity"]));
		ThisToon.SetSkill(ThisToon, "Stealth", Calcs.CalcMod(ThisToon.Attributes["Dexterity"]));
		ThisToon.SetSkill(ThisToon, "Arcana", Calcs.CalcMod(ThisToon.Attributes["Intelligence"]));
		ThisToon.SetSkill(ThisToon, "History", Calcs.CalcMod(ThisToon.Attributes["Intelligence"]));
		ThisToon.SetSkill(ThisToon, "Investigation", Calcs.CalcMod(ThisToon.Attributes["Intelligence"]));
		ThisToon.SetSkill(ThisToon, "Nature", Calcs.CalcMod(ThisToon.Attributes["Intelligence"]));
		ThisToon.SetSkill(ThisToon, "Religion", Calcs.CalcMod(ThisToon.Attributes["Intelligence"]));
		ThisToon.SetSkill(ThisToon, "Animal Handling", Calcs.CalcMod(ThisToon.Attributes["Wisdom"]));
		ThisToon.SetSkill(ThisToon, "Insight", Calcs.CalcMod(ThisToon.Attributes["Wisdom"]));
		ThisToon.SetSkill(ThisToon, "Medicine", Calcs.CalcMod(ThisToon.Attributes["Wisdom"]));
		ThisToon.SetSkill(ThisToon, "Perception", Calcs.CalcMod(ThisToon.Attributes["Wisdom"]));
		ThisToon.SetSkill(ThisToon, "Survival", Calcs.CalcMod(ThisToon.Attributes["Wisdom"]));
		ThisToon.SetSkill(ThisToon, "Deception", Calcs.CalcMod(ThisToon.Attributes["Charisma"]));
		ThisToon.SetSkill(ThisToon, "Intimidation", Calcs.CalcMod(ThisToon.Attributes["Charisma"]));
		ThisToon.SetSkill(ThisToon, "Performance", Calcs.CalcMod(ThisToon.Attributes["Charisma"]));
		ThisToon.SetSkill(ThisToon, "Persuasion", Calcs.CalcMod(ThisToon.Attributes["Charisma"]));
		//stat = Calcs.CalcMod(ThisToon.Attributes["Strength"]);
	}

	public void AddSkillProficiency(Character ThisToon, string Skill)
    {
		int NewValue = ThisToon.ProficiencyBonus + ThisToon.SkillsList[Skill];
		ThisToon.SetSkill(ThisToon, Skill, NewValue);
    }

	public void SetSpeed(Character ThisToon, int Speed)
    {
		ThisToon.Speed = Speed;
    }


}
