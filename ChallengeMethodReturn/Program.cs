Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay()) 
{
    PlayGame();
}

void PlayGame() 
{
    var play = true;

    while (play) 
    {
        var target = GetTarget();
        var roll = GetRoll();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(roll, target));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

int GetTarget() {
    int numTarget = random.Next(1,7);
    return numTarget;
}

int GetRoll() {
    return random.Next(1,6);

}

bool ShouldPlay() {
    
    bool validData = false;

    do {

        string reader = Console.ReadLine().Trim().ToLower();

        if (reader != null) 
        {
            if (reader == "y") 
            {
                validData = true;
                return true;
            }
        }
        return false;

    } while (validData == false);
}
/* MSFT Method:
bool ShouldPlay() 
{
    string response = Console.ReadLine();
    return response.ToLower().Equals("y");
}
*/
string WinOrLose(int rolled, int target) {
    if (rolled <= target)
        return "You lose!";
    else
        return "You win!";
}