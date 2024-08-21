//Goal ===>  {✔,X}
/*
 * Study Hard 
 * - حدد الاجزاء اللى هتذاكرها 
 * - حدد مصادر التعلم + مكان الملاحظات 
 * - ابتعد عن التشتت 
 * - ذاكر فترات قصرة و قست من الرحة 
 * - غير المكان 
 * 
 * 
 * #1 
 * [✔] Review ( ConCept + Library System ) 
 * [] IMprove Concept OOP + Apply 
 * 
 * 
 */
// Procedural Vs. OOP
// Defult Class ==> internal 
// Defult member ==> private 


// # Basic (Fawzy)

// Varible - data type 
// Type Convertion - Getting user input
// Operations - Conditions
// Loop - Array
// Const - Nullable type - Coalscing
// Exception 
// Method
//      - Named paramter
//      - Defult Paramter
//      - Ref - out
//      - params array 
// String  ==> Need to More Study And Search and Apply join , split 



// # Intermadiate 
// Intro to oop ( class - object - class Member {Fild,property,Method}- Constractor - Access Modifiers )
//      - Constractor Chaining 
//      - Access (Public - private - internal - protected)
/*
 * Intro to OOP
 * 
 * Class and Object
 * # Class:
 *      - A class is a blueprint for creating objects. It defines properties (fields), methods, and events that an object can have.
 * # Object:
 *      - An object is an instance of a class. It is created from a class and can have its own values for the properties defined by the class.
 *
 * # Constructor
 *      - A constructor is a special method that is called when an object is instantiated. It usually initializes the fields of the object. 
 *      - Constructor chaining is when one constructor calls another constructor within the same class. 'This' can help in reducing code duplication and initializing objects in multiple steps.
 *
 * # Access Modifiers
 * Access modifiers define the accessibility of classes and class members. C# has several access modifiers:
 *      - Public: The member is accessible from any other code.
 *      - Private: The member is accessible only within its own class.
 *      - Protected: The member is accessible within its own class and by derived classes.
 *      - Internal: The member is accessible within its own assembly but not from another assembly.
 *
 *
 */

// Encapsulation / Inherance / Polymorphism   
/*
 * Encapsulation
 * Definition: is the mechanism of restricting access to some of the object's components and making
 * only certain fields and methods accessible. This is usually achieved using access modifiers like private, protected, and public.
 *
 * Key Points:
 *      - Private Members: Hide the internal state of the object.
 *      - Public Methods: Provide controlled access to the private members through getters and setters.
 */

/*
 * Inheritance
 * Definition:
 * Inheritance allows one class to inherit the properties and methods of another class. The class that inherits is
 * called the derived class or child class, and the class being inherited from is called the base class or parent class.
 *
 * Key Points:
 *      - Base Class: The class being inherited from.
 *      - Derived Class: The class that inherits from the base class.
 *      - Reusability: Promotes code reusability and reduces redundancy.
 *  
 */
/*
 *
 * Polymorphism
 * Definition: allows methods to do different things based on the object they are acting upon, even though they share the same name.
 * It can be achieved through method overriding and interfaces in C#.
 *
 *  Key Points:
 *      - Method Overriding: Redefining a base class's method in a derived class with the same signature.
 *      - Interfaces: Different classes can implement the same interface, which allows for method polymorphism.
 * 
 */


// Abstraction / Interfaces 
/*
 * An abstract class:- is a class that cannot be instantiated on its own and must be inherited by other classes.
 * It can contain both abstract methods (without implementation) and concrete methods (with implementation).
 * 
 * This helps in reducing complexity and increasing reusability and maintainability of the code.
 * Abstraction can be achieved using abstract classes and interfaces.
 * 
 * 
 * Interfaces :- 
 * An interface is a contract that defines a set of methods and properties that a class must implement.
 * Unlike abstract classes, interfaces cannot contain any implementation.
 * 
 * Key Points
 * Abstract classes can have both abstract and concrete methods. They provide a base class that
 * other classes can inherit and are useful when you want to share common functionality among related classes.
 * Interfaces define a contract with methods and properties that implementing classes must provide.
 * They are useful for achieving multiple inheritance and defining capabilities that can be shared across unrelated classes.
 * Understanding and using abstraction effectively can help you design more flexible, scalable, and maintainable software systems in C#.
 * 
 */

