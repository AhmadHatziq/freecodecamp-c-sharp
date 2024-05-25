Personal code repo which follows this [C# course](https://www.freecodecamp.org/learn/foundational-c-sharp-with-microsoft/) by Microsoft & FreeCodeCamp. 

To create the hello-world project in C#, run `dotnet new console -o ./hello-world-project/`

To compile the code to binary file, run `dotnet build`

To run the project, run `dotnet run`. 

String interpolation example: `Console.WriteLine($"First roll: {roll1}");`

Raw string (verbatim) example with interpolation: 
```
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");
```

