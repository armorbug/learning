//do-while and while statements 

// Example 1
Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);

/*
while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");
*/

// Exercise 1
int attack = 0;
int heroHP = 10;
int monsterHP = 10;

while (heroHP > 0 && monsterHP > 0)
{
    attack = random.Next(1, 11);
    monsterHP -= attack;
    Console.WriteLine($"Monster was damaged and lost {attack} health and now has {monsterHP} health.");
    if (monsterHP <= 0) continue;
    attack = random.Next(1, 11);
    heroHP -= attack;
    Console.WriteLine($"Hero was damaged and lost {attack} health and now has {heroHP} health.");
}
if (monsterHP <= 0) Console.WriteLine("Hero wins!");
else Console.WriteLine("Monster wins...");

// // Example 2
// string? readResult;
// Console.WriteLine("Enter a string:");
// do
// {
//     readResult = Console.ReadLine();
// } while (readResult == null);

// // Example 3 
// string? readResult;
// bool validEntry = false;
// Console.WriteLine("Enter a string containing at least three characters:");
// do
// {
//     readResult = Console.ReadLine();
//     if (readResult != null)
//     {
//         if (readResult.Length >= 3)
//         {
//             validEntry = true;
//         }
//         else
//         {
//             Console.WriteLine("Your input is invalid, please try again.");
//         }
//     }
// } while (validEntry == false);

// // Example 4
// // capture user input in a string variable named readResult

// int numericValue = 0;
// bool validNumber = false;

// validNumber = int.TryParse(readResult, out numericValue);

// Exercise 2 
int numericValue = 0;
bool validNumber = false;

Console.WriteLine("Please enter an integer value between 5 and 10");
do
{
    string? readResult = Console.ReadLine();
    if (int.TryParse(readResult, out numericValue))
    {
        if (numericValue >= 5 && numericValue <= 10) validNumber = true;
        else Console.WriteLine($"You entered {numericValue}. Please enter a number between 5 and 10.");
    } else Console.WriteLine("Sorry, you entered an invalid number, please try again.");
} while (!validNumber);

Console.WriteLine("Your input value has been accepted.");

// Exercise 3
bool validInput = false;
string? inputRole;

Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

do
{
    inputRole = Console.ReadLine();
    if (inputRole == "Administrator" || inputRole == "Manager" || inputRole == "User") validInput = true;
    else Console.WriteLine($"The role name that you entered, \"{inputRole}\" is not valid. Enter your role name (Administrator, Manager, or User)");

} while (!validInput);
    
Console.WriteLine($"Your input value ({inputRole}) has been accepted.");

// Exercise 4
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int periodLocation;

foreach (string myString in myStrings)
{
    periodLocation = myString.IndexOf('.');
    string str = myString;

    while (periodLocation != -1)
    {
        Console.WriteLine(str.Remove(periodLocation));

        str = str.Substring(periodLocation+1).TrimStart();
        periodLocation = str.IndexOf('.');
    }
    Console.WriteLine(str);
}