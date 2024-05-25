// See https://aka.ms/new-console-template for more information
Random dice1 = new Random(); 
int roll = dice1.Next(1, 7); // Clase / stateful method. Requires the class to be instanciated first, before the method can be called 
Console.WriteLine(roll); // WriteLine(...) is a static method 
Console.Clear(); 

Random dice = new Random();
int roll1 = dice.Next(); // No bounds are set. Will generate an int from 0 to max_int 
int roll2 = dice.Next(101); // 101 is the max argument. Will generate an int from 0 to 101. 
int roll3 = dice.Next(50, 101); // Will generate an int from 50 to 100
int roll4 = dice.Next(-100, 1); 

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");
Console.WriteLine($"Fourth roll: {roll4}");

// Find the larger int 
int firstValue = 500;
int secondValue = 600;
int largerValue = System.Math.Max(firstValue, secondValue);
Console.WriteLine(largerValue);

