using DND5eCharacterGeneratorCSharp;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
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
		StrSaving,
		DexSaving,
		ConSaving,
		IntSaving,
		WisSaving,
		ChaSaving,
		Level,
		HitPoints,
		Initiative,
		HitDie,
		TempHP,
		Speed,
		ProficiencyBonus,
		ExcessProfs;

	public Dictionary<string, int> Attributes = new Dictionary<string, int>();
	public Dictionary<string, int> AttributeMods = new Dictionary<string, int>();
	public Dictionary<string, string> FeatsList = new Dictionary<string, string>();
	public Dictionary<string, int> SkillsList = new Dictionary<string, int>();
	public List<string> SkillProficiencies = new List<string>();
	public Dictionary<string, int> SavingThrows = new Dictionary<string, int>();
	public List<string> ProfSavingThrows = new List<string>();

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
		Dictionary<string, int> AttributeMods = new Dictionary<string, int>();
		//this.InitialiseAttributes();
		//SetAttMods(this);
		Dictionary<string, string> FeatsList = new Dictionary<string, string>();
		SkillProficiency Skills = new SkillProficiency(this);
		Dictionary<string, int> SkillsList = new Dictionary<string, int>();
		//this.InitialiseSkills(this);

		Skills.PresetBackgroundProfs(this);
		Skills.PresetRaceProfs(this);
		Skills.PresetClassProfs(this);
		Feats Feats = new Feats(this);
		SetHitDie(Class);
		List<string> ProfSavingThrows = new List<String>();
		Dictionary<string, int> SavingThrows = new Dictionary<string, int>();
		SetupClass(this);
		//ReCalcSkills(this);
	}

	public Character()
    {

    }

	public void InitialiseAttributes()
    {
		Attributes.Add("Strength", this.Strength); ;
		Attributes.Add("Dexterity", this.Dexterity);
		Attributes.Add("Constitution", this.Constitution);
		Attributes.Add("Intelligence", this.Intelligence);
		Attributes.Add("Wisdom", this.Wisdom);
		Attributes.Add("Charisma", this.Charisma);

		SetAttMods(this);
	}

	public void SetAttMods(Character ThisToon)
    {
		AttributeMods.Add("Strength", Calcs.CalcMod(Strength));
		AttributeMods.Add("Dexterity", Calcs.CalcMod(Dexterity));
		AttributeMods.Add("Constitution", Calcs.CalcMod(Constitution));
		AttributeMods.Add("Intelligence", Calcs.CalcMod(Intelligence));
		AttributeMods.Add("Wisdom", Calcs.CalcMod(Wisdom));
		AttributeMods.Add("Charisma", Calcs.CalcMod(Charisma));

		ThisToon.StrMod = Calcs.CalcMod(Strength);
		ThisToon.DexMod = Calcs.CalcMod(Dexterity);
		ThisToon.ConMod = Calcs.CalcMod(Constitution);
		ThisToon.IntMod = Calcs.CalcMod(Intelligence);
		ThisToon.WisMod = Calcs.CalcMod(Wisdom);
		ThisToon.ChaMod = Calcs.CalcMod(Charisma);
	}

	public void InitialiseSkills(Character ThisToon)
    {
		SkillsList.Add("Athletics", ThisToon.StrMod);
		SkillsList.Add("Acrobatics", ThisToon.DexMod);
		SkillsList.Add("Sleight of Hand", ThisToon.DexMod);
		SkillsList.Add("Stealth", ThisToon.DexMod);
		SkillsList.Add("Arcana", ThisToon.IntMod);
		SkillsList.Add("History", ThisToon.IntMod);
		SkillsList.Add("Investigation", ThisToon.IntMod);
		SkillsList.Add("Nature", ThisToon.IntMod);
		SkillsList.Add("Religion", ThisToon.IntMod);
		SkillsList.Add("Animal Handling", ThisToon.WisMod);
		SkillsList.Add("Insight", ThisToon.WisMod);
		SkillsList.Add("Medicine", ThisToon.WisMod);
		SkillsList.Add("Perception", ThisToon.WisMod);
		SkillsList.Add("Survival", ThisToon.WisMod);
		SkillsList.Add("Deception", ThisToon.ChaMod);
		SkillsList.Add("Intimidation", ThisToon.ChaMod);
		SkillsList.Add("Performance", ThisToon.ChaMod);
		SkillsList.Add("Persuasion", ThisToon.ChaMod);
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
			if (ThisToon.AttributeMods.ContainsKey(AttName))
            {
				ThisToon.AttributeMods[AttName] = Calcs.CalcMod(AttValue);
            }
            else
            {
				ThisToon.AttributeMods.Add(AttName, AttValue);
            }
		}
        else
        {
			ThisToon.Attributes.Add(AttName, AttValue);
			if (ThisToon.AttributeMods.ContainsKey(AttName))
			{
				ThisToon.AttributeMods[AttName] = Calcs.CalcMod(AttValue);
			}
			else
			{
				ThisToon.AttributeMods.Add(AttName, AttValue);
			}
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
		ThisToon.Initiative +=  Value;
    }

	public void SetTempHP(Character ThisToon, int Value)
    {
		ThisToon.TempHP = Value;
    }

	public void ModifyTempHP(Character ThisToon, int Value)
    {
		ThisToon.TempHP += Value;
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
		// THIS IS INCOMPLETE, FINISH AFTER SKILL PROFICIENCIES FORM
		// int stat = 0;
		// int modifier = 0;
		//ThisToon.SkillsList["Athletics"] = ThisToon.Attributes["Strength"];
		ThisToon.SetSkill(ThisToon, "Athletics", ThisToon.StrMod);
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
		CalcSkillProficiency(ThisToon);
	}

	public void CalcSkillProficiency(Character ThisToon)
    {
		for (int i = 0; i <= ThisToon.SkillProficiencies.Count - 1; i++)
        {
			string Skill = ThisToon.SkillProficiencies[i];
			int NewValue = ThisToon.ProficiencyBonus + ThisToon.SkillsList[Skill];
			ThisToon.SetSkill(ThisToon, Skill, NewValue);
		}
    }

	public void SetSpeed(Character ThisToon, int Speed)
    {
		ThisToon.Speed = Speed;
    }

	public void SetupClass(Character ThisToon)
    {
		if (ThisToon.Class == "Barbarian")
		{
			ThisToon.ProfSavingThrows.Clear();
			ThisToon.SavingThrows.Clear();
			ThisToon.ProfSavingThrows.Add("Strength");
			ThisToon.ProfSavingThrows.Add("Constitution");
			ThisToon.SavingThrows.Add("Strength", ThisToon.StrMod);
			ThisToon.SavingThrows.Add("Dexterity", ThisToon.DexMod);
			ThisToon.SavingThrows.Add("Constitution", ThisToon.ConMod);
			ThisToon.SavingThrows.Add("Intelligence", ThisToon.IntMod);
			ThisToon.SavingThrows.Add("Wisdom", ThisToon.WisMod);
			ThisToon.SavingThrows.Add("Charisma", ThisToon.ChaMod);
			SavingProfs(ThisToon);
		}
		else if (ThisToon.Class == "Bard")
		{
			ThisToon.ProfSavingThrows.Clear();
			ThisToon.SavingThrows.Clear();
			ThisToon.ProfSavingThrows.Add("Dexterity");
			ThisToon.ProfSavingThrows.Add("Charisma");
			ThisToon.SavingThrows.Add("Strength", ThisToon.StrMod);
			ThisToon.SavingThrows.Add("Dexterity", ThisToon.DexMod);
			ThisToon.SavingThrows.Add("Constitution", ThisToon.ConMod);
			ThisToon.SavingThrows.Add("Intelligence", ThisToon.IntMod);
			ThisToon.SavingThrows.Add("Wisdom", ThisToon.WisMod);
			ThisToon.SavingThrows.Add("Charisma", ThisToon.ChaMod);
			SavingProfs(ThisToon);
		}
		else if (ThisToon.Class == "Cleric")
		{
			ThisToon.ProfSavingThrows.Clear();
			ThisToon.SavingThrows.Clear();
			ThisToon.ProfSavingThrows.Add("Wisdom");
			ThisToon.ProfSavingThrows.Add("Charisma");
			ThisToon.SavingThrows.Add("Strength", ThisToon.StrMod);
			ThisToon.SavingThrows.Add("Dexterity", ThisToon.DexMod);
			ThisToon.SavingThrows.Add("Constitution", ThisToon.ConMod);
			ThisToon.SavingThrows.Add("Intelligence", ThisToon.IntMod);
			ThisToon.SavingThrows.Add("Wisdom", ThisToon.WisMod);
			ThisToon.SavingThrows.Add("Charisma", ThisToon.ChaMod);
			SavingProfs(ThisToon);
		}
		else if (ThisToon.Class == "Druid")
		{
			ThisToon.ProfSavingThrows.Clear();
			ThisToon.SavingThrows.Clear();
			ThisToon.ProfSavingThrows.Add("Intelligence");
			ThisToon.ProfSavingThrows.Add("Wisdom");
			ThisToon.SavingThrows.Add("Strength", ThisToon.StrMod);
			ThisToon.SavingThrows.Add("Dexterity", ThisToon.DexMod);
			ThisToon.SavingThrows.Add("Constitution", ThisToon.ConMod);
			ThisToon.SavingThrows.Add("Intelligence", ThisToon.IntMod);
			ThisToon.SavingThrows.Add("Wisdom", ThisToon.WisMod);
			ThisToon.SavingThrows.Add("Charisma", ThisToon.ChaMod);
			SavingProfs(ThisToon);
		}
		else if (ThisToon.Class == "Fighter")
		{
			ThisToon.ProfSavingThrows.Clear();
			ThisToon.SavingThrows.Clear();
			ThisToon.ProfSavingThrows.Add("Strength");
			ThisToon.ProfSavingThrows.Add("Constitution");
			ThisToon.SavingThrows.Add("Strength", ThisToon.StrMod);
			ThisToon.SavingThrows.Add("Dexterity", ThisToon.DexMod);
			ThisToon.SavingThrows.Add("Constitution", ThisToon.ConMod);
			ThisToon.SavingThrows.Add("Intelligence", ThisToon.IntMod);
			ThisToon.SavingThrows.Add("Wisdom", ThisToon.WisMod);
			ThisToon.SavingThrows.Add("Charisma", ThisToon.ChaMod);
			SavingProfs(ThisToon);
		}
		else if (ThisToon.Class == "Monk")
		{
			ThisToon.ProfSavingThrows.Clear();
			ThisToon.SavingThrows.Clear();
			ThisToon.ProfSavingThrows.Add("Strength");
			ThisToon.ProfSavingThrows.Add("Dexterity");
			ThisToon.SavingThrows.Add("Strength", ThisToon.StrMod);
			ThisToon.SavingThrows.Add("Dexterity", ThisToon.DexMod);
			ThisToon.SavingThrows.Add("Constitution", ThisToon.ConMod);
			ThisToon.SavingThrows.Add("Intelligence", ThisToon.IntMod);
			ThisToon.SavingThrows.Add("Wisdom", ThisToon.WisMod);
			ThisToon.SavingThrows.Add("Charisma", ThisToon.ChaMod);
			SavingProfs(ThisToon);
		}
		else if (ThisToon.Class == "Paladin")
		{
			ThisToon.ProfSavingThrows.Clear();
			ThisToon.SavingThrows.Clear();
			ThisToon.ProfSavingThrows.Add("Wisdom");
			ThisToon.ProfSavingThrows.Add("Charisma");
			ThisToon.SavingThrows.Add("Strength", ThisToon.StrMod);
			ThisToon.SavingThrows.Add("Dexterity", ThisToon.DexMod);
			ThisToon.SavingThrows.Add("Constitution", ThisToon.ConMod);
			ThisToon.SavingThrows.Add("Intelligence", ThisToon.IntMod);
			ThisToon.SavingThrows.Add("Wisdom", ThisToon.WisMod);
			ThisToon.SavingThrows.Add("Charisma", ThisToon.ChaMod);
			SavingProfs(ThisToon);
		}
		else if (ThisToon.Class == "Ranger")
		{
			ThisToon.ProfSavingThrows.Clear();
			ThisToon.SavingThrows.Clear();
			ThisToon.ProfSavingThrows.Add("Strength");
			ThisToon.ProfSavingThrows.Add("Dexterity");
			ThisToon.SavingThrows.Add("Strength", ThisToon.StrMod);
			ThisToon.SavingThrows.Add("Dexterity", ThisToon.DexMod);
			ThisToon.SavingThrows.Add("Constitution", ThisToon.ConMod);
			ThisToon.SavingThrows.Add("Intelligence", ThisToon.IntMod);
			ThisToon.SavingThrows.Add("Wisdom", ThisToon.WisMod);
			ThisToon.SavingThrows.Add("Charisma", ThisToon.ChaMod);
			SavingProfs(ThisToon);
		}
		else if (ThisToon.Class == "Rogue")
		{
			ThisToon.ProfSavingThrows.Clear();
			ThisToon.SavingThrows.Clear();
			ThisToon.ProfSavingThrows.Add("Dexterity");
			ThisToon.ProfSavingThrows.Add("Intelligence");
			ThisToon.SavingThrows.Add("Strength", ThisToon.StrMod);
			ThisToon.SavingThrows.Add("Dexterity", ThisToon.DexMod);
			ThisToon.SavingThrows.Add("Constitution", ThisToon.ConMod);
			ThisToon.SavingThrows.Add("Intelligence", ThisToon.IntMod);
			ThisToon.SavingThrows.Add("Wisdom", ThisToon.WisMod);
			ThisToon.SavingThrows.Add("Charisma", ThisToon.ChaMod);
			SavingProfs(ThisToon);
		}
		else if (ThisToon.Class == "Sorcerer")
		{
			ThisToon.ProfSavingThrows.Clear();
			ThisToon.SavingThrows.Clear();
			ThisToon.ProfSavingThrows.Add("Constitution");
			ThisToon.ProfSavingThrows.Add("Charisma");
			ThisToon.SavingThrows.Add("Strength", ThisToon.StrMod);
			ThisToon.SavingThrows.Add("Dexterity", ThisToon.DexMod);
			ThisToon.SavingThrows.Add("Constitution", ThisToon.ConMod);
			ThisToon.SavingThrows.Add("Intelligence", ThisToon.IntMod);
			ThisToon.SavingThrows.Add("Wisdom", ThisToon.WisMod);
			ThisToon.SavingThrows.Add("Charisma", ThisToon.ChaMod);
			SavingProfs(ThisToon);
		}
		else if (ThisToon.Class == "Warlock")
		{
			ThisToon.ProfSavingThrows.Clear();
			ThisToon.SavingThrows.Clear();
			ThisToon.ProfSavingThrows.Add("Wisdom");
			ThisToon.ProfSavingThrows.Add("Charisma");
			ThisToon.SavingThrows.Add("Strength", ThisToon.StrMod);
			ThisToon.SavingThrows.Add("Dexterity", ThisToon.DexMod);
			ThisToon.SavingThrows.Add("Constitution", ThisToon.ConMod);
			ThisToon.SavingThrows.Add("Intelligence", ThisToon.IntMod);
			ThisToon.SavingThrows.Add("Wisdom", ThisToon.WisMod);
			ThisToon.SavingThrows.Add("Charisma", ThisToon.ChaMod);
			SavingProfs(ThisToon);
		}
		else if (ThisToon.Class == "Wizard")
		{
			ThisToon.ProfSavingThrows.Clear();
			ThisToon.SavingThrows.Clear();
			ThisToon.ProfSavingThrows.Add("Intelligence");
			ThisToon.ProfSavingThrows.Add("Wisdom");
			ThisToon.SavingThrows.Add("Strength", ThisToon.StrMod);
			ThisToon.SavingThrows.Add("Dexterity", ThisToon.DexMod);
			ThisToon.SavingThrows.Add("Constitution", ThisToon.ConMod);
			ThisToon.SavingThrows.Add("Intelligence", ThisToon.IntMod);
			ThisToon.SavingThrows.Add("Wisdom", ThisToon.WisMod);
			ThisToon.SavingThrows.Add("Charisma", ThisToon.ChaMod);
			SavingProfs(ThisToon);
		}
		else
		{
			ThisToon.ProfSavingThrows.Clear();
			ThisToon.SavingThrows.Clear();
		}
	}

	public void SavingProfs(Character ThisToon)
    {
        for (int i = 0; i <= ThisToon.ProfSavingThrows.Count - 1 ; i++)
        {
			if (ThisToon.SavingThrows.ContainsKey(ThisToon.ProfSavingThrows[i]))
			{
				string ThrowName = ThisToon.ProfSavingThrows[i];
				int NewValue = ThisToon.SavingThrows[ThrowName] + ThisToon.ProficiencyBonus;
				ThisToon.SavingThrows[ThrowName] = NewValue;
			}
        }
    }

}
