using DND5eCharacterGeneratorCSharp;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

public class Feats
{
	public static Dictionary<string, string> FeatList = new Dictionary<string, string>();

	public Feats(Character ThisToon)
	{
		//FeatList = new Dictionary<string, string>();
		// Darkvision
        AddNewFeat("Darkvision", "Accustomed to life underground, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can’t discern color in darkness, only shades of gray.");

		SetupElvenFeats(ThisToon);
	}

	public static void AddNewFeat(string FeatName, string FeatDesc)
	{
		if (!FeatList.ContainsKey(FeatName))
		{
			FeatList.Add(FeatName, FeatDesc);
		}
	}

	public void SetupElvenFeats(Character ThisToon)
    {
		// Elven/Half Elven Racial Feats
		// Keen Senses
		AddNewFeat("Keen Senses", "Proficiency in Perception skill.");
        if (!ThisToon.SkillProficiencies.Contains("Perception"))
        {
            ThisToon.SkillProficiencies.Add("Perception");
        }
        else if (ThisToon.SkillProficiencies.Contains("Perception"))
        {
            ThisToon.ExcessProfs += 1;
        }
        // Fey Ancestry
        AddNewFeat("Fey Ancestry", "Advantage on saving throws vs being charmed. Immune to magical sleep effects.");
        // Trance
        AddNewFeat("Trance", "Elves don't need to sleep. Instead they meditate deeply, remaining semiconscious, for 4 hours a day.");
	}

	public void SetBackgroundFeats(Character ThisToon)
    {
        string ToonBackground = ThisToon.Background;
        if (ToonBackground == "Acolyte")
        {
            AddToonFeat(ThisToon, "Shelter of the Faithful", "As an acolyte, you command the respect of those who share your faith, and you can perform the religious ceremonies of your deity. You and your adventuring companions can expect to receive free healing and care at a temple, shrine, or other established presence of your faith, though you must provide any material components needed for spells. Those who share your religion will support you (but only you) at a modest lifestyle. You might also have ties to a specific temple dedicated to your chosen deity or pantheon, and you have a residence there. This could be the temple where you used to serve, if you remain on good terms with it, or a temple where you have found a new home. While near your temple, you can call upon the priests for assistance, provided the assistance you ask for is not hazardous and you remain in good standing with your temple.");
        }
        else if (ToonBackground == "Charlatan")
        {
            AddToonFeat(ThisToon, "False Identity", "You have created a second identity that includes documentation, established acquaintances, and disguises that allow you to assume that persona. Additionally, you can forge documents including official papers and personal letters, as long as you have seen an example of the kind of document or the handwriting you are trying to copy.");
        }
        else if (ToonBackground == "Criminal/Spy")
        {
            AddToonFeat(ThisToon, "Criminal Contact", "You have a reliable and trustworthy contact who acts as your liaison to a network of other criminals. You know how to get messages to and from your contact, even over great distances; specifically, you know the local messengers, corrupt caravan masters, and seedy sailors who can deliver messages for you.");
        }
        else if (ToonBackground == "Entertainer")
        {
            AddToonFeat(ThisToon, "By Popular Demand", "You can always find a place to perform, usually in an inn or tavern but possibly with a circus, at a theater, or even in a noble's court. At such a place, you receive free lodging and food of a modest or comfortable standard (depending on the quality of the establishment), as long as you perform each night. In addition, your performance makes you something of a local figure. When strangers recognize you in a town where you have performed, they typically take a liking to you.");
        }
        else if (ToonBackground == "Folk Hero")
        {
            AddToonFeat(ThisToon, "Rustic Hospitality", "Since you come from the ranks of the common folk, you fit in among them with ease. You can find a place to hide, rest, or recuperate among other commoners, unless you have shown yourself to be a danger to them. They will shield you from the law or anyone else searching for you, though they will not risk their lives for you.");
        }
        else if (ToonBackground == "Gladiator")
        {
            AddToonFeat(ThisToon, "By Popular Demand", "You can always find a place to perform, usually in an inn or tavern but possibly with a circus, at a theater, or even in a noble's court. At such a place, you receive free lodging and food of a modest or comfortable standard (depending on the quality of the establishment), as long as you perform each night. In addition, your performance makes you something of a local figure. When strangers recognize you in a town where you have performed, they typically take a liking to you.");
        }
        else if (ToonBackground == "Guild Artisan/Merchant")
        {
            AddToonFeat(ThisToon, "Guild Membership", "");
        }
        else if (ToonBackground == "Hermit")
        {
            AddToonFeat(ThisToon, "Discovery", "");
        }
        else if (ToonBackground == "Knight")
        {
            AddToonFeat(ThisToon, "Retainers", "You have the service of three retainers loyal to your family. These retainers can be attendants or messengers, and one might be a majordomo. Your retainers are commoners who can perform mundane tasks for you, but they do not fight for you, will not follow you into obviously dangerous areas (such as dungeons), and will leave if they are frequently endangered or abused");
        }
        else if (ToonBackground == "Noble")
        {
            AddToonFeat(ThisToon, "Position of Privilege", "Thanks to your noble birth, people are inclined to think the best of you. You are welcome in high society, and people assume you have the right to be wherever you are. The common folk make every effort to accommodate you and avoid your displeasure, and other people of high birth treat you as a member of the same social sphere. You can secure an audience with a local noble if you need to.");
        }
        else if (ToonBackground == "Outlander")
        {
            AddToonFeat(ThisToon, "Wanderer", "");
        }
        else if (ToonBackground == "Pirate")
        {
            AddToonFeat(ThisToon, "Bad Reputation", "");
        }
        else if (ToonBackground == "Sage")
        {
            AddToonFeat(ThisToon, "Researcher", "When you attempt to learn or recall a piece of lore, if you do not know that information, you often know where and from whom you can obtain it. Usually, this information comes from a library, scriptorium, university, or a sage or other learned person or creature. Your DM might rule that the knowledge you seek is secreted away in an almost inaccessible place, or that it simply cannot be found. Unearthing the deepest secrets of the multiverse can require an adventure or even a whole campaign.");
        }
        else if (ToonBackground == "Sailor")
        {
            AddToonFeat(ThisToon, "Ship's Passage", "");
        }
        else if (ToonBackground == "Soldier")
        {
            AddToonFeat(ThisToon, "Military Rank", "You have a military rank from your career as a soldier. Soldiers loyal to your former military organization still recognize your authority and influence, and they defer to you if they are of a lower rank. You can invoke your rank to exert influence over other soldiers and requisition simple equipment or horses for temporary use. You can also usually gain access to friendly military encampments and fortresses where your rank is recognized.");
        }
        else if (ToonBackground == "Urchin")
        {
            AddToonFeat(ThisToon, "City Secrets", "");
        }
    }

    public void AddToonFeat(Character ThisToon, string FeatName, string FeatDesc)
    {
        if (!ThisToon.FeatsList.ContainsKey(FeatName))
        {
            ThisToon.FeatsList.Add(FeatName, FeatDesc);
        }
    }
}
