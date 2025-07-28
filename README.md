Personal code repo which follows this [C# course](https://www.freecodecamp.org/learn/foundational-c-sharp-with-microsoft/) by Microsoft & FreeCodeCamp. 
- FreeCodeCamp progress: Use gmail 
- Microsoft Learn progress: use hotmail 

To create the hello-world project in C#, run `dotnet new console -o ./hello-world-project/`

To compile the code to binary file, run `dotnet build`

To run the project, run `dotnet run`. 

String interpolation example: `Console.WriteLine($"First roll: {roll1}");`

Raw string (verbatim) example with interpolation: 
```
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");
```

# Running a dotnet Program 
1. Create a Project and run it  

```
dotnet new console -o MyApp
cd MyApp
cp /path/to/your/Program.cs .
dotnet run
```

2. Use inline execution
```
dotnet tool install -g dotnet-script
dotnet script Program.cs
```
