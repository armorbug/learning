// modify the content of strings using built-in string data type methods 

// Example 1 - IndexOf() and Substring()
string message = "Find what is (inside the parentheses)";
int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

//Console.WriteLine(openingPosition);
//Console.WriteLine(closingPosition);

openingPosition += 1;

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition,length));

message = "What is the value <span>between the tags</span>?";

// // avoid magic(hardcoded) values - e.g. <span>, 6 
// openingPosition = message.IndexOf("<span>");
// closingPosition = message.IndexOf("</span>");

// openingPosition += 6;
// length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

const string openSpan = "<span>";
const string closeSpan = "</span>";

openingPosition = message.IndexOf(openSpan);
closingPosition = message.IndexOf(closeSpan);

openingPosition += openSpan.Length;
length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition,length));
Console.WriteLine();

// Example 2 - IndexOf() and LastIndexOf()
message = "hello there!";

int first_h = message.IndexOf('h');
int last_h = message.LastIndexOf('h');

Console.WriteLine($"For the message: '{message}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");

// LastIndexOf()
message = "(What if) I am (only interested) in the last (set of parentheses)?";
openingPosition = message.LastIndexOf('(');

openingPosition += 1;
closingPosition = message.LastIndexOf(')');
length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

// retrieve all substrings inside parentheses
message = "(What if) there are (more than) one (set of parentheses)?";
while (true)
{
    openingPosition = message.IndexOf('(');
    if (openingPosition == -1) break;

    openingPosition += 1;
    closingPosition = message.IndexOf(')');
    length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));

    // Note the overload of the Substring to return only the remaining 
    // unprocessed message:
    message = message.Substring(closingPosition + 1);
}

// IndexOfAny()
message = "Help (find) the {opening symbols}";
Console.WriteLine($"Searching THIS Message: {message}");
char[] openSymbols = [ '[', '{', '(' ];
int startPosition = 5;
openingPosition = message.IndexOfAny(openSymbols);
Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

openingPosition = message.IndexOfAny(openSymbols, startPosition);
Console.WriteLine($"Found WITH using startPosition {startPosition}:  {message.Substring(openingPosition)}");
Console.WriteLine();

// Example 3 - advanced 
message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char array of characters. 
// You want to look for:

openSymbols = [ '[', '{', '(' ];

// You'll use a slightly different technique for iterating through 
// the characters in the string. This time, use the closing 
// position of the previous iteration as the starting index for the 
//next open symbol. So, you need to initialize the closingPosition 
// variable to zero:

closingPosition = 0;

while (true)
{
    openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1) break;

    string currentSymbol = message.Substring(openingPosition, 1);

    // Now  find the matching closing symbol
    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
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

    // To find the closingPosition, use an overload of the IndexOf method to specify 
    // that the search for the matchingSymbol should start at the openingPosition in the string. 

    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    // Finally, use the techniques you've already learned to display the sub-string:

    length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
}
Console.WriteLine("");

// Example 4 - Remove() and Replace()
string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);
Console.WriteLine(updatedData);

message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-", "");
Console.WriteLine(message);
Console.WriteLine();

// Exercise 1 - string manipulation
const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

const string openDiv = "<div>";
const string closeDiv = "</div>";

int openingSpan = input.IndexOf(openSpan);
int closingSpan = input.IndexOf(closeSpan);
string quantity = input.Substring(openingSpan + openSpan.Length, closingSpan - openingSpan - openSpan.Length);


int openingDiv = input.IndexOf(openDiv);
string output = input.Remove(openingDiv, openDiv.Length);
int closingDiv = output.IndexOf(closeDiv);
output = output.Remove(closingDiv,closeDiv.Length);
output = output.Replace("&trade;","&reg;");

Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");