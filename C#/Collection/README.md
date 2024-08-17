# Collection 

## Generics

**provide a way to define classes, methods, interfaces, and delegates that can work with any data type, enhancing code reusability, type safety, and performance.**
	
- Generic Class 
		![[Pasted image ٢٠٢٤٠٨١٦١٥٣٢١٣.png]]
		Main
		![[Pasted image ٢٠٢٤٠٨١٦١٥٣٥٠٢.png]]

- Generic Method
		![[Pasted image ٢٠٢٤٠٨١٦١٦١٢٥٧.png]]
		****************************************************************************
	
- Generic Interface 
		![[Pasted image ٢٠٢٤٠٨١٦١٦١٣٤٢.png]]
		Main 
		![[Pasted image ٢٠٢٤٠٨١٦١٦١٤٢٢.png]]

- Generic Constraints
		![[Pasted image ٢٠٢٤٠٨١٦١٦٢٨٤٣.png]]


## List<T>

### 1. Generic Collection
`List<T>` is a **generic** collection, meaning it is type-safe. It can store elements of a specific type, where `T` represents the type.

Example:

```csharp
List<int> intList = new List<int>();
intList.Add(1);
intList.Add(2);

List<string> stringList = new List<string>();
stringList.Add("Apple");
stringList.Add("Banana");
```

### 2. Type Safety
Since `List<T>` is generic, it provides compile-time type checking, reducing the chance of runtime errors. The elements added to the list must match the specified type `T`.

Example:

```csharp
List<int> intList = new List<int>();
intList.Add(1);
// intList.Add("Hello"); // This would result in a compile-time error
```

### 3. Performance
`List<T>` avoids boxing and unboxing when dealing with value types (e.g., `int`, `float`). Boxing is the process of converting a value type to an `object`, and unboxing is the reverse. Avoiding these conversions improves performance.

Example:

```csharp
List<int> intList = new List<int>();
intList.Add(42); // No boxing occurs
```

### 4. Methods and Properties
`List<T>` provides a rich set of methods and properties for managing collections, such as `Add`, `Remove`, `Sort`, `Contains`, `Count`, and more.

Example:

```csharp
List<int> numbers = new List<int> { 1, 3, 5 };
numbers.Add(7);
numbers.Remove(3);
numbers.Sort();
```