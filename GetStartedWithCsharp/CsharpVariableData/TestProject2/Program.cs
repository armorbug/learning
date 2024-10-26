// convert data types using casting and conversion techniques

// Example 1 - safe conversions 
using System.Runtime.CompilerServices;

int first = 2;
string second = "4";
//int result = first + second; - error
string result = first + second;
Console.WriteLine(result);
Console.WriteLine("");

// Example 2 - widening(implicit) conversion
int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");
Console.WriteLine("");

// Example 3 - casting and narrowing(explicit) conversion
myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");
Console.WriteLine("");

// Example 4 - narrowing or widening
myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float  : {myFloat}");
Console.WriteLine("");

// Example 5 - number to string
int firstInt = 5;
int secondInt = 7;

string message = firstInt.ToString() + secondInt.ToString();
Console.WriteLine(message);
Console.WriteLine("");

// Example 6 - string to int
string firstString = "5";
string secondString = "7";
int sum = int.Parse(firstString) + int.Parse(secondString); //use TryParse to avoid illegal conversions
Console.WriteLine(sum);
int product = Convert.ToInt32(firstString) + Convert.ToInt32(secondString);
Console.WriteLine(product);
Console.WriteLine("");

// Example 7 - casting and converting decimal to int
int value = (int)1.5m; //casting truncates
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m); //converting rounds up
Console.WriteLine(value2);

int value3 = Convert.ToInt32(1.499m);
Console.WriteLine(value3);
Console.WriteLine("");

// Example 8 - TryParse
//string measurementString = "102";
string badValue = "bad";
int measurement = 0;
if (int.TryParse(badValue, out measurement))
{
    Console.WriteLine($"Measurement: {measurement}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}
if (measurement > 0)
{
    Console.WriteLine($"Measurement (w/ offset): {50 + measurement}");
}
Console.WriteLine("");


// Exercise 1 - sort string and integer values
string[] values = ["12.3", "45", "ABC", "11", "DEF"];
message = "";
decimal sumD = 0;
foreach (string item in values)
{
    if (decimal.TryParse(item, out decimal number)) //out assigns value if true
    {
        sumD += number;
    }
    else
    {
        message += item;
    }
}
Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {sumD}");
Console.WriteLine("");

// Exercise 2 - output math operations
int value4 = 11;
decimal value5 = 6.2m;
float value6 = 4.3f;

// Your code here to set result1
int result1 = Convert.ToInt32(value4 / value5);
// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide value4 by value5, display the result as an int: {result1}");

// Your code here to set result2
decimal result2 = value5 / (decimal)value6;
Console.WriteLine($"Divide value5 by value6, display the result as a decimal: {result2}");

// Your code here to set result3
float result3 = value6 / value4;
Console.WriteLine($"Divide value6 by value4, display the result as a float: {result3}");