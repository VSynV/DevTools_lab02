// See https://aka.ms/new-console-template for more information
using Wintellect.PowerCollections;
Wintellect.PowerCollections.Stack < string > S = new Wintellect.PowerCollections.Stack<string>(10);
S.Push("Hello");
Console.WriteLine(S.Pop());
