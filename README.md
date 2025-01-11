# NullReferenceException in C# due to Uninitialized Property

This repository demonstrates a common C# error: a `NullReferenceException` arising from accessing an uninitialized class property.  The `bug.cs` file contains the problematic code. The solution, preventing this exception, is shown in `bugSolution.cs`.

## The Problem

In C#, class properties are initially null unless explicitly initialized. Attempting to use such a property before assignment will throw a `NullReferenceException`.  This can be tricky to debug, especially in larger projects.

## The Solution

The best practice is to initialize the property in the class constructor or provide explicit null checks before using the property.
