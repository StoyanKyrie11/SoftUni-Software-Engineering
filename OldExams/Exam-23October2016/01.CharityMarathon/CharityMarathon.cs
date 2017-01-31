﻿using System;

public class CharityMarathon
{
   public static void Main()
    {
        int maratonDays = int.Parse(Console.ReadLine());
        int countRunner = int.Parse(Console.ReadLine());
        int numOfLaps = int.Parse(Console.ReadLine());
        int lapLenght = int.Parse(Console.ReadLine());
        int trackCapacity = int.Parse(Console.ReadLine());
        decimal moneyPerKm = decimal.Parse(Console.ReadLine());

        long maxRunners = Math.Min((trackCapacity * maratonDays), countRunner);
        long totalKm = (maxRunners * numOfLaps * lapLenght) / 1000;

        decimal moneyRaised = totalKm * moneyPerKm;

        Console.WriteLine("Money raised: {0:f2}", moneyRaised);
    }
}
