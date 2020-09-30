using System;

public class Calcs
{
	public Calcs()
	{
		
	}

	public static int RollDice(int MaxValue)
    {
		var DiceRoller = new Random();
		var Result = DiceRoller.Next(1, MaxValue);
		return Result;
    }

	public static int CalcMod(int Attribute)
    {
		int Modifier;
		if(Attribute <= 1)
        {
			Modifier = -5;
        }
		if (Attribute <= 3)
		{
			Modifier = -4;
		}
		if (Attribute <= 5)
		{
			Modifier = -3;
		}
		if (Attribute <= 7)
		{
			Modifier = -2;
		}
		if (Attribute <= 9)
		{
			Modifier = -1;
		}
		if (Attribute <= 11)
		{
			Modifier = 0;
		}
		if (Attribute <= 13)
		{
			Modifier = 1;
		}
		if (Attribute <= 15)
		{
			Modifier = 2;
		}
		if (Attribute <= 17)
		{
			Modifier = 3;
		}
		if (Attribute <= 19)
		{
			Modifier = 4;
		}
		if (Attribute == 20)
		{
			Modifier = 5;
		}
		else
		{
			Modifier = 0;
		}

		return Modifier;
    }

	public static int RollAttribute(){

	}
}
