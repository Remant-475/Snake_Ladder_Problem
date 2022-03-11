using System;

namespace Snake_Ladder_Problem;

class program
{
    static void Main(String[] args)
    {
        Random random = new Random();
        int Diceroll = random.Next(1, 7);
        Console.WriteLine("Diceroll : " + Diceroll);
        int position = 0;
        int Number_of_player = 1;

        Random random1 = new Random();
        int Checkoption = random1.Next(0, 3);

        switch (Checkoption)
        {
            case 0:
                position = position;
                Console.WriteLine("player statyed at position " + position);

                break;
            case 1:
                position = position + Diceroll;
                Console.WriteLine("player moved to position " + position);
                break;
            case 2:


                position = position - Diceroll;

                Console.WriteLine("player back to position " + position);
                break;

        }



    }

}

