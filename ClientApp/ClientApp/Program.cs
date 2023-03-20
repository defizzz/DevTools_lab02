using Wintellect.PowerCollections;

var stack = new Wintellect.PowerCollections.Stack<int>(16);

for(int i = 0; i < stack.Capacity; i++)
{
	stack.Push(i);
}

foreach(int i in stack)
{
	Console.WriteLine(Convert.ToString(i, 2).PadLeft(4, '0'));
}