// implement exception handling

// Example 1 - finally executes before catch 
try
{
    // Step 1: code execution begins
    try
    {
        // Step 2: an exception occurs here
    }
    finally
    {
        // Step 4: the system executes the finally code block associated with the try statement where the exception occurred
    }

}
catch // Step 3: the system finds a catch clause that can handle the exception
{
    // Step 5: the system transfers control to the first line of the catch code block
}

// Example 2 - common exception types 

// // ArrayTypeMismatchException
// string[] names = { "Dog", "Cat", "Fish" };
// Object[] objs = (Object[])names;

// Object obj = (Object)13;
// objs[2] = obj; // ArrayTypeMismatchException occurs

// // DivideByZeroException - but dividing floats does not trigger it 
// int number1 = 3000;
// int number2 = 0;
// Console.WriteLine(number1 / number2); // DivideByZeroException occurs

// // FormatException
// int valueEntered;
// string userValue = "two";
// valueEntered = int.Parse(userValue); // FormatException occurs

// // IndexOutOfRangeException
// int[] values1 = { 3, 6, 9, 12, 15, 18, 21 };
// int[] values2 = new int[6];

// values2[values1.Length - 1] = values1[values1.Length - 1]; // IndexOutOfRangeException occurs

// // InvalidCastException
// obj = "This is a string";
// int num = (int)obj;

// // NullReferenceException
// int[] values = null;
// for (int i = 0; i <= 9; i++)
//     values[i] = i * 2;

// string? lowCaseString = null;
// Console.WriteLine(lowCaseString.ToUpper());

// //OverflowException
// decimal x = 400;
// byte i;

// i = (byte)x; // OverflowException occurs
// Console.WriteLine(i);

// Example 3 - try-catch
double float1 = 3000.0;
double float2 = 0.0;
int number1 = 3000;
int number2 = 0;

try
{
    Console.WriteLine(float1 / float2);
    Console.WriteLine(number1 / number2);
}
catch
{
    Console.WriteLine("An exception has been caught.");
}
Console.WriteLine("Exit program");
Console.WriteLine("");

// Exercise 1 - catch specific exception types
try
{
    Process1();
}
catch
{
    Console.WriteLine("An exception has occurred");
}

Console.WriteLine("Exit program");
Console.WriteLine("");

static void Process1()
{
    try
    {
        WriteMessage();
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"Exception caught in Process1: {ex.Message}");
    }
}
static void WriteMessage()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;
    byte smallNumber;

    try
    {
        Console.WriteLine(float1 / float2);
        Console.WriteLine(number1 / number2);
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"Exception caught in WriteMessage: {ex.Message}");
    }
    checked //having "checked" in the code throws the OverflowException
    {
        checked
        {
            try
            {
                smallNumber = (byte)number1;
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"Exception caught in WriteMessage: {ex.Message}");
            }
        }
    }
}

// Example 4 - catch exceptions in a code block
// inputValues is used to store numeric values entered by a user
string[] inputValues = new string[] { "three", "9999999999", "0", "2" };

foreach (string inputValue in inputValues)
{
    int numValue = 0;
    try
    {
        numValue = int.Parse(inputValue);
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid readResult. Please enter a valid number.");
    }
    catch (OverflowException)
    {
        Console.WriteLine("The number you entered is too large or too small.");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
Console.WriteLine("");


// Exercise 2 
try
{
    int num1 = int.MaxValue;
    int num2 = int.MaxValue;
    int result;
    checked
    {
        result = num1 + num2;
    }
    Console.WriteLine("Result: " + result);
}
catch (OverflowException ex)
{
    Console.WriteLine("Error: The number is too large to be represented as an integer. " + ex.Message);
}
try
{
    string str = null;
    int length = str.Length;
    Console.WriteLine("String Length: " + length);
}
catch (NullReferenceException ex)
{
    Console.WriteLine("Error: The reference is null. " + ex.Message);
}
try
{
    int[] numbers = new int[5];
    numbers[5] = 10;
    Console.WriteLine("Number at index 5: " + numbers[5]);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("Error: Index out of range. " + ex.Message);
}
try
{
    int num3 = 10;
    int num4 = 0;
    int result2 = num3 / num4;
    Console.WriteLine("Result: " + result2);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Error: Cannot divide by zero. " + ex.Message);
}

Console.WriteLine("Exiting program.");
Console.WriteLine("");