// Struct / Enum 
/*
* 
* Structures (structs) in C# :- are value types that are typically used to encapsulate small groups of related variables. 
* Structs are similar to classes but have some key differences, mainly in terms of their behavior and usage.
* 
* Key Characteristics of Structs
* 1-Value Type: Structs are value types, which means they are stored on the stack and hold their data directly,
* as opposed to reference types (like classes), which are stored on the heap and hold references to their data.
* 2-No Inheritance: Structs cannot inherit from other structs or classes, 
* and they cannot be used as a base for other structs or classes. However, they can implement interfaces.
* 3-Immutability: ensures that once an instance is created, its state cannot change.
* This concept is valuable for thread safety, predictability, and simplicity. By using readonly fields and properties.
* 
* 
* enumeration (enum) is a value type that consists of a set of named constants called the enumerator list.
* Enums are used to define a collection of related constants that can be assigned to a variable, 
* making the code more readable and maintainable.
* 
* Summary
* 1-Enums are value types that consist of named constants.
* 2-Default underlying type is int, but can be changed to other integral types.
* 3-Methods: Enums have several useful methods provided by the Enum class, such as GetName, GetNames, and GetValues.
* 4-Usage: Enums make code more readable and maintainable by providing meaningful names to a set of related values.
* 
* Search More on Parse [@!!] 
* 
*/


// Static types /
/*
 * Static Class: A class that cannot be instantiated and can only contain static members.
 * Static Methods: Methods can called on the class itself rather than on instances of the class ,Deal With Static Member.
 * Static Fields: Variables that are shared among all instances of the class.
 * Static Properties: Static properties can be used to encapsulate static fields.
 * Static Constructors: A static class can have a static constructor, which is called once,
 * before any static members are accessed, and is used to initialize static members.
 *
 */
// Namespaces _ Assemblies 
/*
 * Namespaces :- organize code and prevent naming conflicts by grouping related types.
 * Key Points about Namespaces:
 *      - Declaration: Namespaces are declared using the namespace keyword.
 *      - Hierarchy: Namespaces can be nested, creating a hierarchy.
 *      - Using Directive: The 'using' keyword allows you to access members of a namespace without specifying the full namespace path.
 * Assemblies :- are compiled code libraries that contain one or more namespaces and
 * provide the unit of deployment, versioning, and security in .NET applications.
 * 
 */


// Object Initializers _ Extension Methods
/*
 * 
 * Object initializers :- allow you to initialize an object's properties at the time of creation without explicitly
 * calling a constructor.This provides a more concise and readable way to set properties.
 * 
 * Extension methods :-  allow you to add new methods to existing types without modifying their source code or creating
 * a new derived type.This is particularly useful for extending classes from libraries that you do not control.
 *
 */


// Association_ Aggregation _ Composition
/*
 * 
 * Association :- represents a relationship between two or more objects where all objects have their own lifecycle
 * and there is no ownership between them. It is a "uses-a" relationship.
 * Key Points about Association:
 *  - Bidirectional or Unidirectional: It can be bidirectional (both objects know about each other)
 * or unidirectional (one object knows about the other).
 *  - Lifetime Independence: The existence of one object does not depend on the other.
 * 
 * Aggregation is a special type of association that represents a "whole-part" relationship
 * where the part can exist independently of the whole. It is a "has-a" relationship with a weaker form of ownership.
 * Key Points about Aggregation:
 *  - Weak Ownership: The part can exist independently of the whole.
 *  - Lifetime Independence: Deleting the whole does not delete the part.
 * 
 * Composition:-  is a stronger form of aggregation that represents a "whole-part" relationship
 * where the part cannot exist without the whole. It is a "contains-a" relationship with strong ownership.
 * Key Points about Composition:
 *  - Strong Ownership: The part cannot exist independently of the whole.
 *  - Lifetime Dependence: Deleting the whole deletes the part.
 * 
 */

