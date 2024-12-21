# NullReferenceException in C# Property Access

This repository demonstrates a common coding error in C#: the `NullReferenceException` that occurs when trying to access a member of a null object reference.

## The Problem
The `Bug.cs` file contains a simple class with a property. The `MyMethod` attempts to access the `ToString()` method of the property without checking for null. If `MyProperty` is null, this will throw a `NullReferenceException`.

## The Solution
The `BugSolution.cs` file provides a corrected version. It checks for null before accessing the property's member, thus preventing the exception.

## How to reproduce
1. Clone this repository.
2. Open `Bug.cs` in a C# IDE.
3. Run `MyMethod()`.  You will get a `NullReferenceException`. 
4. Open `BugSolution.cs` in a C# IDE.
5. Run `MyMethod()`.  This code should run without error even if MyProperty is null.
