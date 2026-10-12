using BigWork.Core;

var probe = new Buffer<int>();
Console.WriteLine(probe.TryAdd(1));
Console.WriteLine(probe.TryAdd(2));
Console.WriteLine(probe.TryAdd(3));


var labels = new LabeledBuffer();
labels.TryAdd("привет");
labels.TryAdd("мир");
labels.TryAdd("отчёт");
labels.PrintAllUpper();
Console.WriteLine($"LabeledBuffer.Count = {labels.Count}");
Console.ReadLine();