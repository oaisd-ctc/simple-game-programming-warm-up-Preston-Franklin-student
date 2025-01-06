public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Dice Game");
        Console.WriteLine();
        Console.WriteLine("In this game you and a computer Rival will play 10 rounds");
        Console.WriteLine("where you will each roll a 6-sided dice, and the player");
        Console.WriteLine("with the highest dice value will win the round. The player");
        Console.WriteLine("who wins the most rounds wins the game. Good luck!");
        Console.WriteLine();
        Console.WriteLine("Press any key to start. . .");
        Console.ReadLine();
        int playerDiceRoll;
        int rivalDiceRoll;
        int playerScore = 0;
        int rivalScore = 0;
        Random random = new Random();
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Round " + i);
            rivalDiceRoll = random.Next(1, 7);
            playerDiceRoll = random.Next(1, 7);
            Console.WriteLine("Rival rolled a " + rivalDiceRoll);
            Console.Write("Press any key to roll the dice. . .");
            Console.ReadLine();
            Console.WriteLine("You rolled a " + playerDiceRoll);
            if (rivalDiceRoll > playerDiceRoll)
            {
                Console.WriteLine("The Rival won this round.");
                rivalScore++;
            }
            else if (rivalDiceRoll == playerDiceRoll)
            {
                Console.WriteLine("This round is a draw.");
            }
            else
            {
                Console.WriteLine("You won this round.");
                playerScore++;
            }
            Console.WriteLine("The score is now - You : " + playerScore + ". Rival : " + rivalScore + ".");
            Console.WriteLine("Press any key to continue. . .");
            Console.ReadLine();
        }
        Console.WriteLine("Game over.");
        Console.WriteLine("The score is now - You : " + playerScore + ". Rival : " + rivalScore + ".");
        if (rivalScore > playerScore)
        {
            Console.WriteLine("You lost!");
        }
        else if (rivalScore == playerScore)
        {
            Console.WriteLine("This game is a draw.");
        }
        else
        {
            Console.WriteLine("You won!");
        }
        Console.WriteLine("Press any key to exit. . .");
        Console.ReadLine();
    }
}