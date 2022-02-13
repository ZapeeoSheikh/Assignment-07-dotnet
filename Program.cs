// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Calculator calculator = new Calculator() ;

// Method Overloading 
Console.WriteLine(calculator.Sum(89, 34));
Console.WriteLine(calculator.Sum(9.2, 3.3, 12.3));
// There is not overriding occurs because number of paremeter are diffrent 

Blacksmith blacksmith = new Blacksmith();
Carpenter carpenter = new Carpenter();
Worker worker = new Worker();

// Method Overriding 
string value1 = worker.Work = "General work";
string value2 = carpenter.Work = "Wood work";
string value3 = blacksmith.Work = "Iron work";
Console.WriteLine(value1);
Console.WriteLine(value2);
Console.WriteLine(value3);