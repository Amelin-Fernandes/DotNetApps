// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Xml.Linq;

//WorkingWithDataTypes();
void WorkingWithDataTypes()
{
    Console.WriteLine("Hello, World!");

    int num1 = 100;
    int num2 = 100;
    Console.WriteLine("Sum = " + (num1 + num2));

    var num3 = 200;
    var formattedFloat = 200f;
    var formattedDouble = 200d;
    var formattedDecimal = 200m;
    Console.WriteLine(num3.GetType().Name);
    Console.WriteLine(formattedFloat.GetType().Name);
    Console.WriteLine(formattedDouble.GetType().Name);
    Console.WriteLine(formattedDecimal.GetType().Name);

    // Concatenation using String Interpolation
    Console.WriteLine($"The datatype of num3 is {num3.GetType().Name}");
    Console.WriteLine($"The datatype of formattedFloat is {formattedFloat.GetType().Name}");
    Console.WriteLine($"The datatype of formattedDouble is {formattedDouble.GetType().Name}");
    Console.WriteLine($"The datatype of formattedDecimal is {formattedDecimal.GetType().Name}");

    //other types
    bool isEverythingOk = true;
    String greetMessage = "Hello welcome to C# Training session";
    char iAmSingle = 'S';

    Console.WriteLine($"Value of {nameof(isEverythingOk)} is {isEverythingOk}");

}

void ConversionOfTypes()
{
    int num1 = 100;
    double num2 = 100;
    bool isEverythingOk = true;
    string str = "Hello";
    string strNum = "100";

    var result1 = (double)num1;
    var result2 = (int)num2;
    // var result3 = (string)isEverythingOk; //string on heap and bool in stack

    var convert1 = Convert.ToString(num1);
    var convert2 = Convert.ToInt32(strNum);
    //var convert3 = Convert.ToInt32(str);
}

//WorkingWithArrays();

void WorkingWithArrays()
{
    int[] arr = new int[3];
    arr[0] = 10;
    arr[1] = 20;
    arr[2] = 30;

    for (int i=0; i<arr.Length;i++)
    {
        Console.WriteLine($"Value of item: {arr[i]}");
    }

    String[] greetings = { "Namaste", "Hello", "Hola"};

    int k = 0;
    while(k <= greetings.Length)
    {
        Console.WriteLine($"A new way to Greet: {greetings[k]}");
        k++;
    }

    int[] evens = {2,4,6,8,10};
    int counter = 0;
    do
    {
        Console.WriteLine($"The next even number: {evens[counter]}");
        counter++;
    }while(counter <= evens.Length);
    object[] objArray= { 100, "Ok", new int[] { 1, 2, 3 } };

    foreach (var singleitem in objArray)
    {
        if (singleitem.GetType().Name == "Int32[]")
        {
            foreach (var item in (Int32[])singleitem)
            {
                Console.WriteLine(item);
            }
        }
        else
        {
            Console.WriteLine($"Simple item in {nameof(objArray)}: {singleitem}");
        }
    }
}

WorkingWithLists();

void WorkingWithLists()
{
    List<string> shoppingList = new List<String>();
    Console.WriteLine($"Total items in shopping bag: {shoppingList.Count()}");
    shoppingList.Add("Bags");
    Log(new object[] { "item added:", shoppingList[0] });
    shoppingList.Add("Dresses");
    Log(new object[] { "item added:", shoppingList[1] });
    shoppingList.Add("Shoes");
    Log(new object[] { "item added:", shoppingList[2] });
    //print, we didn't do List<string> because it will create list of list and we do not want that
    PrintValues(shoppingList);
    Console.WriteLine($"Total items in shopping bag: {shoppingList.Count()}");
    shoppingList.Remove("Shoes");
    Log(new object[] { "item removed: Shoes" });
    Console.WriteLine($"Total items in shopping bag: {shoppingList.Count()}");
    Print(new object[]{"Comma-separated values of the shopping list",
        shoppingList[0], shoppingList[1],"\nThe total count of items is: ", shoppingList.Count() });
}

void Log<T>(T[] pValues)
{
    string result = "";
    foreach (var item in pValues)
    {
        result = $"{result} {item}";
    }

    var finalResult = $"[{DateTime.Now.ToString()}] : {result}";
    //Console Logging
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("-----------");
    Console.WriteLine(finalResult);

    //Output Window
    Debug.WriteLine("---- LOG ----");
    Debug.WriteLine(finalResult);
}

//object array takes multiple types
void Print<T>(T[] pValues)
{
    string result = "";
    foreach (var item in pValues)
    {
        result = $"{result}, {item}";
    }
    result = result.TrimStart(',');
    Console.WriteLine(result);
}
void PrintValues<T>(List<T> pCollection)
{
    foreach (var item in pCollection)
    {
        Console.WriteLine(item);
    }
}

Utils objUtils = new Utils();
class Utils
{

}
