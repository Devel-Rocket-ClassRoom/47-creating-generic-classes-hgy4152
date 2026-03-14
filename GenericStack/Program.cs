using System;

// README.md를 읽고 아래에 코드를 작성하세요.


SimpleQueue<int> intQueue = new SimpleQueue<int>(3);
SimpleQueue<string> stringQueue = new SimpleQueue<string>(2);

Console.WriteLine("=== int 큐 (용량: 3) ===");

intQueue.Enqueue(10);
intQueue.Enqueue(20);
intQueue.Enqueue(30);

Console.WriteLine($"Enqueue:{string.Join(", ", intQueue.Queue)}");

Console.WriteLine($"Count: {intQueue.Count}, IsFull: {intQueue.IsFull}");
intQueue.Enqueue(50);

Console.WriteLine($"Peek: {intQueue.Peek()}");
Console.WriteLine($"Dequeue: {intQueue.Dequeue()}");
Console.WriteLine($"Dequeue: {intQueue.Dequeue()}");
Console.WriteLine($"Count: {intQueue.Count}, IsEmpty: {intQueue.IsEmpty}");


Console.WriteLine();

Console.WriteLine("=== string 큐 (용량: 2) ===");

stringQueue.Enqueue("Hello");
stringQueue.Enqueue("World");

Console.WriteLine($"Enqueue:{string.Join(", ", stringQueue.Queue)}");


Console.WriteLine($"Dequeue: {stringQueue.Dequeue()}");
Console.WriteLine($"Dequeue: {stringQueue.Dequeue()}");
Console.WriteLine($"Dequeue: {stringQueue.Dequeue()}");
Console.WriteLine($"isEmpty: {stringQueue.IsEmpty}");