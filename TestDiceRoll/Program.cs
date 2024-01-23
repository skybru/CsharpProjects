Random dice = new Random();
int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);

int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) { //verifico se ALMENO due numeri sono uguali
    if ((roll1 == roll2) && (roll2 == roll3)) {                 //verifico se l'ultimo numero rimasto è uguale agli altri
        Console.WriteLine("You rolled triples! +6 bonus points!");
        total += 6;
    } else {
        Console.WriteLine("You rolled doubles! +2 bouns points!");
        total += 2;
    }
}

if (total >= 15) {
    Console.WriteLine($"With {total} points you win! ");
} else {
    Console.WriteLine("Sorry, you lose.");
}
