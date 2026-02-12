using Hi_Lo_game;
/*This game the player will guess two numbers
 * that generated randomly and if they are higher or lower 
 * and if his guess is true it will increase the pot by one mark 
 * and if the player give wrong answer the pot will decrease by one mark
 */
Console.WriteLine("Welcome to HiLo.");
Console.WriteLine($"Guess numbers between 1 and {HiLoGame.MAXIMUM}.");
HiLoGame.Hint();
while (HiLoGame.GetPot() > 0)
{
    int potValue = HiLoGame.GetPot();
    Console.WriteLine($"The pot Value is {potValue}");
    Console.WriteLine("Press h for higher, l for lower, ? to buy a hint,");
    Console.WriteLine($"or any other key to quit");
    char key = Console.ReadKey(true).KeyChar;
    if (key == 'h') HiLoGame.Guess(true);
    else if (key == 'l') HiLoGame.Guess(false);
    else if (key == '?') HiLoGame.Hint();
    else return;
}
Console.WriteLine("The pot is empty. Bye!");
