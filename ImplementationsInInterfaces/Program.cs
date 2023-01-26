// See https://aka.ms/new-console-template for more information
using ImplementationsInInterfaces;


AdderFromInterface adderI = new("Test");
Console.WriteLine(adderI.Dupe(3));
// The next statement generates a compiler errror. 
//Console.WriteLine(adderI.Add("B"));
// In order to call a member implemented in an interace, you must cast the object to the interfacee
Console.WriteLine(((IBase)adderI).Add("B"));

AdderFromBase adderB = new("Test");
Console.WriteLine(adderB.Dupe(3));
Console.WriteLine(adderB.Add("B"));
Console.WriteLine(((Base)adderB).Add("B"));

