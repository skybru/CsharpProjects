//string value1 = " a";
//string value2 = "A";
//Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());
/*
Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string myValue = "a";
Console.WriteLine(myValue != "a");

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));
*/
// These two lines of code will create the same output
//Console.WriteLine(pangram.Contains("fox") == false);
//Console.WriteLine(!pangram.Contains("fox"));
/*
Operatore Ternario test:
int saleAmount = 997;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount:  {discount}");
*/

//Coin Flip challenge:
//-use Random class to generate value
//-use conditional operator to determine heads or tails
//-in three lines of code
Random coin = new Random();
int flip = coin.Next(1, 10);
//string result = generatedValue > 5 ? "Head" : "Tail";
Console.WriteLine($"Coin toss result: {(flip > 5 ? "Head" : "Tail")}");