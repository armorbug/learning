// perform operations on arrays using helper methods 

// Example 1 - Array.Sort() and Array.Reverse()
string[] pallets = ["B14", "A11", "B12","A13"];

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach(var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
} 

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach(var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// Example 2 - Array.Clear() and Array.Resize()
pallets = [ "B14", "A11", "B12", "A13" ];
Console.WriteLine("");

Console.WriteLine($"Before: {pallets[0].ToLower()}");
Array.Clear(pallets, 0, 2);
//Console.WriteLine($"After: {pallets[0].ToLower()}"); - System.NullReferenceException
if (pallets[0] != null)
    Console.WriteLine($"After: {pallets[0].ToLower()}");
else Console.WriteLine($"After: {pallets[0]}"); //implicit coversion of null to empty string by C# compiler 

Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6); //pass by reference 
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
Console.WriteLine();

/*
To remove null elements from array:
1) count the number of non-null elements by iterating through each item and increment a variable (counter)
2) create a second array that is the size of the counter variable
3) loop through each element in the original array and copy non-null values into the new array
*/

// Example 3 - Array.Split() and Array.Join()
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
//string result = new string(valueArray);
string result = String.Join(",",valueArray);
Console.WriteLine(result);

string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}
Console.WriteLine();

// Exercise 1 - reverse words in a sentence 
string pangram = "The quick brown fox jumps over the lazy dog";
string[] words = pangram.Split(' ');
string margnap = "";
foreach (string word in words)
{
    char[] wordArray = word.ToCharArray();
    Array.Reverse(wordArray);
    margnap += new string (wordArray) + ' ';
}
Console.WriteLine(margnap);
Console.WriteLine();

// //another solution
// string pangram = "The quick brown fox jumps over the lazy dog";

// // Step 1
// string[] message = pangram.Split(' ');

// //Step 2
// string[] newMessage = new string[message.Length];

// // Step 3
// for (int i = 0; i < message.Length; i++)
// {
//     char[] letters = message[i].ToCharArray();
//     Array.Reverse(letters);
//     newMessage[i] = new string(letters);
// }

// //Step 4
// string result = String.Join(" ", newMessage);
// Console.WriteLine(result);

// Exercise 2 - parse a string of orders, sort the orders and tag possible errors
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orderIDs = orderStream.Split(',');
Array.Sort(orderIDs);
foreach (string orderID in orderIDs)
{
    if (orderID.Length != 4) Console.WriteLine($"{orderID}\t- Error");
    else Console.WriteLine(orderID);
}