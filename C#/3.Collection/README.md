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

## ArrayList

### 1. Non-Generic Collection
`ArrayList` is a **non-generic** collection that can hold objects of any type. Because it stores elements as `object`, it is less type-safe.

Example:

```csharp
ArrayList arrayList = new ArrayList();
arrayList.Add(1);
arrayList.Add("Hello");
arrayList.Add(DateTime.Now);
```

### 2. Type Safety
Since `ArrayList` stores elements as `object`, type checking is not enforced at compile-time. This can lead to runtime errors if elements are not cast correctly.

Example:

```csharp
ArrayList arrayList = new ArrayList();
arrayList.Add(1);

int number = (int)arrayList[0]; // Explicit cast required
// string str = (string)arrayList[0]; // This would cause a runtime error
```

### 3. Performance
When storing value types in an `ArrayList`, boxing occurs, and unboxing is required when retrieving the values. This can impact performance, especially with large collections.

Example:

```csharp
ArrayList arrayList = new ArrayList();
arrayList.Add(42); // Boxing occurs here

int value = (int)arrayList[0]; // Unboxing occurs here
```

### 4. Legacy Collection
`ArrayList` was commonly used before C# 2.0, when generics were introduced. Today, `List<T>` is preferred for new development due to its type safety and performance benefits.

## Comparison Summary

- **Type Safety**: `List<T>` is type-safe (generic), while `ArrayList` is not (non-generic).
- **Performance**: `List<T>` is generally more performant because it avoids boxing/unboxing with value types.
- **Flexibility**: `ArrayList` can store different types, but this flexibility comes at the cost of type safety and performance.
- **Usage**: `List<T>` is preferred for modern C# development, while `ArrayList` is considered a legacy collection.

## Example Comparison

```csharp
// Using List<T>
List<int> intList = new List<int> { 1, 2, 3 };
intList.Add(4);
int sum = intList[0] + intList[1]; // No casting required

// Using ArrayList
ArrayList arrayList = new ArrayList();
arrayList.Add(1);
arrayList.Add(2);
int sumArrayList = (int)arrayList[0] + (int)arrayList[1]; // Casting required
```

In summary, while both `List<T>` and `ArrayList` can be used to store collections of elements, `List<T>` is generally the better choice due to its type safety, performance, and extensive support in the .NET ecosystem.
