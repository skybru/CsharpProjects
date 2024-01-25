/*
string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

//Console.WriteLine(openingPosition);
//Console.WriteLine(closingPosition);
openingPosition++;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));


string message = "What is the value <span>between the tags</span>?";

int openingPosition = message.IndexOf("<span>");
int closingPosition = message.IndexOf("</span>");

openingPosition += 6;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));
//versione migliore NON HARD-CODED
string message = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition = message.IndexOf(openSpan);
int closingPosition = message.IndexOf(closeSpan);

openingPosition += openSpan.Length;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));


string message = "(What if) I am (only interested) in the last (set of parentheses)?";
int openingPos = message.LastIndexOf('(');

openingPos++;
int closingPos = message.LastIndexOf(')');
int length = closingPos - openingPos;
Console.WriteLine(message.Substring(openingPos, length));


string message = "(What if) there are (more than) one (set of parentheses)?";
while (true) {
    int openingPos = message.IndexOf('(');

    if (openingPos == -1)
        break;

    openingPos++;
    int closingPos = message.IndexOf(')');
    int length = closingPos - openingPos;
    Console.WriteLine(message.Substring(openingPos, length));

    message = message.Substring(closingPos + 1);
}


string message = "Help (find) the {opening symbols}";
Console.WriteLine($"Searching THIS Message: {message}");

char[] openSymbols = { '[', '{', '('};
int startPos = 6;
int openingPos = message.IndexOfAny(openSymbols);
Console.WriteLine($"Found WITHOUT using startPos: {message.Substring(openingPos)}");

openingPos = message.IndexOfAny(openSymbols, startPos);
Console.WriteLine($"Found WITH using startPos: {message.Substring(openingPos)}");


string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";
char[] openSymbols = { '[', '{', '('};

int closingPos = 0;

while (true) {
    int openingPos = message.IndexOfAny(openSymbols, closingPos);

    if (openingPos == -1)
        break;
    
    string currentSymbol = message.Substring(openingPos, 1);

    char matchingSymbol = ' ';

    switch (currentSymbol) {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    openingPos++;
    closingPos = message.IndexOf(matchingSymbol, openingPos);

    int length = closingPos - openingPos;
    Console.WriteLine(message.Substring(openingPos, length));
}


string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);
Console.WriteLine(updatedData);


string message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-", "");
Console.WriteLine(message);
*/


const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

string openSpan = "<span>";
string closeSpan = "</span>";
int openingQuantity = input.IndexOf(openSpan);
int closingQuantity = input.IndexOf(closeSpan);

openingQuantity += 6;
int length = closingQuantity - openingQuantity;
quantity = input.Substring(openingQuantity, length);


string openDiv = "<div>";
string closeDiv = "</div>";
int openingPos = input.IndexOf(openDiv);
output = input.Remove(openingPos, openDiv.Length);

int closingPos = output.IndexOf(closeDiv);
output = output.Remove(closingPos, closeDiv.Length);

string registeredSymbol = "&reg";
output = output.Replace("&trade", registeredSymbol);

Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");