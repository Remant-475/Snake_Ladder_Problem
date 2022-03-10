using System;

namespace Snake_Ladder_Problem;

class program
{
    static void Main(String[] args)
    {
        Random random= new Random();
        int Diceroll=random.Next(1,7);

        int position=0;
        int Number_of_player = 1;
        Console.WriteLine("Welcome to Snake and Ladder Game ");
        Console.WriteLine("starting postion is : " + position);
        Console.WriteLine("Number of Player : " + Number_of_player);
        Console.WriteLine("Dice roll : " + Diceroll);
    }

}



