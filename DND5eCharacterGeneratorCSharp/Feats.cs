using DND5eCharacterGeneratorCSharp;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

public class Feats
{
	public static Dictionary<string, string> FeatList = new Dictionary<string, string>();

	public Feats()
	{
		//FeatList = new Dictionary<string, string>();
	}

	public static void AddNewFeat(string FeatName, string FeatDesc)
	{
		if (!FeatList.ContainsKey(FeatName))
		{
			FeatList.Add(FeatName, FeatDesc);
		}
	}

	public static void InitialiseFeats()
	{
		// Darkvision
		FeatList.Add("Darkvision", "Darkvision up to 60ft. No colour, only shades of grey.");
		// Keen Senses
		FeatList.Add("Keen Senses", "Proficiency in Perception skill.");
		// Fey Ancestry
		FeatList.Add("Fey Ancestry", "Advantage on saving throws vs being charmed. Immune to magical sleep effects.");
		// Trance
		FeatList.Add("Trance", "Elves don't need to sleep. Instead they meditate deeply, remaining semiconscious, for 4 hours a day.");
	}

	


}