// IDentify Requirment (Functional Requirment / Non-Functional Requirment )
// Identify Use Cases 
// Write User Story 
// Identify Classes and Relationships From user Stories 
// Create UML 
// Going Code 



// 1- Collection
// 2- Some Advanced

namespace Concept
{
    internal class Program
    {
        static void Main(string[] args)
        {


			Console.WriteLine("Fawzy");


            Console.ReadKey();
        }
    }
    public class test
    {
        public int id;
        public string name;
        public test_2 t;

        public test(int id, string name, test_2 t)
        {
            this.id = id;
            this.name = name;
            this.t = t;
        }
    }

    public class test_2
    {
        public string name;
        public int id;

        public test_2(string name, int id)
        {
            this.id = id;
            this.name = name;
        }
    }

    // More Examle 
    #region Example on Inheritance
    class Student
    {
        private int id;
        private string name;
        private int age;
        public Student(int age, string name, int id = 0)
        {
            this.age = age;
            this.id = id;
            this.name = name;
        }
        // Constractor Chaining
        public Student() { }
        public int Id
        {
            set { id = value; }
            get { return this.id; }
        }

        public string Name
        {
            set { name = value; }
            get { return this.name; }
        }

        public int Age
        {
            set { age = value; }
            get { return age; }
        }
        public virtual void DataStudent()
        {
            Console.WriteLine($"Name : {this.name}\nAge : {this.age}\nId : {this.id}");
        }
    }
    class Postgraduate : Student
    {
        public string Research_area { set; get; }
        public Postgraduate(int id, string name, int age, string res_area) : base(age, name, id)
        {
            this.Research_area = res_area;
        }
        public Postgraduate() { }
        public override void DataStudent()
        {
            Console.WriteLine($"Name : {this.Name}\nAge : {this.Age}\nId : {this.Id}\nResearch_area : {this.Research_area}");
        }
    }
    #endregion

    #region Example on Abstract 
    abstract class A_abstract
    {
        public abstract void Open();
        public abstract void Close();
        public void Saled()
        {
            Console.WriteLine("this is Abstract clase Saled Mainly !!");
        }
    }
    class B : A_abstract
    {
        public override void Close()
        {
            Console.WriteLine("this is Class B Close");
        }

        public override void Open()
        {
            Console.WriteLine("this is Class B Open");
        }
    }
    class C : A_abstract
    {
        public override void Close()
        {
            Console.WriteLine("this is Class C Close");
        }

        public override void Open()
        {
            Console.WriteLine("this is Class C Open");
        }
    }
    #endregion

    #region Example on Interface
    interface IShape
    {
        public double GetArea();
    }

    class Rect : IShape
    {
        public double Lenght { get; set; }
        public double Width { get; set; }
        public double GetArea()
        {
            return Lenght * Width;
        }
    }
    #endregion

    #region Example on Struct
    struct Point
    {
        private int x;
        private int y;

        public Point(int x, int y) { this.x = x; this.y = y; }
        public int X { set; get; }
        public int Y { set; get; }
        public int Sum() { return x + y; }
    }
    #endregion

