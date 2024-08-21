
# Intro to OOP in C#

## Class and Object

### Class:
- A class is a blueprint for creating objects. It defines properties (fields), methods, and events that an object can have.

### Object:
- An object is an instance of a class. It is created from a class and can have its own values for the properties defined by the class.

### Constructor
- A constructor is a special method that is called when an object is instantiated. It usually initializes the fields of the object.

### Access Modifiers
Access modifiers define the accessibility of classes and class members. C# has several access modifiers:
- **Public:** The member is accessible from any other code.
- **Private:** The member is accessible only within its own class.
- **Protected:** The member is accessible within its own class and by derived classes.
- **Internal:** The member is accessible within its own assembly but not from another assembly.

## Constructor Chaining
Constructor chaining is when one constructor calls another constructor within the same class. This can help in reducing code duplication and initializing objects in multiple steps.

```csharp
public class Person {
    private string name;
    private int age;

    // Default constructor
    public Person() : this("Unknown", 0) {}

    // Constructor with one parameter
    public Person(string name) : this(name, 0) {}

    // Constructor with two parameters
    public Person(string name, int age) {
        this.name = name;
        this.age = age;
    }

    public void Introduce() {
        Console.WriteLine($"Hi, I'm {name} and I'm {age} years old.");
    }
}

// Creating objects with different constructors
Person person1 = new Person();
Person person2 = new Person("Alice");
Person person3 = new Person("Bob", 25);

person1.Introduce(); // Output: Hi, I'm Unknown and I'm 0 years old.
person2.Introduce(); // Output: Hi, I'm Alice and I'm 0 years old.
person3.Introduce(); // Output: Hi, I'm Bob and I'm 25 years old.
```

## Encapsulation / Inheritance / Polymorphism

### Encapsulation
**Definition:** Encapsulation is the mechanism of restricting access to some of the object's components and making only certain fields and methods accessible. This is usually achieved using access modifiers like private, protected, and public.

**Key Points:**
- Private Members: Hide the internal state of the object.
- Public Methods: Provide controlled access to the private members through getters and setters.

### Inheritance
**Definition:** Inheritance allows one class to inherit the properties and methods of another class. The class that inherits is called the derived class or child class, and the class being inherited from is called the base class or parent class.

**Key Points:**
- Base Class: The class being inherited from.
- Derived Class: The class that inherits from the base class.
- Reusability: Promotes code reusability and reduces redundancy.

### Polymorphism
**Definition:** Polymorphism allows methods to do different things based on the object they are acting upon, even though they share the same name. It can be achieved through method overriding and interfaces in C#.

**Key Points:**
- Method Overriding: Redefining a base class's method in a derived class with the same signature.
- Interfaces: Different classes can implement the same interface, which allows for method polymorphism.

## Abstraction / Interfaces

### Abstraction
An abstract class is a class that cannot be instantiated on its own and must be inherited by other classes. It can contain both abstract methods (without implementation) and concrete methods (with implementation).

### Interfaces
An interface is a contract that defines a set of methods and properties that a class must implement. Unlike abstract classes, interfaces cannot contain any implementation.

**Key Points:**
- Abstract classes can have both abstract and concrete methods.
- Interfaces define a contract with methods and properties that implementing classes must provide.

## Struct / Enum

### Struct
Structures (structs) in C# are value types that are typically used to encapsulate small groups of related variables. Structs are similar to classes but have some key differences, mainly in terms of their behavior and usage.

**Key Characteristics of Structs:**
- Value Type: Structs are value types, stored on the stack and holding their data directly.
- No Inheritance: Structs cannot inherit from other structs or classes, and they cannot be used as a base for other structs or classes. However, they can implement interfaces.
- Immutability: Ensures that once an instance is created, its state cannot change.

### Enum
An enumeration (enum) is a value type that consists of a set of named constants called the enumerator list. Enums are used to define a collection of related constants that can be assigned to a variable, making the code more readable and maintainable.

**Summary:**
- Enums are value types that consist of named constants.
- Default underlying type is int, but can be changed to other integral types.
- Enums have several useful methods provided by the Enum class, such as `GetName`, `GetNames`, and `GetValues`.

## Static Types

### Static Class
A class that cannot be instantiated and can only contain static members.

### Static Methods
Methods that are called on the class itself rather than on instances of the class. They deal with static members.

### Static Fields
Variables that are shared among all instances of the class.

### Static Properties
Static properties can be used to encapsulate static fields.

### Static Constructors
A static class can have a static constructor, which is called once, before any static members are accessed, and is used to initialize static members.

## Namespaces and Assemblies

### Namespaces
Namespaces organize code and prevent naming conflicts by grouping related types.

**Key Points about Namespaces:**
- Declaration: Namespaces are declared using the `namespace` keyword.
- Hierarchy: Namespaces can be nested, creating a hierarchy.
- Using Directive: The `using` keyword allows you to access members of a namespace without specifying the full namespace path.

### Assemblies
Assemblies are compiled code libraries that contain one or more namespaces and provide the unit of deployment, versioning, and security in .NET applications.

## Object Initializers and Extension Methods

### Object Initializers
Allow you to initialize an object's properties at the time of creation without explicitly calling a constructor. This provides a more concise and readable way to set properties.

### Extension Methods
Allow you to add new methods to existing types without modifying their source code or creating a new derived type. This is particularly useful for extending classes from libraries that you do not control.

## Association, Aggregation, Composition

### Association
Represents a relationship between two or more objects where all objects have their own lifecycle and there is no ownership between them. It is a "uses-a" relationship.

**Key Points about Association:**
- Bidirectional or Unidirectional: It can be bidirectional (both objects know about each other) or unidirectional (one object knows about the other).
- Lifetime Independence: The existence of one object does not depend on the other.

### Aggregation
A special type of association that represents a "whole-part" relationship where the part can exist independently of the whole. It is a "has-a" relationship with a weaker form of ownership.

**Key Points about Aggregation:**
- Weak Ownership: The part can exist independently of the whole.
- Lifetime Independence: Deleting the whole does not delete the part.

### Composition
A stronger form of aggregation that represents a "whole-part" relationship where the part cannot exist without the whole. It is a "contains-a" relationship with strong ownership.

**Key Points about Composition:**
- Strong Ownership: The part cannot exist independently of the whole.
- Lifetime Dependence: Deleting the whole deletes the part.

## Software Development Process

### Identify Requirements
- **Functional Requirements:** Define the specific behavior or functions of the system.
- **Non-Functional Requirements:** Define the system's operational attributes such as performance, usability, reliability, etc.

### Identify Use Cases
Identify and describe the different ways the system will be used by actors (users or other systems).

### Write User Stories
Create user stories to describe the features of the system from an end-user perspective.

### Identify Classes and Relationships from User Stories
Analyze user stories to identify the classes and relationships that will form the basis of the system's design.

### Create UML
Use Unified Modeling Language (UML) to visually represent the system's classes, relationships, and interactions.

### Start Coding
Begin the implementation of the system based on the design and UML diagrams.
