
# Event and Observer Pattern in C#

## Introduction

### Event Pattern
The Event pattern in C# is a way to notify multiple subscribers about events that occur within an object. It leverages delegates and is integral to the .NET framework's event-driven programming model.

### Observer Pattern
The Observer pattern is a behavioral design pattern where an object, known as the subject, maintains a list of dependents, called observers, and notifies them of any state changes, usually by calling one of their methods. This pattern is particularly useful in scenarios where an event should trigger updates in multiple parts of an application.

## Implementation

This example demonstrates both the Event and Observer patterns through a simulation of a YouTube channel where subscribers get notified when a new video is uploaded.

### Code Explanation

The provided code consists of three main parts:

1. **Program Class**: The entry point of the application.
2. **Youtyoub_Chanel Class**: Represents the YouTube channel that notifies subscribers about new video uploads.
3. **Subscriber Class**: Represents the subscribers that receive notifications about new video uploads.

### Program Class

The `Program` class contains the `Main` method, which starts the application by calling `Youtyoub_Chanel.StartApp()`.

```csharp
namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Youtyoub_Chanel.StartApp();
        }
    }
}
```

### Youtyoub_Chanel Class

The `Youtyoub_Chanel` class simulates a YouTube channel.

1. **Event Definition**: The event `del` is declared using a generic `Action<string>` delegate.
2. **UploadVideo Method**: This method simulates uploading a video and notifies subscribers.
3. **StartApp Method**: This method demonstrates how subscribers can subscribe to a channel and how the event can be invoked.

```csharp
class Youtyoub_Chanel
{
    public static void StartApp()
    {
        // Example 1
        Console.WriteLine("this is Example 1 ");
        Youtyoub_Chanel ch = new Youtyoub_Chanel();
        Subscriber s1 = new Subscriber();
        Subscriber s2 = new Subscriber();
        Subscriber s3 = new Subscriber();

        s1.Subscribe(ch);
        s2.Subscribe(ch);
        s3.Subscribe(ch);
        Console.Write("Enter Title Video : ");
        ch.UploadVideo(Console.ReadLine());

        // Example 2
        Console.WriteLine("this is Example 2 ");
        Youtyoub_Chanel y = new Youtyoub_Chanel();
        Subscriber s_1 = new Subscriber();
        Subscriber s_2 = new Subscriber();
        Subscriber s_3 = new Subscriber();

        s_1.Subscribe(y);
        s_2.Subscribe(y);
        s_3.Subscribe(y);

        // Incorrect way to invoke delegate
        y.del.Invoke("fawzy");

        // Incorrect way to assign delegate (should use +=, not =)
        y.del = (s) => Console.WriteLine("Happy");
    }

    // Event declaration
    public event Action<string> del;

    // Method to upload video and notify subscribers
    public void UploadVideo(string title)
    {
        Console.WriteLine($"Upload Video ({title})");
        del.Invoke(title);
    }
}
```

### Subscriber Class

The `Subscriber` class represents a subscriber to the YouTube channel.

1. **Subscribe Method**: Subscribes the subscriber to the channel.
2. **WatchVideo Method**: Method that gets called when a new video is uploaded.

```csharp
class Subscriber
{
    public int Id { get; }
    static int count = 0;

    public Subscriber()
    {
        count++;
        Id = count;
    }

    public void Subscribe(Youtyoub_Chanel chanel)
    {
        chanel.del += this.WatchVideo;
    }

    public void WatchVideo(string title)
    {
        Console.WriteLine($"Id {Id}, I am watching video ({title})");
    }
}
```

### Key Points

1. **Delegate Definition**: A delegate `DelSub` is defined but not used in the event declaration. Instead, `Action<string>` is used for simplicity.
2. **Event Declaration**: The event `del` is declared using `Action<string>` to handle video upload notifications.
3. **Event Invocation**: The `UploadVideo` method raises the event by invoking `del`.
4. **Subscription**: Subscribers use the `Subscribe` method to attach their `WatchVideo` method to the event.
5. **Multicasting**: Multiple subscribers can attach to the same event, demonstrating the multicast capability of delegates.

### Improvements and Notes

1. **Avoid Direct Invocation**: Events should not be invoked directly outside their class. This is enforced by using the `event` keyword.
2. **Proper Subscription**: Use the `+=` operator to add methods to an event, not `=`, to avoid overwriting existing subscribers.
3. **Anonymous Methods and Lambda Expressions**: The code includes comments on using anonymous methods and lambda expressions for inline delegate definitions.

By understanding this example, you can grasp how events and the Observer pattern are implemented in C#. You can expand this by adding more functionality, handling edge cases, and experimenting with different scenarios to deepen your mastery.
