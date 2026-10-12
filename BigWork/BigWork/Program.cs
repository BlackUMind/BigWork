using BigWork.Core;

var probe = new Buffer<int>();
Console.WriteLine(probe.TryAdd(1));
Console.WriteLine(probe.TryAdd(2));
Console.WriteLine(probe.TryAdd(3));


var container = new Container<Dog>(new Dog { Name = "Шарик" });
IContainer<Animal> animal = container;
Console.WriteLine($"IContainer<Animal>.GetItem() = {animal.GetItem()}");

Console.ReadLine();