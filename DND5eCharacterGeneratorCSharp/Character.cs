using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Character
{
	public String FirstName, LastName, Age, Height, Weight, Race, Class, Background;

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
	}

}
