# DCIT 318: Programming II Assignment 2

## Object-Oriented Programming Demonstrations in C#

This C# console application demonstrates three fundamental aspects of object-oriented programming:

### 1. Inheritance and Method Overriding

**Classes:**
- `Animal` (base class) - Contains a virtual `MakeSound()` method that prints "Some generic sound"
- `Dog` (derived class) - Overrides `MakeSound()` to print "Bark"
- `Cat` (derived class) - Overrides `MakeSound()` to print "Meow"

**Demonstration:** Shows how derived classes can override methods from their base class to provide specific implementations.

### 2. Abstract Classes and Methods

**Classes:**
- `Shape` (abstract base class) - Contains an abstract `GetArea()` method
- `Circle` (derived class) - Implements `GetArea()` to calculate circle area using π × r²
- `Rectangle` (derived class) - Implements `GetArea()` to calculate rectangle area using length × width

**Demonstration:** Shows how abstract classes define a contract that derived classes must implement.

### 3. Interfaces

**Interface:**
- `IMovable` - Defines a `Move()` method contract

**Classes:**
- `Car` - Implements `IMovable` and prints "Car is moving"
- `Bicycle` - Implements `IMovable` and prints "Bicycle is moving"

**Demonstration:** Shows how interfaces provide a way to achieve multiple inheritance and define contracts that classes must follow.

## How to Run

1. Ensure you have .NET SDK installed
2. Navigate to the project directory
3. Run the following commands:
   ```bash
   dotnet build
   dotnet run
   ```

## Expected Output

The application will display demonstrations of all three OOP concepts with clear output showing:
- Animal sounds from different classes
- Area calculations for different shapes
- Movement messages from different vehicles

## Project Structure

```
dcit318-assignment2-11297686/
├── Program.cs                             
├── InheritanceandOverriding/
│   └── InheritanceExample.cs             
├── AbstractClassesandMethods/
│   └── AbstractExample.cs                
├── Interface/
│   └── InterfaceExample.cs               
├── OOPDemo.csproj                        
├── .gitignore                            
└── README.md                             
```

## Learning Objectives

This assignment helps me understand:
- How inheritance works in C#
- Method overriding and virtual methods
- Abstract classes and methods
- Interface implementation
- Polymorphism in object-oriented programming 
