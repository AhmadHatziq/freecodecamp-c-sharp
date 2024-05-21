// See https://aka.ms/new-console-template for more information
Random dice = new Random(); 
int roll = dice.Next(1, 7); // Clase / stateful method. Requires the class to be instanciated first, before the method can be called 
Console.WriteLine(roll); // WriteLine(...) is a static method 


