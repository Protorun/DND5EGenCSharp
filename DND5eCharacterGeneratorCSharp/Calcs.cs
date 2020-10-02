using System;
using System.Drawing.Text;

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
		int Modifier = (Attribute - 10) / 2;

		if(Attribute < 10)
        {
			Modifier = (int)Math.Floor((Attribute - 10)/2.0) ;
        }
		return Modifier;
    }

	public int RollAttribute(){
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
			Attribute += Rolls[i];
        }
		//int Modifier = CalcMod(Attribute);
		//Console.WriteLine("Modifier is : " + Modifier);
		return Attribute;
	}

	public int[] RollArray()
    {
		int[] FinalArray = { 0, 0, 0, 0, 0, 0 };

		int[] Rolls = { 0, 0, 0, 0 };
		int Attribute = 0;
		var DiceRoller = new Random();
		for (int x = 0; x < 6; x++)
		{
			for (int i = 0; i < 4; i++)
			{
				int Result = DiceRoller.Next(1, 7);
				Rolls.SetValue(Result, i);
				//Console.WriteLine(Result);
			}
			Array.Sort(Rolls);
			for (int i = 1; i < Rolls.Length; i++)
			{
				Attribute += Rolls[i];
			}

			FinalArray.SetValue(Attribute, x);
			Attribute = 0;
		}
		//FinalArray.SetValue(RollAttribute(), 0);
		//FinalArray.SetValue(RollAttribute(), 1);
		//FinalArray.SetValue(RollAttribute(), 2);
		//FinalArray.SetValue(RollAttribute(), 3);
		//FinalArray.SetValue(RollAttribute(), 4);
		//FinalArray.SetValue(RollAttribute(), 5);
		return FinalArray;
    }
}
