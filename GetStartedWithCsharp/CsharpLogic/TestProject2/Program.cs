//variable scope and logic using code blocks

//Example 1
bool flag = true;
int value = 0;

if (flag)
{
    value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}

Console.WriteLine($"Outside the code block: {value}");

//Example 2
bool flag2 = true;
if (flag2)
    Console.WriteLine(flag2);

//Example 3
string name = "steve";
if (name == "bob") 
    Console.WriteLine("Found Bob");
else if (name == "steve") 
    Console.WriteLine("Found Steve");
else 
    Console.WriteLine("Found Chuck");

//Exercise 1
int[] numbers = { 4, 8, 15, 16, 23, 42};
int total = 0;
bool found = false;

foreach (int number in numbers)
{
    total += number;
    if (number == 42)
        found = true;
}

if (found)
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");