    // More Example 
    #region Enum
    class AppEnum
    {
        public void Example(int input)
        {
            if (input == (int)TrifficLigth.Red) { Console.WriteLine("Stop..."); }
            else if (input == (int)TrifficLigth.Green) { Console.WriteLine("Wating..."); }
            else if (input == (int)TrifficLigth.Yellow) { Console.WriteLine("Gooo..."); }
            else { Console.WriteLine("Invalid input..."); }
        }
        public void IterateEnum()
        {
            // Iterate on Enum 
            foreach (var item in Enum.GetValues(typeof(TrifficLigth)))
            {
                switch (item)
                {
                    case TrifficLigth.Red:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case TrifficLigth.Green:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case TrifficLigth.Yellow:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                }
                Console.WriteLine($"{item} = {(int)item}");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public void PrmissionEnum()
        {
            PermissionFile permission = PermissionFile.ReadWrite;
            //Check 
            Console.WriteLine((permission & PermissionFile.Read) == PermissionFile.Read ? "Can Read" : "Not Can Read");
            Console.WriteLine((permission & PermissionFile.Write) == PermissionFile.Write ? "Can Write" : "Not Can Write");
            Console.WriteLine((permission & PermissionFile.Execute) == PermissionFile.Execute ? "Can Execute" : "Not Can Execute");

            // Add PerMission Execute
            permission |= PermissionFile.Execute;
            Console.WriteLine((permission & PermissionFile.Execute) == PermissionFile.Execute ? "Can Execute" : "Not Can Execute");

            // Remove PerMission Execute
            permission ^= PermissionFile.Execute;
            Console.WriteLine((permission & PermissionFile.Execute) == PermissionFile.Execute ? "Can Execute" : "Not Can Execute");

        }
    }
    enum TrifficLigth
    {
        Red = 1,
        Green,
        Yellow,
    }

    [Flags]
    enum Days
    {
        none = 0,
        Saturday = 1,
        Sunday = 2,
        Monday = 4,
        Tuesday = 8,
        Wednesday = 16,
        Thursday = 32,
        Friday = 64,
        Weekdays = Sunday | Monday | Tuesday | Wednesday | Thursday,
        Weekend = Sunday | Saturday,
        Allday = Weekdays | Weekend
    }


    [Flags]
    enum PermissionFile
    {
        None = 0,
        Read = 1,
        Write = 2,
        Execute = 4,
        ReadWrite = Read | Write,
        All = Execute | ReadWrite
    }

    #endregion

    #region StaticType
    public static class StaticType
    {
        public static int X { set; get; }
        public static void increamentX()
        {
            X++;
        }
    }
    public class StaticTypeV2
    {
        private static int count;

        public StaticTypeV2()
        {
            count++;
        }
        public int Count { get { return count; } }

        public static void MulCount()
        {
            count *= 2;
        }

    }
    #endregion

    #region Object_Intializer
    class ObjectIntializer
    {
        public string Name { set; get; }
        public int Id { set; get; }
        public int Age { set; get; }

        public ObjectIntializer() { }

        public ObjectIntializer(string name, int age)
        {
            Name = name;
            Age = age;
        }

    }
    class AppOI
    {
        public void App()
        {
            ObjectIntializer ob = new ObjectIntializer()
            {
                Id = 1,
                Name = "fawzy",
                Age = 25
            };
            ObjectIntializer ob2 = new ObjectIntializer(name: "Mstafa", age: 30)
            {
                Id = 5
            };
            Console.WriteLine($"obj_1\tName : {ob.Name}\tID: {ob.Id}\tAge : {ob.Age}");
            Console.WriteLine($"obj_2\tName : {ob2.Name}\tID: {ob2.Id}\tAge : {ob2.Age}");
        }
    }
    #endregion

    #region Extension_Methods
    class Culcalter
    {
        public int add(int a, int b)
        {
            return a + b;
        }
        public int sub(int a, int b)
        {
            return a - b;
        }
    }
    static class CulcalterEx
    {
        public static int Mul(this Culcalter cu, int a, int b)
        {
            return a * b;
        }
    }
    class AppEx
    {
        public void app()
        {
            Culcalter cu = new Culcalter();
            Console.WriteLine($"Mul : {cu.Mul(10, 20)}");
        }
    }

    static class StringEx
    {
        public static string CapFirst(this String input)
        {
            char[] charArr = input.ToCharArray();
            charArr[0] = char.ToUpper(charArr[0]);
            return new string(charArr);
        }
    }
    #endregion




}
