// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic;
using System;

partial class Program
{
    //Declaration = new
    delegate void Compute(int n1, int n2);
    delegate void Contractor(double budget);
    delegate void WorkDelegate();
    static void Main()
    {
        //Work Delegate: accepts string, bool and returns void
        //Work("Coding in C#", true)
        Action<string, bool> WorkDelegate = new Action<string, bool>(
                    (work1, work2) => 
                    {
                        Console.WriteLine($"Coding in C# : {work1} and {work2}");
                    });

        //Print Delegate: accepts a string and Returns a string to be printed
        //Print("Dhanush")
        //Func<string> PrintDelegate = () => { };

        //UpdateDb Delegate: accepts a string and returns boolean
        //UpdateDb("update Employee set isActive=true")
        //Predicate<string> isEmpty = (v) =>
        {
            //string v =
            //if ("update Employee set") return false;
            //else return true;
        };


    }

    private static void UsingGenericDelegate()
    {
        Action<double> RockyRaniRegisterMarriage = new Action<double>(
                    (budget) =>
                    {
                        Console.WriteLine($"Registration fees & Arrangement: {budget * 95 / 100}");
                        Console.WriteLine($"Reception Charges: {budget * 5 / 100}");
                    });

        Func<int, int, string> modifiedCompute = (n1, n2) => $"Addition: {n1 + n2}";
        modifiedCompute += (n1, n2) => $"Subtration; {n1 - n2}";

        Predicate<int> isActive = (v) =>
        {
            if (v == 0) return false;
            else return true;
        };

        //Invoke all above delegates
        RockyRaniRegisterMarriage(50000d);
        Console.WriteLine(modifiedCompute(100, 200));
        Console.WriteLine($"Output of Predicate: {isActive(1)}");
    }

    private static void RockyRaniMarriage()
    {
        Contractor RockyRaniMarriage = new Contractor((b) => Console.WriteLine($"Pandit charges: {b * 20 / 100}"));
        RockyRaniMarriage += (b) => Console.WriteLine($"Catering Charges: {b * 50 / 100}");
        RockyRaniMarriage += (b) => Console.WriteLine($"Mandap Decoration: {b * 5 / 100}");
        RockyRaniMarriage += (b) => Console.WriteLine($"Couple arrive in Porsche: {b * 15 / 100}");

        //Invokation like calling a function
        RockyRaniMarriage(5000000);
    }

    private static void UsingLambdas()
    {
        //Instantiate
        Compute objShortCompute = new Compute((a, b) => Console.WriteLine($"Addition: {a + b}"));
        objShortCompute += (s, t) => Console.WriteLine($"Substraction: {s - t}");
        objShortCompute += (a, b) => Console.WriteLine($"Multiplication: {a * b}");
        objShortCompute += (s, t) => Console.WriteLine($"Division: {s / t}");

        //Invokation like calling a function
        objShortCompute(250, -50);
    }

    private static void DelegatesUsingLongCutTechnique()
    {
        //Instatiate
        Compute objCompute = new Compute(AddFn);
        objCompute += SubFn;
        objCompute += MulFn;
        objCompute += DivFn;

        //Invoke the delegate exactly lika a function
        objCompute(100, 200);
    }

    static void AddFn(int n1, int n2)
    {
        Console.WriteLine($"Output of Addition: {n1 + n2}");
    }

    static void SubFn(int n1, int n2)
    {
        Console.WriteLine($"Output of Subtracttion: {n1 - n2}");
    }

    static void MulFn(int n1, int n2)
    {
        Console.WriteLine($"Output of Multiplication: {n1 * n2}");
    }

    static void DivFn(int n1, int n2)
    {
        Console.WriteLine($"Output of Division: {n1 / n2}");
    }
}
