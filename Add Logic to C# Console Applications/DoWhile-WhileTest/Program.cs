/*
string? readResult;
bool validEntry = false;

Console.WriteLine("Enter a string containing at least 3 characters:");

do {
    readResult = Console.ReadLine();
    if (readResult != null) {
        if (readResult.Length >= 3) {
            validEntry = true;
        } else {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }    
} while (validEntry == false);

// capture user input in a string variable named readResult
int numericValue = 0;
bool validNumber = false;

validNumber = int.TryParse(readResult, out numericValue);
Console.WriteLine(readResult+","+validNumber+","+numericValue);

//Code Project 1
string? readResult;
int numValue = 0;

Console.WriteLine("Enter an integer between 5 and 10:");

do {

    readResult = Console.ReadLine();

    if (readResult != null) {
        bool validNumber = int.TryParse(readResult, out numValue);

        if (validNumber == true) {
            if (numValue >= 5 && numValue <= 10)
                continue;
            else
                Console.WriteLine($"You entered {numValue}. Please, enter an integer between 5 and 10:");

        } else {
            Console.WriteLine("You entered an invalid number, please try again.");
        }
    }

} while (numValue < 5 || numValue > 10);

Console.WriteLine($"Your input value ({numValue}) has been accepted.");

//Code Project 2
string? readerLine;
string currentLine;
bool validRole = false;

Console.WriteLine("Please, input your role (Administrator, Manager, User):");

do {
    readerLine = Console.ReadLine();
    if (readerLine != null) {
        currentLine = readerLine.Trim().ToLower();

        switch (currentLine) {
            case "administrator":
                validRole = true;
                break;
            case "manager":
                validRole = true;
                break;
            case "user":
                validRole = true;
                break;
            default:
                Console.WriteLine($"The role \"{readerLine}\" you entered is not valid.\nPlease, input your role (Administrator, Manager, User):");
                break;
        }
    }
    
} while (validRole == false);

Console.WriteLine($"Your input role ({readerLine}) has been accepted.");
*/

//Code Project 3

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int periodLocation = 0;
//myString.IndexOf(".");

for (int i = 1; i < myStrings.Length; i++) {
    string myString = myStrings[i];

        do {
            periodLocation = myString.IndexOf(".");

            if (periodLocation > 0) {
                string visualString = myString.Remove(periodLocation);
                Console.WriteLine(visualString);
                myString = myString.Substring(periodLocation+=1).TrimStart();
            } else
                Console.WriteLine(myString);

        } while (periodLocation != -1);
}

//Microsoft dice che non si dovrebbe usare il do-while in questo terzo caso,
//ma così facendo non ripeto l'aggiornamento di periodLocation come propongono nella loro soluzione
//Il motivo è che l'iterazione potrebbe anche non avere bisogno di essere esegutia,
//io la eseguo comunque e implemento una logica che "cattura" il possibile errore generabile.
