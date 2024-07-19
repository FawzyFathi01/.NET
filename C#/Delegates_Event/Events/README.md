
# Event and Observer Patterns in C#

## Event 
The Event in C# is a way to notify multiple subscribers about events that occur within an object. It leverages delegates and is integral to the .NET framework's event-driven programming model.

## Observer Pattern
The Observer pattern is a behavioral design pattern where an object, known as the subject, maintains a list of dependents, called observers, and notifies them of any state changes, usually by calling one of their methods. This pattern is particularly useful in scenarios where an event should trigger updates in multiple parts of an application.

## EventHandler
The `EventHandler` delegate is a predefined delegate type in C# used for handling events. It has two main forms: non-generic and generic.

### Non-Generic EventHandler
The non-generic `EventHandler` delegate represents a method that handles an event and takes two parameters: the source of the event and an `EventArgs` object, which contains the event data.

### Generic EventHandler
The generic `EventHandler<TEventArgs>` delegate is a more flexible version, allowing the event data to be of any type specified by the `TEventArgs` parameter. This enables more specific event data types to be used.

### Key Points
- **Keyword `event`**: 
  - Prevents direct invocation of the event outside the class.
  - Enforces the use of `+=` and `-=` for adding or removing event handlers.
- **EventHandler**:
  - Non-generic: `(object, EventArgs)`
  - Generic: `(object, TEventArgs)` where `TEventArgs` can be any type.

## Example Observer Pattern 

```csharp
class YouTube_Channel
{ 
    // Method to Upload Video, Delegate pointing to Subscriber 
    // public event DelSub del;
    public event Action<string> del;
    // To Solve 2 Problem: 1- Not Invoking Directly outside Class, Not = but += 

    public void UploadVideo(string title) {
        Console.WriteLine($"Upload Video ({title})");
        del.Invoke(title);
    } 
}

class Subscriber
{
    // Method to Watch Video upload 

    public int Id { get; }
    static int count = 0;

    public Subscriber() { count++; Id = count; }

    public void Subscribe(YouTube_Channel channel) {
        channel.del += this.WatchVideo;
    }
    public void WatchVideo(string title) {
        Console.WriteLine($"Id {Id}, I am Watching Video ({title})");
    }
}
```

In this example:
- `YouTube_Channel` class has an event `del` of type `Action<string>`, which is invoked when a new video is uploaded.
- `Subscriber` class subscribes to the `del` event and reacts by watching the video, displaying a message with the video title.

## EventHandler Example 1

```csharp
class Video_Info : EventArgs
{
    public string Name { get; set; }
    public int Duration { get; set; }
}

class YoutubeChannel
{
    public string Name { get; set; }
    public event EventHandler<Video_Info> Action;
   
    public void UploadVideo(Video_Info vd)
    {
        vd.Name = "Fawzy";
        vd.Duration = 30;
        Console.WriteLine("Upload Video!!");
        Action(this, vd);
    }
}

class SubscriberX
{
    public void Subscribe(YoutubeChannel y)
    {
        y.Action += this.WatchVideo;   
    }

    public void WatchVideo(object ob, Video_Info vd)
    {
        YoutubeChannel y = (YoutubeChannel)ob;  
        Console.WriteLine($"I am Watching: {vd.Name}	, {vd.Duration} minutes");
    }
}
```

## EventHandler Example 2

```csharp
class AppStock
{
    public void StartApp()
    {
        Stock st = new Stock("Google");
        HandleStock hs = new HandleStock();
        hs.Subscribe(st);

        Console.Write("Enter Price of Stock: ");
        st.Price = decimal.Parse(Console.ReadLine());

        int t = 4;
        while (t > 0)
        {
            Console.Write("Enter percent to change Stock Price: ");
            decimal a = decimal.Parse(Console.ReadLine());
            st.ChangePrice(a);
            t--;
            Console.WriteLine();
        }
        Console.WriteLine("Finished");

        Console.ReadKey();
    }
}

class HandleStock
{
    public void Subscribe(Stock st)
    {
        st.EventHandlerChangeStockPrice += HandleChangePrice;
    }
    public void HandleChangePrice(object st, decimal oldPrice)
    {
        Stock stock = (Stock)st;

        Console.WriteLine($"Price of Stock Before Change: ${oldPrice}");
        Console.Write($"Price of Stock After Change: $");

        if (stock.Price > oldPrice) Console.ForegroundColor = ConsoleColor.Green;
        else if (stock.Price < oldPrice) Console.ForegroundColor = ConsoleColor.Red;
        else Console.ForegroundColor = ConsoleColor.Gray;

        Console.WriteLine(stock.Price);
        Console.ForegroundColor = ConsoleColor.White;
    }
}

class Stock
{
    private string name;
    private decimal price;

    public event EventHandler<decimal> EventHandlerChangeStockPrice;
    public decimal Price { set { price = value; } get { return price; } }
    public string Name { get => name; }

    public Stock(string name)
    {
        this.name = name;
    }

    public void ChangePrice(decimal percent)
    {
        decimal oldPrice = price;
        Console.WriteLine($"Old: {oldPrice}");
        this.price += (this.Price * percent / 100);
        EventHandlerChangeStockPrice(this, oldPrice);
    }
}
```

In this example:
- `AppStock` initializes the stock price and simulates price changes.
- `HandleStock` subscribes to stock price changes and handles the change event.
- `Stock` class raises the event when its price changes, notifying all subscribers.

These examples demonstrate how events and the observer pattern work together to create a flexible and dynamic system for handling changes and notifications.
