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
		// Darkvision
		if (!FeatList.ContainsKey("Darkvision"))
		{
			FeatList.Add("Darkvision", "Darkvision up to 60ft. No colour, only shades of grey.");
		}
		SetupElvenFeats();
	}

	public static void AddNewFeat(string FeatName, string FeatDesc)
	{
		if (!FeatList.ContainsKey(FeatName))
		{
			FeatList.Add(FeatName, FeatDesc);
		}
	}

	public void SetupElvenFeats()
    {
		// Elven/Half Elven Racial Feats
		// Keen Senses
		FeatList.Add("Keen Senses", "Proficiency in Perception skill.");
		// Fey Ancestry
		FeatList.Add("Fey Ancestry", "Advantage on saving throws vs being charmed. Immune to magical sleep effects.");
		// Trance
		FeatList.Add("Trance", "Elves don't need to sleep. Instead they meditate deeply, remaining semiconscious, for 4 hours a day.");
	}

	public void SetBackgroundFeats(Character ThisToon)
    {
        string ToonBackground = ThisToon.Background;
        if (ToonBackground == "Acolyte")
        {
            ThisToon.FeatsList.Add("Shelter of the Faithful", "As an acolyte, you command the respect of those who share your faith, and you can perform the religious ceremonies of your deity. You and your adventuring companions can expect to receive free healing and care at a temple, shrine, or other established presence of your faith, though you must provide any material components needed for spells. Those who share your religion will support you (but only you) at a modest lifestyle. You might also have ties to a specific temple dedicated to your chosen deity or pantheon, and you have a residence there. This could be the temple where you used to serve, if you remain on good terms with it, or a temple where you have found a new home. While near your temple, you can call upon the priests for assistance, provided the assistance you ask for is not hazardous and you remain in good standing with your temple.");
        }
        else if (ToonBackground == "Charlatan")
        {
            ThisToon.FeatsList.Add("False Identity", "");
        }
        else if (ToonBackground == "Criminal/Spy")
        {
            ThisToon.FeatsList.Add("Criminal Contact", "You have a reliable and trustworthy contact who acts as your liaison to a network of other criminals. You know how to get messages to and from your contact, even over great distances; specifically, you know the local messengers, corrupt caravan masters, and seedy sailors who can deliver messages for you.");
        }
        else if (ToonBackground == "Entertainer")
        {
            ThisToon.FeatsList.Add("By Popular Demand", "");
        }
        else if (ToonBackground == "Folk Hero")
        {
            ThisToon.FeatsList.Add("Rustic Hospitality", "Since you come from the ranks of the common folk, you fit in among them with ease. You can find a place to hide, rest, or recuperate among other commoners, unless you have shown yourself to be a danger to them. They will shield you from the law or anyone else searching for you, though they will not risk their lives for you.");
        }
        else if (ToonBackground == "Gladiator")
        {
            ThisToon.FeatsList.Add("By Popular Demand", "");
        }
        else if (ToonBackground == "Guild Artisan/Merchant")
        {
            ThisToon.FeatsList.Add("Guild Membership", "");
        }
        else if (ToonBackground == "Hermit")
        {
            ThisToon.FeatsList.Add("Discovery", "");
        }
        else if (ToonBackground == "Knight")
        {
            ThisToon.FeatsList.Add("Retainers", "You have the service of three retainers loyal to your family. These retainers can be attendants or messengers, and one might be a majordomo. Your retainers are commoners who can perform mundane tasks for you, but they do not fight for you, will not follow you into obviously dangerous areas (such as dungeons), and will leave if they are frequently endangered or abused");
        }
        else if (ToonBackground == "Noble")
        {
            ThisToon.FeatsList.Add("Position of Privilege", "Thanks to your noble birth, people are inclined to think the best of you. You are welcome in high society, and people assume you have the right to be wherever you are. The common folk make every effort to accommodate you and avoid your displeasure, and other people of high birth treat you as a member of the same social sphere. You can secure an audience with a local noble if you need to.");
        }
        else if (ToonBackground == "Outlander")
        {
            ThisToon.FeatsList.Add("Wanderer", "");
        }
        else if (ToonBackground == "Pirate")
        {
            ThisToon.FeatsList.Add("Bad Reputation", "");
        }
        else if (ToonBackground == "Sage")
        {
            ThisToon.FeatsList.Add("Researcher", "When you attempt to learn or recall a piece of lore, if you do not know that information, you often know where and from whom you can obtain it. Usually, this information comes from a library, scriptorium, university, or a sage or other learned person or creature. Your DM might rule that the knowledge you seek is secreted away in an almost inaccessible place, or that it simply cannot be found. Unearthing the deepest secrets of the multiverse can require an adventure or even a whole campaign.");
        }
        else if (ToonBackground == "Sailor")
        {
            ThisToon.FeatsList.Add("Ship's Passage", "");
        }
        else if (ToonBackground == "Soldier")
        {
            ThisToon.FeatsList.Add("Military Rank", "You have a military rank from your career as a soldier. Soldiers loyal to your former military organization still recognize your authority and influence, and they defer to you if they are of a lower rank. You can invoke your rank to exert influence over other soldiers and requisition simple equipment or horses for temporary use. You can also usually gain access to friendly military encampments and fortresses where your rank is recognized.");
        }
        else if (ToonBackground == "Urchin")
        {
            ThisToon.FeatsList.Add("City Secrets", "");
        }
    }
}
