
# Delegate

## What is a Delegate?

A delegate is a type that defines a method signature, and it can hold a reference to a method with that signature. Delegates are similar to function pointers in C and C++, but they are type-safe and secure.

### Key Characteristics of Delegates

- **Type Safety:** Delegates are type-safe, meaning the method signature must match the delegate signature.
- **Flexibility:** Delegates can point to both static and instance methods.
- **Chainable:** Multiple methods can be assigned to a delegate, creating a chain of methods.

## Understanding Delegates

Delegates can be thought of as objects that point to methods and can be changed at runtime. Here's a quick breakdown:

1. **Identify the Delegate:** Declare a delegate type that defines the method signature.
2. **Pointing to a Method:** Create a delegate instance and assign it a method.
3. **Invoking the Delegate:** Call the method via the delegate.

### Inline Anonymous Methods

You can define delegates using inline anonymous methods.

```csharp
// Inline Anonymous Method
delegate (int a, int b) { return a + b; }
```

### Lambda Expressions

Delegates can also be defined using lambda expressions.

```csharp
// Lambda Expression
(int a, int b) => a + b;
```

## Delegate Chains (Multicasting)

Delegates can be combined to form a multicast delegate, allowing multiple methods to be invoked.

```csharp
// Example of Delegate Chaining
public delegate void PrintMessage(string message);

PrintMessage printDel = printer.PrintToConsole;
printDel += printer.PrintToFile;

// Invoke the multicast delegate
printDel("Hello, Multicast!");
```

## Generic Delegates

C# provides several generic delegates to simplify common scenarios.

- **Func<in, in..., out>:** Represents a method that returns a value.
- **Action<in, in...>:** Represents a method that returns void.
- **Predicate<in, in...>:** Represents a method that returns a boolean value.

### Examples

```csharp
// Func delegate example
Func<int, int, int> add = (a, b) => a + b;

// Action delegate example
Action<string> print = message => Console.WriteLine(message);

// Predicate delegate example
Predicate<int> isEven = num => num % 2 == 0;
```

## Code Examples

### Basic Delegate Example

```csharp
public static void BasicDelegate()
{
    // Pointing
    Del del = (a, b) => Console.WriteLine($"RES : {a + b}");
    // Invoking
    del(1, 2);
}
```

This example defines a delegate `Del` that points to a method which takes two integers and prints their sum.

### Filtering a List using Delegates

```csharp
public static void AppFilterBasic()
{
    List<int> list = new List<int>() { 1, 10, 15, 40, 30, 70, 35, 20, 55, 80, 12, 100 };

    // Using Predicate delegate to check for even numbers
    Predicate<int> PredicateCheck = (a) => a % 2 == 0;

    // Invoking the delegate to filter the list
    FilterList(list, PredicateCheck);
    Console.WriteLine("#######################");

    // Adding another check using delegate multicasting
    PredicateCheck += (a) => a % 2 == 0;
    FilterList(list, PredicateCheck);
}
```

This example uses the `Predicate<int>` delegate to filter a list of integers for even numbers.

### Filtering Employees using Delegates

```csharp
public static void FilterEmp()
{
    List<Employee> employees = new List<Employee>() {
        new Employee(1,"fawzy1",20,2000),
        new Employee(2,"fawzy2",21,4000),
        new Employee(3,"fawzy3",22,8000),
        new Employee(4,"fawzy4",23,12000),
        new Employee(5,"fawzy5",24,14000),
        new Employee(6,"fawzy6",25,20000),
        new Employee(7,"fawzy7",26,25000),
    };

    // Filter employees by age
    FilterEmployee(employees, e => e.Age >= 24);
    Console.WriteLine("############################");
    
    // Filter employees by salary
    FilterEmployee(employees, e => e.Salary >= 12000);
    Console.WriteLine("############################");
    
    // Filter employees by ID
    FilterEmployee(employees, e => e.Id >= 5);
}
```

This example demonstrates how to use a delegate to filter a list of employees based on different criteria like age, salary, and ID.

### Generic Delegate Example

```csharp
public static void GnericDelebate()
{
    DelCal<int> del = (a, b) => Console.WriteLine($"RES : {a + b}");
    del.Invoke(10, 7);
}
```

This example shows the use of a generic delegate `DelCal<T>` to perform an addition operation on integers.

## Delegate Definitions

```csharp
// Definition of Del delegate
delegate void Del(int a, int b);

// Definition of CheckEvenOdd delegate
delegate bool CheckEvenOdd(int a);

// Definition of CheckEmp delegate
delegate bool CheckEmp(Employee emp);

// Definition of generic delegate
delegate void DelCal<T>(T a, T b);
```

## Helper Methods

### FilterList Method

```csharp
static void FilterList(List<int> list, Predicate<int> ch)
{
    foreach (var item in list)
    {
        if (ch(item))
        {
            Console.WriteLine(item);
        }
    }
}
```

This method filters a list of integers based on a predicate delegate.

### FilterEmployee Method

```csharp
static void FilterEmployee(List<Employee> emp, CheckEmp chemp)
{
    foreach (var item in emp)
    {
        if (chemp(item))
        {
            Console.WriteLine($"ID : {item.Id}, Name : {item.Name}, Age : {item.Age}, Salary : {item.Salary}");
        }
    }
}
```

This method filters a list of employees based on a delegate.

## Employee Class

```csharp
class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Salary { get; set; }

    public Employee(int id, string name, int age, int salary)
    {
        Id = id;
        Name = name;
        Age = age;
        Salary = salary;
    }
}
```

The `Employee` class represents an employee with properties for ID, name, age, and salary.

