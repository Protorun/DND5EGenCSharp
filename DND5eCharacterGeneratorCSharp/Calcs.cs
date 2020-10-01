using System;

public class Calcs
{
	
	public Calcs()
	{
		
	}

	public static int RollDice(int MaxValue)
    {
		//int rolls[] = new int[];
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
		else if (Attribute <= 3)
		{
			Modifier = -4;
		}
		else if (Attribute <= 5)
		{
			Modifier = -3;
		}
		else if (Attribute <= 7)
		{
			Modifier = -2;
		}
		else if (Attribute <= 9)
		{
			Modifier = -1;
		}
		else if (Attribute <= 11)
		{
			Modifier = 0;
		}
		else if (Attribute <= 13)
		{
			Modifier = 1;
		}
		else if (Attribute <= 15)
		{
			Modifier = 2;
		}
		else if (Attribute <= 17)
		{
			Modifier = 3;
		}
		else if (Attribute <= 19)
		{
			Modifier = 4;
		}
		else if (Attribute == 20)
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
		int[] Rolls = { 0, 0, 0, 0 };
		int Attribute = 0;
		var DiceRoller = new Random();
		for (int i = 0; i < 4; i++)
        {
			int Result = DiceRoller.Next(1, 7);
			Rolls.SetValue(Result, i);
			//Console.WriteLine(Result);
        }
		Array.Sort(Rolls);
        for (int i = 1; i < Rolls.Length; i++)
        {
			Attribute = Attribute + Rolls[i];
        }
		int Modifier = CalcMod(Attribute);
		//Console.WriteLine("Modifier is : " + Modifier);
		return Attribute;
	}
}
