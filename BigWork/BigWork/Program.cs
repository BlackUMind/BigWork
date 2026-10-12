using BigWork.Core;

var probe = new Buffer<int>();
Console.WriteLine(probe.TryAdd(1));
Console.WriteLine(probe.TryAdd(2));
Console.WriteLine(probe.TryAdd(3));

var nums = new List<int> { 5, 9, 2 };
Console.WriteLine($"FindMax на List<int> = {nums.FindMax()}");
Console.WriteLine($"FindMax на пустом List<string> = {(new List<string>().FindMax() is null ? "null" : "ошибка")}");
Console.WriteLine($"FindMax на пустом List<int> = {new List<int>().FindMax()}");
nums.PrintAll("Элемент: ");
new List<string>().PrintAll("Элемент: ");
Console.WriteLine("(пустой список ничего не напечатал)");
//var container = new Container<Dog>(new Dog { Name = "Шарик" });
//IContainer<Animal> animal = container;
//Console.WriteLine($"IContainer<Animal>.GetItem() = {animal.GetItem()}");

Console.ReadLine();