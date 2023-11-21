// See https://aka.ms/new-console-template for more information
using EmpConsole;
using EmpDal;
using EmpConsole;

/*
using EmpLib;

EmpLib.Person Amelin = new EmpLib.Person();
Amelin.Name = "Amelin";
Console.WriteLine(Amelin.eat());

EmpLib.Person Annlyn = new EmpLib.Person();
Annlyn.Name = "Annlyn";
Console.WriteLine(Annlyn.Work());

EmpLib.Person Amy = new EmpLib.Employee() { Designation="Intern", DOJ= DateTime.Now.AddMonths(-1)};
Amy.Name = "Amy";
((EmpLib.Employee)Amy).Designation = "Analyst";
Console.WriteLine(Amy.Work());
Console.WriteLine($"EmpId for {Amy.Name} is {((EmpLib.Employee)Amy).EmpId}");

Console.WriteLine(((EmpLib.Employee)Amy).AttendTraining("C2C"));

//Polymorphism
Polymorphism SharmajisFather = new Polymorphism();
Console.WriteLine($"Sharmaji's Father: {SharmajisFather.Settle()}");
Console.WriteLine($"Sharmaji's father gets married: {SharmajisFather.GetMarried()}");
Console.WriteLine($"Sharmaji's father's concept of Drawing (using Abstract): {SharmajisFather.Drawing()}");
Console.WriteLine($"Sharmaji's father's concept of Dating (using Abstract): {SharmajisFather.WhatIsDating()}");

//using virtual, modifications are allowed using override. Overrides behaviour is executed as below
Polymorphism Sharmaji = new Child();
Console.WriteLine($"Sharmaji: {Sharmaji.Settle()}");
Console.WriteLine($"Sharmaji gets married: {Sharmaji.GetMarried()}");
Console.WriteLine($"Sharmaji's concept of Drawing (using Abstract): {SharmajisFather.Drawing()}");
Console.WriteLine($"Sharmaji's concept of Dating (using Abstract): {SharmajisFather.WhatIsDating()}");

//No virtual, modifications disallowed by base class, forced modify using "new" keyword. Forced execution of derived class using
//typecasting ((Child)SharmajiV2).GetMarried()
Polymorphism SharmajiV2 = new Child();
Console.WriteLine($"Sharmaji V2 gets married: {((Child)SharmajiV2).GetMarried()}");

//C Overloading
EmpLib.Employee Jazz = new EmpLib.Employee();
Jazz.Name = "Jazz";
Jazz.Designation = "Security Analyst";
Console.WriteLine(Jazz.Work());
Console.WriteLine(Jazz.Work("Solving bugs"));

//orphan code - check
EmpLib.Employee Jennie = new EmpLib.Employee();
Jennie.SetTaxInfo("I'm eligible in the 20% tax payer category");
Console.WriteLine(Jennie.GetTaxInfo);

EmpLib.Person shanaya = new EmpLib.Person("123456789321","+91 8310204568");
Console.WriteLine($"Aadhar: {shanaya.Aadhar} | Mobile Number: {shanaya.MobileNumber}");

Console.WriteLine($"Total Employee Count: {EmpUtils.EmpCount}");

//Adding Employees to a Employee db using a static List<Employee>
EmpUtils.EmpDb.Add(Jazz);
EmpUtils.EmpDb.Add(Jennie);
EmpUtils.EmpDb.Add(new EmpLib.Employee("A23456789321", "+91 8310204568") { Name="Amelin", Designation="Analyst",Salary=500000});
EmpUtils.EmpDb.Add(new EmpLib.Employee("B21487653214", "+91 9310304678") { Name = "Genelia", Designation = "Analyst", Salary = 600000 });
EmpUtils.EmpDb.Add(new EmpLib.Employee("C23456543123", "+91 8310304567") { Name = "Annlyn", Designation = "Analyst", Salary = 900000 });
//Get all Employess whose aadhar card starts with A; where will put a for each loop, it returns a list
var resultList = EmpUtils.EmpDb.Where((emp) => emp.Aadhar != null && emp.Aadhar.StartsWith("A"));
resultList.ToList().ForEach((emp) => Console.WriteLine($"{emp.Name} | {emp.Aadhar}"));
//Get all Employees with salary greater than 600000
EmpUtils.EmpDb.Where((emp) => emp.Salary > 600000);
*/


//lab work
CrudEmpEf<Employee>.Add("Amelin", true);

CrudEmpEf<Employee>.Get() //Parent is datatype
         .ToList()
         .ForEach((p) => {
             if (p.IsActive == true)
                 Console.WriteLine($"{p.EmpName} is an {p.IsActive} employee");
             else
                 Console.WriteLine($"{p.EmpName} is not an active employee");
         });
