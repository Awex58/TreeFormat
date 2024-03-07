
again: 
Console.Write("Uygun formatta giriş yapınız örn:'abccbdeeda':  ");
string? word = Console.ReadLine();

Stack<char> letterstack = new Stack<char>();
int depth = -1;

if (word != null)
foreach (char letter in word)
{
    if (letterstack.Count > 0 && letterstack.Peek() == letter)
    {
        letterstack.Pop();
        depth--;
    }
    else
    {
        if (letterstack.Count > 0)
            Console.Write("-");

        for (int i = 0; i < depth; i++)
            Console.Write("-");

        Console.WriteLine(letter);
        letterstack.Push(letter);
        depth++;
    }
}
goto again;
