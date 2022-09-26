
using OefeningenLes5_2;

var stack = new MyStack<string>();

stack.Add("myfirstgeneric");
stack.Add("myfirstgeneric2");
stack.Add("myfirstgeneric3");
stack.Add("myfirstgeneric4");

Console.WriteLine(stack.Peek());


Console.WriteLine(stack.Remove());
Console.WriteLine(stack.Remove());
Console.WriteLine(stack.Remove());
Console.WriteLine(stack.Remove());
Console.WriteLine(stack.Remove());
Console.WriteLine(stack.Remove());

Console.ReadLine();


