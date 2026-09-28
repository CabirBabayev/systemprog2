async Task ProcessOrderAsync(int orderId)
{
    Console.WriteLine($"Заказ {orderId}: начал обработку");
    await Task.Delay(2000);
    Console.WriteLine($"Заказ {orderId}: обработка завершена");
} 
await Task.WhenAll(ProcessOrderAsync(1), ProcessOrderAsync(2), ProcessOrderAsync(3));

int counter = 0;
object _lock = new object();
Thread thread1 = new Thread(() =>
{
    for (int i = 0; i < 1000; i++)
    {
        lock (_lock)
        {
            counter++;
        }
    }
});
Thread thread2 = new Thread(() =>
{
    for (int i = 0; i < 1000; i++)
    {
        lock (_lock)
        {
            counter++;
        }
    }
});
Thread thread3 = new Thread(() =>
{
    for (int i = 0; i < 1000; i++)
    {
        lock (_lock)
        {
            counter++;
        }
    }
});
Thread thread4 = new Thread(() =>
{
    for (int i = 0; i < 1000; i++)
    {
        lock (_lock)
        {
            counter++;
        }
    }
});
Thread thread5 = new Thread(() =>
{
    for (int i = 0; i < 1000; i++)
    {
        lock (_lock)
        {
            counter++;
        }
    }
});
thread1.Start();
thread2.Start();
thread3.Start();
thread4.Start();
thread5.Start();
thread1.Join();
thread2.Join();
thread3.Join();
thread4.Join();
thread5.Join();
Console.WriteLine($"Counter: {counter}");