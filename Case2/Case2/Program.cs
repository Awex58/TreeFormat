
again: 
Console.Write("Uygun formatta giriş yapınız örn:'abccbdeeda':  ");
string? word = Console.ReadLine();

Stack<char> letterstack = new Stack<char>();
int x = -1;

if (word != null)
foreach (char letter in word)
{
    if (letterstack.Count > 0 && letterstack.Peek() == letter)
    {
        letterstack.Pop();
        x--;
    }
    else
    {
        if (letterstack.Count > 0)
            Console.Write("-");

        for (int i = 0; i < x; i++)
            Console.Write("-");

        Console.WriteLine(letter);
        letterstack.Push(letter);
        x++;
    }
}
goto again;
